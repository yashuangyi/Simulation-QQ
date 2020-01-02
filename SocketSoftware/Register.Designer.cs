namespace SocketSoftware
{
    partial class Register
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register));
            this.yep = new CCWin.SkinControl.SkinButton();
            this.cancel = new CCWin.SkinControl.SkinButton();
            this.id = new CCWin.SkinControl.SkinWaterTextBox();
            this.name = new CCWin.SkinControl.SkinWaterTextBox();
            this.passwordAgain = new CCWin.SkinControl.SkinWaterTextBox();
            this.password = new CCWin.SkinControl.SkinWaterTextBox();
            this.sign = new CCWin.SkinControl.SkinWaterTextBox();
            this.phone = new CCWin.SkinControl.SkinWaterTextBox();
            this.label_picture = new CCWin.SkinControl.SkinLabel();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.picture = new CCWin.SkinControl.SkinPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).BeginInit();
            this.SuspendLayout();
            // 
            // yep
            // 
            this.yep.BackColor = System.Drawing.Color.Transparent;
            this.yep.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.yep.DownBack = null;
            this.yep.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.yep.Location = new System.Drawing.Point(57, 319);
            this.yep.MouseBack = null;
            this.yep.Name = "yep";
            this.yep.NormlBack = null;
            this.yep.Size = new System.Drawing.Size(101, 49);
            this.yep.TabIndex = 0;
            this.yep.Text = "确认";
            this.yep.UseVisualStyleBackColor = false;
            this.yep.Click += new System.EventHandler(this.yep_Click);
            // 
            // cancel
            // 
            this.cancel.BackColor = System.Drawing.Color.Transparent;
            this.cancel.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancel.DownBack = null;
            this.cancel.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cancel.Location = new System.Drawing.Point(227, 319);
            this.cancel.MouseBack = null;
            this.cancel.Name = "cancel";
            this.cancel.NormlBack = null;
            this.cancel.Size = new System.Drawing.Size(101, 49);
            this.cancel.TabIndex = 1;
            this.cancel.Text = "退出";
            this.cancel.UseVisualStyleBackColor = false;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // id
            // 
            this.id.Font = new System.Drawing.Font("宋体", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.id.Location = new System.Drawing.Point(141, 29);
            this.id.MaxLength = 10;
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(187, 25);
            this.id.TabIndex = 2;
            this.id.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.id.WaterText = "账号";
            // 
            // name
            // 
            this.name.Font = new System.Drawing.Font("宋体", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.name.Location = new System.Drawing.Point(141, 152);
            this.name.MaxLength = 10;
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(187, 25);
            this.name.TabIndex = 3;
            this.name.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.name.WaterText = "昵称";
            this.name.TextChanged += new System.EventHandler(this.skinWaterTextBox1_TextChanged);
            // 
            // passwordAgain
            // 
            this.passwordAgain.Font = new System.Drawing.Font("宋体", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.passwordAgain.Location = new System.Drawing.Point(141, 111);
            this.passwordAgain.MaxLength = 15;
            this.passwordAgain.Name = "passwordAgain";
            this.passwordAgain.Size = new System.Drawing.Size(187, 25);
            this.passwordAgain.TabIndex = 4;
            this.passwordAgain.UseSystemPasswordChar = true;
            this.passwordAgain.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.passwordAgain.WaterText = "确认密码";
            // 
            // password
            // 
            this.password.Font = new System.Drawing.Font("宋体", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.password.Location = new System.Drawing.Point(141, 70);
            this.password.MaxLength = 15;
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(187, 25);
            this.password.TabIndex = 5;
            this.password.UseSystemPasswordChar = true;
            this.password.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.password.WaterText = "密码";
            // 
            // sign
            // 
            this.sign.Font = new System.Drawing.Font("宋体", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.sign.Location = new System.Drawing.Point(141, 194);
            this.sign.MaxLength = 15;
            this.sign.Name = "sign";
            this.sign.Size = new System.Drawing.Size(187, 25);
            this.sign.TabIndex = 6;
            this.sign.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.sign.WaterText = "个性签名（选填）";
            // 
            // phone
            // 
            this.phone.Font = new System.Drawing.Font("宋体", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.phone.Location = new System.Drawing.Point(141, 234);
            this.phone.MaxLength = 11;
            this.phone.Name = "phone";
            this.phone.Size = new System.Drawing.Size(187, 25);
            this.phone.TabIndex = 7;
            this.phone.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.phone.WaterText = "手机号（用于找回密码）";
            // 
            // label_picture
            // 
            this.label_picture.AutoSize = true;
            this.label_picture.BackColor = System.Drawing.Color.Transparent;
            this.label_picture.BorderColor = System.Drawing.Color.White;
            this.label_picture.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_picture.Location = new System.Drawing.Point(33, 176);
            this.label_picture.Name = "label_picture";
            this.label_picture.Size = new System.Drawing.Size(80, 17);
            this.label_picture.TabIndex = 9;
            this.label_picture.Text = "点击更换头像";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // picture
            // 
            this.picture.BackColor = System.Drawing.Color.Transparent;
            this.picture.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picture.Image = global::SocketSoftware.Properties.Resources.title;
            this.picture.Location = new System.Drawing.Point(24, 59);
            this.picture.Name = "picture";
            this.picture.Size = new System.Drawing.Size(100, 100);
            this.picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picture.TabIndex = 8;
            this.picture.TabStop = false;
            this.picture.Click += new System.EventHandler(this.picture_Click);
            // 
            // Register
            // 
            this.AcceptButton = this.yep;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancel;
            this.ClientSize = new System.Drawing.Size(386, 380);
            this.ControlBox = false;
            this.Controls.Add(this.label_picture);
            this.Controls.Add(this.picture);
            this.Controls.Add(this.phone);
            this.Controls.Add(this.sign);
            this.Controls.Add(this.password);
            this.Controls.Add(this.passwordAgain);
            this.Controls.Add(this.name);
            this.Controls.Add(this.id);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.yep);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Register";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "注册账号";
            this.Load += new System.EventHandler(this.Register_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CCWin.SkinControl.SkinButton yep;
        private CCWin.SkinControl.SkinButton cancel;
        private CCWin.SkinControl.SkinWaterTextBox id;
        private CCWin.SkinControl.SkinWaterTextBox name;
        private CCWin.SkinControl.SkinWaterTextBox passwordAgain;
        private CCWin.SkinControl.SkinWaterTextBox password;
        private CCWin.SkinControl.SkinWaterTextBox sign;
        private CCWin.SkinControl.SkinWaterTextBox phone;
        private CCWin.SkinControl.SkinPictureBox picture;
        private CCWin.SkinControl.SkinLabel label_picture;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}