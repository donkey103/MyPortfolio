namespace comment
{
	partial class frmUpdate
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
			this.btnUpdateSave = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.chkUpdateMarried = new System.Windows.Forms.CheckBox();
			this.label2 = new System.Windows.Forms.Label();
			this.rtxtUpdateComment = new System.Windows.Forms.RichTextBox();
			this.txtUpdatePassword = new System.Windows.Forms.TextBox();
			this.txtUpdateName = new System.Windows.Forms.TextBox();
			this.txtUpdateAge = new System.Windows.Forms.TextBox();
			this.txtUpdateID = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.btnUpdateDelete = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnUpdateSave
			// 
			this.btnUpdateSave.Location = new System.Drawing.Point(145, 368);
			this.btnUpdateSave.Name = "btnUpdateSave";
			this.btnUpdateSave.Size = new System.Drawing.Size(75, 30);
			this.btnUpdateSave.TabIndex = 7;
			this.btnUpdateSave.Text = "저장";
			this.btnUpdateSave.UseVisualStyleBackColor = true;
			this.btnUpdateSave.Click += new System.EventHandler(this.btnUpdateSave_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
			this.groupBox1.Controls.Add(this.chkUpdateMarried);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.rtxtUpdateComment);
			this.groupBox1.Controls.Add(this.txtUpdatePassword);
			this.groupBox1.Controls.Add(this.txtUpdateName);
			this.groupBox1.Controls.Add(this.txtUpdateAge);
			this.groupBox1.Controls.Add(this.txtUpdateID);
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Location = new System.Drawing.Point(13, 8);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(288, 354);
			this.groupBox1.TabIndex = 14;
			this.groupBox1.TabStop = false;
			// 
			// chkUpdateMarried
			// 
			this.chkUpdateMarried.AutoSize = true;
			this.chkUpdateMarried.Location = new System.Drawing.Point(86, 217);
			this.chkUpdateMarried.Name = "chkUpdateMarried";
			this.chkUpdateMarried.Size = new System.Drawing.Size(76, 16);
			this.chkUpdateMarried.TabIndex = 5;
			this.chkUpdateMarried.Text = "결혼 여부";
			this.chkUpdateMarried.UseVisualStyleBackColor = true;
			this.chkUpdateMarried.CheckedChanged += new System.EventHandler(this.chkUpdateMarried_CheckedChanged);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(15, 83);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(57, 12);
			this.label2.TabIndex = 1;
			this.label2.Text = "비밀번호:";
			// 
			// rtxtUpdateComment
			// 
			this.rtxtUpdateComment.Location = new System.Drawing.Point(86, 252);
			this.rtxtUpdateComment.Name = "rtxtUpdateComment";
			this.rtxtUpdateComment.Size = new System.Drawing.Size(180, 89);
			this.rtxtUpdateComment.TabIndex = 6;
			this.rtxtUpdateComment.Text = "";
			// 
			// txtUpdatePassword
			// 
			this.txtUpdatePassword.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.txtUpdatePassword.Location = new System.Drawing.Point(86, 76);
			this.txtUpdatePassword.Name = "txtUpdatePassword";
			this.txtUpdatePassword.PasswordChar = '*';
			this.txtUpdatePassword.Size = new System.Drawing.Size(180, 26);
			this.txtUpdatePassword.TabIndex = 2;
			// 
			// txtUpdateName
			// 
			this.txtUpdateName.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.txtUpdateName.Location = new System.Drawing.Point(86, 123);
			this.txtUpdateName.Name = "txtUpdateName";
			this.txtUpdateName.Size = new System.Drawing.Size(180, 26);
			this.txtUpdateName.TabIndex = 3;
			// 
			// txtUpdateAge
			// 
			this.txtUpdateAge.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.txtUpdateAge.Location = new System.Drawing.Point(86, 164);
			this.txtUpdateAge.Name = "txtUpdateAge";
			this.txtUpdateAge.Size = new System.Drawing.Size(180, 26);
			this.txtUpdateAge.TabIndex = 4;
			// 
			// txtUpdateID
			// 
			this.txtUpdateID.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.txtUpdateID.Location = new System.Drawing.Point(86, 35);
			this.txtUpdateID.Name = "txtUpdateID";
			this.txtUpdateID.Size = new System.Drawing.Size(180, 26);
			this.txtUpdateID.TabIndex = 1;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(39, 255);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(33, 12);
			this.label6.TabIndex = 5;
			this.label6.Text = "비고:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(39, 171);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(33, 12);
			this.label4.TabIndex = 3;
			this.label4.Text = "나이:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(39, 130);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(33, 12);
			this.label3.TabIndex = 2;
			this.label3.Text = "이름:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(27, 42);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(45, 12);
			this.label1.TabIndex = 0;
			this.label1.Text = "아이디:";
			// 
			// btnUpdateDelete
			// 
			this.btnUpdateDelete.Location = new System.Drawing.Point(226, 368);
			this.btnUpdateDelete.Name = "btnUpdateDelete";
			this.btnUpdateDelete.Size = new System.Drawing.Size(75, 30);
			this.btnUpdateDelete.TabIndex = 8;
			this.btnUpdateDelete.Text = "삭제";
			this.btnUpdateDelete.UseVisualStyleBackColor = true;
			this.btnUpdateDelete.Click += new System.EventHandler(this.btnUpdateDelete_Click);
			// 
			// frmUpdate
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(314, 406);
			this.Controls.Add(this.btnUpdateDelete);
			this.Controls.Add(this.btnUpdateSave);
			this.Controls.Add(this.groupBox1);
			this.Name = "frmUpdate";
			this.Text = "수정메뉴";
			this.Load += new System.EventHandler(this.frmUpdate_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btnUpdateSave;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.CheckBox chkUpdateMarried;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.RichTextBox rtxtUpdateComment;
		private System.Windows.Forms.TextBox txtUpdatePassword;
		private System.Windows.Forms.TextBox txtUpdateName;
		private System.Windows.Forms.TextBox txtUpdateAge;
		private System.Windows.Forms.TextBox txtUpdateID;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnUpdateDelete;
	}
}