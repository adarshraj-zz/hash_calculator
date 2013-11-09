/*
 * Created by SharpDevelop.
 * User: Ads
 * Date: 5/17/2008
 * Time: 8:50 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace MD5_Calculator
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.txtString = new System.Windows.Forms.TextBox();
            this.txtMD5 = new System.Windows.Forms.TextBox();
            this.txtSHA1 = new System.Windows.Forms.TextBox();
            this.txtSHA512 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSHA256 = new System.Windows.Forms.TextBox();
            this.txtSHA384 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnString = new System.Windows.Forms.RadioButton();
            this.btnFile = new System.Windows.Forms.RadioButton();
            this.txtFileName = new System.Windows.Forms.TextBox();
            this.btnSelectFile = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chkUpper = new System.Windows.Forms.CheckBox();
            this.ofdOpenFile = new System.Windows.Forms.OpenFileDialog();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnCompareTool = new System.Windows.Forms.Button();
            this.btnAbout = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtString
            // 
            this.txtString.Location = new System.Drawing.Point(80, 41);
            this.txtString.Multiline = true;
            this.txtString.Name = "txtString";
            this.txtString.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtString.Size = new System.Drawing.Size(451, 32);
            this.txtString.TabIndex = 4;
            this.txtString.TextChanged += new System.EventHandler(this.TextBox1TextChanged);
            // 
            // txtMD5
            // 
            this.txtMD5.BackColor = System.Drawing.SystemColors.Window;
            this.txtMD5.Location = new System.Drawing.Point(80, 19);
            this.txtMD5.Name = "txtMD5";
            this.txtMD5.ReadOnly = true;
            this.txtMD5.Size = new System.Drawing.Size(451, 21);
            this.txtMD5.TabIndex = 6;
            this.txtMD5.TabStop = false;
            // 
            // txtSHA1
            // 
            this.txtSHA1.BackColor = System.Drawing.SystemColors.Window;
            this.txtSHA1.Location = new System.Drawing.Point(80, 46);
            this.txtSHA1.Name = "txtSHA1";
            this.txtSHA1.ReadOnly = true;
            this.txtSHA1.Size = new System.Drawing.Size(451, 21);
            this.txtSHA1.TabIndex = 7;
            this.txtSHA1.TabStop = false;
            // 
            // txtSHA512
            // 
            this.txtSHA512.BackColor = System.Drawing.SystemColors.Window;
            this.txtSHA512.Location = new System.Drawing.Point(80, 139);
            this.txtSHA512.Multiline = true;
            this.txtSHA512.Name = "txtSHA512";
            this.txtSHA512.ReadOnly = true;
            this.txtSHA512.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtSHA512.Size = new System.Drawing.Size(451, 32);
            this.txtSHA512.TabIndex = 10;
            this.txtSHA512.TabStop = false;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(16, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "MD5 :";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(16, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "SHA1 :";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(16, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "SHA512 :";
            // 
            // txtSHA256
            // 
            this.txtSHA256.BackColor = System.Drawing.SystemColors.Window;
            this.txtSHA256.Location = new System.Drawing.Point(80, 74);
            this.txtSHA256.Multiline = true;
            this.txtSHA256.Name = "txtSHA256";
            this.txtSHA256.ReadOnly = true;
            this.txtSHA256.Size = new System.Drawing.Size(451, 21);
            this.txtSHA256.TabIndex = 8;
            this.txtSHA256.TabStop = false;
            // 
            // txtSHA384
            // 
            this.txtSHA384.BackColor = System.Drawing.SystemColors.Window;
            this.txtSHA384.Location = new System.Drawing.Point(80, 101);
            this.txtSHA384.Multiline = true;
            this.txtSHA384.Name = "txtSHA384";
            this.txtSHA384.ReadOnly = true;
            this.txtSHA384.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtSHA384.Size = new System.Drawing.Size(451, 32);
            this.txtSHA384.TabIndex = 9;
            this.txtSHA384.TabStop = false;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(16, 108);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "SHA384 :";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(16, 77);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "SHA256 :";
            // 
            // btnString
            // 
            this.btnString.AutoSize = true;
            this.btnString.Location = new System.Drawing.Point(16, 44);
            this.btnString.Name = "btnString";
            this.btnString.Size = new System.Drawing.Size(60, 17);
            this.btnString.TabIndex = 1;
            this.btnString.TabStop = true;
            this.btnString.Text = "String :";
            this.btnString.UseVisualStyleBackColor = true;
            this.btnString.CheckedChanged += new System.EventHandler(this.btnString_CheckedChanged);
            // 
            // btnFile
            // 
            this.btnFile.AutoSize = true;
            this.btnFile.Location = new System.Drawing.Point(16, 16);
            this.btnFile.Name = "btnFile";
            this.btnFile.Size = new System.Drawing.Size(48, 17);
            this.btnFile.TabIndex = 0;
            this.btnFile.TabStop = true;
            this.btnFile.Text = "File :";
            this.btnFile.UseVisualStyleBackColor = true;
            this.btnFile.CheckedChanged += new System.EventHandler(this.btnFile_CheckedChanged);
            // 
            // txtFileName
            // 
            this.txtFileName.Location = new System.Drawing.Point(80, 15);
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.Size = new System.Drawing.Size(410, 21);
            this.txtFileName.TabIndex = 2;
            // 
            // btnSelectFile
            // 
            this.btnSelectFile.Location = new System.Drawing.Point(496, 16);
            this.btnSelectFile.Name = "btnSelectFile";
            this.btnSelectFile.Size = new System.Drawing.Size(35, 21);
            this.btnSelectFile.TabIndex = 3;
            this.btnSelectFile.Text = "...";
            this.btnSelectFile.UseVisualStyleBackColor = true;
            this.btnSelectFile.Click += new System.EventHandler(this.btnSelectFile_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSelectFile);
            this.groupBox1.Controls.Add(this.txtFileName);
            this.groupBox1.Controls.Add(this.txtString);
            this.groupBox1.Controls.Add(this.btnFile);
            this.groupBox1.Controls.Add(this.btnString);
            this.groupBox1.Location = new System.Drawing.Point(6, -1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(537, 80);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtSHA384);
            this.groupBox2.Controls.Add(this.txtSHA512);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtSHA256);
            this.groupBox2.Controls.Add(this.txtMD5);
            this.groupBox2.Controls.Add(this.txtSHA1);
            this.groupBox2.Location = new System.Drawing.Point(6, 79);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(537, 180);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            // 
            // chkUpper
            // 
            this.chkUpper.AutoSize = true;
            this.chkUpper.Location = new System.Drawing.Point(284, 268);
            this.chkUpper.Name = "chkUpper";
            this.chkUpper.Size = new System.Drawing.Size(79, 17);
            this.chkUpper.TabIndex = 5;
            this.chkUpper.Text = "UpperCase";
            this.chkUpper.UseVisualStyleBackColor = true;
            this.chkUpper.CheckedChanged += new System.EventHandler(this.chkUpper_CheckedChanged);
            // 
            // ofdOpenFile
            // 
            this.ofdOpenFile.Filter = "All Files|*.*";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(381, 266);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(93, 21);
            this.btnClear.TabIndex = 12;
            this.btnClear.Text = "Clear All";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnCompareTool
            // 
            this.btnCompareTool.Location = new System.Drawing.Point(6, 266);
            this.btnCompareTool.Name = "btnCompareTool";
            this.btnCompareTool.Size = new System.Drawing.Size(142, 20);
            this.btnCompareTool.TabIndex = 13;
            this.btnCompareTool.Text = "Hash Comparison Tool";
            this.btnCompareTool.UseVisualStyleBackColor = true;
            this.btnCompareTool.Click += new System.EventHandler(this.btnCompareTool_Click);
            // 
            // btnAbout
            // 
            this.btnAbout.Location = new System.Drawing.Point(480, 266);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(58, 21);
            this.btnAbout.TabIndex = 14;
            this.btnAbout.Text = "About";
            this.btnAbout.UseVisualStyleBackColor = true;
            this.btnAbout.Click += new System.EventHandler(this.BtnAboutClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Enabled = false;
            this.label1.Location = new System.Drawing.Point(173, 270);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "© WaxCodes";
            // 
            // MainForm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 290);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAbout);
            this.Controls.Add(this.btnCompareTool);
            this.Controls.Add(this.chkUpper);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hash Calculator 0.1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.MainForm_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.MainForm_DragEnter);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		private System.Windows.Forms.Button btnAbout;
		private System.Windows.Forms.Button btnCompareTool;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txtSHA384;
		private System.Windows.Forms.TextBox txtSHA256;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtSHA512;
		private System.Windows.Forms.TextBox txtSHA1;
		private System.Windows.Forms.TextBox txtMD5;
        private System.Windows.Forms.TextBox txtString;
        private System.Windows.Forms.RadioButton btnString;
        private System.Windows.Forms.RadioButton btnFile;
        private System.Windows.Forms.TextBox txtFileName;
        private System.Windows.Forms.Button btnSelectFile;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox chkUpper;
        private System.Windows.Forms.OpenFileDialog ofdOpenFile;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label label1;
	}
}
