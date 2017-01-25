namespace Expander_Example
{
    partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        { 
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ucExpander3 = new Expander.ucExpander();
            this.label4 = new System.Windows.Forms.Label();
            this.ucExpander4 = new Expander.ucExpander();
            this.label3 = new System.Windows.Forms.Label();
            this.advancedFlowLayoutPanel1 = new Expander.AdvancedFlowLayoutPanel();
            this.ucExpander1 = new Expander.ucExpander();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.ucExpander2 = new Expander.ucExpander();
            this.statusStrip2 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripProgressBar2 = new System.Windows.Forms.ToolStripProgressBar();
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.button2 = new System.Windows.Forms.Button();
            this.ucExpander3.SuspendLayout();
            this.ucExpander4.SuspendLayout();
            this.advancedFlowLayoutPanel1.SuspendLayout();
            this.ucExpander1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.ucExpander2.SuspendLayout();
            this.statusStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Expander in an AdvancedFlowLayoutPanel.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(446, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Expander in a default size.";
            // 
            // ucExpander3
            // 
            this.ucExpander3.BackColor = System.Drawing.Color.LightGray;
            this.ucExpander3.BorderColor = System.Drawing.Color.Brown;
            this.ucExpander3.Controls.Add(this.label4);
            this.ucExpander3.Controls.Add(this.ucExpander4);
            this.ucExpander3.ExpandedHeight = 0;
            this.ucExpander3.HeaderBackColor = System.Drawing.Color.Brown;
            this.ucExpander3.Location = new System.Drawing.Point(449, 54);
            this.ucExpander3.Name = "ucExpander3";
            this.ucExpander3.Padding = new System.Windows.Forms.Padding(2);
            this.ucExpander3.Size = new System.Drawing.Size(395, 496);
            this.ucExpander3.TabIndex = 8;
            this.ucExpander3.Text = "#Hotkeys";
            this.ucExpander3.UseAnimation = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(8, 472);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(379, 19);
            this.label4.TabIndex = 2;
            this.label4.Text = "Border is still wonky and could probably be improved!";
            // 
            // ucExpander4
            // 
            this.ucExpander4.BorderColor = System.Drawing.Color.Brown;
            this.ucExpander4.Controls.Add(this.label3);
            this.ucExpander4.ExpandedHeight = 211;
            this.ucExpander4.HeaderBackColor = System.Drawing.Color.Brown;
            this.ucExpander4.Location = new System.Drawing.Point(5, 34);
            this.ucExpander4.Name = "ucExpander4";
            this.ucExpander4.Size = new System.Drawing.Size(384, 210);
            this.ucExpander4.TabIndex = 1;
            this.ucExpander4.Text = "Expander without Animation!";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(139, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 22);
            this.label3.TabIndex = 1;
            this.label3.Text = "Found Me!";
            // 
            // advancedFlowLayoutPanel1
            // 
            this.advancedFlowLayoutPanel1.Controls.Add(this.ucExpander1);
            this.advancedFlowLayoutPanel1.Controls.Add(this.ucExpander2);
            this.advancedFlowLayoutPanel1.Location = new System.Drawing.Point(40, 51);
            this.advancedFlowLayoutPanel1.Name = "advancedFlowLayoutPanel1";
            this.advancedFlowLayoutPanel1.Size = new System.Drawing.Size(403, 499);
            this.advancedFlowLayoutPanel1.TabIndex = 7;
            // 
            // ucExpander1
            // 
            this.ucExpander1.BackColor = System.Drawing.Color.LightGray;
            this.ucExpander1.BorderColor = System.Drawing.Color.Brown;
            this.ucExpander1.Controls.Add(this.statusStrip1);
            this.ucExpander1.Controls.Add(this.progressBar1);
            this.ucExpander1.Controls.Add(this.pictureBox1);
            this.ucExpander1.Controls.Add(this.comboBox1);
            this.ucExpander1.Controls.Add(this.checkBox2);
            this.ucExpander1.Controls.Add(this.checkBox1);
            this.ucExpander1.Controls.Add(this.button1);
            this.ucExpander1.ExpandedHeight = 0;
            this.ucExpander1.HeaderBackColor = System.Drawing.Color.Brown;
            this.ucExpander1.Location = new System.Drawing.Point(3, 3);
            this.ucExpander1.Name = "ucExpander1";
            this.ucExpander1.Padding = new System.Windows.Forms.Padding(2);
            this.ucExpander1.Size = new System.Drawing.Size(397, 245);
            this.ucExpander1.TabIndex = 6;
            this.ucExpander1.Text = "#Hotkeys";
            this.ucExpander1.UseAnimation = true;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripProgressBar1});
            this.statusStrip1.Location = new System.Drawing.Point(2, 221);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(393, 22);
            this.statusStrip1.TabIndex = 7;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(100, 16);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(5, 117);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(196, 23);
            this.progressBar1.TabIndex = 6;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(207, 63);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 128);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(5, 90);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(196, 21);
            this.comboBox1.TabIndex = 4;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(106, 63);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(103, 23);
            this.checkBox2.TabIndex = 3;
            this.checkBox2.Text = "checkBox2";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(5, 63);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(103, 23);
            this.checkBox1.TabIndex = 2;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(5, 34);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(302, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // ucExpander2
            // 
            this.ucExpander2.BackColor = System.Drawing.Color.LightGray;
            this.ucExpander2.BorderColor = System.Drawing.Color.Brown;
            this.ucExpander2.Controls.Add(this.statusStrip2);
            this.ucExpander2.Controls.Add(this.progressBar2);
            this.ucExpander2.Controls.Add(this.pictureBox2);
            this.ucExpander2.Controls.Add(this.comboBox2);
            this.ucExpander2.Controls.Add(this.checkBox3);
            this.ucExpander2.Controls.Add(this.checkBox4);
            this.ucExpander2.Controls.Add(this.button2);
            this.ucExpander2.ExpandedHeight = 0;
            this.ucExpander2.HeaderBackColor = System.Drawing.Color.Brown;
            this.ucExpander2.Location = new System.Drawing.Point(3, 254);
            this.ucExpander2.Name = "ucExpander2";
            this.ucExpander2.Padding = new System.Windows.Forms.Padding(2);
            this.ucExpander2.Size = new System.Drawing.Size(397, 245);
            this.ucExpander2.TabIndex = 8;
            this.ucExpander2.Text = "#Hotkeys";
            this.ucExpander2.UseAnimation = true;
            // 
            // statusStrip2
            // 
            this.statusStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel2,
            this.toolStripProgressBar2});
            this.statusStrip2.Location = new System.Drawing.Point(2, 221);
            this.statusStrip2.Name = "statusStrip2";
            this.statusStrip2.Size = new System.Drawing.Size(393, 22);
            this.statusStrip2.TabIndex = 7;
            this.statusStrip2.Text = "statusStrip2";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel2.Text = "toolStripStatusLabel1";
            // 
            // toolStripProgressBar2
            // 
            this.toolStripProgressBar2.Name = "toolStripProgressBar2";
            this.toolStripProgressBar2.Size = new System.Drawing.Size(100, 16);
            // 
            // progressBar2
            // 
            this.progressBar2.Location = new System.Drawing.Point(5, 117);
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(196, 23);
            this.progressBar2.TabIndex = 6;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(207, 63);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 128);
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(5, 90);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(196, 21);
            this.comboBox2.TabIndex = 4;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(106, 63);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(103, 23);
            this.checkBox3.TabIndex = 3;
            this.checkBox3.Text = "checkBox3";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(5, 63);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(103, 23);
            this.checkBox4.TabIndex = 2;
            this.checkBox4.Text = "checkBox4";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(5, 34);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(302, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 585);
            this.Controls.Add(this.ucExpander3);
            this.Controls.Add(this.advancedFlowLayoutPanel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Expander Example";
            this.ucExpander3.ResumeLayout(false);
            this.ucExpander3.PerformLayout();
            this.ucExpander4.ResumeLayout(false);
            this.ucExpander4.PerformLayout();
            this.advancedFlowLayoutPanel1.ResumeLayout(false);
            this.ucExpander1.ResumeLayout(false);
            this.ucExpander1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ucExpander2.ResumeLayout(false);
            this.ucExpander2.PerformLayout();
            this.statusStrip2.ResumeLayout(false);
            this.statusStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Expander.ucExpander ucExpander1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
        private Expander.AdvancedFlowLayoutPanel advancedFlowLayoutPanel1;
        private Expander.ucExpander ucExpander2;
        private System.Windows.Forms.StatusStrip statusStrip2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar2;
        private System.Windows.Forms.ProgressBar progressBar2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.Button button2;
        private Expander.ucExpander ucExpander3;
        private Expander.ucExpander ucExpander4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

