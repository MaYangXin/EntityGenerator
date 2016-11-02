namespace EntityGenerator
{
    partial class Preview_frm
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
            this.preview_rtx = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // preview_rtx
            // 
            this.preview_rtx.Dock = System.Windows.Forms.DockStyle.Fill;
            this.preview_rtx.Location = new System.Drawing.Point(0, 0);
            this.preview_rtx.Name = "preview_rtx";
            this.preview_rtx.ReadOnly = true;
            this.preview_rtx.Size = new System.Drawing.Size(502, 274);
            this.preview_rtx.TabIndex = 0;
            this.preview_rtx.Text = "";
            // 
            // Preview_frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 274);
            this.Controls.Add(this.preview_rtx);
            this.Name = "Preview_frm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "代码预览";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox preview_rtx;
    }
}