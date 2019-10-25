namespace comment
{
	partial class frmComment
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
			System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("");
			this.lstComment = new System.Windows.Forms.ListView();
			this.btnCmtQuit = new System.Windows.Forms.Button();
			this.btnCmtDelete = new System.Windows.Forms.Button();
			this.btnCmtUpdate = new System.Windows.Forms.Button();
			this.btnCmtInsert = new System.Windows.Forms.Button();
			this.btnCmtSelect = new System.Windows.Forms.Button();
			this.txtCmtSearch = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.btnCmtSearch = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lstComment
			// 
			this.lstComment.HideSelection = false;
			this.lstComment.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
			this.lstComment.Location = new System.Drawing.Point(31, 53);
			this.lstComment.Name = "lstComment";
			this.lstComment.Size = new System.Drawing.Size(732, 443);
			this.lstComment.TabIndex = 16;
			this.lstComment.TabStop = false;
			this.lstComment.UseCompatibleStateImageBehavior = false;
			this.lstComment.SelectedIndexChanged += new System.EventHandler(this.lstComment_SelectedIndexChanged);
			// 
			// btnCmtQuit
			// 
			this.btnCmtQuit.Location = new System.Drawing.Point(688, 11);
			this.btnCmtQuit.Name = "btnCmtQuit";
			this.btnCmtQuit.Size = new System.Drawing.Size(75, 23);
			this.btnCmtQuit.TabIndex = 15;
			this.btnCmtQuit.Text = "종료";
			this.btnCmtQuit.UseVisualStyleBackColor = true;
			this.btnCmtQuit.Click += new System.EventHandler(this.btnCmtQuit_Click);
			// 
			// btnCmtDelete
			// 
			this.btnCmtDelete.Location = new System.Drawing.Point(605, 11);
			this.btnCmtDelete.Name = "btnCmtDelete";
			this.btnCmtDelete.Size = new System.Drawing.Size(75, 23);
			this.btnCmtDelete.TabIndex = 14;
			this.btnCmtDelete.Text = "삭제";
			this.btnCmtDelete.UseVisualStyleBackColor = true;
			this.btnCmtDelete.Click += new System.EventHandler(this.btnCmtDelete_Click);
			// 
			// btnCmtUpdate
			// 
			this.btnCmtUpdate.Location = new System.Drawing.Point(522, 11);
			this.btnCmtUpdate.Name = "btnCmtUpdate";
			this.btnCmtUpdate.Size = new System.Drawing.Size(75, 23);
			this.btnCmtUpdate.TabIndex = 13;
			this.btnCmtUpdate.Text = "수정";
			this.btnCmtUpdate.UseVisualStyleBackColor = true;
			this.btnCmtUpdate.Click += new System.EventHandler(this.btnCmtUpdate_Click);
			// 
			// btnCmtInsert
			// 
			this.btnCmtInsert.Location = new System.Drawing.Point(439, 11);
			this.btnCmtInsert.Name = "btnCmtInsert";
			this.btnCmtInsert.Size = new System.Drawing.Size(75, 23);
			this.btnCmtInsert.TabIndex = 12;
			this.btnCmtInsert.Text = "추가";
			this.btnCmtInsert.UseVisualStyleBackColor = true;
			this.btnCmtInsert.Click += new System.EventHandler(this.btnCmtInsert_Click);
			// 
			// btnCmtSelect
			// 
			this.btnCmtSelect.Location = new System.Drawing.Point(356, 11);
			this.btnCmtSelect.Name = "btnCmtSelect";
			this.btnCmtSelect.Size = new System.Drawing.Size(75, 23);
			this.btnCmtSelect.TabIndex = 11;
			this.btnCmtSelect.Text = "조회";
			this.btnCmtSelect.UseVisualStyleBackColor = true;
			this.btnCmtSelect.Click += new System.EventHandler(this.btnCmtSelect_Click);
			// 
			// txtCmtSearch
			// 
			this.txtCmtSearch.Location = new System.Drawing.Point(68, 12);
			this.txtCmtSearch.Name = "txtCmtSearch";
			this.txtCmtSearch.Size = new System.Drawing.Size(166, 21);
			this.txtCmtSearch.TabIndex = 10;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(29, 16);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(33, 12);
			this.label1.TabIndex = 9;
			this.label1.Text = "이름:";
			// 
			// btnCmtSearch
			// 
			this.btnCmtSearch.Location = new System.Drawing.Point(240, 10);
			this.btnCmtSearch.Name = "btnCmtSearch";
			this.btnCmtSearch.Size = new System.Drawing.Size(75, 23);
			this.btnCmtSearch.TabIndex = 17;
			this.btnCmtSearch.Text = "검색";
			this.btnCmtSearch.UseVisualStyleBackColor = true;
			this.btnCmtSearch.Click += new System.EventHandler(this.btnCmtSearch_Click);
			// 
			// frmComment
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(784, 511);
			this.Controls.Add(this.btnCmtSearch);
			this.Controls.Add(this.lstComment);
			this.Controls.Add(this.btnCmtQuit);
			this.Controls.Add(this.btnCmtDelete);
			this.Controls.Add(this.btnCmtUpdate);
			this.Controls.Add(this.btnCmtInsert);
			this.Controls.Add(this.btnCmtSelect);
			this.Controls.Add(this.txtCmtSearch);
			this.Controls.Add(this.label1);
			this.Name = "frmComment";
			this.Text = "댓글관리";
			this.Activated += new System.EventHandler(this.frmComment_Activated);
			this.Load += new System.EventHandler(this.Form5_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ListView lstComment;
		private System.Windows.Forms.Button btnCmtQuit;
		private System.Windows.Forms.Button btnCmtDelete;
		private System.Windows.Forms.Button btnCmtUpdate;
		private System.Windows.Forms.Button btnCmtInsert;
		private System.Windows.Forms.Button btnCmtSelect;
		private System.Windows.Forms.TextBox txtCmtSearch;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnCmtSearch;
	}
}