#region Category: Header Text

// ***********************************************************************
// Assembly         : WinFormExpander\Expander\ucExpanderHeader.cs
// Author           : Danny Patten
// Created          : 24 - 01 - 2017 at 13:18h
// 
// Last Modified By : Danny Patten
// Last Modified On : 24 - 01 - 2017 at 14:40h
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
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#endregion

namespace Expander
{
    public partial class ucExpanderHeader : UserControl
    {
        private int _heightCache;
        private State _isExpanded = State.Expanded;
        private int _collapsedHeight = 27;

        public enum State
        {
            Collapsed = 0,
            Expanded = 1,
        }

        public ucExpanderHeader()
        {
            InitializeComponent();

            Images.CreateBitmaps();

            lblHeaderTextDisplay.Text = "Title";
            
            _heightCache = Size.Height;

            ShowMenuButton = false;
            btnHeaderMenuDisplay.Visible = false;
            btnHeaderMenuDisplay.BackgroundImage = Images.MenuBtnImage;
            btnHeaderMenuDisplay.BackgroundImageLayout = ImageLayout.Center;
            pbHeaderPictureDisplay.BackgroundImageLayout = ImageLayout.Center;

            InitializeState();
        }

        #region Category: Header

        /// <summary>
        /// Handles the Click event of the header control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void header_Click(object sender, EventArgs e)
        {
            ExpandCollapse();
        }

        #endregion

        #region Category: Settings

        /// <summary>
        /// Gets or sets the color of the expander header.
        /// </summary>
        /// <value>
        /// The color of the expander header.
        /// </value>
        [Browsable(true)]
        [Category("Extra")]
        [DisplayName("Expander Color")]
        [DefaultValue(null)]
        public Color ExpanderHeaderColor
        {
            get { return pHeader.BackColor; }
            set
            {
                pHeader.BackColor = value;
                pBody.BackColor = value;
            }
        }

        /// <summary>
        /// Gets or sets the color of the expander content body.
        /// </summary>
        /// <value>
        /// The color of the expander content body.
        /// </value>
        [Browsable(true)]
        [Category("Extra")]
        [DisplayName("Expander ContentBodyColor")]
        [DefaultValue(null)]
        public Color ExpanderContentBodyColor
        {
            get { return pExpanderContentBody.BackColor; }
            set { pExpanderContentBody.BackColor = value; }
        }


        /// <summary>
        /// Gets or sets a value indicating whether to show the menu button.
        /// </summary>
        /// <value>
        ///   <c>true</c> if [show menu button]; otherwise, <c>false</c>.
        /// </value>
        [Browsable(true)]
        [Category("Extra")]
        [DisplayName("Show Menu button")]
        [Description("Determines whether the Menu button control is shown.")]
        [DefaultValue(false)]
        public bool ShowMenuButton
        {
            get { return btnHeaderMenuDisplay.Visible; }
            set { btnHeaderMenuDisplay.Visible = value; }
        }

        /// <summary>
        /// Gets or sets the title.
        /// </summary>
        /// <value>
        /// The title.
        /// </value>
        [Browsable(true)]
        [Category("Extra")]
        [DisplayName("Header Title")]
        [DefaultValue("Title")]
        public string Title
        {
            get { return lblHeaderTextDisplay.Text; }
            set { lblHeaderTextDisplay.Text = value; }
        }

        /// <summary>
        /// Gets or sets the header font.
        /// </summary>
        /// <value>
        /// The header font.
        /// </value>
        [Browsable(true)]
        [Category("Extra")]
        [DisplayName("Header Font")]
        public Font HeaderFont
        {
            get { return lblHeaderTextDisplay.Font; }
            set { lblHeaderTextDisplay.Font = value; }
        }

        [Browsable(true)]
        [Category("Extra")]
        [DisplayName("Header ForeColor")]
        [DefaultValue(null)]
        public Color ForeColor
        {
            get { return lblHeaderTextDisplay.ForeColor; }
            set { lblHeaderTextDisplay.ForeColor = value; }
        }

        #endregion

        #region Category: Menu Button

        /// <summary>
        /// Handles the MouseEnter event of the btnHeaderMenuDisplay control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void btnHeaderMenuDisplay_MouseEnter(object sender, EventArgs e)
        {
            btnHeaderMenuDisplay.BackgroundImage = Images.MenuMouseOverBtnImage;
        }

        private void ucExpanderHeader_Load(object sender, EventArgs e)
        {
        }

        /// <summary>
        /// Handles the MouseLeave event of the btnHeaderMenuDisplay control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void btnHeaderMenuDisplay_MouseLeave(object sender, EventArgs e)
        {
            btnHeaderMenuDisplay.BackgroundImage = Images.MenuBtnImage;
        }

        #endregion

        private void InitializeState()
        {
            if (_isExpanded == State.Expanded)
            {
                pbHeaderPictureDisplay.BackgroundImage = Images.CollapsedImage;
                Size = new Size(Size.Width, _heightCache);
            }
            else
            {
                pbHeaderPictureDisplay.BackgroundImage = Images.ExpandedImage;
                Size = new Size(Size.Width, _collapsedHeight);
            }
        }

        private void ExpandCollapse()
        {
            if (_isExpanded == State.Expanded)
            {
                pbHeaderPictureDisplay.BackgroundImage = Images.CollapsedImage;
                Size = new Size(Size.Width, _heightCache);
                _isExpanded = State.Collapsed;
            }
            else
            {
                pbHeaderPictureDisplay.BackgroundImage = Images.ExpandedImage;
                Size = new Size(Size.Width, 27);
                _isExpanded = State.Expanded;
            }
        }
    }
}