namespace Expander
{
    partial class ucExpanderHeader
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.cntxtBtnMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.testToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.testToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.testToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.pBody = new System.Windows.Forms.Panel();
            this.lblHeaderTextDisplay = new System.Windows.Forms.Label();
            this.btnHeaderMenuDisplay = new System.Windows.Forms.Button();
            this.pbHeaderPictureDisplay = new System.Windows.Forms.PictureBox();
            this.cntxtBtnMenu.SuspendLayout();
            this.pBody.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbHeaderPictureDisplay)).BeginInit();
            this.SuspendLayout();
            // 
            // cntxtBtnMenu
            // 
            this.cntxtBtnMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.cntxtBtnMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.testToolStripMenuItem,
            this.testToolStripMenuItem1,
            this.testToolStripMenuItem2});
            this.cntxtBtnMenu.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow;
            this.cntxtBtnMenu.Name = "cntxtBtnMenu";
            this.cntxtBtnMenu.Size = new System.Drawing.Size(96, 70);
            // 
            // testToolStripMenuItem
            // 
            this.testToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.testToolStripMenuItem.Name = "testToolStripMenuItem";
            this.testToolStripMenuItem.Size = new System.Drawing.Size(95, 22);
            this.testToolStripMenuItem.Text = "Test";
            // 
            // testToolStripMenuItem1
            // 
            this.testToolStripMenuItem1.ForeColor = System.Drawing.Color.White;
            this.testToolStripMenuItem1.Name = "testToolStripMenuItem1";
            this.testToolStripMenuItem1.Size = new System.Drawing.Size(95, 22);
            this.testToolStripMenuItem1.Text = "Test";
            // 
            // testToolStripMenuItem2
            // 
            this.testToolStripMenuItem2.ForeColor = System.Drawing.Color.White;
            this.testToolStripMenuItem2.Name = "testToolStripMenuItem2";
            this.testToolStripMenuItem2.Size = new System.Drawing.Size(95, 22);
            this.testToolStripMenuItem2.Text = "Test";
            // 
            // pBody
            // 
            this.pBody.BackColor = System.Drawing.Color.Transparent;
            this.pBody.Controls.Add(this.lblHeaderTextDisplay);
            this.pBody.Controls.Add(this.btnHeaderMenuDisplay);
            this.pBody.Controls.Add(this.pbHeaderPictureDisplay);
            this.pBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pBody.Location = new System.Drawing.Point(0, 0);
            this.pBody.Margin = new System.Windows.Forms.Padding(0);
            this.pBody.Name = "pBody";
            this.pBody.Size = new System.Drawing.Size(355, 28);
            this.pBody.TabIndex = 10;
            // 
            // lblHeaderTextDisplay
            // 
            this.lblHeaderTextDisplay.BackColor = System.Drawing.Color.Transparent;
            this.lblHeaderTextDisplay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblHeaderTextDisplay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblHeaderTextDisplay.Font = new System.Drawing.Font("Century Gothic", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeaderTextDisplay.ForeColor = System.Drawing.Color.White;
            this.lblHeaderTextDisplay.Location = new System.Drawing.Point(25, 0);
            this.lblHeaderTextDisplay.Margin = new System.Windows.Forms.Padding(0);
            this.lblHeaderTextDisplay.Name = "lblHeaderTextDisplay";
            this.lblHeaderTextDisplay.Size = new System.Drawing.Size(315, 28);
            this.lblHeaderTextDisplay.TabIndex = 16;
            this.lblHeaderTextDisplay.Text = "label1";
            this.lblHeaderTextDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblHeaderTextDisplay.Click += new System.EventHandler(this.OnMouseDown);
            // 
            // btnHeaderMenuDisplay
            // 
            this.btnHeaderMenuDisplay.BackColor = System.Drawing.Color.Transparent;
            this.btnHeaderMenuDisplay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnHeaderMenuDisplay.ContextMenuStrip = this.cntxtBtnMenu;
            this.btnHeaderMenuDisplay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHeaderMenuDisplay.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnHeaderMenuDisplay.FlatAppearance.BorderSize = 0;
            this.btnHeaderMenuDisplay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHeaderMenuDisplay.Location = new System.Drawing.Point(340, 0);
            this.btnHeaderMenuDisplay.Margin = new System.Windows.Forms.Padding(0);
            this.btnHeaderMenuDisplay.Name = "btnHeaderMenuDisplay";
            this.btnHeaderMenuDisplay.Size = new System.Drawing.Size(15, 28);
            this.btnHeaderMenuDisplay.TabIndex = 15;
            this.btnHeaderMenuDisplay.UseVisualStyleBackColor = false;
            // 
            // pbHeaderPictureDisplay
            // 
            this.pbHeaderPictureDisplay.BackColor = System.Drawing.Color.Transparent;
            this.pbHeaderPictureDisplay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbHeaderPictureDisplay.Dock = System.Windows.Forms.DockStyle.Left;
            this.pbHeaderPictureDisplay.Location = new System.Drawing.Point(0, 0);
            this.pbHeaderPictureDisplay.Margin = new System.Windows.Forms.Padding(0);
            this.pbHeaderPictureDisplay.Name = "pbHeaderPictureDisplay";
            this.pbHeaderPictureDisplay.Size = new System.Drawing.Size(25, 28);
            this.pbHeaderPictureDisplay.TabIndex = 14;
            this.pbHeaderPictureDisplay.TabStop = false;
            this.pbHeaderPictureDisplay.Click += new System.EventHandler(this.OnMouseDown);
            // 
            // ucExpanderHeader
            // 
            this.BackColor = System.Drawing.Color.Brown;
            this.Controls.Add(this.pBody);
            this.MaximumSize = new System.Drawing.Size(0, 28);
            this.Name = "ucExpanderHeader";
            this.Size = new System.Drawing.Size(355, 28);
            this.cntxtBtnMenu.ResumeLayout(false);
            this.pBody.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbHeaderPictureDisplay)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip cntxtBtnMenu;
        private System.Windows.Forms.ToolStripMenuItem testToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem testToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem testToolStripMenuItem2;
        private System.Windows.Forms.Panel pBody;
        private System.Windows.Forms.Label lblHeaderTextDisplay;
        private System.Windows.Forms.Button btnHeaderMenuDisplay;
        private System.Windows.Forms.PictureBox pbHeaderPictureDisplay;
    }
}
