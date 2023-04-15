namespace cnn_project
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbl_recommendedTime = new System.Windows.Forms.Label();
            this.tbx_medi = new System.Windows.Forms.TextBox();
            this.cmb_patient = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbx_timer = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_go = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("경기천년제목B Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(69, 169);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "환자명";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("경기천년제목B Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(69, 225);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 39);
            this.label2.TabIndex = 2;
            this.label2.Text = "마취제 용량\r\n(숫자 입력요망)";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("경기천년제목B Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(69, 293);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "권장시간";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("경기천년제목B Bold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.Location = new System.Drawing.Point(357, 233);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "mg";
            // 
            // lbl_recommendedTime
            // 
            this.lbl_recommendedTime.BackColor = System.Drawing.Color.White;
            this.lbl_recommendedTime.Font = new System.Drawing.Font("경기천년제목B Bold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl_recommendedTime.Location = new System.Drawing.Point(218, 293);
            this.lbl_recommendedTime.Name = "lbl_recommendedTime";
            this.lbl_recommendedTime.Size = new System.Drawing.Size(121, 16);
            this.lbl_recommendedTime.TabIndex = 9;
            this.lbl_recommendedTime.Text = "miniute";
            this.lbl_recommendedTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbx_medi
            // 
            this.tbx_medi.BackColor = System.Drawing.SystemColors.Window;
            this.tbx_medi.Location = new System.Drawing.Point(220, 225);
            this.tbx_medi.Name = "tbx_medi";
            this.tbx_medi.Size = new System.Drawing.Size(121, 21);
            this.tbx_medi.TabIndex = 12;
            this.tbx_medi.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbx_medi.TextChanged += new System.EventHandler(this.tbx_medi_TextChanged);
            this.tbx_medi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbx_medi_KeyPress);
            // 
            // cmb_patient
            // 
            this.cmb_patient.FormattingEnabled = true;
            this.cmb_patient.Location = new System.Drawing.Point(218, 166);
            this.cmb_patient.Name = "cmb_patient";
            this.cmb_patient.Size = new System.Drawing.Size(121, 20);
            this.cmb_patient.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("경기천년제목B Bold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(182, 105);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(141, 34);
            this.label5.TabIndex = 16;
            this.label5.Text = "졸음경보기";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("경기천년제목B Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(69, 347);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 16);
            this.label4.TabIndex = 17;
            this.label4.Text = "타이머";
            // 
            // tbx_timer
            // 
            this.tbx_timer.Location = new System.Drawing.Point(218, 347);
            this.tbx_timer.Name = "tbx_timer";
            this.tbx_timer.Size = new System.Drawing.Size(121, 21);
            this.tbx_timer.TabIndex = 19;
            this.tbx_timer.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbx_timer.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbx_timer_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("경기천년제목B Bold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label7.Location = new System.Drawing.Point(357, 296);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(18, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "분";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("경기천년제목B Bold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label8.Location = new System.Drawing.Point(357, 350);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(18, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "분";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btn_go
            // 
            this.btn_go.Animated = true;
            this.btn_go.AutoRoundedCorners = true;
            this.btn_go.BackColor = System.Drawing.Color.Transparent;
            this.btn_go.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_go.BorderRadius = 16;
            this.btn_go.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_go.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_go.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_go.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_go.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_go.ForeColor = System.Drawing.Color.White;
            this.btn_go.HoverState.BorderColor = System.Drawing.Color.Blue;
            this.btn_go.HoverState.CustomBorderColor = System.Drawing.Color.Blue;
            this.btn_go.HoverState.FillColor = System.Drawing.Color.Blue;
            this.btn_go.Location = new System.Drawing.Point(209, 404);
            this.btn_go.Name = "btn_go";
            this.btn_go.Size = new System.Drawing.Size(72, 35);
            this.btn_go.TabIndex = 22;
            this.btn_go.Text = "실행";
            this.btn_go.Click += new System.EventHandler(this.btn_go_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.BackgroundImage = global::cnn_project.Properties.Resources._2622422_removebg_preview;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(490, 600);
            this.Controls.Add(this.btn_go);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbx_timer);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmb_patient);
            this.Controls.Add(this.tbx_medi);
            this.Controls.Add(this.lbl_recommendedTime);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbl_recommendedTime;
        private System.Windows.Forms.TextBox tbx_medi;
        private System.Windows.Forms.ComboBox cmb_patient;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbx_timer;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private Guna.UI2.WinForms.Guna2Button btn_go;
    }
}

