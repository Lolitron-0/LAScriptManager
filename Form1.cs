using System;
using System.Diagnostics;
using System.Drawing;
using System.Media;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using RunProcessAsTask;

namespace LAScriptManager
{
    public partial class Form1 : Form
    {
        int dX, dY;
        bool grabbed = false;

        string hwnd="";
        bool autoG = false;
        bool autoFish = false;
        bool autoShipSprint = false;
        CancellationTokenSource ctsG = new CancellationTokenSource();
        CancellationTokenSource ctsFish = new CancellationTokenSource();
        CancellationTokenSource ctsSprint = new CancellationTokenSource();
        SoundPlayer spOn = new SoundPlayer("on.wav");
        SoundPlayer spOff = new SoundPlayer("off.wav");

        public Form1()
        {
            InitializeComponent();
            panel1.Enabled = false;
        }

        public ProcessStartInfo getPsi(string scriptFilePath, string args)
        {
            var psi = new ProcessStartInfo();
            psi.FileName = @"venv\Scripts\pythonw.exe"; // or any python environment

            psi.Arguments = $"\"{scriptFilePath}\" {args}";

            psi.UseShellExecute = false;
            psi.CreateNoWindow = true;
            psi.RedirectStandardOutput = true;
            psi.RedirectStandardError = true;
            psi.StandardOutputEncoding = Encoding.UTF8;

            return psi;
        }

        private void btnFindHandle_Click(object sender, EventArgs e)
        {
            string errors = "", result = "";

            var process = Process.Start(getPsi("findWindow.py", "/c"));
            result = process.StandardOutput.ReadToEnd();
            errors = process.StandardError.ReadToEnd();

            hwnd = result;
            if(hwnd!="")
            {
                lblHandle.Text = "Window found";
                lblHandle.ForeColor = Color.Green;
                panel1.Enabled = true;
            }
        }

        private void btnG_Click(object sender, EventArgs e)
        {
            autoG = !autoG;
            if (autoG) btnG.ForeColor = Color.Green;
            else btnG.ForeColor = Color.Red;

            if (autoG)
            {
                ctsG = new CancellationTokenSource();
                var proc = ProcessEx.RunAsync(getPsi("autoG.py",$"/c {hwnd}"),ctsG.Token);
                spOn.Play();
            }
            else
            {
                ctsG.Cancel();
                spOff.Play();
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            ctsFish.Cancel();
            ctsG.Cancel();
            ctsSprint.Cancel();
        }

        private void btnShip_Click(object sender, EventArgs e)
        {
            autoShipSprint = !autoShipSprint;
            if (autoShipSprint) btnShip.ForeColor = Color.Green;
            else btnShip.ForeColor = Color.Red;

            if (autoShipSprint)
            {
                ctsSprint= new CancellationTokenSource();
                var proc = ProcessEx.RunAsync(getPsi("autoShipSprint.py", $"/c {hwnd}"), ctsSprint.Token);
                spOn.Play();
            }
            else
            {
                ctsSprint.Cancel();
                spOff.Play();
            }
        }

        private void btnFish_Click(object sender, EventArgs e)
        {
            autoFish = !autoFish;
            if (autoFish) btnFish.ForeColor = Color.Green;
            else btnFish.ForeColor = Color.Red;

            if (autoFish)
            {
                ctsFish = new CancellationTokenSource();
                var proc = ProcessEx.RunAsync(getPsi("autoFish.py", $"/c {hwnd}"), ctsFish.Token);
            }
            else
            {
                ctsFish.Cancel();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (ClientRectangle.Contains(PointToClient(Cursor.Position)))
                Opacity = 1;
            else
                Opacity = 0.2;
        }

        private void Form1_MouseLeave(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (grabbed)
                Location = new Point(Cursor.Position.X-dX,Cursor.Position.Y-dY);
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            grabbed=false;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.G)
                btnG.PerformClick();
            else if (e.Control && e.KeyCode == Keys.Space)
                btnShip.PerformClick();
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            grabbed = true;
            dX = Cursor.Position.X - Location.X;
            dY = Cursor.Position.Y - Location.Y;
        }
    }
}
