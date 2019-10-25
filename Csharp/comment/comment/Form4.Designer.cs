namespace comment
{
	partial class frmLogin
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
			this.txtLgnID = new System.Windows.Forms.TextBox();
			this.txtLgnPW = new System.Windows.Forms.TextBox();
			this.btnLgnOK = new System.Windows.Forms.Button();
			this.btnLgnCancel = new System.Windows.Forms.Button();
			this.panel1 = new System.Windows.Forms.Panel();
			this.panel2 = new System.Windows.Forms.Panel();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(15, 10);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(41, 12);
			this.label1.TabIndex = 0;
			this.label1.Text = "로그인";
			this.label1.Click += new System.EventHandler(this.label1_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(16, 16);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(45, 12);
			this.label2.TabIndex = 0;
			this.label2.Text = "아이디:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(16, 50);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(57, 12);
			this.label3.TabIndex = 1;
			this.label3.Text = "비밀번호:";
			// 
			// txtLgnID
			// 
			this.txtLgnID.Location = new System.Drawing.Point(86, 13);
			this.txtLgnID.Name = "txtLgnID";
			this.txtLgnID.Size = new System.Drawing.Size(153, 21);
			this.txtLgnID.TabIndex = 1;
			this.txtLgnID.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmLogin_KeyDown);
			// 
			// txtLgnPW
			// 
			this.txtLgnPW.Location = new System.Drawing.Point(86, 47);
			this.txtLgnPW.Name = "txtLgnPW";
			this.txtLgnPW.PasswordChar = '*';
			this.txtLgnPW.Size = new System.Drawing.Size(153, 21);
			this.txtLgnPW.TabIndex = 2;
			this.txtLgnPW.TextChanged += new System.EventHandler(this.txtLgnPW_TextChanged);
			this.txtLgnPW.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmLogin_KeyDown);
			// 
			// btnLgnOK
			// 
			this.btnLgnOK.Location = new System.Drawing.Point(111, 140);
			this.btnLgnOK.Name = "btnLgnOK";
			this.btnLgnOK.Size = new System.Drawing.Size(75, 23);
			this.btnLgnOK.TabIndex = 3;
			this.btnLgnOK.Text = "확인";
			this.btnLgnOK.UseVisualStyleBackColor = true;
			this.btnLgnOK.Click += new System.EventHandler(this.btnLgnOK_Click);
			// 
			// btnLgnCancel
			// 
			this.btnLgnCancel.Location = new System.Drawing.Point(192, 140);
			this.btnLgnCancel.Name = "btnLgnCancel";
			this.btnLgnCancel.Size = new System.Drawing.Size(75, 23);
			this.btnLgnCancel.TabIndex = 4;
			this.btnLgnCancel.Text = "취소";
			this.btnLgnCancel.UseVisualStyleBackColor = true;
			this.btnLgnCancel.Click += new System.EventHandler(this.btnLgnCancel_Click);
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
			this.panel1.Controls.Add(this.label1);
			this.panel1.Location = new System.Drawing.Point(12, 12);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(255, 28);
			this.panel1.TabIndex = 4;
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.SystemColors.ControlDark;
			this.panel2.Controls.Add(this.txtLgnPW);
			this.panel2.Controls.Add(this.txtLgnID);
			this.panel2.Controls.Add(this.label2);
			this.panel2.Controls.Add(this.label3);
			this.panel2.Location = new System.Drawing.Point(12, 46);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(255, 85);
			this.panel2.TabIndex = 5;
			// 
			// frmLogin
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ControlLight;
			this.ClientSize = new System.Drawing.Size(279, 171);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.btnLgnCancel);
			this.Controls.Add(this.btnLgnOK);
			this.Name = "frmLogin";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "로그인";
			this.Load += new System.EventHandler(this.frmLogin_Load);
			this.Shown += new System.EventHandler(this.frmLogin_Shown);
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmLogin_KeyDown);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtLgnPW;
		private System.Windows.Forms.TextBox txtLgnID;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button btnLgnOK;
		private System.Windows.Forms.Button btnLgnCancel;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel2;
	}
}