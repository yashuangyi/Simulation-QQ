namespace SocketSoftware
{
    partial class AddFriends
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddFriends));
            this.skinPanel1 = new CCWin.SkinControl.SkinPanel();
            this.skinWaterTextBox_search = new CCWin.SkinControl.SkinWaterTextBox();
            this.skinPictureBox_search = new CCWin.SkinControl.SkinPictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Lab_NoSearchMention = new System.Windows.Forms.Label();
            this.skinFlowLayoutPanel_SearchList = new CCWin.SkinControl.SkinFlowLayoutPanel();
            this.Lab_mention = new System.Windows.Forms.Label();
            this.skinPanel_single = new CCWin.SkinControl.SkinPanel();
            this.Bu_Add = new CCWin.SkinControl.SkinButton();
            this.skinWaterTextBox_AllInfo = new CCWin.SkinControl.SkinWaterTextBox();
            this.skinPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.skinPictureBox_search)).BeginInit();
            this.skinFlowLayoutPanel_SearchList.SuspendLayout();
            this.skinPanel_single.SuspendLayout();
            this.SuspendLayout();
            // 
            // skinPanel1
            // 
            this.skinPanel1.BackColor = System.Drawing.Color.Transparent;
            this.skinPanel1.Controls.Add(this.skinWaterTextBox_search);
            this.skinPanel1.Controls.Add(this.skinPictureBox_search);
            this.skinPanel1.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinPanel1.DownBack = null;
            this.skinPanel1.Location = new System.Drawing.Point(68, 152);
            this.skinPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.skinPanel1.MouseBack = null;
            this.skinPanel1.Name = "skinPanel1";
            this.skinPanel1.NormlBack = null;
            this.skinPanel1.Size = new System.Drawing.Size(982, 94);
            this.skinPanel1.TabIndex = 2;
            // 
            // skinWaterTextBox_search
            // 
            this.skinWaterTextBox_search.Font = new System.Drawing.Font("宋体", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinWaterTextBox_search.Location = new System.Drawing.Point(24, 16);
            this.skinWaterTextBox_search.Margin = new System.Windows.Forms.Padding(4);
            this.skinWaterTextBox_search.Name = "skinWaterTextBox_search";
            this.skinWaterTextBox_search.Size = new System.Drawing.Size(852, 57);
            this.skinWaterTextBox_search.TabIndex = 6;
            this.skinWaterTextBox_search.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.skinWaterTextBox_search.WaterText = "在这里输入要添加的账号";
            this.skinWaterTextBox_search.Click += new System.EventHandler(this.SkinWaterTextBox1_Click);
            // 
            // skinPictureBox_search
            // 
            this.skinPictureBox_search.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.skinPictureBox_search.BackColor = System.Drawing.Color.Transparent;
            this.skinPictureBox_search.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.skinPictureBox_search.Image = global::SocketSoftware.Properties.Resources.search;
            this.skinPictureBox_search.Location = new System.Drawing.Point(904, 16);
            this.skinPictureBox_search.Margin = new System.Windows.Forms.Padding(4);
            this.skinPictureBox_search.Name = "skinPictureBox_search";
            this.skinPictureBox_search.Size = new System.Drawing.Size(56, 56);
            this.skinPictureBox_search.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.skinPictureBox_search.TabIndex = 1;
            this.skinPictureBox_search.TabStop = false;
            this.skinPictureBox_search.Click += new System.EventHandler(this.SkinPictureBox_search_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("华文新魏", 19.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.BlueViolet;
            this.label1.Location = new System.Drawing.Point(24, 58);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(293, 54);
            this.label1.TabIndex = 3;
            this.label1.Text = "添加好友：";
            // 
            // Lab_NoSearchMention
            // 
            this.Lab_NoSearchMention.AutoSize = true;
            this.Lab_NoSearchMention.Font = new System.Drawing.Font("华文彩云", 19.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Lab_NoSearchMention.ForeColor = System.Drawing.Color.Red;
            this.Lab_NoSearchMention.Location = new System.Drawing.Point(184, 462);
            this.Lab_NoSearchMention.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lab_NoSearchMention.Name = "Lab_NoSearchMention";
            this.Lab_NoSearchMention.Size = new System.Drawing.Size(672, 55);
            this.Lab_NoSearchMention.TabIndex = 4;
            this.Lab_NoSearchMention.Text = "搜索失败！找不到该账号！";
            this.Lab_NoSearchMention.Visible = false;
            // 
            // skinFlowLayoutPanel_SearchList
            // 
            this.skinFlowLayoutPanel_SearchList.BackColor = System.Drawing.Color.SkyBlue;
            this.skinFlowLayoutPanel_SearchList.Controls.Add(this.Lab_mention);
            this.skinFlowLayoutPanel_SearchList.Controls.Add(this.skinPanel_single);
            this.skinFlowLayoutPanel_SearchList.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinFlowLayoutPanel_SearchList.DownBack = null;
            this.skinFlowLayoutPanel_SearchList.Location = new System.Drawing.Point(2, 268);
            this.skinFlowLayoutPanel_SearchList.Margin = new System.Windows.Forms.Padding(4);
            this.skinFlowLayoutPanel_SearchList.MouseBack = null;
            this.skinFlowLayoutPanel_SearchList.Name = "skinFlowLayoutPanel_SearchList";
            this.skinFlowLayoutPanel_SearchList.NormlBack = null;
            this.skinFlowLayoutPanel_SearchList.Size = new System.Drawing.Size(1073, 564);
            this.skinFlowLayoutPanel_SearchList.TabIndex = 5;
            this.skinFlowLayoutPanel_SearchList.Visible = false;
            // 
            // Lab_mention
            // 
            this.Lab_mention.AutoSize = true;
            this.Lab_mention.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Lab_mention.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Lab_mention.Location = new System.Drawing.Point(4, 0);
            this.Lab_mention.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lab_mention.Name = "Lab_mention";
            this.Lab_mention.Size = new System.Drawing.Size(670, 33);
            this.Lab_mention.TabIndex = 0;
            this.Lab_mention.Text = "以下是搜索结果：                       ";
            // 
            // skinPanel_single
            // 
            this.skinPanel_single.BackColor = System.Drawing.Color.White;
            this.skinPanel_single.Controls.Add(this.Bu_Add);
            this.skinPanel_single.Controls.Add(this.skinWaterTextBox_AllInfo);
            this.skinPanel_single.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinPanel_single.DownBack = null;
            this.skinPanel_single.Location = new System.Drawing.Point(4, 37);
            this.skinPanel_single.Margin = new System.Windows.Forms.Padding(4);
            this.skinPanel_single.MouseBack = null;
            this.skinPanel_single.Name = "skinPanel_single";
            this.skinPanel_single.NormlBack = null;
            this.skinPanel_single.Size = new System.Drawing.Size(549, 197);
            this.skinPanel_single.TabIndex = 1;
            // 
            // Bu_Add
            // 
            this.Bu_Add.BackColor = System.Drawing.Color.Transparent;
            this.Bu_Add.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Bu_Add.BorderColor = System.Drawing.Color.Aqua;
            this.Bu_Add.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.Bu_Add.DownBack = null;
            this.Bu_Add.Font = new System.Drawing.Font("楷体", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Bu_Add.Location = new System.Drawing.Point(419, 140);
            this.Bu_Add.Margin = new System.Windows.Forms.Padding(4);
            this.Bu_Add.MouseBack = null;
            this.Bu_Add.Name = "Bu_Add";
            this.Bu_Add.NormlBack = null;
            this.Bu_Add.Size = new System.Drawing.Size(112, 44);
            this.Bu_Add.TabIndex = 1;
            this.Bu_Add.Text = "添加";
            this.Bu_Add.UseVisualStyleBackColor = false;
            this.Bu_Add.Click += new System.EventHandler(this.Bu_Add_Click);
            // 
            // skinWaterTextBox_AllInfo
            // 
            this.skinWaterTextBox_AllInfo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.skinWaterTextBox_AllInfo.Font = new System.Drawing.Font("等线", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinWaterTextBox_AllInfo.Location = new System.Drawing.Point(27, 16);
            this.skinWaterTextBox_AllInfo.Margin = new System.Windows.Forms.Padding(4);
            this.skinWaterTextBox_AllInfo.Multiline = true;
            this.skinWaterTextBox_AllInfo.Name = "skinWaterTextBox_AllInfo";
            this.skinWaterTextBox_AllInfo.Size = new System.Drawing.Size(384, 168);
            this.skinWaterTextBox_AllInfo.TabIndex = 0;
            this.skinWaterTextBox_AllInfo.Text = "name:gigi\r\nage:20\r\naddress:广东";
            this.skinWaterTextBox_AllInfo.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.skinWaterTextBox_AllInfo.WaterText = "";
            // 
            // AddFriends
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1078, 836);
            this.Controls.Add(this.skinFlowLayoutPanel_SearchList);
            this.Controls.Add(this.Lab_NoSearchMention);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.skinPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AddFriends";
            this.Text = "添加好友";
            this.Load += new System.EventHandler(this.AddFriends_Load);
            this.skinPanel1.ResumeLayout(false);
            this.skinPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.skinPictureBox_search)).EndInit();
            this.skinFlowLayoutPanel_SearchList.ResumeLayout(false);
            this.skinFlowLayoutPanel_SearchList.PerformLayout();
            this.skinPanel_single.ResumeLayout(false);
            this.skinPanel_single.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private CCWin.SkinControl.SkinPictureBox skinPictureBox_search;
        private CCWin.SkinControl.SkinPanel skinPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Lab_NoSearchMention;
        private CCWin.SkinControl.SkinFlowLayoutPanel skinFlowLayoutPanel_SearchList;
        private System.Windows.Forms.Label Lab_mention;
        private CCWin.SkinControl.SkinPanel skinPanel_single;
        private CCWin.SkinControl.SkinWaterTextBox skinWaterTextBox_AllInfo;
        private CCWin.SkinControl.SkinButton Bu_Add;
        private CCWin.SkinControl.SkinWaterTextBox skinWaterTextBox_search;
    }
}