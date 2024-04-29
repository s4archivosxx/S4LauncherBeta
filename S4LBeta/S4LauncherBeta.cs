using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using System.Net;
using System.IO;

namespace S4LauncherBeta
{
    public partial class S4LauncherBeta : Form
    {
        Point FormPosition;
        Boolean mauseaction;
        private string _filename = "";
        private string _args = "";

        WebClient wc = new WebClient();
        IniFile ini = new IniFile("version.ini");

        public S4LauncherBeta()
        {
            InitializeComponent();
            ConfigIni();
        }

        private void ConfigIni()
        {
            if (!File.Exists("version.ini"))
            {
                ini.Write("Client", "", "LAUNCHER");
                ini.Write("Args", "", "LAUNCHER");
                ini.Write("IP1", "127.0.0.1", "SERVER");
                ini.Write("PORT1", "28002", "SERVER");
            }

            if (!ini.KeyExists("Client", "LAUNCHER") || !ini.KeyExists("Args", "LAUNCHER"))
            {
                ini.Write("Client", "", "LAUNCHER");
                ini.Write("Args", "", "LAUNCHER");
            }

            if (!ini.KeyExists("IP1", "SERVER") || !ini.KeyExists("PORT1", "SERVER"))
            {
                ini.Write("IP1", "127.0.0.1", "SERVER");
                ini.Write("PORT1", "28002", "SERVER");
            }

            _filename = ini.Read("Client", "LAUNCHER");
            _args = ini.Read("Args", "LAUNCHER");
        }

        private void Btnminimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void Bntexit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Btnstart_Click(object sender, EventArgs e)
        {
            Process p = new Process();
            p.StartInfo.FileName = _filename;
            p.StartInfo.Arguments = _args;
            p.Start();
            Environment.Exit(-1);
        }

        private void Btnregister_Click(object sender, EventArgs e)
        {
            //Process.Start("http://190.238.57.221/beta/");
        }

        private void S4LBeta_Load(object sender, EventArgs e)
        {
            //Uri Version = new Uri("http://190.238.57.221/Game/Patchs/Beta/version.ini");
            //wc.DownloadFileAsync(Version, "version.ini");
            ////updater.CheckForUpdates();
            lblversion.Text = "Versión del Launcher : \n" + Application.ProductVersion;
         }

        private void S4LBeta_MouseDown(object sender, MouseEventArgs e)
        {
            FormPosition = new Point(Cursor.Position.X - Location.X, Cursor.Position.Y - Location.Y);
            mauseaction = true;
        }

        private void S4LBeta_MouseMove(object sender, MouseEventArgs e)
        {
            if(mauseaction == true)
            {
                Location = new Point(Cursor.Position.X - FormPosition.X, Cursor.Position.Y - FormPosition.Y);
            }
        }

        private void S4LBeta_MouseUp(object sender, MouseEventArgs e)
        {
            mauseaction = false;
        }
    }
}
