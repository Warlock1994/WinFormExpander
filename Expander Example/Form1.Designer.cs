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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.ucExpanderHeader1 = new Expander.ucExpanderHeader();
            this.ucExpanderHeader2 = new Expander.ucExpanderHeader();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ucExpanderHeader3 = new Expander.ucExpanderHeader();
            this.label3 = new System.Windows.Forms.Label();
            this.ucExpanderHeader4 = new Expander.ucExpanderHeader();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.ucExpanderHeader1);
            this.flowLayoutPanel1.Controls.Add(this.ucExpanderHeader4);
            this.flowLayoutPanel1.Controls.Add(this.ucExpanderHeader2);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 34);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(429, 539);
            this.flowLayoutPanel1.TabIndex = 1;
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
            this.ucExpanderHeader1.Padding = new System.Windows.Forms.Padding(3);
            this.ucExpanderHeader1.Size = new System.Drawing.Size(423, 166);
            this.ucExpanderHeader1.TabIndex = 0;
            this.ucExpanderHeader1.Title = "Expander 1";
            // 
            // ucExpanderHeader2
            // 
            this.ucExpanderHeader2.BackColor = System.Drawing.Color.Brown;
            this.ucExpanderHeader2.ExpanderContentBodyColor = System.Drawing.SystemColors.Control;
            this.ucExpanderHeader2.ExpanderHeaderColor = System.Drawing.Color.Brown;
            this.ucExpanderHeader2.ForeColor = System.Drawing.Color.White;
            this.ucExpanderHeader2.HeaderFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucExpanderHeader2.Location = new System.Drawing.Point(3, 347);
            this.ucExpanderHeader2.Name = "ucExpanderHeader2";
            this.ucExpanderHeader2.Padding = new System.Windows.Forms.Padding(3);
            this.ucExpanderHeader2.Size = new System.Drawing.Size(423, 166);
            this.ucExpanderHeader2.TabIndex = 1;
            this.ucExpanderHeader2.Title = "Expander 3";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Expander in a FlowLayoutPanel.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(444, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Expander in a default size.";
            // 
            // ucExpanderHeader3
            // 
            this.ucExpanderHeader3.BackColor = System.Drawing.Color.Brown;
            this.ucExpanderHeader3.ExpanderContentBodyColor = System.Drawing.SystemColors.Control;
            this.ucExpanderHeader3.ExpanderHeaderColor = System.Drawing.Color.Brown;
            this.ucExpanderHeader3.ForeColor = System.Drawing.Color.White;
            this.ucExpanderHeader3.HeaderFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucExpanderHeader3.Location = new System.Drawing.Point(447, 37);
            this.ucExpanderHeader3.Name = "ucExpanderHeader3";
            this.ucExpanderHeader3.Padding = new System.Windows.Forms.Padding(3);
            this.ucExpanderHeader3.Size = new System.Drawing.Size(423, 284);
            this.ucExpanderHeader3.TabIndex = 3;
            this.ucExpanderHeader3.Title = "Default Expander";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(470, 381);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(386, 100);
            this.label3.TabIndex = 5;
            this.label3.Text = "Knowm Bugs:\r\n1. After Collpasing it revert to default height.\r\n2. Doesn\'t act lik" +
    "e a panel\r\n3. Takes 2 Clicks to Collapse initially.";
            // 
            // ucExpanderHeader4
            // 
            this.ucExpanderHeader4.BackColor = System.Drawing.Color.Brown;
            this.ucExpanderHeader4.ExpanderContentBodyColor = System.Drawing.SystemColors.Control;
            this.ucExpanderHeader4.ExpanderHeaderColor = System.Drawing.Color.Brown;
            this.ucExpanderHeader4.ForeColor = System.Drawing.Color.White;
            this.ucExpanderHeader4.HeaderFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucExpanderHeader4.Location = new System.Drawing.Point(3, 175);
            this.ucExpanderHeader4.Name = "ucExpanderHeader4";
            this.ucExpanderHeader4.Padding = new System.Windows.Forms.Padding(3);
            this.ucExpanderHeader4.Size = new System.Drawing.Size(423, 166);
            this.ucExpanderHeader4.TabIndex = 11;
            this.ucExpanderHeader4.Title = "Expander 2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 585);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ucExpanderHeader3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Expander.ucExpanderHeader ucExpanderHeader1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private Expander.ucExpanderHeader ucExpanderHeader2;
        private System.Windows.Forms.Label label1;
        private Expander.ucExpanderHeader ucExpanderHeader3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Expander.ucExpanderHeader ucExpanderHeader4;
    }
}

