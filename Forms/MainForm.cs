using MaterialSkin.Controls;
using NewFileTool.MainLogic;
using System;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace NewFileTool
{
    public partial class MainForm : MaterialForm
    {
        public HotKeyRegister GlobalHotKeys = null;

        public MainForm()
        {
            InitializeComponent();
        }

        private void CreateButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Filename.Text) || !Filename.Text.Contains('.') || Filename.Text.StartsWith("\\"))
            {
                StatusText.Text = "Input a valid file name including an extension!";
                Filename.Focus();
                return;
            }
            else if (Filename.Text.Contains("/"))
            {
                StatusText.Text = "Use the other slash -_-";
                Filename.Focus();
                return;
            }

            Process[] processes = Process.GetProcessesByName("explorer");

            if (processes.Length == 0)
                return;

            if (Filename.Text.Contains('>'))
            {
                var segments = Filename.Text.Trim().Split('>');
                var path = segments[0].Trim();
                var flags = segments[1].Trim();

                var Params = FlagParser.ParseFlags(flags);

                if (Params == null)
                {
                    StatusText.Text = "Invalid parameters!";
                    Filename.Focus();
                    return;
                }

                WindowState = FormWindowState.Minimized;
                TrayIcon.Visible = true;
                Hide();

                FileProcessor.ProcessFile(path, Params);

                Filename.Text = "";
                StatusText.Text = "";
            }
            else
            {
                var FName = Filename.Text.Trim();

                if (FName.Split('.')[1].Contains(" ") || FName.Split('.')[1].Length == 0)
                {
                    StatusText.Text = "Invalid extension!";
                    Filename.Focus();
                    return;
                }

                WindowState = FormWindowState.Minimized;
                TrayIcon.Visible = true;
                Hide();

                FileProcessor.ProcessFile(Filename.Text.Trim());
            }
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void TrayShow_Click(object sender, EventArgs e)
        {
            Show();
            WindowState = FormWindowState.Normal;
            Focus();
            TrayIcon.Visible = false;
        }

        private void MainForm_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                TrayIcon.Visible = true;
                Hide();
            }
            else
            {
                TrayIcon.Visible = false;
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Application.ApplicationExit += Application_ApplicationExit;

            GlobalHotKeys = new HotKeyRegister(this.Handle, NativeMethods.GlobalAddAtom(Thread.CurrentThread.ManagedThreadId.ToString("X8") + this.GetType().FullName), NativeMethods.KeyModifiers.Shift, Keys.Q);
            GlobalHotKeys.HotKeyPressed += GlobalHotKeys_HotKeyPressed;
        }

        private void GlobalHotKeys_HotKeyPressed(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                Show();
                WindowState = FormWindowState.Normal;
                Focus();
                TrayIcon.Visible = false;
            }
        }

        private void Application_ApplicationExit(object sender, EventArgs e)
        {
            GlobalHotKeys.Dispose();
        }
    }
}
