
namespace Encoder
{
    partial class frmHelp
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
            this.lblEncoder = new System.Windows.Forms.Label();
            this.rtxtHelp = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // lblEncoder
            // 
            this.lblEncoder.AutoSize = true;
            this.lblEncoder.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEncoder.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblEncoder.Location = new System.Drawing.Point(102, 24);
            this.lblEncoder.Name = "lblEncoder";
            this.lblEncoder.Size = new System.Drawing.Size(65, 29);
            this.lblEncoder.TabIndex = 1;
            this.lblEncoder.Text = "HELP";
            // 
            // rtxtHelp
            // 
            this.rtxtHelp.BackColor = System.Drawing.SystemColors.Menu;
            this.rtxtHelp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtxtHelp.Font = new System.Drawing.Font("Sitka Subheading", 11.95F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxtHelp.Location = new System.Drawing.Point(107, 56);
            this.rtxtHelp.Name = "rtxtHelp";
            this.rtxtHelp.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rtxtHelp.Size = new System.Drawing.Size(514, 420);
            this.rtxtHelp.TabIndex = 2;
            this.rtxtHelp.Text = "";
            
            // 
            // frmHelp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(724, 511);
            this.Controls.Add(this.rtxtHelp);
            this.Controls.Add(this.lblEncoder);
            this.Name = "frmHelp";
            this.Text = "frmHelp";
            this.Load += new System.EventHandler(this.frmHelp_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEncoder;
        private System.Windows.Forms.RichTextBox rtxtHelp;
    }
}