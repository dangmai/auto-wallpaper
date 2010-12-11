using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Win32;
using System.IO;
using System.Runtime.InteropServices;
using NLog;

namespace Auto_Wallpaper
{

    public partial class AutoWallpaperForm : Form
    {
        private static Logger logger = LogManager.GetCurrentClassLogger();
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        static extern int SystemParametersInfo(int uAction, int uParam, string lpvParam, int fuWinIni);

        public AutoWallpaperForm()
        {
            if (Properties.Settings.Default.upgradeRequired)
            {
                Properties.Settings.Default.Upgrade();
                Properties.Settings.Default.upgradeRequired = false;
                Properties.Settings.Default.Save();
            }

            logger.Info("AutoWallpaper Log");
            logger.Debug("Program started!");
            InitializeComponent();
            logger.Debug("GUI elements initialized");
            horizontalStyleCombo.SelectedIndex = 0;
            verticalStyleCombo.SelectedIndex = 0;
            if (Properties.Settings.Default.horizontalStyle == "0")
                horizontalStyleCombo.SelectedIndex = 0;
            else
                horizontalStyleCombo.SelectedIndex = 1;
            if (Properties.Settings.Default.verticalStyle == "0")
                verticalStyleCombo.SelectedIndex = 0;
            else
                verticalStyleCombo.SelectedIndex = 1;
            logger.Debug("HorizontalStyle and VerticalStyle set");

            if (Properties.Settings.Default.horizontalTile == "0")
                horizontalTile.Checked = false;
            else
                horizontalTile.Checked = true;
            if (Properties.Settings.Default.verticalTile == "0")
                verticalTile.Checked = false;
            else
                verticalTile.Checked = true;
            logger.Debug("HorizontalTile and VerticalTile set");

            horizontalTextBox.Text = Properties.Settings.Default.horizontalPath;
            verticalTextBox.Text = Properties.Settings.Default.verticalPath;
            autoStartBox.Checked = Properties.Settings.Default.autoStart;

            logger.Debug("Other elements set up from properties");
            SystemEvents.DisplaySettingsChanged += new EventHandler(SystemEvents_DisplaySettingsChanged);
            Application.ApplicationExit += new EventHandler(Application_ApplicationExit);            
        }


        public void SystemEvents_DisplaySettingsChanged(object sender, EventArgs e) 
        {
            if (this.Visible == false)
            {
                logger.Debug("Display Settings have changed!");
                int deskHeight = Screen.PrimaryScreen.Bounds.Height;
                logger.Debug("Current height is: " + deskHeight);
                int deskWidth = Screen.PrimaryScreen.Bounds.Width;
                logger.Debug("Current width is: " + deskWidth);
                if (deskWidth > deskHeight)
                {
                    if (File.Exists(Properties.Settings.Default.horizontalPath))
                        SetWallpaper(Properties.Settings.Default.horizontalPath, Properties.Settings.Default.horizontalStyle, Properties.Settings.Default.horizontalTile);
                    else
                    {
                        MessageBox.Show("The path to horizontal wallpaper is wrong!");
                        logger.Error("Path to horizontal wallpaper is wrong!");
                        this.Show();
                        return;
                    }
                }
                else
                {
                    if (File.Exists(Properties.Settings.Default.verticalPath))
                        SetWallpaper(Properties.Settings.Default.verticalPath, Properties.Settings.Default.verticalStyle, Properties.Settings.Default.verticalTile);
                    else
                    {
                        MessageBox.Show("The path to vertical wallpaper is wrong!");
                        logger.Error("Path to vertical wallpaper is wrong!");
                        this.Show();
                        return;
                    }
                }
            }
        }

        public void Application_ApplicationExit(object sender, EventArgs e)
        {
            logger.Debug("Application about to exit!");
            SystemEvents.DisplaySettingsChanged -= new EventHandler(SystemEvents_DisplaySettingsChanged);
        }

