namespace SocketSoftware
{
    partial class InfoList
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
            CCWin.SkinControl.ChatListItem chatListItem1 = new CCWin.SkinControl.ChatListItem();
            CCWin.SkinControl.ChatListSubItem chatListSubItem1 = new CCWin.SkinControl.ChatListSubItem();
            CCWin.SkinControl.ChatListItem chatListItem2 = new CCWin.SkinControl.ChatListItem();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InfoList));
            this.chatListBox_Message = new CCWin.SkinControl.ChatListBox();
            this.chatListBox_newFriends = new CCWin.SkinControl.ChatListBox();
            this.chatListBox_Friend = new CCWin.SkinControl.ChatListBox();
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton_AddFriends = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_list = new System.Windows.Forms.ToolStripButton();
            this.skinPanel_Middle = new CCWin.SkinControl.SkinPanel();
            this.skinPanel_list = new CCWin.SkinControl.SkinPanel();
            this.skinButton_shiftId = new CCWin.SkinControl.SkinButton();
            this.skinButton_help = new CCWin.SkinControl.SkinButton();
            this.skinButton_set = new CCWin.SkinControl.SkinButton();
            this.skinMenuStrip_Main3 = new CCWin.SkinControl.SkinMenuStrip();
            this.消息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.好友ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.新的好友ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.skinPanel_Top = new CCWin.SkinControl.SkinPanel();
            this.skinWaterTextBox_search = new CCWin.SkinControl.SkinWaterTextBox();
            this.lab_signature = new System.Windows.Forms.Label();
            this.skinPictureBox_head = new CCWin.SkinControl.SkinPictureBox();
            this.contextMenuStrip_HeadPhoto = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.编辑个人资料ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.更改头像ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lab_Name = new System.Windows.Forms.Label();
            this.timZoom = new System.Windows.Forms.Timer(this.components);
            this.skinContextMenuStrip_newFriends = new CCWin.SkinControl.SkinContextMenuStrip();
            this.移动到好友ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.删除该提示ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripContainer1.BottomToolStripPanel.SuspendLayout();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.skinPanel_Middle.SuspendLayout();
            this.skinPanel_list.SuspendLayout();
            this.skinMenuStrip_Main3.SuspendLayout();
            this.skinPanel_Top.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.skinPictureBox_head)).BeginInit();
            this.contextMenuStrip_HeadPhoto.SuspendLayout();
            this.skinContextMenuStrip_newFriends.SuspendLayout();
            this.SuspendLayout();
            // 
            // chatListBox_Message
            // 
            this.chatListBox_Message.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.chatListBox_Message.Font = new System.Drawing.Font("微软雅黑", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.chatListBox_Message.ForeColor = System.Drawing.Color.Black;
            this.chatListBox_Message.FriendsMobile = true;
            chatListItem1.Bounds = new System.Drawing.Rectangle(0, 1, 612, 25);
            chatListItem1.IsTwinkleHide = false;
            chatListItem1.OwnerChatListBox = this.chatListBox_Message;
            chatListSubItem1.Bounds = new System.Drawing.Rectangle(0, 0, 0, 0);
            chatListSubItem1.DisplayName = "知人者明";
            chatListSubItem1.HeadImage = global::SocketSoftware.Properties.Resources.add;
            chatListSubItem1.HeadRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            chatListSubItem1.ID = ((uint)(0u));
            chatListSubItem1.IpAddress = null;
            chatListSubItem1.IsTwinkle = false;
            chatListSubItem1.IsTwinkleHide = false;
            chatListSubItem1.IsVip = false;
            chatListSubItem1.NicName = "傻子";
            chatListSubItem1.OwnerListItem = chatListItem1;
            chatListSubItem1.PersonalMsg = "201725010202";
            chatListSubItem1.PlatformTypes = CCWin.SkinControl.PlatformType.PC;
            chatListSubItem1.QQShow = null;
            chatListSubItem1.Status = CCWin.SkinControl.ChatListSubItem.UserStatus.Online;
            chatListSubItem1.Tag = null;
            chatListSubItem1.TcpPort = 0;
            chatListSubItem1.UpdPort = 0;
            chatListItem1.SubItems.AddRange(new CCWin.SkinControl.ChatListSubItem[] {
            chatListSubItem1});
            chatListItem1.Tag = null;
            chatListItem1.Text = "最近联系人";
            chatListItem1.TwinkleSubItemNumber = 0;
            this.chatListBox_Message.Items.AddRange(new CCWin.SkinControl.ChatListItem[] {
            chatListItem1});
            this.chatListBox_Message.ListSubItemMenu = null;
            this.chatListBox_Message.Location = new System.Drawing.Point(-4, 60);
            this.chatListBox_Message.Margin = new System.Windows.Forms.Padding(4);
            this.chatListBox_Message.Name = "chatListBox_Message";
            this.chatListBox_Message.SelectSubItem = null;
            this.chatListBox_Message.Size = new System.Drawing.Size(612, 620);
            this.chatListBox_Message.SubItemMenu = null;
            this.chatListBox_Message.TabIndex = 3;
            this.chatListBox_Message.Text = "chatListBox2";
            this.chatListBox_Message.DoubleClickSubItem += new CCWin.SkinControl.ChatListBox.ChatListEventHandler(this.ChatListBox_Message_DoubleClickSubItem);
            // 
            // chatListBox_newFriends
            // 
            this.chatListBox_newFriends.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.chatListBox_newFriends.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.chatListBox_newFriends.ForeColor = System.Drawing.Color.Black;
            this.chatListBox_newFriends.FriendsMobile = true;
            chatListItem2.Bounds = new System.Drawing.Rectangle(0, 1, 605, 25);
            chatListItem2.IsTwinkleHide = false;
            chatListItem2.OwnerChatListBox = this.chatListBox_newFriends;
            chatListItem2.Tag = null;
            chatListItem2.Text = "暂无此功能!";
            chatListItem2.TwinkleSubItemNumber = 0;
            this.chatListBox_newFriends.Items.AddRange(new CCWin.SkinControl.ChatListItem[] {
            chatListItem2});
            this.chatListBox_newFriends.ListSubItemMenu = null;
            this.chatListBox_newFriends.Location = new System.Drawing.Point(3, 60);
            this.chatListBox_newFriends.Name = "chatListBox_newFriends";
            this.chatListBox_newFriends.SelectSubItem = null;
            this.chatListBox_newFriends.Size = new System.Drawing.Size(605, 620);
            this.chatListBox_newFriends.SubItemMenu = null;
            this.chatListBox_newFriends.TabIndex = 5;
            this.chatListBox_newFriends.Text = "chatListBox_newFriends";
            this.chatListBox_newFriends.Visible = false;
            this.chatListBox_newFriends.DoubleClickSubItem += new CCWin.SkinControl.ChatListBox.ChatListEventHandler(this.ChatListBox_newFriends_DoubleClickSubItem);
            // 
            // chatListBox_Friend
            // 
            this.chatListBox_Friend.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.chatListBox_Friend.Font = new System.Drawing.Font("微软雅黑", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.chatListBox_Friend.ForeColor = System.Drawing.Color.Black;
            this.chatListBox_Friend.FriendsMobile = true;
            this.chatListBox_Friend.ListSubItemMenu = null;
            this.chatListBox_Friend.Location = new System.Drawing.Point(0, 60);
            this.chatListBox_Friend.Margin = new System.Windows.Forms.Padding(4);
            this.chatListBox_Friend.Name = "chatListBox_Friend";
            this.chatListBox_Friend.Padding = new System.Windows.Forms.Padding(10);
            this.chatListBox_Friend.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chatListBox_Friend.SelectSubItem = null;
            this.chatListBox_Friend.Size = new System.Drawing.Size(612, 620);
            this.chatListBox_Friend.SubItemMenu = null;
            this.chatListBox_Friend.TabIndex = 2;
            this.chatListBox_Friend.Text = "chatListBox1";
            this.chatListBox_Friend.Visible = false;
            this.chatListBox_Friend.DoubleClickSubItem += new CCWin.SkinControl.ChatListBox.ChatListEventHandler(this.ChatListBox_Friend_DoubleClickSubItem);
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.BottomToolStripPanel
            // 
            this.toolStripContainer1.BottomToolStripPanel.Controls.Add(this.toolStrip1);
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Controls.Add(this.skinPanel_Middle);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.skinPanel_Top);
            this.toolStripContainer1.ContentPanel.Margin = new System.Windows.Forms.Padding(4);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(624, 980);
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer1.LeftToolStripPanelVisible = false;
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer1.Margin = new System.Windows.Forms.Padding(4);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.RightToolStripPanelVisible = false;
            this.toolStripContainer1.Size = new System.Drawing.Size(624, 1022);
            this.toolStripContainer1.TabIndex = 1;
            this.toolStripContainer1.Text = "toolStripContainer1";
            this.toolStripContainer1.TopToolStripPanelVisible = false;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton_AddFriends,
            this.toolStripButton_list});
            this.toolStrip1.Location = new System.Drawing.Point(6, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(114, 42);
            this.toolStrip1.TabIndex = 0;
            // 
            // toolStripButton_AddFriends
            // 
            this.toolStripButton_AddFriends.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton_AddFriends.Image = global::SocketSoftware.Properties.Resources.add;
            this.toolStripButton_AddFriends.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_AddFriends.Name = "toolStripButton_AddFriends";
            this.toolStripButton_AddFriends.Size = new System.Drawing.Size(46, 36);
            this.toolStripButton_AddFriends.Text = "添加好友";
            this.toolStripButton_AddFriends.Click += new System.EventHandler(this.ToolStripButton_AddFriends_Click);
            // 
            // toolStripButton_list
            // 
            this.toolStripButton_list.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton_list.Image = global::SocketSoftware.Properties.Resources.menu;
            this.toolStripButton_list.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_list.Name = "toolStripButton_list";
            this.toolStripButton_list.Size = new System.Drawing.Size(46, 36);
            this.toolStripButton_list.Text = "toolStripButton2";
            this.toolStripButton_list.Click += new System.EventHandler(this.ToolStripButton_list_Click);
            // 
            // skinPanel_Middle
            // 
            this.skinPanel_Middle.BackColor = System.Drawing.Color.LightGray;
            this.skinPanel_Middle.Controls.Add(this.skinPanel_list);
            this.skinPanel_Middle.Controls.Add(this.chatListBox_newFriends);
            this.skinPanel_Middle.Controls.Add(this.skinMenuStrip_Main3);
            this.skinPanel_Middle.Controls.Add(this.chatListBox_Friend);
            this.skinPanel_Middle.Controls.Add(this.chatListBox_Message);
            this.skinPanel_Middle.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinPanel_Middle.Cursor = System.Windows.Forms.Cursors.Default;
            this.skinPanel_Middle.DownBack = null;
            this.skinPanel_Middle.Location = new System.Drawing.Point(4, 252);
            this.skinPanel_Middle.Margin = new System.Windows.Forms.Padding(4);
            this.skinPanel_Middle.MouseBack = null;
            this.skinPanel_Middle.Name = "skinPanel_Middle";
            this.skinPanel_Middle.NormlBack = null;
            this.skinPanel_Middle.Size = new System.Drawing.Size(618, 700);
            this.skinPanel_Middle.TabIndex = 3;
            // 
            // skinPanel_list
            // 
            this.skinPanel_list.BackColor = System.Drawing.Color.Transparent;
            this.skinPanel_list.Controls.Add(this.skinButton_shiftId);
            this.skinPanel_list.Controls.Add(this.skinButton_help);
            this.skinPanel_list.Controls.Add(this.skinButton_set);
            this.skinPanel_list.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinPanel_list.DownBack = null;
            this.skinPanel_list.Font = new System.Drawing.Font("宋体", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinPanel_list.Location = new System.Drawing.Point(100, 490);
            this.skinPanel_list.MouseBack = null;
            this.skinPanel_list.Name = "skinPanel_list";
            this.skinPanel_list.NormlBack = null;
            this.skinPanel_list.Size = new System.Drawing.Size(141, 159);
            this.skinPanel_list.TabIndex = 6;
            this.skinPanel_list.Visible = false;
            // 
            // skinButton_shiftId
            // 
            this.skinButton_shiftId.BackColor = System.Drawing.Color.Transparent;
            this.skinButton_shiftId.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.skinButton_shiftId.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.skinButton_shiftId.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinButton_shiftId.DownBack = null;
            this.skinButton_shiftId.Font = new System.Drawing.Font("楷体", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinButton_shiftId.Location = new System.Drawing.Point(0, 106);
            this.skinButton_shiftId.Margin = new System.Windows.Forms.Padding(0);
            this.skinButton_shiftId.MouseBack = null;
            this.skinButton_shiftId.Name = "skinButton_shiftId";
            this.skinButton_shiftId.NormlBack = null;
            this.skinButton_shiftId.Size = new System.Drawing.Size(141, 53);
            this.skinButton_shiftId.TabIndex = 9;
            this.skinButton_shiftId.Text = "切换账号";
            this.skinButton_shiftId.UseVisualStyleBackColor = false;
            this.skinButton_shiftId.Click += new System.EventHandler(this.SkinButton_shiftId_Click);
            // 
            // skinButton_help
            // 
            this.skinButton_help.BackColor = System.Drawing.Color.Transparent;
            this.skinButton_help.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.skinButton_help.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.skinButton_help.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinButton_help.DownBack = null;
            this.skinButton_help.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinButton_help.Location = new System.Drawing.Point(0, 53);
            this.skinButton_help.Margin = new System.Windows.Forms.Padding(0);
            this.skinButton_help.MouseBack = null;
            this.skinButton_help.Name = "skinButton_help";
            this.skinButton_help.NormlBack = null;
            this.skinButton_help.Size = new System.Drawing.Size(141, 53);
            this.skinButton_help.TabIndex = 8;
            this.skinButton_help.Text = "帮助";
            this.skinButton_help.UseVisualStyleBackColor = false;
            this.skinButton_help.Click += new System.EventHandler(this.SkinButton_help_Click);
            // 
            // skinButton_set
            // 
            this.skinButton_set.BackColor = System.Drawing.Color.Transparent;
            this.skinButton_set.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.skinButton_set.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.skinButton_set.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinButton_set.DownBack = null;
            this.skinButton_set.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinButton_set.Location = new System.Drawing.Point(0, 0);
            this.skinButton_set.Margin = new System.Windows.Forms.Padding(0);
            this.skinButton_set.MouseBack = null;
            this.skinButton_set.Name = "skinButton_set";
            this.skinButton_set.NormlBack = null;
            this.skinButton_set.Size = new System.Drawing.Size(141, 53);
            this.skinButton_set.TabIndex = 7;
            this.skinButton_set.Text = "设置";
            this.skinButton_set.UseVisualStyleBackColor = false;
            this.skinButton_set.Click += new System.EventHandler(this.SkinButton_set_Click);
            // 
            // skinMenuStrip_Main3
            // 
            this.skinMenuStrip_Main3.AllowItemReorder = true;
            this.skinMenuStrip_Main3.Arrow = System.Drawing.Color.Black;
            this.skinMenuStrip_Main3.Back = System.Drawing.Color.White;
            this.skinMenuStrip_Main3.BackRadius = 4;
            this.skinMenuStrip_Main3.BackRectangle = new System.Drawing.Rectangle(10, 10, 10, 10);
            this.skinMenuStrip_Main3.Base = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(200)))), ((int)(((byte)(254)))));
            this.skinMenuStrip_Main3.BaseFore = System.Drawing.Color.Black;
            this.skinMenuStrip_Main3.BaseForeAnamorphosis = false;
            this.skinMenuStrip_Main3.BaseForeAnamorphosisBorder = 4;
            this.skinMenuStrip_Main3.BaseForeAnamorphosisColor = System.Drawing.Color.White;
            this.skinMenuStrip_Main3.BaseHoverFore = System.Drawing.Color.WhiteSmoke;
            this.skinMenuStrip_Main3.BaseItemAnamorphosis = true;
            this.skinMenuStrip_Main3.BaseItemBorder = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.skinMenuStrip_Main3.BaseItemBorderShow = true;
            this.skinMenuStrip_Main3.BaseItemDown = ((System.Drawing.Image)(resources.GetObject("skinMenuStrip_Main3.BaseItemDown")));
            this.skinMenuStrip_Main3.BaseItemHover = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.skinMenuStrip_Main3.BaseItemMouse = ((System.Drawing.Image)(resources.GetObject("skinMenuStrip_Main3.BaseItemMouse")));
            this.skinMenuStrip_Main3.BaseItemPressed = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.skinMenuStrip_Main3.BaseItemRadius = 4;
            this.skinMenuStrip_Main3.BaseItemRadiusStyle = CCWin.SkinClass.RoundStyle.All;
            this.skinMenuStrip_Main3.BaseItemSplitter = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.skinMenuStrip_Main3.Dock = System.Windows.Forms.DockStyle.None;
            this.skinMenuStrip_Main3.DropDownImageSeparator = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.skinMenuStrip_Main3.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinMenuStrip_Main3.Fore = System.Drawing.Color.Black;
            this.skinMenuStrip_Main3.GripMargin = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.skinMenuStrip_Main3.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.skinMenuStrip_Main3.HoverFore = System.Drawing.Color.White;
            this.skinMenuStrip_Main3.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.skinMenuStrip_Main3.ItemAnamorphosis = true;
            this.skinMenuStrip_Main3.ItemBorder = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.skinMenuStrip_Main3.ItemBorderShow = true;
            this.skinMenuStrip_Main3.ItemHover = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.skinMenuStrip_Main3.ItemPressed = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.skinMenuStrip_Main3.ItemRadius = 4;
            this.skinMenuStrip_Main3.ItemRadiusStyle = CCWin.SkinClass.RoundStyle.All;
            this.skinMenuStrip_Main3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.消息ToolStripMenuItem,
            this.好友ToolStripMenuItem,
            this.新的好友ToolStripMenuItem});
            this.skinMenuStrip_Main3.Location = new System.Drawing.Point(0, 0);
            this.skinMenuStrip_Main3.Name = "skinMenuStrip_Main3";
            this.skinMenuStrip_Main3.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.skinMenuStrip_Main3.RadiusStyle = CCWin.SkinClass.RoundStyle.All;
            this.skinMenuStrip_Main3.Size = new System.Drawing.Size(636, 50);
            this.skinMenuStrip_Main3.SkinAllColor = true;
            this.skinMenuStrip_Main3.TabIndex = 1;
            this.skinMenuStrip_Main3.Text = "skinMenuStrip_Main3";
            this.skinMenuStrip_Main3.TitleAnamorphosis = true;
            this.skinMenuStrip_Main3.TitleColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(228)))), ((int)(((byte)(236)))));
            this.skinMenuStrip_Main3.TitleRadius = 4;
            this.skinMenuStrip_Main3.TitleRadiusStyle = CCWin.SkinClass.RoundStyle.All;
            // 
            // 消息ToolStripMenuItem
            // 
            this.消息ToolStripMenuItem.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.消息ToolStripMenuItem.Name = "消息ToolStripMenuItem";
            this.消息ToolStripMenuItem.Size = new System.Drawing.Size(202, 46);
            this.消息ToolStripMenuItem.Text = "     消息     ";
            this.消息ToolStripMenuItem.Click += new System.EventHandler(this.消息ToolStripMenuItem_Click);
            // 
            // 好友ToolStripMenuItem
            // 
            this.好友ToolStripMenuItem.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.好友ToolStripMenuItem.Name = "好友ToolStripMenuItem";
            this.好友ToolStripMenuItem.Size = new System.Drawing.Size(172, 46);
            this.好友ToolStripMenuItem.Text = "     好友  ";
            this.好友ToolStripMenuItem.Click += new System.EventHandler(this.好友ToolStripMenuItem_Click);
            // 
            // 新的好友ToolStripMenuItem
            // 
            this.新的好友ToolStripMenuItem.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.新的好友ToolStripMenuItem.Name = "新的好友ToolStripMenuItem";
            this.新的好友ToolStripMenuItem.Size = new System.Drawing.Size(246, 46);
            this.新的好友ToolStripMenuItem.Text = "   新的好友     ";
            this.新的好友ToolStripMenuItem.Click += new System.EventHandler(this.新的好友ToolStripMenuItem_Click);
            // 
            // skinPanel_Top
            // 
            this.skinPanel_Top.BackColor = System.Drawing.Color.Turquoise;
            this.skinPanel_Top.Controls.Add(this.skinWaterTextBox_search);
            this.skinPanel_Top.Controls.Add(this.lab_signature);
            this.skinPanel_Top.Controls.Add(this.skinPictureBox_head);
            this.skinPanel_Top.Controls.Add(this.lab_Name);
            this.skinPanel_Top.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinPanel_Top.DownBack = null;
            this.skinPanel_Top.Location = new System.Drawing.Point(0, 4);
            this.skinPanel_Top.Margin = new System.Windows.Forms.Padding(4);
            this.skinPanel_Top.MouseBack = null;
            this.skinPanel_Top.Name = "skinPanel_Top";
            this.skinPanel_Top.NormlBack = null;
            this.skinPanel_Top.Size = new System.Drawing.Size(620, 244);
            this.skinPanel_Top.TabIndex = 0;
            // 
            // skinWaterTextBox_search
            // 
            this.skinWaterTextBox_search.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.skinWaterTextBox_search.Location = new System.Drawing.Point(24, 200);
            this.skinWaterTextBox_search.Margin = new System.Windows.Forms.Padding(4);
            this.skinWaterTextBox_search.MaxLength = 20;
            this.skinWaterTextBox_search.Name = "skinWaterTextBox_search";
            this.skinWaterTextBox_search.ReadOnly = true;
            this.skinWaterTextBox_search.Size = new System.Drawing.Size(572, 28);
            this.skinWaterTextBox_search.TabIndex = 3;
            this.skinWaterTextBox_search.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.skinWaterTextBox_search.WaterText = "联系人";
            // 
            // lab_signature
            // 
            this.lab_signature.AutoSize = true;
            this.lab_signature.Font = new System.Drawing.Font("华文新魏", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lab_signature.Location = new System.Drawing.Point(210, 120);
            this.lab_signature.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lab_signature.Name = "lab_signature";
            this.lab_signature.Size = new System.Drawing.Size(288, 27);
            this.lab_signature.TabIndex = 2;
            this.lab_signature.Text = "The Main Of My family";
            // 
            // skinPictureBox_head
            // 
            this.skinPictureBox_head.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.skinPictureBox_head.BackColor = System.Drawing.Color.Transparent;
            this.skinPictureBox_head.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.skinPictureBox_head.ContextMenuStrip = this.contextMenuStrip_HeadPhoto;
            this.skinPictureBox_head.Image = global::SocketSoftware.Properties.Resources._2;
            this.skinPictureBox_head.Location = new System.Drawing.Point(24, 42);
            this.skinPictureBox_head.Margin = new System.Windows.Forms.Padding(0);
            this.skinPictureBox_head.Name = "skinPictureBox_head";
            this.skinPictureBox_head.Size = new System.Drawing.Size(154, 132);
            this.skinPictureBox_head.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.skinPictureBox_head.TabIndex = 1;
            this.skinPictureBox_head.TabStop = false;
            // 
            // contextMenuStrip_HeadPhoto
            // 
            this.contextMenuStrip_HeadPhoto.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.contextMenuStrip_HeadPhoto.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.编辑个人资料ToolStripMenuItem,
            this.更改头像ToolStripMenuItem});
            this.contextMenuStrip_HeadPhoto.Name = "contextMenuStrip_HeadPhoto";
            this.contextMenuStrip_HeadPhoto.Size = new System.Drawing.Size(233, 80);
            // 
            // 编辑个人资料ToolStripMenuItem
            // 
            this.编辑个人资料ToolStripMenuItem.Name = "编辑个人资料ToolStripMenuItem";
            this.编辑个人资料ToolStripMenuItem.Size = new System.Drawing.Size(232, 38);
            this.编辑个人资料ToolStripMenuItem.Text = "编辑个人资料";
            this.编辑个人资料ToolStripMenuItem.Click += new System.EventHandler(this.编辑个人资料ToolStripMenuItem_Click);
            // 
            // 更改头像ToolStripMenuItem
            // 
            this.更改头像ToolStripMenuItem.Name = "更改头像ToolStripMenuItem";
            this.更改头像ToolStripMenuItem.Size = new System.Drawing.Size(232, 38);
            this.更改头像ToolStripMenuItem.Text = "更改头像";
            this.更改头像ToolStripMenuItem.Click += new System.EventHandler(this.更改头像ToolStripMenuItem_Click);
            // 
            // lab_Name
            // 
            this.lab_Name.AutoSize = true;
            this.lab_Name.Font = new System.Drawing.Font("宋体", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lab_Name.Location = new System.Drawing.Point(208, 52);
            this.lab_Name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lab_Name.Name = "lab_Name";
            this.lab_Name.Size = new System.Drawing.Size(177, 37);
            this.lab_Name.TabIndex = 0;
            this.lab_Name.Text = "Real_Dad";
            // 
            // timZoom
            // 
            this.timZoom.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // skinContextMenuStrip_newFriends
            // 
            this.skinContextMenuStrip_newFriends.Arrow = System.Drawing.Color.Black;
            this.skinContextMenuStrip_newFriends.Back = System.Drawing.Color.White;
            this.skinContextMenuStrip_newFriends.BackRadius = 4;
            this.skinContextMenuStrip_newFriends.Base = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(200)))), ((int)(((byte)(254)))));
            this.skinContextMenuStrip_newFriends.DropDownImageSeparator = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.skinContextMenuStrip_newFriends.Fore = System.Drawing.Color.Black;
            this.skinContextMenuStrip_newFriends.HoverFore = System.Drawing.Color.White;
            this.skinContextMenuStrip_newFriends.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.skinContextMenuStrip_newFriends.ItemAnamorphosis = true;
            this.skinContextMenuStrip_newFriends.ItemBorder = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.skinContextMenuStrip_newFriends.ItemBorderShow = true;
            this.skinContextMenuStrip_newFriends.ItemHover = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.skinContextMenuStrip_newFriends.ItemPressed = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.skinContextMenuStrip_newFriends.ItemRadius = 4;
            this.skinContextMenuStrip_newFriends.ItemRadiusStyle = CCWin.SkinClass.RoundStyle.All;
            this.skinContextMenuStrip_newFriends.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.移动到好友ToolStripMenuItem,
            this.删除该提示ToolStripMenuItem});
            this.skinContextMenuStrip_newFriends.ItemSplitter = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.skinContextMenuStrip_newFriends.Name = "skinContextMenuStrip_newFriends";
            this.skinContextMenuStrip_newFriends.RadiusStyle = CCWin.SkinClass.RoundStyle.All;
            this.skinContextMenuStrip_newFriends.Size = new System.Drawing.Size(209, 80);
            this.skinContextMenuStrip_newFriends.SkinAllColor = true;
            this.skinContextMenuStrip_newFriends.TitleAnamorphosis = true;
            this.skinContextMenuStrip_newFriends.TitleColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(228)))), ((int)(((byte)(236)))));
            this.skinContextMenuStrip_newFriends.TitleRadius = 4;
            this.skinContextMenuStrip_newFriends.TitleRadiusStyle = CCWin.SkinClass.RoundStyle.All;
            // 
            // 移动到好友ToolStripMenuItem
            // 
            this.移动到好友ToolStripMenuItem.Name = "移动到好友ToolStripMenuItem";
            this.移动到好友ToolStripMenuItem.Size = new System.Drawing.Size(208, 38);
            this.移动到好友ToolStripMenuItem.Text = "移动到好友";
            // 
            // 删除该提示ToolStripMenuItem
            // 
            this.删除该提示ToolStripMenuItem.Name = "删除该提示ToolStripMenuItem";
            this.删除该提示ToolStripMenuItem.Size = new System.Drawing.Size(208, 38);
            this.删除该提示ToolStripMenuItem.Text = "删除该提示";
            // 
            // InfoList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 1022);
            this.Controls.Add(this.toolStripContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "InfoList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dao_QQ";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.InfoList_FormClosed);
            this.Load += new System.EventHandler(this.InfoList_Load);
            this.Move += new System.EventHandler(this.InfoList_Move);
            this.toolStripContainer1.BottomToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.BottomToolStripPanel.PerformLayout();
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.skinPanel_Middle.ResumeLayout(false);
            this.skinPanel_Middle.PerformLayout();
            this.skinPanel_list.ResumeLayout(false);
            this.skinMenuStrip_Main3.ResumeLayout(false);
            this.skinMenuStrip_Main3.PerformLayout();
            this.skinPanel_Top.ResumeLayout(false);
            this.skinPanel_Top.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.skinPictureBox_head)).EndInit();
            this.contextMenuStrip_HeadPhoto.ResumeLayout(false);
            this.skinContextMenuStrip_newFriends.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton_AddFriends;
        private CCWin.SkinControl.SkinPanel skinPanel_Top;
        private CCWin.SkinControl.SkinPictureBox skinPictureBox_head;
        private System.Windows.Forms.ToolStripMenuItem 消息ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 好友ToolStripMenuItem;
        private CCWin.SkinControl.SkinPanel skinPanel_Middle;
        private System.Windows.Forms.ToolStripButton toolStripButton_list;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip_HeadPhoto;
        private System.Windows.Forms.ToolStripMenuItem 编辑个人资料ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 更改头像ToolStripMenuItem;
        private CCWin.SkinControl.SkinWaterTextBox skinWaterTextBox_search;
        protected internal System.Windows.Forms.Label lab_Name;
        protected internal System.Windows.Forms.Label lab_signature;
        private CCWin.SkinControl.SkinMenuStrip skinMenuStrip_Main3;
        private System.Windows.Forms.ToolStripMenuItem 新的好友ToolStripMenuItem;
        private System.Windows.Forms.Timer timZoom;
        private CCWin.SkinControl.SkinPanel skinPanel_list;
        private CCWin.SkinControl.SkinButton skinButton_shiftId;
        private CCWin.SkinControl.SkinButton skinButton_help;
        private CCWin.SkinControl.SkinButton skinButton_set;
        public CCWin.SkinControl.ChatListBox chatListBox_newFriends;
        private CCWin.SkinControl.SkinContextMenuStrip skinContextMenuStrip_newFriends;
        private System.Windows.Forms.ToolStripMenuItem 移动到好友ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 删除该提示ToolStripMenuItem;
        public CCWin.SkinControl.ChatListBox chatListBox_Friend;
        public CCWin.SkinControl.ChatListBox chatListBox_Message;
    }
}