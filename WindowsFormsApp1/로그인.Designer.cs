namespace WindowsFormsApp1
{
    partial class 로그인
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
            this.btnAut = new System.Windows.Forms.Button();
            this.btnGuest = new System.Windows.Forms.Button();
            this.btnBoard = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lbResult = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.IbResult = new System.Windows.Forms.Label();
            this.IbName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAut
            // 
            this.btnAut.Enabled = false;
            this.btnAut.Location = new System.Drawing.Point(77, 208);
            this.btnAut.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAut.Name = "btnAut";
            this.btnAut.Size = new System.Drawing.Size(78, 27);
            this.btnAut.TabIndex = 15;
            this.btnAut.Text = "권한부여";
            this.btnAut.UseVisualStyleBackColor = true;
            this.btnAut.Visible = false;
            // 
            // btnGuest
            // 
            this.btnGuest.Location = new System.Drawing.Point(175, 210);
            this.btnGuest.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGuest.Name = "btnGuest";
            this.btnGuest.Size = new System.Drawing.Size(71, 23);
            this.btnGuest.TabIndex = 16;
            this.btnGuest.Text = "방명록";
            this.btnGuest.UseVisualStyleBackColor = true;
            this.btnGuest.Click += new System.EventHandler(this.btnGuest_Click);
            // 
            // btnBoard
            // 
            this.btnBoard.Location = new System.Drawing.Point(175, 161);
            this.btnBoard.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBoard.Name = "btnBoard";
            this.btnBoard.Size = new System.Drawing.Size(60, 29);
            this.btnBoard.TabIndex = 17;
            this.btnBoard.Text = "게시판";
            this.btnBoard.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            this.btnSearch.Enabled = false;
            this.btnSearch.Location = new System.Drawing.Point(77, 161);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(92, 29);
            this.btnSearch.TabIndex = 18;
            this.btnSearch.Text = "회원조회";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Visible = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lbResult
            // 
            this.lbResult.AutoSize = true;
            this.lbResult.Location = new System.Drawing.Point(31, 145);
            this.lbResult.Name = "lbResult";
            this.lbResult.Size = new System.Drawing.Size(29, 12);
            this.lbResult.TabIndex = 14;
            this.lbResult.Text = "결과";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(175, 113);
            this.btnClose.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(60, 28);
            this.btnClose.TabIndex = 13;
            this.btnClose.Text = "닫기";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(77, 113);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(78, 28);
            this.btnLogin.TabIndex = 12;
            this.btnLogin.Text = "로그인";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(115, 73);
            this.txtPass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '*';
            this.txtPass.Size = new System.Drawing.Size(106, 21);
            this.txtPass.TabIndex = 11;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(115, 32);
            this.txtId.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtId.MaxLength = 8;
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(106, 21);
            this.txtId.TabIndex = 10;
            // 
            // IbResult
            // 
            this.IbResult.AutoSize = true;
            this.IbResult.Location = new System.Drawing.Point(31, 81);
            this.IbResult.Name = "IbResult";
            this.IbResult.Size = new System.Drawing.Size(37, 12);
            this.IbResult.TabIndex = 9;
            this.IbResult.Text = "PASS";
            // 
            // IbName
            // 
            this.IbName.AutoSize = true;
            this.IbName.Location = new System.Drawing.Point(31, 34);
            this.IbName.Name = "IbName";
            this.IbName.Size = new System.Drawing.Size(16, 12);
            this.IbName.TabIndex = 8;
            this.IbName.Text = "ID";
            // 
            // 로그인
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 311);
            this.Controls.Add(this.btnAut);
            this.Controls.Add(this.btnGuest);
            this.Controls.Add(this.btnBoard);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.lbResult);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.IbResult);
            this.Controls.Add(this.IbName);
            this.Name = "로그인";
            this.Text = "로그인";
            this.Load += new System.EventHandler(this.로그인_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAut;
        private System.Windows.Forms.Button btnGuest;
        private System.Windows.Forms.Button btnBoard;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lbResult;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label IbResult;
        private System.Windows.Forms.Label IbName;
    }
}