        private void doneButton_Click(object sender, EventArgs e)
        {
            logger.Debug("Done button clicked!");
            if (File.Exists(horizontalTextBox.Text))
            {
                Properties.Settings.Default.horizontalPath = horizontalTextBox.Text;
            }
            else
            {
                logger.Error("Wrong path for horizontal wallpaper");
                return;
            }
            if (File.Exists(verticalTextBox.Text))
            {
                Properties.Settings.Default.verticalPath = verticalTextBox.Text;
            }
            else
            {
                logger.Error("Wrong path for vertical wallpaper");
                return;
            }
            Properties.Settings.Default.autoStart = autoStartBox.Checked;

            string keyName = "Auto WallPaper";
            string assemblyLocation = "\"" + System.Reflection.Assembly.GetExecutingAssembly().Location + "\"";  // Or the EXE path.
            logger.Debug("Location to program is: " + System.Reflection.Assembly.GetExecutingAssembly().Location);

            if (autoStartBox.Checked == true)
            {
                SetAutoStart(keyName, assemblyLocation);
                logger.Debug("Set auto start for program done");
            }
            else
            {
                // Unset Auto-start.
                if (IsAutoStartEnabled(keyName, assemblyLocation))
                    UnSetAutoStart(keyName);
                logger.Debug("Unset auto start for program done");
            }
            if (horizontalStyleCombo.SelectedIndex == 0)
                Properties.Settings.Default.horizontalStyle = "0";
            else
                Properties.Settings.Default.horizontalStyle = "10";
            logger.Debug("Saved new horizontalStyle");
            
            if (verticalStyleCombo.SelectedIndex == 0)
                Properties.Settings.Default.verticalStyle = "0";
            else
                Properties.Settings.Default.verticalStyle = "10";
            logger.Debug("Saved new verticalStyle");

            if (horizontalTile.Checked == false)
                Properties.Settings.Default.horizontalTile = "0";
            else
                Properties.Settings.Default.horizontalTile = "1";
            logger.Debug("Saved new horizontalTile");

            if (verticalTile.Checked == false)
                Properties.Settings.Default.verticalTile = "0";
            else
                Properties.Settings.Default.verticalTile = "1";
            logger.Debug("Saved new verticalTile");

            Properties.Settings.Default.configured = true;
            logger.Debug("configured set to be True");

            Properties.Settings.Default.Save();
            logger.Debug("Settings persisted!");

            this.Hide();
            SystemEvents_DisplaySettingsChanged(null, null);
            logger.Debug("DisplaySettingsChanged called");
        }

        private void notifyIcon_MouseClick(object sender, MouseEventArgs e)
        {
            this.Show();
            logger.Debug("Tray icon was clicked");
        }

        private void horizontalBrowseButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                horizontalTextBox.Text = openFileDialog.FileName;
            }
            
        }

        private void verticalBrowseButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                verticalTextBox.Text = openFileDialog.FileName;
            }
        }

        private const string RUN_LOCATION = @"Software\Microsoft\Windows\CurrentVersion\Run";

        /// <summary>
        /// Sets the autostart value for the assembly.
        /// </summary>
        /// <param name="keyName">Registry Key Name</param>
        /// <param name="assemblyLocation">Assembly location (e.g. Assembly.GetExecutingAssembly().Location)</param>
        public static void SetAutoStart(string keyName, string assemblyLocation)
        {
            RegistryKey key = Registry.CurrentUser.CreateSubKey(RUN_LOCATION);
            key.SetValue(keyName, assemblyLocation);
        }

        /// <summary>
        /// Returns whether auto start is enabled.
        /// </summary>
        /// <param name="keyName">Registry Key Name</param>
        /// <param name="assemblyLocation">Assembly location (e.g. Assembly.GetExecutingAssembly().Location)</param>
        public static bool IsAutoStartEnabled(string keyName, string assemblyLocation)
        {
            RegistryKey key = Registry.CurrentUser.OpenSubKey(RUN_LOCATION);
            if (key == null)
                return false;

            string value = (string)key.GetValue(keyName);
            if (value == null)
                return false;

            return (value == assemblyLocation);
        }

        /// <summary>
        /// Unsets the autostart value for the assembly.
        /// </summary>
        /// <param name="keyName">Registry Key Name</param>
        public static void UnSetAutoStart(string keyName)
        {
            RegistryKey key = Registry.CurrentUser.CreateSubKey(RUN_LOCATION);
            key.DeleteValue(keyName);
        }

        
        private void SetWallpaper(string WallpaperLocation, string WallpaperStyle, string TileWallpaper)
        {
               // Set the wallpaper style to streched (can be changed to tile, center, maintain aspect ratio, etc.
               RegistryKey rkWallPaper = Registry.CurrentUser.OpenSubKey("Control Panel\\Desktop", true);

               // Sets the wallpaper style
               rkWallPaper.SetValue("WallpaperStyle", WallpaperStyle);

               // Whether or not this wallpaper will be displayed as a tile
               rkWallPaper.SetValue("TileWallpaper", TileWallpaper);
               rkWallPaper.Close();

               // Sets the actual wallpaper
               SystemParametersInfo(20, 0, WallpaperLocation, 0x01 | 0x02);
        }

        private void AutoWallpaperForm_Shown(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.configured == true)
            {
                this.Hide();
                SystemEvents_DisplaySettingsChanged(null, null);
                logger.Debug("Program was started and configured is True, DisplaySettingsChanged has run immediately");
            }
        }

        private void horizontalTile_CheckedChanged(object sender, EventArgs e)
        {
            if (horizontalTile.Checked == true)
            {
                horizontalStyleCombo.Enabled = false;
            }
            else
            {
                horizontalStyleCombo.Enabled = true;
            }
        }

        private void verticalTile_CheckedChanged(object sender, EventArgs e)
        {
            if (verticalTile.Checked == true)
            {
                verticalStyleCombo.Enabled = false;
            }
            else
            {
                verticalStyleCombo.Enabled = true;
            }
        }

    }
}
