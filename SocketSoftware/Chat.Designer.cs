namespace SocketSoftware
{
    partial class Chat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Chat));
            this.lab_Name = new CCWin.SkinControl.SkinLabel();
            this.splitLine = new CCWin.SkinControl.SkinLine();
            this.send = new CCWin.SkinControl.SkinButton();
            this.close = new CCWin.SkinControl.SkinButton();
            this.scanner = new CCWin.SkinControl.RtfRichTextBox();
            this.screen = new CCWin.SkinControl.RtfRichTextBox();
            this.emojiGroup = new CCWin.SkinControl.SkinGroupBox();
            this.emoji3 = new CCWin.SkinControl.SkinPictureBox();
            this.emoji4 = new CCWin.SkinControl.SkinPictureBox();
            this.emoji7 = new CCWin.SkinControl.SkinPictureBox();
            this.emoji8 = new CCWin.SkinControl.SkinPictureBox();
            this.emoji9 = new CCWin.SkinControl.SkinPictureBox();
            this.emoji6 = new CCWin.SkinControl.SkinPictureBox();
            this.emoji2 = new CCWin.SkinControl.SkinPictureBox();
            this.emoji5 = new CCWin.SkinControl.SkinPictureBox();
            this.emoji1 = new CCWin.SkinControl.SkinPictureBox();
            this.folder = new CCWin.SkinControl.SkinPictureBox();
            this.photo = new CCWin.SkinControl.SkinPictureBox();
            this.emoji = new CCWin.SkinControl.SkinPictureBox();
            this.picture = new CCWin.SkinControl.SkinPictureBox();
            this.backgroundTitle = new CCWin.SkinControl.SkinPictureBox();
            this.open = new System.Windows.Forms.OpenFileDialog();
            this.lab_sign = new System.Windows.Forms.Label();
            this.emojiGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.emoji3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emoji4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emoji7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emoji8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emoji9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emoji6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emoji2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emoji5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emoji1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.folder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.photo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emoji)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.backgroundTitle)).BeginInit();
            this.SuspendLayout();
            // 
            // lab_Name
            // 
            this.lab_Name.AutoSize = true;
            this.lab_Name.BackColor = System.Drawing.Color.SkyBlue;
            this.lab_Name.BorderColor = System.Drawing.Color.White;
            this.lab_Name.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lab_Name.Location = new System.Drawing.Point(102, 14);
            this.lab_Name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lab_Name.Name = "lab_Name";
            this.lab_Name.Size = new System.Drawing.Size(92, 46);
            this.lab_Name.TabIndex = 2;
            this.lab_Name.Text = "蕉皮";
            this.lab_Name.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // splitLine
            // 
            this.splitLine.BackColor = System.Drawing.Color.Transparent;
            this.splitLine.LineColor = System.Drawing.Color.LightBlue;
            this.splitLine.LineHeight = 5;
            this.splitLine.Location = new System.Drawing.Point(-2, 420);
            this.splitLine.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.splitLine.Name = "splitLine";
            this.splitLine.Size = new System.Drawing.Size(718, 68);
            this.splitLine.TabIndex = 3;
            this.splitLine.Text = "skinLine1";
            // 
            // send
            // 
            this.send.BackColor = System.Drawing.Color.Transparent;
            this.send.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.send.DownBack = null;
            this.send.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.send.Location = new System.Drawing.Point(596, 685);
            this.send.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.send.MouseBack = null;
            this.send.Name = "send";
            this.send.NormlBack = null;
            this.send.Size = new System.Drawing.Size(108, 52);
            this.send.TabIndex = 4;
            this.send.Text = "发送";
            this.send.UseVisualStyleBackColor = false;
            this.send.Click += new System.EventHandler(this.Send_Click);
            // 
            // close
            // 
            this.close.BackColor = System.Drawing.Color.Transparent;
            this.close.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.close.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.close.DownBack = null;
            this.close.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.close.Location = new System.Drawing.Point(447, 685);
            this.close.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.close.MouseBack = null;
            this.close.Name = "close";
            this.close.NormlBack = null;
            this.close.Size = new System.Drawing.Size(110, 52);
            this.close.TabIndex = 5;
            this.close.Text = "关闭";
            this.close.UseVisualStyleBackColor = false;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // scanner
            // 
            this.scanner.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.scanner.HiglightColor = CCWin.SkinControl.RtfRichTextBox.RtfColor.White;
            this.scanner.Location = new System.Drawing.Point(0, 496);
            this.scanner.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.scanner.Name = "scanner";
            this.scanner.Size = new System.Drawing.Size(716, 181);
            this.scanner.TabIndex = 7;
            this.scanner.Text = "";
            this.scanner.TextColor = CCWin.SkinControl.RtfRichTextBox.RtfColor.Black;
            this.scanner.Click += new System.EventHandler(this.hideEmoji);
            // 
            // screen
            // 
            this.screen.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.screen.BackColor = System.Drawing.Color.White;
            this.screen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.screen.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.screen.HiglightColor = CCWin.SkinControl.RtfRichTextBox.RtfColor.White;
            this.screen.Location = new System.Drawing.Point(0, 84);
            this.screen.Margin = new System.Windows.Forms.Padding(0);
            this.screen.Name = "screen";
            this.screen.ReadOnly = true;
            this.screen.Size = new System.Drawing.Size(716, 346);
            this.screen.TabIndex = 8;
            this.screen.Text = "";
            this.screen.TextColor = CCWin.SkinControl.RtfRichTextBox.RtfColor.Black;
            this.screen.Click += new System.EventHandler(this.hideEmoji);
            this.screen.TextChanged += new System.EventHandler(this.screen_TextChanged);
            // 
            // emojiGroup
            // 
            this.emojiGroup.BackColor = System.Drawing.Color.Transparent;
            this.emojiGroup.BorderColor = System.Drawing.Color.PaleTurquoise;
            this.emojiGroup.Controls.Add(this.emoji3);
            this.emojiGroup.Controls.Add(this.emoji4);
            this.emojiGroup.Controls.Add(this.emoji7);
            this.emojiGroup.Controls.Add(this.emoji8);
            this.emojiGroup.Controls.Add(this.emoji9);
            this.emojiGroup.Controls.Add(this.emoji6);
            this.emojiGroup.Controls.Add(this.emoji2);
            this.emojiGroup.Controls.Add(this.emoji5);
            this.emojiGroup.Controls.Add(this.emoji1);
            this.emojiGroup.ForeColor = System.Drawing.Color.DodgerBlue;
            this.emojiGroup.Location = new System.Drawing.Point(39, 159);
            this.emojiGroup.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.emojiGroup.Name = "emojiGroup";
            this.emojiGroup.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.emojiGroup.RectBackColor = System.Drawing.Color.White;
            this.emojiGroup.RoundStyle = CCWin.SkinClass.RoundStyle.All;
            this.emojiGroup.Size = new System.Drawing.Size(300, 288);
            this.emojiGroup.TabIndex = 12;
            this.emojiGroup.TabStop = false;
            this.emojiGroup.Text = "emoji";
            this.emojiGroup.TitleBorderColor = System.Drawing.Color.DarkTurquoise;
            this.emojiGroup.TitleRectBackColor = System.Drawing.Color.White;
            this.emojiGroup.TitleRoundStyle = CCWin.SkinClass.RoundStyle.All;
            this.emojiGroup.Visible = false;
            // 
            // emoji3
            // 
            this.emoji3.BackColor = System.Drawing.Color.Transparent;
            this.emoji3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.emoji3.Image = global::SocketSoftware.Properties.Resources._3;
            this.emoji3.Location = new System.Drawing.Point(200, 30);
            this.emoji3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.emoji3.Name = "emoji3";
            this.emoji3.Size = new System.Drawing.Size(82, 75);
            this.emoji3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.emoji3.TabIndex = 8;
            this.emoji3.TabStop = false;
            this.emoji3.Click += new System.EventHandler(this.emoji0_Click);
            // 
            // emoji4
            // 
            this.emoji4.BackColor = System.Drawing.Color.Transparent;
            this.emoji4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.emoji4.Image = global::SocketSoftware.Properties.Resources._4;
            this.emoji4.Location = new System.Drawing.Point(9, 114);
            this.emoji4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.emoji4.Name = "emoji4";
            this.emoji4.Size = new System.Drawing.Size(82, 75);
            this.emoji4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.emoji4.TabIndex = 7;
            this.emoji4.TabStop = false;
            this.emoji4.Click += new System.EventHandler(this.emoji0_Click);
            // 
            // emoji7
            // 
            this.emoji7.BackColor = System.Drawing.Color.Transparent;
            this.emoji7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.emoji7.Image = global::SocketSoftware.Properties.Resources._7;
            this.emoji7.Location = new System.Drawing.Point(9, 198);
            this.emoji7.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.emoji7.Name = "emoji7";
            this.emoji7.Size = new System.Drawing.Size(82, 75);
            this.emoji7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.emoji7.TabIndex = 6;
            this.emoji7.TabStop = false;
            this.emoji7.Click += new System.EventHandler(this.emoji0_Click);
            // 
            // emoji8
            // 
            this.emoji8.BackColor = System.Drawing.Color.Transparent;
            this.emoji8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.emoji8.Image = global::SocketSoftware.Properties.Resources._8;
            this.emoji8.Location = new System.Drawing.Point(104, 198);
            this.emoji8.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.emoji8.Name = "emoji8";
            this.emoji8.Size = new System.Drawing.Size(82, 75);
            this.emoji8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.emoji8.TabIndex = 5;
            this.emoji8.TabStop = false;
            this.emoji8.Click += new System.EventHandler(this.emoji0_Click);
            // 
            // emoji9
            // 
            this.emoji9.BackColor = System.Drawing.Color.Transparent;
            this.emoji9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.emoji9.Image = global::SocketSoftware.Properties.Resources._9;
            this.emoji9.Location = new System.Drawing.Point(200, 198);
            this.emoji9.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.emoji9.Name = "emoji9";
            this.emoji9.Size = new System.Drawing.Size(82, 75);
            this.emoji9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.emoji9.TabIndex = 4;
            this.emoji9.TabStop = false;
            this.emoji9.Click += new System.EventHandler(this.emoji0_Click);
            // 
            // emoji6
            // 
            this.emoji6.BackColor = System.Drawing.Color.Transparent;
            this.emoji6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.emoji6.Image = global::SocketSoftware.Properties.Resources._6;
            this.emoji6.Location = new System.Drawing.Point(200, 114);
            this.emoji6.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.emoji6.Name = "emoji6";
            this.emoji6.Size = new System.Drawing.Size(82, 75);
            this.emoji6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.emoji6.TabIndex = 3;
            this.emoji6.TabStop = false;
            this.emoji6.Click += new System.EventHandler(this.emoji0_Click);
            // 
            // emoji2
            // 
            this.emoji2.BackColor = System.Drawing.Color.Transparent;
            this.emoji2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.emoji2.Image = global::SocketSoftware.Properties.Resources._2;
            this.emoji2.Location = new System.Drawing.Point(104, 30);
            this.emoji2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.emoji2.Name = "emoji2";
            this.emoji2.Size = new System.Drawing.Size(82, 75);
            this.emoji2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.emoji2.TabIndex = 2;
            this.emoji2.TabStop = false;
            this.emoji2.Click += new System.EventHandler(this.emoji0_Click);
            // 
            // emoji5
            // 
            this.emoji5.BackColor = System.Drawing.Color.Transparent;
            this.emoji5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.emoji5.Image = global::SocketSoftware.Properties.Resources._5;
            this.emoji5.Location = new System.Drawing.Point(104, 114);
            this.emoji5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.emoji5.Name = "emoji5";
            this.emoji5.Size = new System.Drawing.Size(82, 75);
            this.emoji5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.emoji5.TabIndex = 1;
            this.emoji5.TabStop = false;
            this.emoji5.Click += new System.EventHandler(this.emoji0_Click);
            // 
            // emoji1
            // 
            this.emoji1.BackColor = System.Drawing.Color.Transparent;
            this.emoji1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.emoji1.Image = global::SocketSoftware.Properties.Resources._1;
            this.emoji1.Location = new System.Drawing.Point(9, 30);
            this.emoji1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.emoji1.Name = "emoji1";
            this.emoji1.Size = new System.Drawing.Size(82, 75);
            this.emoji1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.emoji1.TabIndex = 0;
            this.emoji1.TabStop = false;
            this.emoji1.Click += new System.EventHandler(this.emoji0_Click);
            // 
            // folder
            // 
            this.folder.BackColor = System.Drawing.Color.Transparent;
            this.folder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.folder.Image = global::SocketSoftware.Properties.Resources.folder;
            this.folder.Location = new System.Drawing.Point(76, 435);
            this.folder.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.folder.Name = "folder";
            this.folder.Size = new System.Drawing.Size(35, 35);
            this.folder.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.folder.TabIndex = 11;
            this.folder.TabStop = false;
            this.folder.Click += new System.EventHandler(this.folder_Click);
            // 
            // photo
            // 
            this.photo.BackColor = System.Drawing.Color.Transparent;
            this.photo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.photo.Image = global::SocketSoftware.Properties.Resources.photo;
            this.photo.Location = new System.Drawing.Point(142, 435);
            this.photo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.photo.Name = "photo";
            this.photo.Size = new System.Drawing.Size(35, 35);
            this.photo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.photo.TabIndex = 10;
            this.photo.TabStop = false;
            this.photo.Click += new System.EventHandler(this.photo_Click);
            // 
            // emoji
            // 
            this.emoji.BackColor = System.Drawing.Color.Transparent;
            this.emoji.Cursor = System.Windows.Forms.Cursors.Hand;
            this.emoji.Image = global::SocketSoftware.Properties.Resources.emoji;
            this.emoji.Location = new System.Drawing.Point(15, 435);
            this.emoji.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.emoji.Name = "emoji";
            this.emoji.Size = new System.Drawing.Size(35, 35);
            this.emoji.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.emoji.TabIndex = 9;
            this.emoji.TabStop = false;
            this.emoji.Click += new System.EventHandler(this.emoji_Click);
            // 
            // picture
            // 
            this.picture.BackColor = System.Drawing.Color.Transparent;
            this.picture.Image = ((System.Drawing.Image)(resources.GetObject("picture.Image")));
            this.picture.Location = new System.Drawing.Point(0, 0);
            this.picture.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.picture.Name = "picture";
            this.picture.Size = new System.Drawing.Size(94, 88);
            this.picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picture.TabIndex = 6;
            this.picture.TabStop = false;
            // 
            // backgroundTitle
            // 
            this.backgroundTitle.BackColor = System.Drawing.Color.SkyBlue;
            this.backgroundTitle.Location = new System.Drawing.Point(0, 0);
            this.backgroundTitle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.backgroundTitle.Name = "backgroundTitle";
            this.backgroundTitle.Size = new System.Drawing.Size(718, 166);
            this.backgroundTitle.TabIndex = 1;
            this.backgroundTitle.TabStop = false;
            this.backgroundTitle.Click += new System.EventHandler(this.hideEmoji);
            // 
            // open
            // 
            this.open.FileName = "openFileDialog1";
            // 
            // lab_sign
            // 
            this.lab_sign.AutoSize = true;
            this.lab_sign.BackColor = System.Drawing.Color.SkyBlue;
            this.lab_sign.Font = new System.Drawing.Font("微软雅黑", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lab_sign.Location = new System.Drawing.Point(282, 51);
            this.lab_sign.Name = "lab_sign";
            this.lab_sign.Size = new System.Drawing.Size(59, 28);
            this.lab_sign.TabIndex = 13;
            this.lab_sign.Text = "sign:";
            // 
            // Chat
            // 
            this.AcceptButton = this.send;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.close;
            this.ClientSize = new System.Drawing.Size(717, 770);
            this.ControlBox = false;
            this.Controls.Add(this.lab_sign);
            this.Controls.Add(this.emojiGroup);
            this.Controls.Add(this.folder);
            this.Controls.Add(this.photo);
            this.Controls.Add(this.emoji);
            this.Controls.Add(this.screen);
            this.Controls.Add(this.scanner);
            this.Controls.Add(this.picture);
            this.Controls.Add(this.close);
            this.Controls.Add(this.send);
            this.Controls.Add(this.splitLine);
            this.Controls.Add(this.lab_Name);
            this.Controls.Add(this.backgroundTitle);
            this.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Chat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "与蕉皮的聊天";
            this.Load += new System.EventHandler(this.Chat_Load);
            this.Click += new System.EventHandler(this.hideEmoji);
            this.emojiGroup.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.emoji3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emoji4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emoji7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emoji8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emoji9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emoji6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emoji2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emoji5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emoji1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.folder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.photo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emoji)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.backgroundTitle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CCWin.SkinControl.SkinPictureBox backgroundTitle;
        private CCWin.SkinControl.SkinLine splitLine;
        private CCWin.SkinControl.SkinButton send;
        private CCWin.SkinControl.SkinButton close;
        private CCWin.SkinControl.SkinPictureBox picture;
        private CCWin.SkinControl.RtfRichTextBox scanner;
        private CCWin.SkinControl.RtfRichTextBox screen;
        private CCWin.SkinControl.SkinPictureBox emoji;
        private CCWin.SkinControl.SkinPictureBox photo;
        private CCWin.SkinControl.SkinPictureBox folder;
        private CCWin.SkinControl.SkinLabel lab_Name;
        private CCWin.SkinControl.SkinGroupBox emojiGroup;
        private CCWin.SkinControl.SkinPictureBox emoji3;
        private CCWin.SkinControl.SkinPictureBox emoji4;
        private CCWin.SkinControl.SkinPictureBox emoji7;
        private CCWin.SkinControl.SkinPictureBox emoji8;
        private CCWin.SkinControl.SkinPictureBox emoji9;
        private CCWin.SkinControl.SkinPictureBox emoji6;
        private CCWin.SkinControl.SkinPictureBox emoji2;
        private CCWin.SkinControl.SkinPictureBox emoji5;
        private CCWin.SkinControl.SkinPictureBox emoji1;
        private System.Windows.Forms.OpenFileDialog open;
        private System.Windows.Forms.Label lab_sign;
    }
}