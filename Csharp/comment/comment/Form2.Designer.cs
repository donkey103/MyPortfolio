namespace comment
{
	partial class frmInsert
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
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.txtAddID = new System.Windows.Forms.TextBox();
			this.txtAddAge = new System.Windows.Forms.TextBox();
			this.txtAddName = new System.Windows.Forms.TextBox();
			this.txtAddPassword = new System.Windows.Forms.TextBox();
			this.rtxtAddComment = new System.Windows.Forms.RichTextBox();
			this.chkAddMarried = new System.Windows.Forms.CheckBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.btnAddSave = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(27, 42);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(45, 12);
			this.label1.TabIndex = 0;
			this.label1.Text = "아이디:";
			this.label1.Click += new System.EventHandler(this.label1_Click);
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
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(39, 130);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(33, 12);
			this.label3.TabIndex = 2;
			this.label3.Text = "이름:";
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
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(39, 255);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(33, 12);
			this.label6.TabIndex = 5;
			this.label6.Text = "비고:";
			// 
			// txtAddID
			// 
			this.txtAddID.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.txtAddID.Location = new System.Drawing.Point(86, 35);
			this.txtAddID.Name = "txtAddID";
			this.txtAddID.Size = new System.Drawing.Size(180, 26);
			this.txtAddID.TabIndex = 1;
			// 
			// txtAddAge
			// 
			this.txtAddAge.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.txtAddAge.Location = new System.Drawing.Point(86, 162);
			this.txtAddAge.Name = "txtAddAge";
			this.txtAddAge.Size = new System.Drawing.Size(180, 26);
			this.txtAddAge.TabIndex = 4;
			// 
			// txtAddName
			// 
			this.txtAddName.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.txtAddName.Location = new System.Drawing.Point(86, 116);
			this.txtAddName.Name = "txtAddName";
			this.txtAddName.Size = new System.Drawing.Size(180, 26);
			this.txtAddName.TabIndex = 3;
			// 
			// txtAddPassword
			// 
			this.txtAddPassword.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.txtAddPassword.Location = new System.Drawing.Point(86, 74);
			this.txtAddPassword.Name = "txtAddPassword";
			this.txtAddPassword.PasswordChar = '*';
			this.txtAddPassword.Size = new System.Drawing.Size(180, 26);
			this.txtAddPassword.TabIndex = 2;
			// 
			// rtxtAddComment
			// 
			this.rtxtAddComment.Location = new System.Drawing.Point(86, 252);
			this.rtxtAddComment.Name = "rtxtAddComment";
			this.rtxtAddComment.Size = new System.Drawing.Size(180, 89);
			this.rtxtAddComment.TabIndex = 6;
			this.rtxtAddComment.Text = "";
			// 
			// chkAddMarried
			// 
			this.chkAddMarried.AutoSize = true;
			this.chkAddMarried.Location = new System.Drawing.Point(86, 217);
			this.chkAddMarried.Name = "chkAddMarried";
			this.chkAddMarried.Size = new System.Drawing.Size(76, 16);
			this.chkAddMarried.TabIndex = 5;
			this.chkAddMarried.Text = "결혼 여부";
			this.chkAddMarried.UseVisualStyleBackColor = true;
			// 
			// groupBox1
			// 
			this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
			this.groupBox1.Controls.Add(this.chkAddMarried);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.rtxtAddComment);
			this.groupBox1.Controls.Add(this.txtAddPassword);
			this.groupBox1.Controls.Add(this.txtAddName);
			this.groupBox1.Controls.Add(this.txtAddAge);
			this.groupBox1.Controls.Add(this.txtAddID);
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Location = new System.Drawing.Point(9, 10);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(288, 354);
			this.groupBox1.TabIndex = 12;
			this.groupBox1.TabStop = false;
			// 
			// btnAddSave
			// 
			this.btnAddSave.Location = new System.Drawing.Point(222, 370);
			this.btnAddSave.Name = "btnAddSave";
			this.btnAddSave.Size = new System.Drawing.Size(75, 30);
			this.btnAddSave.TabIndex = 10;
			this.btnAddSave.Text = "저장";
			this.btnAddSave.UseVisualStyleBackColor = true;
			this.btnAddSave.Click += new System.EventHandler(this.btnAddSave_Click);
			// 
			// frmInsert
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.ClientSize = new System.Drawing.Size(307, 406);
			this.Controls.Add(this.btnAddSave);
			this.Controls.Add(this.groupBox1);
			this.Name = "frmInsert";
			this.Text = "회원정보추가";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox txtAddID;
		private System.Windows.Forms.TextBox txtAddAge;
		private System.Windows.Forms.TextBox txtAddName;
		private System.Windows.Forms.TextBox txtAddPassword;
		private System.Windows.Forms.RichTextBox rtxtAddComment;
		private System.Windows.Forms.CheckBox chkAddMarried;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button btnAddSave;
	}
}