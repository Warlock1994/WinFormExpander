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
            this.btnHeaderMenuDisplay = new System.Windows.Forms.Button();
            this.cntxtBtnMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.testToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.testToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.testToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.pbHeaderPictureDisplay = new System.Windows.Forms.PictureBox();
            this.pBody = new System.Windows.Forms.Panel();
            this.pExpanderContentBody = new System.Windows.Forms.Panel();
            this.pHeader = new System.Windows.Forms.Panel();
            this.lblHeaderTextDisplay = new System.Windows.Forms.Label();
            this.cntxtBtnMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbHeaderPictureDisplay)).BeginInit();
            this.pBody.SuspendLayout();
            this.pHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnHeaderMenuDisplay
            // 
            this.btnHeaderMenuDisplay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnHeaderMenuDisplay.ContextMenuStrip = this.cntxtBtnMenu;
            this.btnHeaderMenuDisplay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHeaderMenuDisplay.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnHeaderMenuDisplay.FlatAppearance.BorderSize = 0;
            this.btnHeaderMenuDisplay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHeaderMenuDisplay.Location = new System.Drawing.Point(404, 0);
            this.btnHeaderMenuDisplay.Name = "btnHeaderMenuDisplay";
            this.btnHeaderMenuDisplay.Size = new System.Drawing.Size(15, 25);
            this.btnHeaderMenuDisplay.TabIndex = 8;
            this.btnHeaderMenuDisplay.UseVisualStyleBackColor = true;
            this.btnHeaderMenuDisplay.MouseEnter += new System.EventHandler(this.btnHeaderMenuDisplay_MouseEnter);
            this.btnHeaderMenuDisplay.MouseLeave += new System.EventHandler(this.btnHeaderMenuDisplay_MouseLeave);
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
            // pbHeaderPictureDisplay
            // 
            this.pbHeaderPictureDisplay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbHeaderPictureDisplay.Dock = System.Windows.Forms.DockStyle.Left;
            this.pbHeaderPictureDisplay.Location = new System.Drawing.Point(0, 0);
            this.pbHeaderPictureDisplay.Name = "pbHeaderPictureDisplay";
            this.pbHeaderPictureDisplay.Size = new System.Drawing.Size(25, 25);
            this.pbHeaderPictureDisplay.TabIndex = 7;
            this.pbHeaderPictureDisplay.TabStop = false;
            this.pbHeaderPictureDisplay.Click += new System.EventHandler(this.header_Click);
            // 
            // pBody
            // 
            this.pBody.Controls.Add(this.pExpanderContentBody);
            this.pBody.Controls.Add(this.pHeader);
            this.pBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pBody.Location = new System.Drawing.Point(0, 0);
            this.pBody.Name = "pBody";
            this.pBody.Padding = new System.Windows.Forms.Padding(2);
            this.pBody.Size = new System.Drawing.Size(423, 284);
            this.pBody.TabIndex = 10;
            // 
            // pExpanderContentBody
            // 
            this.pExpanderContentBody.BackColor = System.Drawing.SystemColors.Control;
            this.pExpanderContentBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pExpanderContentBody.Location = new System.Drawing.Point(2, 27);
            this.pExpanderContentBody.Name = "pExpanderContentBody";
            this.pExpanderContentBody.Padding = new System.Windows.Forms.Padding(3);
            this.pExpanderContentBody.Size = new System.Drawing.Size(419, 255);
            this.pExpanderContentBody.TabIndex = 11;
            // 
            // pHeader
            // 
            this.pHeader.Controls.Add(this.lblHeaderTextDisplay);
            this.pHeader.Controls.Add(this.btnHeaderMenuDisplay);
            this.pHeader.Controls.Add(this.pbHeaderPictureDisplay);
            this.pHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pHeader.Location = new System.Drawing.Point(2, 2);
            this.pHeader.Name = "pHeader";
            this.pHeader.Size = new System.Drawing.Size(419, 25);
            this.pHeader.TabIndex = 10;
            // 
            // lblHeaderTextDisplay
            // 
            this.lblHeaderTextDisplay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblHeaderTextDisplay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblHeaderTextDisplay.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeaderTextDisplay.ForeColor = System.Drawing.Color.White;
            this.lblHeaderTextDisplay.Location = new System.Drawing.Point(25, 0);
            this.lblHeaderTextDisplay.Name = "lblHeaderTextDisplay";
            this.lblHeaderTextDisplay.Size = new System.Drawing.Size(379, 25);
            this.lblHeaderTextDisplay.TabIndex = 10;
            this.lblHeaderTextDisplay.Text = "label1";
            this.lblHeaderTextDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblHeaderTextDisplay.Click += new System.EventHandler(this.header_Click);
            // 
            // ucExpanderHeader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Brown;
            this.Controls.Add(this.pBody);
            this.Name = "ucExpanderHeader";
            this.Size = new System.Drawing.Size(423, 284);
            this.Load += new System.EventHandler(this.ucExpanderHeader_Load);
            this.cntxtBtnMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbHeaderPictureDisplay)).EndInit();
            this.pBody.ResumeLayout(false);
            this.pHeader.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnHeaderMenuDisplay;
        private System.Windows.Forms.PictureBox pbHeaderPictureDisplay;
        private System.Windows.Forms.ContextMenuStrip cntxtBtnMenu;
        private System.Windows.Forms.ToolStripMenuItem testToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem testToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem testToolStripMenuItem2;
        private System.Windows.Forms.Panel pBody;
        private System.Windows.Forms.Panel pHeader;
        private System.Windows.Forms.Label lblHeaderTextDisplay;
        private System.Windows.Forms.Panel pExpanderContentBody;
    }
}
