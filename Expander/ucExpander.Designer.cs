namespace Expander
{
    partial class ucExpander
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
            this.btnHeader = new Expander.ucExpanderHeader();
            this.SuspendLayout();
            // 
            // btnHeader
            // 
            this.btnHeader.BackColor = System.Drawing.Color.Brown;
            this.btnHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHeader.IsExpanded = false;
            this.btnHeader.Location = new System.Drawing.Point(0, 0);
            this.btnHeader.Margin = new System.Windows.Forms.Padding(0);
            this.btnHeader.MaximumSize = new System.Drawing.Size(0, 28);
            this.btnHeader.Name = "btnHeader";
            this.btnHeader.Size = new System.Drawing.Size(190, 28);
            this.btnHeader.TabIndex = 0;
            // 
            // ucExpander
            // 
            this.Controls.Add(this.btnHeader);
            this.Name = "ucExpander";
            this.Size = new System.Drawing.Size(190, 150);
            this.ResumeLayout(false);

        }

        #endregion

        private ucExpanderHeader btnHeader;
    }
}
