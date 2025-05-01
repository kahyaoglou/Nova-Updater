namespace Nova_Updater.Forms
{
    partial class UpdateAllApps
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateAllApps));
            btnUpdateAll = new Button();
            btnBack = new PictureBox();
            btnClose = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)btnBack).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnClose).BeginInit();
            SuspendLayout();
            // 
            // btnUpdateAll
            // 
            btnUpdateAll.FlatStyle = FlatStyle.Flat;
            btnUpdateAll.ImeMode = ImeMode.NoControl;
            btnUpdateAll.Location = new Point(12, 413);
            btnUpdateAll.Name = "btnUpdateAll";
            btnUpdateAll.Size = new Size(426, 25);
            btnUpdateAll.TabIndex = 1;
            btnUpdateAll.Text = "Bütün Uygulamaları Güncelle";
            btnUpdateAll.UseVisualStyleBackColor = true;
            btnUpdateAll.Click += btnUpdateAll_Click;
            // 
            // btnBack
            // 
            btnBack.Cursor = Cursors.Hand;
            btnBack.Image = Properties.Resources.back;
            btnBack.ImeMode = ImeMode.NoControl;
            btnBack.Location = new Point(362, 12);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(35, 35);
            btnBack.SizeMode = PictureBoxSizeMode.StretchImage;
            btnBack.TabIndex = 5;
            btnBack.TabStop = false;
            btnBack.Click += btnBack_Click;
            // 
            // btnClose
            // 
            btnClose.Cursor = Cursors.Hand;
            btnClose.Image = Properties.Resources.close;
            btnClose.ImeMode = ImeMode.NoControl;
            btnClose.Location = new Point(403, 12);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(35, 35);
            btnClose.SizeMode = PictureBoxSizeMode.StretchImage;
            btnClose.TabIndex = 4;
            btnClose.TabStop = false;
            btnClose.Click += btnClose_Click;
            // 
            // UpdateAllApps
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(450, 450);
            Controls.Add(btnBack);
            Controls.Add(btnClose);
            Controls.Add(btnUpdateAll);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "UpdateAllApps";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UpdateAllApps";
            Load += UpdateAllApps_Load;
            ((System.ComponentModel.ISupportInitialize)btnBack).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnClose).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnUpdateAll;
        private PictureBox btnBack;
        private PictureBox btnClose;
    }
}