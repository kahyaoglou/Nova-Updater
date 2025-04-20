namespace Winget_Updater
{
    partial class MainPage
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainPage));
            btnUpdateAll = new Button();
            btnUpdateSelected = new Button();
            btnClose = new PictureBox();
            btnToggleDarkMode = new PictureBox();
            pictureBox1 = new PictureBox();
            toolTipInfo = new ToolTip(components);
            btnInfo = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)btnClose).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnToggleDarkMode).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnInfo).BeginInit();
            SuspendLayout();
            // 
            // btnUpdateAll
            // 
            resources.ApplyResources(btnUpdateAll, "btnUpdateAll");
            btnUpdateAll.Name = "btnUpdateAll";
            toolTipInfo.SetToolTip(btnUpdateAll, resources.GetString("btnUpdateAll.ToolTip"));
            btnUpdateAll.UseVisualStyleBackColor = true;
            btnUpdateAll.Click += btnUpdateAll_Click;
            // 
            // btnUpdateSelected
            // 
            resources.ApplyResources(btnUpdateSelected, "btnUpdateSelected");
            btnUpdateSelected.Name = "btnUpdateSelected";
            toolTipInfo.SetToolTip(btnUpdateSelected, resources.GetString("btnUpdateSelected.ToolTip"));
            btnUpdateSelected.UseVisualStyleBackColor = true;
            btnUpdateSelected.Click += btnUpdateSelected_Click;
            // 
            // btnClose
            // 
            resources.ApplyResources(btnClose, "btnClose");
            btnClose.Cursor = Cursors.Hand;
            btnClose.Image = Properties.Resources.close;
            btnClose.Name = "btnClose";
            btnClose.TabStop = false;
            toolTipInfo.SetToolTip(btnClose, resources.GetString("btnClose.ToolTip"));
            btnClose.Click += btnClose_Click;
            // 
            // btnToggleDarkMode
            // 
            resources.ApplyResources(btnToggleDarkMode, "btnToggleDarkMode");
            btnToggleDarkMode.Cursor = Cursors.Hand;
            btnToggleDarkMode.Name = "btnToggleDarkMode";
            btnToggleDarkMode.TabStop = false;
            toolTipInfo.SetToolTip(btnToggleDarkMode, resources.GetString("btnToggleDarkMode.ToolTip"));
            btnToggleDarkMode.Click += btnToggleDarkMode_Click;
            // 
            // pictureBox1
            // 
            resources.ApplyResources(pictureBox1, "pictureBox1");
            pictureBox1.Image = Properties.Resources.Winget_Updater;
            pictureBox1.Name = "pictureBox1";
            pictureBox1.TabStop = false;
            toolTipInfo.SetToolTip(pictureBox1, resources.GetString("pictureBox1.ToolTip"));
            // 
            // toolTipInfo
            // 
            toolTipInfo.AutomaticDelay = 0;
            toolTipInfo.BackColor = Color.LightYellow;
            toolTipInfo.IsBalloon = true;
            toolTipInfo.Tag = "";
            toolTipInfo.ToolTipIcon = ToolTipIcon.Info;
            toolTipInfo.ToolTipTitle = "Winget Updater © 2025";
            // 
            // btnInfo
            // 
            resources.ApplyResources(btnInfo, "btnInfo");
            btnInfo.Cursor = Cursors.Hand;
            btnInfo.Image = Properties.Resources.info;
            btnInfo.Name = "btnInfo";
            btnInfo.TabStop = false;
            toolTipInfo.SetToolTip(btnInfo, resources.GetString("btnInfo.ToolTip"));
            // 
            // MainPage
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.EnablePreventFocusChange;
            Controls.Add(btnInfo);
            Controls.Add(pictureBox1);
            Controls.Add(btnToggleDarkMode);
            Controls.Add(btnClose);
            Controls.Add(btnUpdateSelected);
            Controls.Add(btnUpdateAll);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MainPage";
            toolTipInfo.SetToolTip(this, resources.GetString("$this.ToolTip"));
            Load += MainPage_Load;
            ((System.ComponentModel.ISupportInitialize)btnClose).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnToggleDarkMode).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnInfo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnUpdateAll;
        private Button btnUpdateSelected;
        private PictureBox btnClose;
        private PictureBox btnToggleDarkMode;
        private PictureBox pictureBox1;
        private ToolTip toolTipInfo;
        private PictureBox btnInfo;
    }
}