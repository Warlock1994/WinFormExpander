#region Category: Header Text

// ***********************************************************************
// Assembly         : WinFormExpander\Expander\ucExpanderHeader.cs
// Author           : Danny Patten
// Created          : 24 - 01 - 2017 at 16:43h
// 
// Last Modified By : Danny Patten
// Last Modified On : 24 - 01 - 2017 at 22:27h
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
    internal partial class ucExpanderHeader : UserControl
    {
        /// <summary>
        /// Set flag for expand or collapse button
        /// (true - expanded, false - collapsed)
        /// </summary>
        private bool _isExpanded;

        public ucExpanderHeader()
        {
            InitializeComponent();

            Images.CreateBitmaps();

            Text = "Title";

            btnHeaderMenuDisplay.Visible = false;
            btnHeaderMenuDisplay.BackgroundImage = Images.MenuBtnImage;
            btnHeaderMenuDisplay.BackgroundImageLayout = ImageLayout.Center;
            pbHeaderPictureDisplay.BackgroundImageLayout = ImageLayout.Center;

            Margin = new Padding(0);
            pBody.Margin = new Padding(0);
            pBody.Padding = new Padding(0);

            _isExpanded = false;
        }

        /// <summary>
        /// Set flag for expand or collapse button
        /// (true - expanded, false - collapsed)
        /// </summary>
        [Browsable(true)]
        [Category("Expander")]
        [Description("Expand or collapse button.")]
        public bool IsExpanded
        {
            get { return _isExpanded; }
            set
            {
                _isExpanded = value;
                OnExpandCollapse();
            }
        }

        [Browsable(true)]
        [Category("Expander")]
        public override Color BackColor
        {
            get { return base.BackColor; }
            set { base.BackColor = value; }
        }

        [Browsable(true)]
        [Category("Expander")]
        public sealed override string Text
        {
            get { return lblHeaderTextDisplay.Text; }
            set { lblHeaderTextDisplay.Text = value; }
        }

        /// <summary>
        /// Font used for displays header text
        /// </summary>
        public override Font Font
        {
            get { return lblHeaderTextDisplay.Font; }
            set { lblHeaderTextDisplay.Font = value; }
        }

        /// <summary>
        /// Foreground color used for displays header text
        /// </summary>
        public override Color ForeColor
        {
            get { return lblHeaderTextDisplay.ForeColor; }
            set { lblHeaderTextDisplay.ForeColor = value; }
        }

        /// <summary>
        /// Occurs when button has expanded or collapsed.
        /// </summary>
        public event EventHandler<StateChangedEventArgs> ExpandCollapse;

        /// <summary>
        /// Handles the Click event of the Header control.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        protected virtual void OnMouseDown(object sender, EventArgs e)
        {
            // just invert current state
            IsExpanded = !IsExpanded;
        }

        /// <summary>
        /// Handles state changing.
        /// </summary>
        protected virtual void OnExpandCollapse()
        {
            // set appropriate bitmap
            pbHeaderPictureDisplay.BackgroundImage = _isExpanded ? Images.CollapsedImage : Images.ExpandedImage;
            //lblHeader.ForeColor = _isExpanded ? Color.DarkGray : Color.SteelBlue;

            // and fire the event:
            var handler = ExpandCollapse;
            handler?.Invoke(this, new StateChangedEventArgs(_isExpanded));
        }
    }
}