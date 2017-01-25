#region Category: Header Text

// ***********************************************************************
// Assembly         : WinFormExpander\Expander\ucExpander.cs
// Author           : Danny Patten
// Created          : 24 - 01 - 2017 at 22:30h
// 
// Last Modified By : Danny Patten
// Last Modified On : 24 - 01 - 2017 at 23:32h
// ***********************************************************************
// Copyright © 2016 - 2017, Danny Patten - All Rights Reserved
// 
// Redistribution and use in source and binary forms, with or without
// modification, are not permitted
// ***********************************************************************

#endregion

#region Category: Directives

using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

#endregion

namespace Expander
{
    public partial class ucExpander : Panel
    {
        public ucExpander()
        {
            InitializeComponent();

            // Set some basic settings for the animationTimer
            _animationTimer = new Timer {Interval = 50, Enabled = true};
            _animationTimer.Tick += animationTimer_Tick;
            // Make collapsed height equals to fit expand-collapse button
            _collapsedHeight = 31;
            // Make sure we always fill the horizontal space of the panel.
            btnHeader.Dock = DockStyle.Top;
            // initial state of panel - expanded
            btnHeader.IsExpanded = true;
            // subscribe for button expand-collapse state changed event
            btnHeader.ExpandCollapse += ucExpander_StateChanged;
            // Define the content space of the panel.
            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint | ControlStyles.ResizeRedraw | ControlStyles.OptimizedDoubleBuffer, true);
            BorderColor = HeaderBackColor;
            BorderStyle = BorderStyle.None;
        }

        /// <summary>
        /// Handles the StateChanged event of the ucExpander control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="StateChangedEventArgs"/> instance containing the event data.</param>
        private void ucExpander_StateChanged(object sender, StateChangedEventArgs e)
        {
            if (e.IsExpanded) // if button is expanded now
                Expand(); // expand the panel
            else
                Collapse(); // collapse the panel

            // Retrieve expand-collapse state changed event for panel
            var handler = OnStateChanged;
            handler?.Invoke(this, e);
        }

        /// <summary>
        /// Expand panel content.
        /// </summary>
        protected virtual void Expand()
        {
            // if animation enabled
            if (UseAnimation)
            {
                // set internal state for Expanding
                _internalPanelState = InternalPanelState.Expanding;
                // start animation now..
                StartAnimation();
            }
            else // no animation, just expand immediately
            {
                // set internal state to Normal
                _internalPanelState = InternalPanelState.Normal;
                // resize panel
                Size = new Size(Size.Width, _expandedHeight);
            }
        }

        /// <summary>
        /// Collapse panel content.
        /// </summary>
        protected virtual void Collapse()
        {
            // if panel is completely expanded (animation on expanding is ended or no animation at all) 
            // *we don't want store half-expanded panel height
            if (_internalPanelState == InternalPanelState.Normal)
                _expandedHeight = Size.Height;

            // if animation enabled
            if (UseAnimation)
            {
                // set internal state for Collapsing
                _internalPanelState = InternalPanelState.Collapsing;
                // start animation now..
                StartAnimation();
            }
            else // no animation, just collapse immediately
            {
                // set internal state to Normal
                _internalPanelState = InternalPanelState.Normal;
                // resize panel
                Size = new Size(Size.Width, _collapsedHeight);
            }
        }

