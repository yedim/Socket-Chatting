﻿namespace Chatting
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
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_myPort = new System.Windows.Forms.TextBox();
            this.tb_myIP = new System.Windows.Forms.TextBox();
            this.btn_connect = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_otherPort = new System.Windows.Forms.TextBox();
            this.tb_otherIP = new System.Windows.Forms.TextBox();
            this.tb_myName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_send = new System.Windows.Forms.TextBox();
            this.btn_send = new System.Windows.Forms.Button();
            this.lb_chat = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tb_myPort);
            this.groupBox1.Controls.Add(this.tb_myIP);
            this.groupBox1.Location = new System.Drawing.Point(20, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(224, 86);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "내 정보";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "Port";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "IP";
            // 
            // tb_myPort
            // 
            this.tb_myPort.Location = new System.Drawing.Point(85, 50);
            this.tb_myPort.Name = "tb_myPort";
            this.tb_myPort.Size = new System.Drawing.Size(122, 21);
            this.tb_myPort.TabIndex = 4;
            // 
            // tb_myIP
            // 
            this.tb_myIP.Location = new System.Drawing.Point(85, 23);
            this.tb_myIP.Name = "tb_myIP";
            this.tb_myIP.Size = new System.Drawing.Size(122, 21);
            this.tb_myIP.TabIndex = 3;
            // 
            // btn_connect
            // 
            this.btn_connect.Location = new System.Drawing.Point(526, 28);
            this.btn_connect.Name = "btn_connect";
            this.btn_connect.Size = new System.Drawing.Size(75, 64);
            this.btn_connect.TabIndex = 0;
            this.btn_connect.Text = "연결하기";
            this.btn_connect.UseVisualStyleBackColor = true;
            this.btn_connect.Click += new System.EventHandler(this.btn_connect_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.tb_otherPort);
            this.groupBox2.Controls.Add(this.tb_otherIP);
            this.groupBox2.Location = new System.Drawing.Point(275, 15);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(224, 86);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "상대 정보";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "Port";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(16, 12);
            this.label4.TabIndex = 2;
            this.label4.Text = "IP";
            // 
            // tb_otherPort
            // 
            this.tb_otherPort.Location = new System.Drawing.Point(85, 50);
            this.tb_otherPort.Name = "tb_otherPort";
            this.tb_otherPort.Size = new System.Drawing.Size(122, 21);
            this.tb_otherPort.TabIndex = 4;
            // 
            // tb_otherIP
            // 
            this.tb_otherIP.Location = new System.Drawing.Point(85, 23);
            this.tb_otherIP.Name = "tb_otherIP";
            this.tb_otherIP.Size = new System.Drawing.Size(122, 21);
            this.tb_otherIP.TabIndex = 3;
            // 
            // tb_myName
            // 
            this.tb_myName.Location = new System.Drawing.Point(153, 119);
            this.tb_myName.Name = "tb_myName";
            this.tb_myName.Size = new System.Drawing.Size(122, 21);
            this.tb_myName.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 12);
            this.label5.TabIndex = 6;
            this.label5.Text = "내 이름(수정가능)";
            // 
            // tb_send
            // 
            this.tb_send.Location = new System.Drawing.Point(25, 455);
            this.tb_send.Name = "tb_send";
            this.tb_send.Size = new System.Drawing.Size(484, 21);
            this.tb_send.TabIndex = 7;
            // 
            // btn_send
            // 
            this.btn_send.Location = new System.Drawing.Point(527, 455);
            this.btn_send.Name = "btn_send";
            this.btn_send.Size = new System.Drawing.Size(75, 23);
            this.btn_send.TabIndex = 9;
            this.btn_send.Text = "보내기";
            this.btn_send.UseVisualStyleBackColor = true;
            this.btn_send.Click += new System.EventHandler(this.btn_send_Click);
            // 
            // lb_chat
            // 
            this.lb_chat.FormattingEnabled = true;
            this.lb_chat.ItemHeight = 12;
            this.lb_chat.Location = new System.Drawing.Point(25, 153);
            this.lb_chat.Name = "lb_chat";
            this.lb_chat.Size = new System.Drawing.Size(576, 280);
            this.lb_chat.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 533);
            this.Controls.Add(this.lb_chat);
            this.Controls.Add(this.btn_send);
            this.Controls.Add(this.tb_send);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tb_myName);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btn_connect);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "udp 소켓프로그래밍";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_myPort;
        private System.Windows.Forms.TextBox tb_myIP;
        private System.Windows.Forms.Button btn_connect;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_otherPort;
        private System.Windows.Forms.TextBox tb_otherIP;
        private System.Windows.Forms.TextBox tb_myName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_send;
        private System.Windows.Forms.Button btn_send;
        private System.Windows.Forms.ListBox lb_chat;
    }
}

