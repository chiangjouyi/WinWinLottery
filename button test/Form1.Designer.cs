namespace button_test
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn清除選號 = new System.Windows.Forms.Button();
            this.btn當期對獎 = new System.Windows.Forms.Button();
            this.btn獎號自動生成 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label
            // 
            this.label.BackColor = System.Drawing.Color.Transparent;
            this.label.Enabled = false;
            this.label.Font = new System.Drawing.Font("微軟正黑體", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label.ForeColor = System.Drawing.Color.Black;
            this.label.Location = new System.Drawing.Point(26, 9);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(684, 52);
            this.label.TabIndex = 2;
            this.label.Click += new System.EventHandler(this.label_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(80, 218);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(278, 37);
            this.label1.TabIndex = 4;
            this.label1.Text = "本期台彩開出獎號為";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Ivory;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label2.Location = new System.Drawing.Point(3, 414);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(880, 290);
            this.label2.TabIndex = 5;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // btn清除選號
            // 
            this.btn清除選號.BackColor = System.Drawing.Color.Gold;
            this.btn清除選號.Font = new System.Drawing.Font("微軟正黑體", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn清除選號.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btn清除選號.Location = new System.Drawing.Point(623, 620);
            this.btn清除選號.Name = "btn清除選號";
            this.btn清除選號.Size = new System.Drawing.Size(240, 54);
            this.btn清除選號.TabIndex = 8;
            this.btn清除選號.Text = "清  除  選  號";
            this.btn清除選號.UseVisualStyleBackColor = false;
            this.btn清除選號.Click += new System.EventHandler(this.btn清除選號_Click_1);
            // 
            // btn當期對獎
            // 
            this.btn當期對獎.BackColor = System.Drawing.Color.DarkRed;
            this.btn當期對獎.Font = new System.Drawing.Font("微軟正黑體", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn當期對獎.ForeColor = System.Drawing.Color.White;
            this.btn當期對獎.Location = new System.Drawing.Point(623, 409);
            this.btn當期對獎.Name = "btn當期對獎";
            this.btn當期對獎.Size = new System.Drawing.Size(240, 54);
            this.btn當期對獎.TabIndex = 7;
            this.btn當期對獎.Text = "當  期  對  獎";
            this.btn當期對獎.UseVisualStyleBackColor = false;
            this.btn當期對獎.Click += new System.EventHandler(this.btn當期對獎_Click_1);
            // 
            // btn獎號自動生成
            // 
            this.btn獎號自動生成.BackColor = System.Drawing.Color.MidnightBlue;
            this.btn獎號自動生成.Font = new System.Drawing.Font("微軟正黑體", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn獎號自動生成.ForeColor = System.Drawing.Color.White;
            this.btn獎號自動生成.Location = new System.Drawing.Point(623, 517);
            this.btn獎號自動生成.Name = "btn獎號自動生成";
            this.btn獎號自動生成.Size = new System.Drawing.Size(240, 54);
            this.btn獎號自動生成.TabIndex = 6;
            this.btn獎號自動生成.Text = "獎號自動生成";
            this.btn獎號自動生成.UseVisualStyleBackColor = false;
            this.btn獎號自動生成.Click += new System.EventHandler(this.btn獎號自動生成_Click_1);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Ivory;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.ForeColor = System.Drawing.Color.Firebrick;
            this.label3.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.label3.Location = new System.Drawing.Point(80, 255);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(783, 51);
            this.label3.TabIndex = 9;
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.ForeColor = System.Drawing.Color.Navy;
            this.label4.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label4.Location = new System.Drawing.Point(32, 745);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(206, 153);
            this.label4.TabIndex = 10;
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.ForeColor = System.Drawing.Color.DarkRed;
            this.label5.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label5.Location = new System.Drawing.Point(238, 745);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 35);
            this.label5.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label6.ForeColor = System.Drawing.Color.Navy;
            this.label6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label6.Location = new System.Drawing.Point(291, 780);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 35);
            this.label6.TabIndex = 12;
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::button_test.Properties.Resources.圖片24;
            this.pictureBox1.Location = new System.Drawing.Point(-35, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(909, 187);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // toolTip1
            // 
            this.toolTip1.Popup += new System.Windows.Forms.PopupEventHandler(this.toolTip1_Popup);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Green;
            this.button1.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(623, 726);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(240, 54);
            this.button1.TabIndex = 14;
            this.button1.Text = "自選號請直接點選號碼球";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightYellow;
            this.ClientSize = new System.Drawing.Size(863, 969);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn清除選號);
            this.Controls.Add(this.btn當期對獎);
            this.Controls.Add(this.btn獎號自動生成);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn清除選號;
        private System.Windows.Forms.Button btn當期對獎;
        private System.Windows.Forms.Button btn獎號自動生成;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button button1;
    }
}

