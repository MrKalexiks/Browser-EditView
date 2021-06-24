
namespace Browser_EditView
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ToolsAndTabs = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.NewTabButton = new System.Windows.Forms.Button();
            this.RefreshPageButton = new System.Windows.Forms.Button();
            this.RightButton = new System.Windows.Forms.Button();
            this.LeftButton = new System.Windows.Forms.Button();
            this.OpenedTabs = new System.Windows.Forms.ListBox();
            this.webControl1 = new Awesomium.Windows.Forms.WebControl(this.components);
            this.ToolsAndTabs.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ToolsAndTabs
            // 
            this.ToolsAndTabs.Controls.Add(this.tabControl1);
            this.ToolsAndTabs.Controls.Add(this.panel1);
            this.ToolsAndTabs.Dock = System.Windows.Forms.DockStyle.Left;
            this.ToolsAndTabs.Location = new System.Drawing.Point(0, 0);
            this.ToolsAndTabs.Name = "ToolsAndTabs";
            this.ToolsAndTabs.Size = new System.Drawing.Size(147, 450);
            this.ToolsAndTabs.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 38);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(147, 412);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.OpenedTabs);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(139, 386);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Openend tabs";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(139, 386);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Bookmarks";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.NewTabButton);
            this.panel1.Controls.Add(this.RefreshPageButton);
            this.panel1.Controls.Add(this.RightButton);
            this.panel1.Controls.Add(this.LeftButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(147, 38);
            this.panel1.TabIndex = 0;
            // 
            // NewTabButton
            // 
            this.NewTabButton.BackgroundImage = global::EditView.Browser.App.Properties.Resources.icons8_plus_math_2048px;
            this.NewTabButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.NewTabButton.FlatAppearance.BorderSize = 0;
            this.NewTabButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NewTabButton.Location = new System.Drawing.Point(108, 2);
            this.NewTabButton.Name = "NewTabButton";
            this.NewTabButton.Size = new System.Drawing.Size(32, 35);
            this.NewTabButton.TabIndex = 3;
            this.NewTabButton.UseVisualStyleBackColor = true;
            this.NewTabButton.Click += new System.EventHandler(this.NewTabButton_Click);
            // 
            // RefreshPageButton
            // 
            this.RefreshPageButton.BackgroundImage = global::EditView.Browser.App.Properties.Resources.icons8_restart_2048px;
            this.RefreshPageButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.RefreshPageButton.FlatAppearance.BorderSize = 0;
            this.RefreshPageButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RefreshPageButton.Location = new System.Drawing.Point(73, 2);
            this.RefreshPageButton.Name = "RefreshPageButton";
            this.RefreshPageButton.Size = new System.Drawing.Size(34, 35);
            this.RefreshPageButton.TabIndex = 2;
            this.RefreshPageButton.UseVisualStyleBackColor = true;
            // 
            // RightButton
            // 
            this.RightButton.BackgroundImage = global::EditView.Browser.App.Properties.Resources.icons8_forward_2048px;
            this.RightButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.RightButton.FlatAppearance.BorderSize = 0;
            this.RightButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RightButton.Location = new System.Drawing.Point(37, 2);
            this.RightButton.Name = "RightButton";
            this.RightButton.Size = new System.Drawing.Size(34, 35);
            this.RightButton.TabIndex = 1;
            this.RightButton.UseVisualStyleBackColor = true;
            // 
            // LeftButton
            // 
            this.LeftButton.BackgroundImage = global::EditView.Browser.App.Properties.Resources.icons8_back_2048px;
            this.LeftButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.LeftButton.FlatAppearance.BorderSize = 0;
            this.LeftButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LeftButton.Location = new System.Drawing.Point(5, 2);
            this.LeftButton.Name = "LeftButton";
            this.LeftButton.Size = new System.Drawing.Size(34, 35);
            this.LeftButton.TabIndex = 0;
            this.LeftButton.UseVisualStyleBackColor = true;
            // 
            // OpenedTabs
            // 
            this.OpenedTabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OpenedTabs.FormattingEnabled = true;
            this.OpenedTabs.Location = new System.Drawing.Point(3, 3);
            this.OpenedTabs.Name = "OpenedTabs";
            this.OpenedTabs.Size = new System.Drawing.Size(133, 380);
            this.OpenedTabs.TabIndex = 0;
            this.OpenedTabs.SelectedIndexChanged += new System.EventHandler(this.OpenedTabs_SelectedIndexChanged);
            // 
            // webControl1
            // 
            this.webControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webControl1.Location = new System.Drawing.Point(147, 0);
            this.webControl1.Size = new System.Drawing.Size(653, 450);
            this.webControl1.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.webControl1);
            this.Controls.Add(this.ToolsAndTabs);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Browser EditView";
            this.ToolsAndTabs.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel ToolsAndTabs;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button LeftButton;
        private System.Windows.Forms.Button RightButton;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button NewTabButton;
        private System.Windows.Forms.Button RefreshPageButton;
        private System.Windows.Forms.ListBox OpenedTabs;
        private Awesomium.Windows.Forms.WebControl webControl1;
    }
}

