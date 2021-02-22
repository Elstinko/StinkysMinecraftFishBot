using System;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;
using NAudio.CoreAudioApi;

namespace FishBot2
{
    public partial class FishBotForm1 : Form
    {
        int fished = 0;
        int peak = 0;
        double temp = 0;
        double reCastTime = 2;
        Thread botThread;
        bool active = false;

        public FishBotForm1()
        {
            InitializeComponent();
        }

        private void FishBotForm1_Load(object sender, EventArgs e)
        {
            MMDeviceEnumerator enumerator = new MMDeviceEnumerator();
            var devices = enumerator.EnumerateAudioEndPoints(DataFlow.All, DeviceState.Active);
            processList.Items.AddRange(devices.ToArray());
        }

        private void fish()
        {

            int tracker = GetControlPropertyThreadSafe(trackBar1, t => t.Value);
            VirtualMouse.RightClick();


            System.Threading.Thread.Sleep(2000);
            while (active)
            {
                var device = (MMDevice)GetControlPropertyThreadSafe(processList, t => t.SelectedItem);
                var curVol = (int)Math.Round(device.AudioMeterInformation.MasterPeakValue * 1000);
                if (curVol >= tracker)
                {
                    VirtualMouse.RightClick();
                    break;
                }
            }

            System.Threading.Thread.Sleep(Convert.ToInt32(reCastTime * 1000));
            //Console.WriteLine(Convert.ToInt32(reCastTime * 1000));
            fished = fished + 1;

        }

        private void bot_start()
        {
            System.Threading.Thread.Sleep(2500);
            while (active)
            {
                fish();
            }
        }

        public static U GetControlPropertyThreadSafe<T, U>(T control, Func<T, U> func) where T : Control
        {
            if (control.InvokeRequired)
            {
                return (U)control.Invoke(func, new object[] { control });
            }
            else
            {
                return func(control);
            }
        }

        private void StartButton_Click_1(object sender, EventArgs e)
        {
            statLabel.Text = "Active";
            active = true;
            botThread = new Thread(new ThreadStart(bot_start));
            botThread.IsBackground = true;
            botThread.Start();

        }

        private void StopButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                active = false;
                botThread.Abort();
                botThread = null;
                statLabel.Text = "Inactive";
            }
            catch { };
        }

        private void resetBarButton_Click(object sender, EventArgs e)
        {
            peak = 0;
            peakIndicator.Value = peak;

        }

        private void setRecast_Click(object sender, EventArgs e)
        {
            if (reCastTimeInput.TextLength > 0 && double.TryParse(reCastTimeInput.Text, out temp))
            {
                reCastTime = Convert.ToDouble(reCastTimeInput.Text);
            }
            else
            {
                MessageBox.Show("Please Enter a valid number.","Bad Input",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
        private void resetTotal_Click(object sender, EventArgs e)
        {
            fished = 0;
        }

        private void Timer_Tick_1(object sender, EventArgs e)
        {
            casts.Text = fished.ToString();

            if (active == false && processList.SelectedItem != null)
            {
                statLabel.Text = "Output Device Selected";
            }

            if (processList.SelectedItem != null)
            {


                var device = (MMDevice)processList.SelectedItem;
                var volume = (int)(device.AudioMeterInformation.MasterPeakValue * 1000);

                if (volume > peak)
                {
                    peak = volume;
                    peakIndicator.Value = peak;
                }

                audioVisualizer.Value = volume;



            }
        }


        public static class VirtualMouse
        {
            [DllImport("user32.dll")]
            static extern void mouse_event(int dwFlags, int dx, int dy, int dwData, int dwExtraInfo);

            private const int MOUSEEVENTF_RIGHTDOWN = 0x0008;
            private const int MOUSEEVENTF_RIGHTUP = 0x0010;


            public static void RightClick()
            {
                mouse_event(MOUSEEVENTF_RIGHTDOWN, Control.MousePosition.X, Control.MousePosition.Y, 0, 0);
                mouse_event(MOUSEEVENTF_RIGHTUP, Control.MousePosition.X, Control.MousePosition.Y, 0, 0);
            }

        }

    }
}