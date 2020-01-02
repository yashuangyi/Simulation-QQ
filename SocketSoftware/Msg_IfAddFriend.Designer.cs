namespace SocketSoftware
{
    partial class Msg_IfAddFriend
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Msg_IfAddFriend));
            this.label1 = new System.Windows.Forms.Label();
            this.Bu_Add = new CCWin.SkinControl.SkinButton();
            this.skinButton_close = new CCWin.SkinControl.SkinButton();
            this.skinWaterTextBox_info = new CCWin.SkinControl.SkinWaterTextBox();
            this.skinPictureBox_headPhoto = new CCWin.SkinControl.SkinPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.skinPictureBox_headPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("华文仿宋", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.Crimson;
            this.label1.Location = new System.Drawing.Point(25, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(477, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "有人向你发送了添加好友请求：";
            // 
            // Bu_Add
            // 
            this.Bu_Add.BackColor = System.Drawing.Color.Transparent;
            this.Bu_Add.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Bu_Add.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.Bu_Add.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.Bu_Add.DownBack = null;
            this.Bu_Add.Font = new System.Drawing.Font("新宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Bu_Add.ForeColor = System.Drawing.Color.Black;
            this.Bu_Add.Location = new System.Drawing.Point(390, 376);
            this.Bu_Add.MouseBack = null;
            this.Bu_Add.Name = "Bu_Add";
            this.Bu_Add.NormlBack = null;
            this.Bu_Add.Size = new System.Drawing.Size(171, 44);
            this.Bu_Add.TabIndex = 1;
            this.Bu_Add.Text = "添加该好友";
            this.Bu_Add.UseVisualStyleBackColor = false;
            this.Bu_Add.Click += new System.EventHandler(this.Bu_Add_Click);
            // 
            // skinButton_close
            // 
            this.skinButton_close.BackColor = System.Drawing.Color.Transparent;
            this.skinButton_close.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.skinButton_close.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.skinButton_close.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinButton_close.DownBack = null;
            this.skinButton_close.Font = new System.Drawing.Font("新宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinButton_close.ForeColor = System.Drawing.Color.Black;
            this.skinButton_close.Location = new System.Drawing.Point(595, 376);
            this.skinButton_close.MouseBack = null;
            this.skinButton_close.Name = "skinButton_close";
            this.skinButton_close.NormlBack = null;
            this.skinButton_close.Size = new System.Drawing.Size(163, 44);
            this.skinButton_close.TabIndex = 2;
            this.skinButton_close.Text = "忽略此消息";
            this.skinButton_close.UseVisualStyleBackColor = false;
            this.skinButton_close.Click += new System.EventHandler(this.SkinButton_Close_Click);
            // 
            // skinWaterTextBox_info
            // 
            this.skinWaterTextBox_info.Font = new System.Drawing.Font("宋体", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinWaterTextBox_info.Location = new System.Drawing.Point(30, 96);
            this.skinWaterTextBox_info.Multiline = true;
            this.skinWaterTextBox_info.Name = "skinWaterTextBox_info";
            this.skinWaterTextBox_info.ReadOnly = true;
            this.skinWaterTextBox_info.Size = new System.Drawing.Size(575, 209);
            this.skinWaterTextBox_info.TabIndex = 3;
            this.skinWaterTextBox_info.Text = "Name: BigBao\r\nAge: 40\r\nAddress:WuShan\r\nExplaination: Hi~,I am silly BigBao!";
            this.skinWaterTextBox_info.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.skinWaterTextBox_info.WaterText = "";
            // 
            // skinPictureBox_headPhoto
            // 
            this.skinPictureBox_headPhoto.BackColor = System.Drawing.Color.Transparent;
            this.skinPictureBox_headPhoto.Image = global::SocketSoftware.Properties.Resources._2;
            this.skinPictureBox_headPhoto.Location = new System.Drawing.Point(625, 96);
            this.skinPictureBox_headPhoto.Name = "skinPictureBox_headPhoto";
            this.skinPictureBox_headPhoto.Size = new System.Drawing.Size(144, 140);
            this.skinPictureBox_headPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.skinPictureBox_headPhoto.TabIndex = 4;
            this.skinPictureBox_headPhoto.TabStop = false;
            // 
            // Msg_IfAddFriend
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.skinPictureBox_headPhoto);
            this.Controls.Add(this.skinWaterTextBox_info);
            this.Controls.Add(this.skinButton_close);
            this.Controls.Add(this.Bu_Add);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Msg_IfAddFriend";
            this.Text = "Msg_IfAddFriend";
            this.Load += new System.EventHandler(this.Msg_IfAddFriend_Load);
            ((System.ComponentModel.ISupportInitialize)(this.skinPictureBox_headPhoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private CCWin.SkinControl.SkinButton Bu_Add;
        private CCWin.SkinControl.SkinButton skinButton_close;
        private CCWin.SkinControl.SkinWaterTextBox skinWaterTextBox_info;
        private CCWin.SkinControl.SkinPictureBox skinPictureBox_headPhoto;
    }
}