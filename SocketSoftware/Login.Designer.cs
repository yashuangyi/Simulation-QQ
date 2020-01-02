namespace SocketSoftware
{
    partial class Login
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.loginCypher = new CCWin.SkinControl.SkinAlphaWaterTextBox();
            this.loginID = new CCWin.SkinControl.SkinAlphaWaterTextBox();
            this.loginSignIn = new CCWin.SkinControl.SkinButton();
            this.loginRegiste = new CCWin.SkinControl.SkinLabel();
            this.loginFindCypher = new CCWin.SkinControl.SkinLabel();
            this.loginQQ = new CCWin.SkinControl.SkinPictureBox();
            this.loginBase = new CCWin.SkinControl.SkinPictureBox();
            this.loginTop = new CCWin.SkinControl.SkinPictureBox();
            this.server = new CCWin.SkinControl.SkinCheckBox();
            this.client = new CCWin.SkinControl.SkinCheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.loginQQ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginBase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginTop)).BeginInit();
            this.SuspendLayout();
            // 
            // loginCypher
            // 
            this.loginCypher.BackAlpha = 10;
            this.loginCypher.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.loginCypher.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.loginCypher.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.loginCypher.Location = new System.Drawing.Point(132, 263);
            this.loginCypher.Name = "loginCypher";
            this.loginCypher.ShortcutsEnabled = false;
            this.loginCypher.Size = new System.Drawing.Size(165, 22);
            this.loginCypher.TabIndex = 2;
            this.loginCypher.TabStop = false;
            this.loginCypher.UseSystemPasswordChar = true;
            this.loginCypher.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.loginCypher.WaterFont = new System.Drawing.Font("微软雅黑", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.loginCypher.WaterText = "密码";
            // 
            // loginID
            // 
            this.loginID.BackAlpha = 10;
            this.loginID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.loginID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.loginID.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.loginID.Location = new System.Drawing.Point(132, 218);
            this.loginID.Name = "loginID";
            this.loginID.Size = new System.Drawing.Size(165, 22);
            this.loginID.TabIndex = 1;
            this.loginID.TabStop = false;
            this.loginID.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.loginID.WaterFont = new System.Drawing.Font("微软雅黑", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.loginID.WaterText = "账号";
            // 
            // loginSignIn
            // 
            this.loginSignIn.BackColor = System.Drawing.Color.Black;
            this.loginSignIn.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.loginSignIn.DownBack = null;
            this.loginSignIn.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.loginSignIn.ForeColor = System.Drawing.Color.Black;
            this.loginSignIn.Location = new System.Drawing.Point(167, 308);
            this.loginSignIn.MouseBack = null;
            this.loginSignIn.Name = "loginSignIn";
            this.loginSignIn.NormlBack = null;
            this.loginSignIn.Size = new System.Drawing.Size(105, 34);
            this.loginSignIn.TabIndex = 6;
            this.loginSignIn.Text = "登录";
            this.loginSignIn.UseVisualStyleBackColor = false;
            this.loginSignIn.Click += new System.EventHandler(this.loginSignIn_Click);
            // 
            // loginRegiste
            // 
            this.loginRegiste.AutoSize = true;
            this.loginRegiste.BackColor = System.Drawing.Color.LightBlue;
            this.loginRegiste.BorderColor = System.Drawing.Color.White;
            this.loginRegiste.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loginRegiste.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.loginRegiste.Location = new System.Drawing.Point(303, 224);
            this.loginRegiste.Name = "loginRegiste";
            this.loginRegiste.Size = new System.Drawing.Size(56, 17);
            this.loginRegiste.TabIndex = 7;
            this.loginRegiste.Text = "注册账号";
            this.loginRegiste.Click += new System.EventHandler(this.loginRegiste_Click);
            // 
            // loginFindCypher
            // 
            this.loginFindCypher.AutoSize = true;
            this.loginFindCypher.BackColor = System.Drawing.Color.LightBlue;
            this.loginFindCypher.BorderColor = System.Drawing.Color.White;
            this.loginFindCypher.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loginFindCypher.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.loginFindCypher.Location = new System.Drawing.Point(303, 269);
            this.loginFindCypher.Name = "loginFindCypher";
            this.loginFindCypher.Size = new System.Drawing.Size(56, 17);
            this.loginFindCypher.TabIndex = 8;
            this.loginFindCypher.Text = "找回密码";
            this.loginFindCypher.Click += new System.EventHandler(this.loginFindCypher_Click);
            // 
            // loginQQ
            // 
            this.loginQQ.BackColor = System.Drawing.Color.Transparent;
            this.loginQQ.Image = ((System.Drawing.Image)(resources.GetObject("loginQQ.Image")));
            this.loginQQ.Location = new System.Drawing.Point(12, 218);
            this.loginQQ.Name = "loginQQ";
            this.loginQQ.Size = new System.Drawing.Size(97, 103);
            this.loginQQ.TabIndex = 2;
            this.loginQQ.TabStop = false;
            // 
            // loginBase
            // 
            this.loginBase.BackColor = System.Drawing.Color.LightBlue;
            this.loginBase.Location = new System.Drawing.Point(1, 181);
            this.loginBase.Name = "loginBase";
            this.loginBase.Size = new System.Drawing.Size(430, 173);
            this.loginBase.TabIndex = 1;
            this.loginBase.TabStop = false;
            // 
            // loginTop
            // 
            this.loginTop.BackColor = System.Drawing.Color.Transparent;
            this.loginTop.Image = global::SocketSoftware.Properties.Resources.login;
            this.loginTop.Location = new System.Drawing.Point(1, 2);
            this.loginTop.Name = "loginTop";
            this.loginTop.Size = new System.Drawing.Size(430, 184);
            this.loginTop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.loginTop.TabIndex = 0;
            this.loginTop.TabStop = false;
            // 
            // server
            // 
            this.server.AutoSize = true;
            this.server.BackColor = System.Drawing.Color.LightBlue;
            this.server.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.server.DownBack = null;
            this.server.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.server.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.server.Location = new System.Drawing.Point(295, 299);
            this.server.MouseBack = null;
            this.server.Name = "server";
            this.server.NormlBack = null;
            this.server.SelectedDownBack = null;
            this.server.SelectedMouseBack = null;
            this.server.SelectedNormlBack = null;
            this.server.Size = new System.Drawing.Size(63, 21);
            this.server.TabIndex = 9;
            this.server.Text = "服务端";
            this.server.UseVisualStyleBackColor = false;
            this.server.Click += new System.EventHandler(this.server_CheckedChanged);
            // 
            // client
            // 
            this.client.AutoSize = true;
            this.client.BackColor = System.Drawing.Color.LightBlue;
            this.client.Checked = true;
            this.client.CheckState = System.Windows.Forms.CheckState.Checked;
            this.client.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.client.DownBack = null;
            this.client.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.client.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.client.Location = new System.Drawing.Point(295, 326);
            this.client.MouseBack = null;
            this.client.Name = "client";
            this.client.NormlBack = null;
            this.client.SelectedDownBack = null;
            this.client.SelectedMouseBack = null;
            this.client.SelectedNormlBack = null;
            this.client.Size = new System.Drawing.Size(63, 21);
            this.client.TabIndex = 10;
            this.client.Text = "客户端";
            this.client.UseVisualStyleBackColor = false;
            this.client.Click += new System.EventHandler(this.client_CheckedChanged);
            // 
            // Login
            // 
            this.AcceptButton = this.loginSignIn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 354);
            this.Controls.Add(this.client);
            this.Controls.Add(this.server);
            this.Controls.Add(this.loginFindCypher);
            this.Controls.Add(this.loginRegiste);
            this.Controls.Add(this.loginSignIn);
            this.Controls.Add(this.loginID);
            this.Controls.Add(this.loginCypher);
            this.Controls.Add(this.loginQQ);
            this.Controls.Add(this.loginBase);
            this.Controls.Add(this.loginTop);
            this.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dao_QQ";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.loginQQ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginBase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginTop)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CCWin.SkinControl.SkinPictureBox loginTop;
        private CCWin.SkinControl.SkinPictureBox loginBase;
        private CCWin.SkinControl.SkinPictureBox loginQQ;
        private CCWin.SkinControl.SkinAlphaWaterTextBox loginCypher;
        private CCWin.SkinControl.SkinAlphaWaterTextBox loginID;
        private CCWin.SkinControl.SkinButton loginSignIn;
        private CCWin.SkinControl.SkinLabel loginRegiste;
        private CCWin.SkinControl.SkinLabel loginFindCypher;
        private CCWin.SkinControl.SkinCheckBox server;
        private CCWin.SkinControl.SkinCheckBox client;
    }
}

