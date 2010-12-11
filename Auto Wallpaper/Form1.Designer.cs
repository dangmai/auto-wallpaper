namespace Auto_Wallpaper
{
    partial class AutoWallpaperForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AutoWallpaperForm));
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.infoLabel1 = new System.Windows.Forms.Label();
            this.horizontalLabel = new System.Windows.Forms.Label();
            this.horizontalTextBox = new System.Windows.Forms.TextBox();
            this.horizontalBrowseButton = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.verticalLabel = new System.Windows.Forms.Label();
            this.verticalBrowseButton = new System.Windows.Forms.Button();
            this.doneButton = new System.Windows.Forms.Button();
            this.verticalTextBox = new System.Windows.Forms.TextBox();
            this.autoStartBox = new System.Windows.Forms.CheckBox();
            this.horizontalSyleLabel = new System.Windows.Forms.Label();
            this.horizontalStyleCombo = new System.Windows.Forms.ComboBox();
            this.horizontalTile = new System.Windows.Forms.CheckBox();
            this.verticalStyleLabel = new System.Windows.Forms.Label();
            this.verticalStyleCombo = new System.Windows.Forms.ComboBox();
            this.verticalTile = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // notifyIcon
            // 
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "notifyIcon1";
            this.notifyIcon.Visible = true;
            this.notifyIcon.MouseClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_MouseClick);
            // 
            // infoLabel1
            // 
            this.infoLabel1.AutoSize = true;
            this.infoLabel1.Location = new System.Drawing.Point(17, 15);
            this.infoLabel1.Name = "infoLabel1";
            this.infoLabel1.Size = new System.Drawing.Size(122, 13);
            this.infoLabel1.TabIndex = 0;
            this.infoLabel1.Text = "Choose your wallpapers:";
            // 
            // horizontalLabel
            // 
            this.horizontalLabel.AutoSize = true;
            this.horizontalLabel.Location = new System.Drawing.Point(17, 40);
            this.horizontalLabel.Name = "horizontalLabel";
            this.horizontalLabel.Size = new System.Drawing.Size(57, 13);
            this.horizontalLabel.TabIndex = 1;
            this.horizontalLabel.Text = "Horizontal:";
            // 
            // horizontalTextBox
            // 
            this.horizontalTextBox.Location = new System.Drawing.Point(20, 65);
            this.horizontalTextBox.Name = "horizontalTextBox";
            this.horizontalTextBox.Size = new System.Drawing.Size(168, 20);
            this.horizontalTextBox.TabIndex = 2;
            // 
            // horizontalBrowseButton
            // 
            this.horizontalBrowseButton.Location = new System.Drawing.Point(197, 65);
            this.horizontalBrowseButton.Name = "horizontalBrowseButton";
            this.horizontalBrowseButton.Size = new System.Drawing.Size(75, 23);
            this.horizontalBrowseButton.TabIndex = 3;
            this.horizontalBrowseButton.Text = "Browse";
            this.horizontalBrowseButton.UseVisualStyleBackColor = true;
            this.horizontalBrowseButton.Click += new System.EventHandler(this.horizontalBrowseButton_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "Images|*.jpg;*.jpeg;*.bmp;*.gif";
            // 
            // verticalLabel
            // 
            this.verticalLabel.AutoSize = true;
            this.verticalLabel.Location = new System.Drawing.Point(17, 130);
            this.verticalLabel.Name = "verticalLabel";
            this.verticalLabel.Size = new System.Drawing.Size(45, 13);
            this.verticalLabel.TabIndex = 4;
            this.verticalLabel.Text = "Vertical:";
            // 
            // verticalBrowseButton
            // 
            this.verticalBrowseButton.Location = new System.Drawing.Point(197, 153);
            this.verticalBrowseButton.Name = "verticalBrowseButton";
            this.verticalBrowseButton.Size = new System.Drawing.Size(75, 23);
            this.verticalBrowseButton.TabIndex = 5;
            this.verticalBrowseButton.Text = "Browse";
            this.verticalBrowseButton.UseVisualStyleBackColor = true;
            this.verticalBrowseButton.Click += new System.EventHandler(this.verticalBrowseButton_Click);
            // 
            // doneButton
            // 
            this.doneButton.Location = new System.Drawing.Point(198, 241);
            this.doneButton.Name = "doneButton";
            this.doneButton.Size = new System.Drawing.Size(75, 23);
            this.doneButton.TabIndex = 6;
            this.doneButton.Text = "Done";
            this.doneButton.UseVisualStyleBackColor = true;
            this.doneButton.Click += new System.EventHandler(this.doneButton_Click);
            // 
            // verticalTextBox
            // 
            this.verticalTextBox.Location = new System.Drawing.Point(20, 153);
            this.verticalTextBox.Name = "verticalTextBox";
            this.verticalTextBox.Size = new System.Drawing.Size(168, 20);
            this.verticalTextBox.TabIndex = 7;
            // 
            // autoStartBox
            // 
            this.autoStartBox.AutoSize = true;
            this.autoStartBox.Checked = true;
            this.autoStartBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.autoStartBox.Location = new System.Drawing.Point(21, 217);
            this.autoStartBox.Name = "autoStartBox";
            this.autoStartBox.Size = new System.Drawing.Size(117, 17);
            this.autoStartBox.TabIndex = 8;
            this.autoStartBox.Text = "Start with Windows";
            this.autoStartBox.UseVisualStyleBackColor = true;
            // 
            // horizontalSyleLabel
            // 
            this.horizontalSyleLabel.AutoSize = true;
            this.horizontalSyleLabel.Location = new System.Drawing.Point(17, 104);
            this.horizontalSyleLabel.Name = "horizontalSyleLabel";
            this.horizontalSyleLabel.Size = new System.Drawing.Size(33, 13);
            this.horizontalSyleLabel.TabIndex = 9;
            this.horizontalSyleLabel.Text = "Style:";
            // 
            // horizontalStyleCombo
            // 
            this.horizontalStyleCombo.FormattingEnabled = true;
            this.horizontalStyleCombo.Items.AddRange(new object[] {
            "Center",
            "Stretch"});
            this.horizontalStyleCombo.Location = new System.Drawing.Point(56, 101);
            this.horizontalStyleCombo.Name = "horizontalStyleCombo";
            this.horizontalStyleCombo.Size = new System.Drawing.Size(70, 21);
            this.horizontalStyleCombo.TabIndex = 10;
            // 
            // horizontalTile
            // 
            this.horizontalTile.AutoSize = true;
            this.horizontalTile.Location = new System.Drawing.Point(133, 105);
            this.horizontalTile.Name = "horizontalTile";
            this.horizontalTile.Size = new System.Drawing.Size(55, 17);
            this.horizontalTile.TabIndex = 11;
            this.horizontalTile.Text = "Tiled?";
            this.horizontalTile.UseVisualStyleBackColor = true;
            this.horizontalTile.CheckedChanged += new System.EventHandler(this.horizontalTile_CheckedChanged);
            // 
            // verticalStyleLabel
            // 
            this.verticalStyleLabel.AutoSize = true;
            this.verticalStyleLabel.Location = new System.Drawing.Point(18, 189);
            this.verticalStyleLabel.Name = "verticalStyleLabel";
            this.verticalStyleLabel.Size = new System.Drawing.Size(33, 13);
            this.verticalStyleLabel.TabIndex = 12;
            this.verticalStyleLabel.Text = "Style:";
            // 
            // verticalStyleCombo
            // 
            this.verticalStyleCombo.FormattingEnabled = true;
            this.verticalStyleCombo.Items.AddRange(new object[] {
            "Center",
            "Stretch"});
            this.verticalStyleCombo.Location = new System.Drawing.Point(57, 186);
            this.verticalStyleCombo.Name = "verticalStyleCombo";
            this.verticalStyleCombo.Size = new System.Drawing.Size(70, 21);
            this.verticalStyleCombo.TabIndex = 13;
            // 
            // verticalTile
            // 
            this.verticalTile.AutoSize = true;
            this.verticalTile.Location = new System.Drawing.Point(133, 188);
            this.verticalTile.Name = "verticalTile";
            this.verticalTile.Size = new System.Drawing.Size(55, 17);
            this.verticalTile.TabIndex = 14;
            this.verticalTile.Text = "Tiled?";
            this.verticalTile.UseVisualStyleBackColor = true;
            this.verticalTile.CheckedChanged += new System.EventHandler(this.verticalTile_CheckedChanged);
            // 
            // AutoWallpaperForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 284);
            this.Controls.Add(this.verticalTile);
            this.Controls.Add(this.verticalStyleCombo);
            this.Controls.Add(this.verticalStyleLabel);
            this.Controls.Add(this.horizontalTile);
            this.Controls.Add(this.horizontalStyleCombo);
            this.Controls.Add(this.horizontalSyleLabel);
            this.Controls.Add(this.autoStartBox);
            this.Controls.Add(this.verticalTextBox);
            this.Controls.Add(this.doneButton);
            this.Controls.Add(this.verticalBrowseButton);
            this.Controls.Add(this.verticalLabel);
            this.Controls.Add(this.horizontalBrowseButton);
            this.Controls.Add(this.horizontalTextBox);
            this.Controls.Add(this.horizontalLabel);
            this.Controls.Add(this.infoLabel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AutoWallpaperForm";
            this.Text = "Auto Wallpaper";
            this.Shown += new System.EventHandler(this.AutoWallpaperForm_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.Label infoLabel1;
        private System.Windows.Forms.Label horizontalLabel;
        private System.Windows.Forms.TextBox horizontalTextBox;
        private System.Windows.Forms.Button horizontalBrowseButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Label verticalLabel;
        private System.Windows.Forms.Button verticalBrowseButton;
        private System.Windows.Forms.Button doneButton;
        private System.Windows.Forms.TextBox verticalTextBox;
        private System.Windows.Forms.CheckBox autoStartBox;
        private System.Windows.Forms.Label horizontalSyleLabel;
        private System.Windows.Forms.ComboBox horizontalStyleCombo;
        private System.Windows.Forms.CheckBox horizontalTile;
        private System.Windows.Forms.Label verticalStyleLabel;
        private System.Windows.Forms.ComboBox verticalStyleCombo;
        private System.Windows.Forms.CheckBox verticalTile;
    }
}

