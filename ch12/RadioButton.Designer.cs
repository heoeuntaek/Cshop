namespace ch12
{
    partial class FrmRadio
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
            this.grpRadio = new System.Windows.Forms.GroupBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.lbSample = new System.Windows.Forms.Label();
            this.radB3 = new System.Windows.Forms.RadioButton();
            this.radB2 = new System.Windows.Forms.RadioButton();
            this.radB1 = new System.Windows.Forms.RadioButton();
            this.grpRadio.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpRadio
            // 
            this.grpRadio.Controls.Add(this.btnExit);
            this.grpRadio.Controls.Add(this.lbSample);
            this.grpRadio.Controls.Add(this.radB3);
            this.grpRadio.Controls.Add(this.radB2);
            this.grpRadio.Controls.Add(this.radB1);
            this.grpRadio.Location = new System.Drawing.Point(64, 66);
            this.grpRadio.Name = "grpRadio";
            this.grpRadio.Size = new System.Drawing.Size(225, 178);
            this.grpRadio.TabIndex = 0;
            this.grpRadio.TabStop = false;
            this.grpRadio.Text = "성별체크";
            this.grpRadio.Enter += new System.EventHandler(this.grpRadio_Enter);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(124, 129);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "확인";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbSample
            // 
            this.lbSample.AutoSize = true;
            this.lbSample.Location = new System.Drawing.Point(154, 29);
            this.lbSample.Name = "lbSample";
            this.lbSample.Size = new System.Drawing.Size(45, 15);
            this.lbSample.TabIndex = 1;
            this.lbSample.Text = "label1";
            // 
            // radB3
            // 
            this.radB3.AutoSize = true;
            this.radB3.Location = new System.Drawing.Point(24, 114);
            this.radB3.Name = "radB3";
            this.radB3.Size = new System.Drawing.Size(58, 19);
            this.radB3.TabIndex = 0;
            this.radB3.TabStop = true;
            this.radB3.Text = "중성";
            this.radB3.UseVisualStyleBackColor = true;
            this.radB3.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radB2
            // 
            this.radB2.AutoSize = true;
            this.radB2.Location = new System.Drawing.Point(24, 75);
            this.radB2.Name = "radB2";
            this.radB2.Size = new System.Drawing.Size(58, 19);
            this.radB2.TabIndex = 0;
            this.radB2.TabStop = true;
            this.radB2.Text = "남자";
            this.radB2.UseVisualStyleBackColor = true;
            this.radB2.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radB1
            // 
            this.radB1.AutoSize = true;
            this.radB1.Location = new System.Drawing.Point(24, 25);
            this.radB1.Name = "radB1";
            this.radB1.Size = new System.Drawing.Size(58, 19);
            this.radB1.TabIndex = 0;
            this.radB1.TabStop = true;
            this.radB1.Text = "여자";
            this.radB1.UseVisualStyleBackColor = true;
            this.radB1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // FrmRadio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 353);
            this.Controls.Add(this.grpRadio);
            this.Name = "FrmRadio";
            this.Text = "성별체크";
            this.Load += new System.EventHandler(this.FrmRadio_Load);
            this.grpRadio.ResumeLayout(false);
            this.grpRadio.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpRadio;
        private System.Windows.Forms.RadioButton radB1;
        private System.Windows.Forms.RadioButton radB3;
        private System.Windows.Forms.RadioButton radB2;
        private System.Windows.Forms.Label lbSample;
        private System.Windows.Forms.Button btnExit;
    }
}