        /// <summary>
        /// Raises the <see cref="E:System.Windows.Forms.Control.SizeChanged" /> event.
        /// </summary>
        /// <param name="e">An <see cref="T:System.EventArgs" /> that contains the event data.</param>
        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);

            // we always manually scale expand-collapse button for filling the horizontal space of panel:
            btnHeader.Size = new Size(ClientSize.Width - btnHeader.Margin.Left - btnHeader.Margin.Right, btnHeader.Height);

            // ignore height changing from animation timer
            if (_internalPanelState != InternalPanelState.Normal)
                return;

            if (!IsExpanded // if panel collapsed
                && (Anchor & AnchorStyles.Bottom) != 0 //and panel's Anchor property sets to Bottom
                && Size.Height != _collapsedHeight // and panel height is changed (it could happens only if parent control just has resized)
                && Parent != null) // and panel has the parent control
            {
                // main, calculate the parent control resize diff and add it to expandedHeight value:
                _expandedHeight += Parent.Height - _previousParentSize.Height;

                // reset resized height (by base.OnSizeChanged anchor.Bottom handling) to collapsedHeight value:
                Size = new Size(Size.Width, _collapsedHeight);
            }

            // store previous size of parent control (however we need only height)
            if (Parent != null)
                _previousParentSize = Parent.Size;

            Invalidate();
        }

        /// <summary>
        /// Raises the <see cref="E:System.Windows.Forms.Control.Paint" /> event.
        /// </summary>
        /// <param name="e">A <see cref="T:System.Windows.Forms.PaintEventArgs" /> that contains the event data.</param>
        protected override void OnPaint(PaintEventArgs e)
        {
            e.Graphics.DrawRectangle(BorderStyle == BorderStyle.None ? new Pen(BorderColor) : new Pen(Color.FromArgb(646464)), 1, 1, ClientSize.Width - 3, ClientSize.Height - 3);
        }

        /// <summary>
        /// Raises the <see cref="E:System.Windows.Forms.ScrollableControl.Scroll" /> event.
        /// </summary>
        /// <param name="se">A <see cref="T:System.Windows.Forms.ScrollEventArgs" /> that contains the event data.</param>
        protected override void OnScroll(ScrollEventArgs se)
        {
            base.OnScroll(se);
            Invalidate();
        }

        /// <summary>
        /// Fires the event indicating that the panel has been resized. Inheriting controls should use this in favor of actually listening to the event, but should still call base.onResize to ensure that the event is fired for external listeners.
        /// </summary>
        /// <param name="eventargs">An <see cref="T:System.EventArgs" /> that contains the event data.</param>
        protected override void OnResize(EventArgs eventargs)
        {
            base.OnResize(eventargs);
            Invalidate();
        }

        #region Category: Fields

        private static Timer _animationTimer;

        /// <summary>
        /// Enable pretty simple animation of panel on expanding or collapsing
        /// </summary>
        private bool _useAnimation;

        /// <summary>
        /// Height of panel in collapsed state
        /// </summary>
        private readonly int _collapsedHeight;

        /// <summary>
        /// Height of panel in expanded state
        /// </summary>
        private int _expandedHeight;

        /// <summary>
        /// Last stored size of panel's parent control
        /// <remarks>used for handling panel's Anchor property sets to Bottom when panel collapsed
        /// in OnSizeChanged method</remarks>
        /// </summary>
        private Size _previousParentSize = Size.Empty;

        /// <summary>
        /// Occurs when [expand collapse].
        /// </summary>
        [Browsable(true)]
        [Category("Expander")]
        [Description("Occurs when the panel has expanded or collapsed.")]
        public event EventHandler<StateChangedEventArgs> OnStateChanged;

        // degree to adjust the height of the panel when animating
        private int _animationHeightAdjustment;
        // current opacity level
        private int _animationOpacity;

        /// <summary>
        /// Internal state of panel used for checking that panel is animating now
        /// </summary>
        private InternalPanelState _internalPanelState;

        /// <summary>
        /// Internal state of panel
        /// </summary>
        private enum InternalPanelState
        {
            /// <summary>
            /// No animation, completely expanded or collapsed
            /// </summary>
            Normal,

            /// <summary>
            /// Expanding animation
            /// </summary>
            Expanding,

            /// <summary>
            /// Collapsing animation
            /// </summary>
            Collapsing
        }

        #endregion

        #region Category: Settings

        [Browsable(true)]
        [Category("Expander")]
        [DisplayName("BorderColor")]
        [Description("Only works when BorderStyle is set to None.")]
        public Color BorderColor { get; set; }

        /// <summary>
        /// Height of panel in expanded state
        /// </summary>
        [Browsable(true)]
        [DefaultValue(true)]
        [Category("Expander")]
        [DisplayName("Expanded Height")]
        [Description("Height of panel in expanded state.")]
        public int ExpandedHeight
        {
            get { return _expandedHeight; }
            set
            {
                _expandedHeight = value;
                if (IsExpanded)
                    Height = _expandedHeight;
            }
        }

        /// <summary>
        /// Sets a flag for either expanded or collapsed panel content.
        /// (true - expanded, false - collapsed)
        /// </summary>
        [Browsable(true)]
        [DefaultValue(true)]
        [Category("Expander")]
        [DisplayName("Is Expanded")]
        [Description("Expand or collapse panel content. " +
                     "Attention, for correct work with resizing child controls, please set " +
                     "IsExpanded to \"false\" in code (for example in your Form class constructor " +
                     "after InitializeComponent method) and not in Forms Designer!")]
        public bool IsExpanded
        {
            get { return btnHeader.IsExpanded; }
            set
            {
                if (btnHeader.IsExpanded != value)
                    btnHeader.IsExpanded = value;
            }
        }

        [Browsable(true)]
        [DefaultValue(null)]
        [Category("Expander")]
        public Color HeaderBackColor
        {
            get { return btnHeader.BackColor; }
            set { btnHeader.BackColor = value; }
        }

        /// <summary>
        /// Enable a pretty simple animation of panel on expanding or collapsing.
        /// </summary>
        [Browsable(true)]
        [DefaultValue(false)]
        [Category("Expander")]
        [DisplayName("Animated")]
        [Description("Enable pretty simple animation of panel on expanding or collapsing.")]
        public bool UseAnimation
        {
            get { return _useAnimation; }
            set { _useAnimation = value; }
        }

        [Browsable(true)]
        [DefaultValue(true)]
        [Category("Expander")]
        [DisplayName("Text")]
        public override string Text
        {
            get { return btnHeader.Text; }
            set { btnHeader.Text = value; }
        }

        /// <summary>
        /// AutoScroll property
        /// <remarks>Overridden only to hide from designer as mindless and useless</remarks>
        /// </summary>
        [Browsable(false)]
        public override bool AutoScroll
        {
            get { return base.AutoScroll; }
            set { base.AutoScroll = value; }
        }

        /// <summary>
        /// Font used for displays header text
        /// </summary>
        public override Font Font
        {
            get { return btnHeader.Font; }
            set { btnHeader.Font = value; }
        }

        /// <summary>
        /// Foreground color used for displays header text
        /// </summary>
        public override Color ForeColor
        {
            get { return btnHeader.ForeColor; }
            set { btnHeader.ForeColor = value; }
        }

        #endregion

        #region Category: Animation

        //	---------------------------------------------------------------------------------------
        //	The original source of this animation technique was written by
        //	Daren May for his Collapsible Panel implementation which can
        //	be found here:
        //		http://www.codeproject.com/cs/miscctrl/xpgroupbox.asp
        //   
        //	Although I found that piece of code in very good XPPanel implementation by Tom Guinther:
        //		http://www.codeproject.com/Articles/7332/Full-featured-XP-Style-Collapsible-Panel
        //  I have simplified things quite a bit, nothing is fundamentally different. 
        //  So I give many thanks to both for solving this problem.
        //	---------------------------------------------------------------------------------------

        /// <summary>
        /// Initialize animation values and start the timer
        /// </summary>
        private void StartAnimation()
        {
            _animationHeightAdjustment = 1;
            _animationOpacity = 5;
            _animationTimer.Interval = 50;
            _animationTimer.Enabled = true;
        }

        /// <summary>
        /// Handles the Tick event of the animationTimer control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void animationTimer_Tick(object sender, EventArgs e)
        {
            //	---------------------------------------------------------------
            //	Gradually reduce the interval between timer events so that the
            //	animation begins slowly and eventually accelerates to completion
            //	---------------------------------------------------------------
            if (_animationTimer.Interval > 10)
                _animationTimer.Interval -= 10;
            else
                _animationHeightAdjustment += 2;

            // Increase transparency as we collapse
            if (_animationOpacity + 5 < byte.MaxValue)
                _animationOpacity += 5;

            var currOpacity = _animationOpacity;

            switch (_internalPanelState)
            {
                case InternalPanelState.Expanding:
                    // still room to expand?
                    if (Height + _animationHeightAdjustment < _expandedHeight)
                    {
                        Height += _animationHeightAdjustment;
                    }
                    else
                    {
                        // we are done so we dont want any transparency
                        currOpacity = byte.MaxValue;
                        Height = _expandedHeight;
                        _internalPanelState = InternalPanelState.Normal;
                    }
                    break;

                case InternalPanelState.Collapsing:
                    // still something to collapse
                    if (Height - _animationHeightAdjustment > _collapsedHeight)
                    {
                        Height -= _animationHeightAdjustment;
                        // continue decreasing opacity
                        currOpacity = byte.MaxValue - _animationOpacity;
                    }
                    else
                    {
                        // we are done so we dont want any transparency
                        currOpacity = byte.MaxValue;
                        Height = _collapsedHeight;
                        _internalPanelState = InternalPanelState.Normal;
                    }
                    break;

                default:
                    return;
            }

            // set the opacity for all the controls on the XPPanel
            SetControlsOpacity(currOpacity);

            // are we done?
            if (_internalPanelState == InternalPanelState.Normal)
                _animationTimer.Enabled = false;

            Invalidate();
        }

        /// <summary>
        /// Changes the transparency of controls based upon the height of the XPPanel
        /// </summary>
        /// <remarks>
        /// Only used during animation
        /// </remarks>
        private void SetControlsOpacity(int opacity)
        {
            foreach (Control c in Controls)
            {
                if (!c.Visible) continue;
                try
                {
                    if (c.BackColor != Color.Transparent)
                        c.BackColor = Color.FromArgb(opacity, c.BackColor);
                }
                catch
                {
                    // ignored
                }
                c.ForeColor = Color.FromArgb(opacity, c.ForeColor);
            }
        }

        #endregion Animation Code
    }
}