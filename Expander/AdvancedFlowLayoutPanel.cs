#region Category: Header Text

// ***********************************************************************
// Assembly         : ExpandCollapsePanel\MakarovDev.ExpandCollapsePanel\AdvancedFlowLayoutPanel.cs
// Author           : Danny Patten
// Created          : 22 - 01 - 2017 at 16:38h
// 
// Last Modified By : Danny Patten
// Last Modified On : 24 - 01 - 2017 at 23:35h
// ***********************************************************************
// Copyright © 2016 - 2017, Danny Patten - All Rights Reserved
// 
// Redistribution and use in source and binary forms, with or without
// modification, are not permitted
// ***********************************************************************

#endregion

#region Category: Directives

using System;
using System.Drawing;
using System.Windows.Forms;

#endregion

namespace Expander
{
    /// <summary>
    /// FlowLayoutPanel with additional utillity behaviour
    /// </summary>
    public class AdvancedFlowLayoutPanel : FlowLayoutPanel
    {
        /// <summary>
        /// Handle the resize of panel
        /// </summary>
        /// <param name="e"></param>
        protected override void OnSizeChanged(EventArgs e)
        {
            // for each child control
            foreach (Control c in Controls)
                FillControlWidth(c); // scale the width to fill free horizontal space

            // get all another resize stuff from base class
            base.OnSizeChanged(e);
        }

        /// <summary>
        /// Scale the width to fill free horizontal space of current panel
        /// </summary>
        /// <param name="c">control for scalling</param>
        private void FillControlWidth(Control c)
        {
            c.Size = new Size(ClientSize.Width - c.Margin.Left - c.Margin.Right, c.Height);
        }
    }
}