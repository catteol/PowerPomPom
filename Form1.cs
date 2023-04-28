using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;
using Newtonsoft.Json;


namespace PowerPomPom
{
    public partial class Form1 : Form
    {
        private readonly int[] fpsArray = new int[] { 30, 60, 90, 120 };

        private string RegGraphicSettingsKeyName = null;
        private GraphicSettings graphicSettings = new GraphicSettings();
        private bool isFirstLog = true;
        private int currentFps = 0;

        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            var ver = Assembly.GetEntryAssembly().GetName().Version;
            this.Text = $"{this.Text} v{ver.Major}.{ver.Minor}.{ver.Build}";

            // Search Registry entry
            RegistryKey rootKey = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\Cognosphere\Star Rail");
            if (rootKey == null)
            {
                while (rootKey == null)
                {
                    DialogResult result = ShowRegNotFoundDialog();
                    if (result == DialogResult.Cancel)
                    {
                        Application.Exit();
                        return;
                    }
                }
            }
            else
            {
                RegGraphicSettingsKeyName = Array.Find(rootKey.GetValueNames(), delegate (string name) { return name.ToLower().StartsWith("graphicssettings_model"); });
                if (RegGraphicSettingsKeyName == null)
                {
                    while (RegGraphicSettingsKeyName == null)
                    {
                        DialogResult result = ShowRegNotFoundDialog();
                        if (result == DialogResult.Cancel)
                        {
                            Application.Exit();
                            return;
                        }

                    }
                }

                var regValueBytes = (byte[])rootKey.GetValue(RegGraphicSettingsKeyName);
                var regValueStr = System.Text.Encoding.ASCII.GetString(regValueBytes);
                graphicSettings = JsonConvert.DeserializeObject<GraphicSettings>(regValueStr);

            }
            WriteLog("Loaded configuration values from registry.");

            // Set FPS slider to current value
            currentFps = FPSBar.Value = Array.IndexOf(fpsArray, graphicSettings.FPS);
            WriteLog($"Current FPS is {graphicSettings.FPS}.");

            WriteLog("Successfully launched.");
        }

        private void FPSBar_Scroll(object sender, EventArgs e)
        {
            if (currentFps != FPSBar.Value)
            {
                currentFps = FPSBar.Value;
                graphicSettings.FPS = fpsArray[currentFps];

                // Write to Registry
                var settingsJson = JsonConvert.SerializeObject(graphicSettings);
                byte[] settingsBytes = Encoding.ASCII.GetBytes(settingsJson + "\0");

                RegistryKey rootKey = Registry.CurrentUser.OpenSubKey($@"SOFTWARE\Cognosphere\Star Rail", true);
                rootKey.SetValue($"{RegGraphicSettingsKeyName}", settingsBytes, RegistryValueKind.Binary);

                WriteLog($"Change FPS to {fpsArray[FPSBar.Value]}");
            }
        }

        private void WriteLog(string log)
        {
            LogTextbox.SelectionStart = LogTextbox.Text.Length;
            LogTextbox.SelectionLength = 0;
            LogTextbox.SelectedText = isFirstLog ? $"{System.DateTime.Now}: {log}" : $"\n{System.DateTime.Now}: {log}";
            isFirstLog = false;
            LogTextbox.ScrollToCaret();
        }

        private DialogResult ShowRegNotFoundDialog()
        {
            return MessageBox.Show("Registry key is not found.\nLaunch the game once and try again.", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
        }

        private class GraphicSettings
        {
            public int FPS { get; set; }
            public bool EnableVSync { get; set; }
            public float RenderScale { get; set; }
            public int ResolutionQuality { get; set; }
            public int ShadowQuality { get; set; }
            public int LightQuality { get; set; }
            public int CharacterQuality { get; set; }
            public int EnvDetailQuality { get; set; }
            public int ReflectionQuality { get; set; }
            public int BloomQuality { get; set; }
            public int AAMode { get; set; }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
