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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainPage));
            btnUpdateAll = new Button();
            btnUpdateSelected = new Button();
            SuspendLayout();
            // 
            // btnUpdateAll
            // 
            resources.ApplyResources(btnUpdateAll, "btnUpdateAll");
            btnUpdateAll.Name = "btnUpdateAll";
            btnUpdateAll.UseVisualStyleBackColor = true;
            btnUpdateAll.Click += btnUpdateAll_Click;
            // 
            // btnUpdateSelected
            // 
            resources.ApplyResources(btnUpdateSelected, "btnUpdateSelected");
            btnUpdateSelected.Name = "btnUpdateSelected";
            btnUpdateSelected.UseVisualStyleBackColor = true;
            btnUpdateSelected.Click += btnUpdateSelected_Click;
            // 
            // MainPage
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnUpdateSelected);
            Controls.Add(btnUpdateAll);
            Name = "MainPage";
            ResumeLayout(false);
        }

        #endregion

        private Button btnUpdateAll;
        private Button btnUpdateSelected;
    }
}