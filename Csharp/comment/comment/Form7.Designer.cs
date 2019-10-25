namespace comment
{
	partial class frmChangeComment
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
			this.btnAddCmtCancel = new System.Windows.Forms.Button();
			this.btnAddCmtSave = new System.Windows.Forms.Button();
			this.panel1 = new System.Windows.Forms.Panel();
			this.txtChangeCmtComment = new System.Windows.Forms.TextBox();
			this.txtChangeCmtID = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.txtChangeCmtName = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnAddCmtCancel
			// 
			this.btnAddCmtCancel.Location = new System.Drawing.Point(246, 128);
			this.btnAddCmtCancel.Name = "btnAddCmtCancel";
			this.btnAddCmtCancel.Size = new System.Drawing.Size(75, 23);
			this.btnAddCmtCancel.TabIndex = 5;
			this.btnAddCmtCancel.Text = "취소";
			this.btnAddCmtCancel.UseVisualStyleBackColor = true;
			this.btnAddCmtCancel.Click += new System.EventHandler(this.btnAddCmtCancel_Click);
			// 
			// btnAddCmtSave
			// 
			this.btnAddCmtSave.Location = new System.Drawing.Point(162, 128);
			this.btnAddCmtSave.Name = "btnAddCmtSave";
			this.btnAddCmtSave.Size = new System.Drawing.Size(75, 23);
			this.btnAddCmtSave.TabIndex = 4;
			this.btnAddCmtSave.Text = "저장";
			this.btnAddCmtSave.UseVisualStyleBackColor = true;
			this.btnAddCmtSave.Click += new System.EventHandler(this.btnAddCmtSave_Click);
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
			this.panel1.Controls.Add(this.txtChangeCmtName);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.txtChangeCmtComment);
			this.panel1.Controls.Add(this.txtChangeCmtID);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Location = new System.Drawing.Point(12, 12);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(309, 110);
			this.panel1.TabIndex = 3;
			// 
			// txtChangeCmtComment
			// 
			this.txtChangeCmtComment.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.txtChangeCmtComment.Location = new System.Drawing.Point(59, 71);
			this.txtChangeCmtComment.Name = "txtChangeCmtComment";
			this.txtChangeCmtComment.Size = new System.Drawing.Size(244, 22);
			this.txtChangeCmtComment.TabIndex = 5;
			// 
			// txtChangeCmtID
			// 
			this.txtChangeCmtID.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.txtChangeCmtID.Location = new System.Drawing.Point(59, 16);
			this.txtChangeCmtID.Name = "txtChangeCmtID";
			this.txtChangeCmtID.Size = new System.Drawing.Size(100, 22);
			this.txtChangeCmtID.TabIndex = 3;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(20, 75);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(33, 12);
			this.label2.TabIndex = 1;
			this.label2.Text = "댓글:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(8, 20);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(45, 12);
			this.label1.TabIndex = 0;
			this.label1.Text = "아이디:";
			// 
			// txtChangeCmtName
			// 
			this.txtChangeCmtName.Enabled = false;
			this.txtChangeCmtName.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.txtChangeCmtName.Location = new System.Drawing.Point(59, 43);
			this.txtChangeCmtName.Name = "txtChangeCmtName";
			this.txtChangeCmtName.Size = new System.Drawing.Size(100, 22);
			this.txtChangeCmtName.TabIndex = 7;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(20, 47);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(33, 12);
			this.label3.TabIndex = 6;
			this.label3.Text = "이름:";
			// 
			// frmChangeComment
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(333, 163);
			this.Controls.Add(this.btnAddCmtCancel);
			this.Controls.Add(this.btnAddCmtSave);
			this.Controls.Add(this.panel1);
			this.Name = "frmChangeComment";
			this.Text = "Form7";
			this.Load += new System.EventHandler(this.Form7_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btnAddCmtCancel;
		private System.Windows.Forms.Button btnAddCmtSave;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.TextBox txtChangeCmtName;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtChangeCmtComment;
		private System.Windows.Forms.TextBox txtChangeCmtID;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
	}
}