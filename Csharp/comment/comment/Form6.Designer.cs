namespace comment
{
	partial class frmAddCmt
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
			this.panel1 = new System.Windows.Forms.Panel();
			this.txtAddCmtComment = new System.Windows.Forms.TextBox();
			this.txtAddCmtID = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.btnAddCmtSave = new System.Windows.Forms.Button();
			this.btnAddCmtCancel = new System.Windows.Forms.Button();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
			this.panel1.Controls.Add(this.txtAddCmtComment);
			this.panel1.Controls.Add(this.txtAddCmtID);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Location = new System.Drawing.Point(4, 6);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(309, 82);
			this.panel1.TabIndex = 0;
			// 
			// txtAddCmtComment
			// 
			this.txtAddCmtComment.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.txtAddCmtComment.Location = new System.Drawing.Point(59, 44);
			this.txtAddCmtComment.Name = "txtAddCmtComment";
			this.txtAddCmtComment.Size = new System.Drawing.Size(244, 22);
			this.txtAddCmtComment.TabIndex = 5;
			// 
			// txtAddCmtID
			// 
			this.txtAddCmtID.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.txtAddCmtID.Location = new System.Drawing.Point(59, 16);
			this.txtAddCmtID.Name = "txtAddCmtID";
			this.txtAddCmtID.Size = new System.Drawing.Size(100, 22);
			this.txtAddCmtID.TabIndex = 3;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(20, 48);
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
			// btnAddCmtSave
			// 
			this.btnAddCmtSave.Location = new System.Drawing.Point(154, 94);
			this.btnAddCmtSave.Name = "btnAddCmtSave";
			this.btnAddCmtSave.Size = new System.Drawing.Size(75, 23);
			this.btnAddCmtSave.TabIndex = 1;
			this.btnAddCmtSave.Text = "저장";
			this.btnAddCmtSave.UseVisualStyleBackColor = true;
			this.btnAddCmtSave.Click += new System.EventHandler(this.btnAddCmtSave_Click);
			// 
			// btnAddCmtCancel
			// 
			this.btnAddCmtCancel.Location = new System.Drawing.Point(238, 94);
			this.btnAddCmtCancel.Name = "btnAddCmtCancel";
			this.btnAddCmtCancel.Size = new System.Drawing.Size(75, 23);
			this.btnAddCmtCancel.TabIndex = 2;
			this.btnAddCmtCancel.Text = "취소";
			this.btnAddCmtCancel.UseVisualStyleBackColor = true;
			// 
			// frmAddCmt
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(320, 124);
			this.Controls.Add(this.btnAddCmtCancel);
			this.Controls.Add(this.btnAddCmtSave);
			this.Controls.Add(this.panel1);
			this.Name = "frmAddCmt";
			this.Text = "댓글추가";
			this.Load += new System.EventHandler(this.Form6_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.TextBox txtAddCmtComment;
		private System.Windows.Forms.TextBox txtAddCmtID;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnAddCmtSave;
		private System.Windows.Forms.Button btnAddCmtCancel;
	}
}