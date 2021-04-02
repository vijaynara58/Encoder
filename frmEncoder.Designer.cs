
namespace Encoder
{
    partial class frmEncoder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEncoder));
            this.lblEncoder = new System.Windows.Forms.Label();
            this.btnHelp = new System.Windows.Forms.Button();
            this.grpBoxChoices = new System.Windows.Forms.GroupBox();
            this.radSaveKey = new System.Windows.Forms.RadioButton();
            this.radOwnKey = new System.Windows.Forms.RadioButton();
            this.radCreateKey = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.btnEncode = new System.Windows.Forms.Button();
            this.btnDecode = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.rtxtKey = new System.Windows.Forms.RichTextBox();
            this.rtxtResult = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnKeySave = new System.Windows.Forms.Button();
            this.btnGenerateKey = new System.Windows.Forms.Button();
            this.lblError = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.grpBoxChoices.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblEncoder
            // 
            this.lblEncoder.AutoSize = true;
            this.lblEncoder.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEncoder.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblEncoder.Location = new System.Drawing.Point(80, 6);
            this.lblEncoder.Name = "lblEncoder";
            this.lblEncoder.Size = new System.Drawing.Size(110, 29);
            this.lblEncoder.TabIndex = 0;
            this.lblEncoder.Text = "ENCODER";
            // 
            // btnHelp
            // 
            this.btnHelp.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnHelp.Cursor = System.Windows.Forms.Cursors.Help;
            this.btnHelp.Location = new System.Drawing.Point(866, 12);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(98, 38);
            this.btnHelp.TabIndex = 1;
            this.btnHelp.Text = "Help";
            this.btnHelp.UseVisualStyleBackColor = false;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // grpBoxChoices
            // 
            this.grpBoxChoices.Controls.Add(this.radSaveKey);
            this.grpBoxChoices.Controls.Add(this.radOwnKey);
            this.grpBoxChoices.Controls.Add(this.radCreateKey);
            this.grpBoxChoices.Controls.Add(this.radioButton3);
            this.grpBoxChoices.Controls.Add(this.radioButton2);
            this.grpBoxChoices.Controls.Add(this.radioButton1);
            this.grpBoxChoices.Location = new System.Drawing.Point(74, 53);
            this.grpBoxChoices.Name = "grpBoxChoices";
            this.grpBoxChoices.Size = new System.Drawing.Size(128, 156);
            this.grpBoxChoices.TabIndex = 2;
            this.grpBoxChoices.TabStop = false;
            this.grpBoxChoices.Text = "Make Your Selection";
            // 
            // radSaveKey
            // 
            this.radSaveKey.AutoSize = true;
            this.radSaveKey.Location = new System.Drawing.Point(6, 101);
            this.radSaveKey.Name = "radSaveKey";
            this.radSaveKey.Size = new System.Drawing.Size(93, 17);
            this.radSaveKey.TabIndex = 5;
            this.radSaveKey.TabStop = true;
            this.radSaveKey.Text = "Save your key";
            this.radSaveKey.UseVisualStyleBackColor = true;
            this.radSaveKey.CheckedChanged += new System.EventHandler(this.radSaveKey_CheckedChanged);
            // 
            // radOwnKey
            // 
            this.radOwnKey.AutoSize = true;
            this.radOwnKey.Location = new System.Drawing.Point(6, 68);
            this.radOwnKey.Name = "radOwnKey";
            this.radOwnKey.Size = new System.Drawing.Size(110, 17);
            this.radOwnKey.TabIndex = 4;
            this.radOwnKey.TabStop = true;
            this.radOwnKey.Text = "Use your own key";
            this.radOwnKey.UseVisualStyleBackColor = true;
            this.radOwnKey.CheckedChanged += new System.EventHandler(this.radOwnKey_CheckedChanged);
            // 
            // radCreateKey
            // 
            this.radCreateKey.AutoSize = true;
            this.radCreateKey.Location = new System.Drawing.Point(6, 36);
            this.radCreateKey.Name = "radCreateKey";
            this.radCreateKey.Size = new System.Drawing.Size(108, 17);
            this.radCreateKey.TabIndex = 3;
            this.radCreateKey.TabStop = true;
            this.radCreateKey.Text = "Create a new key";
            this.radCreateKey.UseVisualStyleBackColor = true;
            this.radCreateKey.CheckedChanged += new System.EventHandler(this.radCreateKey_CheckedChanged);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(261, 112);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(85, 17);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "radioButton3";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(261, 112);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(85, 17);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "radioButton2";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(261, 112);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(85, 17);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "radioButton1";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // btnEncode
            // 
            this.btnEncode.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEncode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEncode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEncode.Location = new System.Drawing.Point(65, 270);
            this.btnEncode.Name = "btnEncode";
            this.btnEncode.Size = new System.Drawing.Size(148, 30);
            this.btnEncode.TabIndex = 3;
            this.btnEncode.Text = "Encode";
            this.btnEncode.UseVisualStyleBackColor = true;
            this.btnEncode.Click += new System.EventHandler(this.btnEncode_Click);
            // 
            // btnDecode
            // 
            this.btnDecode.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDecode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDecode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDecode.Location = new System.Drawing.Point(65, 350);
            this.btnDecode.Name = "btnDecode";
            this.btnDecode.Size = new System.Drawing.Size(148, 30);
            this.btnDecode.TabIndex = 5;
            this.btnDecode.Text = "Decode";
            this.btnDecode.UseVisualStyleBackColor = true;
            this.btnDecode.Click += new System.EventHandler(this.btnDecode_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightSalmon;
            this.label1.Location = new System.Drawing.Point(328, 270);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "↓Write the text to encode/decode↓";
            // 
            // rtxtKey
            // 
            this.rtxtKey.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.rtxtKey.ForeColor = System.Drawing.Color.OrangeRed;
            this.rtxtKey.Location = new System.Drawing.Point(331, 79);
            this.rtxtKey.Name = "rtxtKey";
            this.rtxtKey.ReadOnly = true;
            this.rtxtKey.Size = new System.Drawing.Size(598, 85);
            this.rtxtKey.TabIndex = 7;
            this.rtxtKey.Text = "";
            // 
            // rtxtResult
            // 
            this.rtxtResult.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.rtxtResult.ForeColor = System.Drawing.Color.OrangeRed;
            this.rtxtResult.Location = new System.Drawing.Point(331, 295);
            this.rtxtResult.Name = "rtxtResult";
            this.rtxtResult.Size = new System.Drawing.Size(598, 85);
            this.rtxtResult.TabIndex = 8;
            this.rtxtResult.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.LightCoral;
            this.label2.Location = new System.Drawing.Point(328, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "↓Encoding key↓";
            // 
            // btnClear
            // 
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(836, 386);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(93, 34);
            this.btnClear.TabIndex = 10;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnKeySave
            // 
            this.btnKeySave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKeySave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKeySave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKeySave.Location = new System.Drawing.Point(782, 170);
            this.btnKeySave.Name = "btnKeySave";
            this.btnKeySave.Size = new System.Drawing.Size(147, 30);
            this.btnKeySave.TabIndex = 11;
            this.btnKeySave.Text = "Save Key";
            this.btnKeySave.UseVisualStyleBackColor = true;
            this.btnKeySave.Visible = false;
            this.btnKeySave.Click += new System.EventHandler(this.btnKeySave_Click);
            // 
            // btnGenerateKey
            // 
            this.btnGenerateKey.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnGenerateKey.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerateKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerateKey.Location = new System.Drawing.Point(331, 170);
            this.btnGenerateKey.Name = "btnGenerateKey";
            this.btnGenerateKey.Size = new System.Drawing.Size(147, 30);
            this.btnGenerateKey.TabIndex = 12;
            this.btnGenerateKey.Text = "Generate Key";
            this.btnGenerateKey.UseVisualStyleBackColor = false;
            this.btnGenerateKey.Visible = false;
            this.btnGenerateKey.Click += new System.EventHandler(this.btnGenerateKey_Click);
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(539, 17);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(0, 24);
            this.lblError.TabIndex = 13;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // frmEncoder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(976, 552);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.btnGenerateKey);
            this.Controls.Add(this.btnKeySave);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rtxtResult);
            this.Controls.Add(this.rtxtKey);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDecode);
            this.Controls.Add(this.btnEncode);
            this.Controls.Add(this.grpBoxChoices);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.lblEncoder);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmEncoder";
            this.Text = "frmEncoder";
            this.Load += new System.EventHandler(this.frmEncoder_Load);
            this.grpBoxChoices.ResumeLayout(false);
            this.grpBoxChoices.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEncoder;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.GroupBox grpBoxChoices;
        private System.Windows.Forms.RadioButton radSaveKey;
        private System.Windows.Forms.RadioButton radOwnKey;
        private System.Windows.Forms.RadioButton radCreateKey;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Button btnEncode;
        private System.Windows.Forms.Button btnDecode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox rtxtKey;
        private System.Windows.Forms.RichTextBox rtxtResult;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnKeySave;
        private System.Windows.Forms.Button btnGenerateKey;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}