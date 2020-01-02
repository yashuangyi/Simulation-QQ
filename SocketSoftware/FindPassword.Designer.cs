namespace SocketSoftware
{
    partial class FindPassword
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FindPassword));
            this.text_id = new CCWin.SkinControl.SkinWaterTextBox();
            this.text_phone = new CCWin.SkinControl.SkinWaterTextBox();
            this.text_password = new CCWin.SkinControl.SkinWaterTextBox();
            this.yep = new CCWin.SkinControl.SkinButton();
            this.label_id = new CCWin.SkinControl.SkinLabel();
            this.label_password = new CCWin.SkinControl.SkinLabel();
            this.label_phone = new CCWin.SkinControl.SkinLabel();
            this.exit = new CCWin.SkinControl.SkinButton();
            this.SuspendLayout();
            // 
            // text_id
            // 
            this.text_id.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.text_id.Location = new System.Drawing.Point(117, 60);
            this.text_id.Name = "text_id";
            this.text_id.Size = new System.Drawing.Size(166, 26);
            this.text_id.TabIndex = 0;
            this.text_id.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.text_id.WaterText = "请输入账号";
            // 
            // text_phone
            // 
            this.text_phone.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.text_phone.Location = new System.Drawing.Point(117, 109);
            this.text_phone.Name = "text_phone";
            this.text_phone.Size = new System.Drawing.Size(166, 26);
            this.text_phone.TabIndex = 1;
            this.text_phone.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.text_phone.WaterText = "请输入该账号的绑定手机号";
            // 
            // text_password
            // 
            this.text_password.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.text_password.Location = new System.Drawing.Point(117, 160);
            this.text_password.Name = "text_password";
            this.text_password.ReadOnly = true;
            this.text_password.Size = new System.Drawing.Size(166, 26);
            this.text_password.TabIndex = 2;
            this.text_password.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.text_password.WaterText = "点击查询按钮进行密码查询";
            // 
            // yep
            // 
            this.yep.BackColor = System.Drawing.Color.Transparent;
            this.yep.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.yep.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.yep.DownBack = null;
            this.yep.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.yep.Location = new System.Drawing.Point(51, 244);
            this.yep.MouseBack = null;
            this.yep.Name = "yep";
            this.yep.NormlBack = null;
            this.yep.Size = new System.Drawing.Size(96, 43);
            this.yep.TabIndex = 3;
            this.yep.Text = "查询";
            this.yep.UseVisualStyleBackColor = false;
            this.yep.Click += new System.EventHandler(this.yep_Click);
            // 
            // label_id
            // 
            this.label_id.AutoSize = true;
            this.label_id.BackColor = System.Drawing.Color.Transparent;
            this.label_id.BorderColor = System.Drawing.Color.White;
            this.label_id.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_id.Location = new System.Drawing.Point(69, 65);
            this.label_id.Name = "label_id";
            this.label_id.Size = new System.Drawing.Size(42, 21);
            this.label_id.TabIndex = 4;
            this.label_id.Text = "账号";
            // 
            // label_password
            // 
            this.label_password.AutoSize = true;
            this.label_password.BackColor = System.Drawing.Color.Transparent;
            this.label_password.BorderColor = System.Drawing.Color.White;
            this.label_password.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_password.Location = new System.Drawing.Point(5, 160);
            this.label_password.Name = "label_password";
            this.label_password.Size = new System.Drawing.Size(106, 21);
            this.label_password.TabIndex = 5;
            this.label_password.Text = "密码查询结果";
            // 
            // label_phone
            // 
            this.label_phone.AutoSize = true;
            this.label_phone.BackColor = System.Drawing.Color.Transparent;
            this.label_phone.BorderColor = System.Drawing.Color.White;
            this.label_phone.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_phone.Location = new System.Drawing.Point(21, 114);
            this.label_phone.Name = "label_phone";
            this.label_phone.Size = new System.Drawing.Size(90, 21);
            this.label_phone.TabIndex = 6;
            this.label_phone.Text = "绑定手机号";
            // 
            // exit
            // 
            this.exit.BackColor = System.Drawing.Color.Transparent;
            this.exit.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.exit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.exit.DownBack = null;
            this.exit.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.exit.Location = new System.Drawing.Point(187, 244);
            this.exit.MouseBack = null;
            this.exit.Name = "exit";
            this.exit.NormlBack = null;
            this.exit.Size = new System.Drawing.Size(96, 43);
            this.exit.TabIndex = 7;
            this.exit.Text = "退出";
            this.exit.UseVisualStyleBackColor = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // FindPassword
            // 
            this.AcceptButton = this.yep;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.exit;
            this.ClientSize = new System.Drawing.Size(343, 309);
            this.ControlBox = false;
            this.Controls.Add(this.exit);
            this.Controls.Add(this.label_phone);
            this.Controls.Add(this.label_password);
            this.Controls.Add(this.label_id);
            this.Controls.Add(this.yep);
            this.Controls.Add(this.text_password);
            this.Controls.Add(this.text_phone);
            this.Controls.Add(this.text_id);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FindPassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "找回密码";
            this.Load += new System.EventHandler(this.FindPassword_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CCWin.SkinControl.SkinWaterTextBox text_id;
        private CCWin.SkinControl.SkinWaterTextBox text_phone;
        private CCWin.SkinControl.SkinWaterTextBox text_password;
        private CCWin.SkinControl.SkinButton yep;
        private CCWin.SkinControl.SkinLabel label_id;
        private CCWin.SkinControl.SkinLabel label_password;
        private CCWin.SkinControl.SkinLabel label_phone;
        private CCWin.SkinControl.SkinButton exit;
    }
}