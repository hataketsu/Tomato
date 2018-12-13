/*
 * Created by SharpDevelop.
 * User: Bullshit
 * Date: 5/6/2018
 * Time: 6:30 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */

using System;
using System.Diagnostics;
using System.Drawing;
using System.IO.Ports;
using System.Threading;
using System.Windows.Forms;
using DirectShowLib;
using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using Emgu.CV.Util;

namespace Tomato
{
    public partial class MainForm : Form
    {
        VideoCapture camera;
        Mat _frame = new Mat();
        Mat frame = new Mat();
        Mat hsv = new Mat();
        Mat mask = new Mat();

        const string POSITION_1 = "1=60;2=110;";
        const string POSITION_2 = "1=120;2=50;";
        const string POSITION_3 = "1=120;2=110;";
        string[] POSITIONS = {POSITION_1, POSITION_2, POSITION_3};
        const string START_SCROLLER = "7=0;";
        const string STOP_SCROLLER = "7=1;";


        private int selected = -1;
        private bool isRunning;

        ScalarArray[][] ALL_COLORS =
        {
            new[]
            {
                new ScalarArray(new MCvScalar(50 / 2, 10 * 2.55, 40 * 2.55)),
                new ScalarArray(new MCvScalar(80 / 2, 255, 255))
            },
            new[]
            {
                new ScalarArray(new MCvScalar(220 / 2, 20 * 2.55, 30 * 2.55)),
                new ScalarArray(new MCvScalar(240 / 2, 255, 255))
            }
        };

        public MainForm()
        {
            InitializeComponent();
            foreach (string port in SerialPort.GetPortNames())
            {
                arduinoPortCB.Items.Add(port);
                arduinoPortCB.Text = port;
            }


            serialPort1.DataReceived += port_DataReceived;

            DsDevice[] _SystemCamereas = DsDevice.GetDevicesOfCat(FilterCategory.VideoInputDevice);

            int _DeviceIndex = 0;
            foreach (DsDevice _Camera in _SystemCamereas)
            {
                cameraListBox.Items.Add("" + _DeviceIndex);
                cameraListBox.Text = "" + _DeviceIndex;
                _DeviceIndex++;
            }
        }

        private void ProcessFrame(object sender, EventArgs arg)
        {
            try
            {
                camera.Retrieve(_frame);
                CvInvoke.Resize(_frame, frame, new Size(640, 480));
                CvInvoke.CvtColor(frame, hsv, ColorConversion.Bgr2Hsv);
                double biggest = 10;
                selected = 2;

                for (int i = 0; i < ALL_COLORS.Length; i++)
                {
                    ScalarArray lowerColor = ALL_COLORS[i][0];
                    ScalarArray upperColor = ALL_COLORS[i][1];

                    CvInvoke.InRange(hsv, lowerColor, upperColor, mask);
                    var element =
                        CvInvoke.GetStructuringElement(ElementShape.Rectangle, new Size(30, 30), new Point(-1, -1));


                    CvInvoke.Erode(mask, mask, element, new Point(-1, -1), 1, BorderType.Reflect, default(MCvScalar));
                    CvInvoke.Dilate(mask, mask, element, new Point(-1, -1), 1, BorderType.Reflect, default(MCvScalar));

                    var contours = new VectorOfVectorOfPoint();
                    var hierarchy = new Mat();
                    CvInvoke.FindContours(
                        mask,
                        contours,
                        hierarchy,
                        RetrType.External,
                        ChainApproxMethod.ChainApproxSimple
                    );

                    CvInvoke.DrawContours(frame, contours, -1, new MCvScalar(255, 255, 0));


                    for (int j = 0; j < contours.Size; j++)
                    {
                        var c = contours[j];
                        var s = CvInvoke.ContourArea(c);
                        if (s > biggest)
                        {
                            biggest = s;
                            selected = i;
                        }
                    }
                }

                pictureBox1.Image = frame.Bitmap;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
            print(""+selected);

        }


        void ComboBox1SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void port_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            while (serialPort1.BytesToRead > 0)
            {
                var data = serialPort1.ReadTo(";");
                print("Receive: " + data);
                if (data.Equals("detect=0") && !isRunning && autoCheckBox1.Checked)
                {
                    isRunning = true;
                    print("Take tomato " + selected);
                    sendToArduino(STOP_SCROLLER);

                    new Thread(() =>
                    {
                        Thread.Sleep(1000);
                        sendToArduino(POSITIONS[selected]);
                        Thread.Sleep(1000);
                        sendToArduino(START_SCROLLER);
                        isRunning = false;
                    }).Start();
                }
            }
        }

        void print(String s)
        {
            Debug.WriteLine(s);
        }

        void GroupBox1Enter(object sender, EventArgs e)
        {
        }

        void OpenCameraClick(object sender, EventArgs e)
        {
            camera = new VideoCapture(int.Parse(cameraListBox.SelectedItem.ToString()));
            camera.ImageGrabbed += ProcessFrame;
            camera.Start();
        }

        void ConnectCOMClick(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.Close();
                connectCOM.Text = "Kết nối";
            }
            else
            {
                connectCOM.Text = "Ngắt kết nối";
                serialPort1.PortName = "" + arduinoPortCB.SelectedItem;
                serialPort1.Open();
            }
        }

        void Button1Click(object sender, EventArgs e)
        {
            sendToArduino(START_SCROLLER);
        }

        void Button2Click(object sender, EventArgs e)
        {
            sendToArduino(STOP_SCROLLER);
        }


        void sendToArduino(String s)
        {
            serialPort1.Write(s);
            print("Sent command: " + s);
        }

        void Button3Click(object sender, EventArgs e)
        {
            sendToArduino(POSITION_1);
        }

        void Button6Click(object sender, EventArgs e)
        {
            sendToArduino(POSITION_2);
        }

        void Button7Click(object sender, EventArgs e)
        {
            sendToArduino(POSITION_3);
        }
    }
}