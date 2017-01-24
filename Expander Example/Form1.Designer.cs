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
            this.ucExpanderHeader1 = new Expander.ucExpanderHeader();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.ucExpanderHeader2 = new Expander.ucExpanderHeader();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ucExpanderHeader1
            // 
            this.ucExpanderHeader1.BackColor = System.Drawing.Color.Brown;
            this.ucExpanderHeader1.ExpanderContentBodyColor = System.Drawing.SystemColors.Control;
            this.ucExpanderHeader1.ExpanderHeaderColor = System.Drawing.Color.Brown;
            this.ucExpanderHeader1.ForeColor = System.Drawing.Color.White;
            this.ucExpanderHeader1.HeaderFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucExpanderHeader1.Location = new System.Drawing.Point(3, 3);
            this.ucExpanderHeader1.Name = "ucExpanderHeader1";
            this.ucExpanderHeader1.Size = new System.Drawing.Size(423, 166);
            this.ucExpanderHeader1.TabIndex = 0;
            this.ucExpanderHeader1.Title = "Expander 1";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.ucExpanderHeader1);
            this.flowLayoutPanel1.Controls.Add(this.ucExpanderHeader2);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(180, 23);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(429, 539);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // ucExpanderHeader2
            // 
            this.ucExpanderHeader2.BackColor = System.Drawing.Color.Brown;
            this.ucExpanderHeader2.ExpanderContentBodyColor = System.Drawing.SystemColors.Control;
            this.ucExpanderHeader2.ExpanderHeaderColor = System.Drawing.Color.Brown;
            this.ucExpanderHeader2.ForeColor = System.Drawing.Color.White;
            this.ucExpanderHeader2.HeaderFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucExpanderHeader2.Location = new System.Drawing.Point(3, 175);
            this.ucExpanderHeader2.Name = "ucExpanderHeader2";
            this.ucExpanderHeader2.Size = new System.Drawing.Size(423, 166);
            this.ucExpanderHeader2.TabIndex = 1;
            this.ucExpanderHeader2.Title = "Expander 2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 585);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Expander.ucExpanderHeader ucExpanderHeader1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private Expander.ucExpanderHeader ucExpanderHeader2;
    }
}

