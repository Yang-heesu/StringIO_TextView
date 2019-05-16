namespace StringIO_TextView
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnEdit = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.txtEdit = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnEdit
            // 
            this.btnEdit.Font = new System.Drawing.Font("Tahoma", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Location = new System.Drawing.Point(12, 49);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(270, 66);
            this.btnEdit.TabIndex = 1;
            this.btnEdit.Text = "입력";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Tahoma", 14F);
            this.lblResult.Location = new System.Drawing.Point(12, 130);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(57, 23);
            this.lblResult.TabIndex = 2;
            this.lblResult.Text = "결과 :";
            this.lblResult.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtEdit
            // 
            this.txtEdit.Location = new System.Drawing.Point(12, 12);
            this.txtEdit.Name = "txtEdit";
            this.txtEdit.Size = new System.Drawing.Size(270, 21);
            this.txtEdit.TabIndex = 3;
            this.txtEdit.TextChanged += new System.EventHandler(this.txtEdit_TextChanged);
            this.txtEdit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEdit_KeyPress);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 180);
            this.Controls.Add(this.txtEdit);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnEdit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "문자열 출력";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.TextBox txtEdit;
    }
}

