using System;
using System.Windows;
using TAPWin;


namespace test_tap
{
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();
            Raw_Timer.init();
        }

        //-----------------------------------
        //                TAP
        //-----------------------------------

        void OnTapped(string identifier, int tapcode)
        {
            ///tapcode numero 1-31
            switch (tapcode)
            {
                case 1:
                    VariablesGlobals.lletres = "a";
                    break;
                case 2:
                    VariablesGlobals.lletres = "e";
                    break;
                case 3:
                    VariablesGlobals.lletres = "n";
                    break;
                case 4:
                    VariablesGlobals.lletres = "i";
                    break;
                case 5:
                    VariablesGlobals.lletres = "d";
                    break;
                case 6:
                    VariablesGlobals.lletres = "t";
                    break;
                case 8:
                    VariablesGlobals.lletres = "o";
                    break;
                case 9:
                    VariablesGlobals.lletres = "k";
                    break;
                case 10:
                    VariablesGlobals.lletres = "m";
                    break;
                case 11:
                    VariablesGlobals.lletres = "f";
                    break;
                case 12:
                    VariablesGlobals.lletres = "l";
                    break;
                case 13:
                    VariablesGlobals.lletres = "g";
                    break;
                case 15:
                    VariablesGlobals.lletres = "r";
                    break;
                case 16:
                    VariablesGlobals.lletres = "u";
                    break;
                case 17:
                    VariablesGlobals.lletres = "y";
                    break;
                case 18:
                    VariablesGlobals.lletres = "b";
                    break;
                case 19:
                    VariablesGlobals.lletres = "p";
                    break;
                case 20:
                    VariablesGlobals.lletres = "z";
                    break;
                case 21:
                    VariablesGlobals.lletres = "w";
                    break;
                case 22:
                    VariablesGlobals.lletres = "q";
                    break;
                case 23:
                    VariablesGlobals.lletres = "j";
                    break;
                case 24:
                    VariablesGlobals.lletres = "s";
                    break;
                case 25:
                    VariablesGlobals.lletres = "x";
                    break;
                case 27:
                    VariablesGlobals.lletres = "v";
                    break;
                case 28:
                    VariablesGlobals.lletres = ". Numbers -> ";
                    break;
                case 29:
                    VariablesGlobals.lletres = "c";
                    break;
                case 30:
                    VariablesGlobals.lletres = "h";
                    break;
                case 31:
                    VariablesGlobals.lletres = " ";
                    break;
            }


            VariablesGlobals.str += VariablesGlobals.lletres;
            this.Dispatcher.Invoke(() =>
            {
                txb_tap.Text = VariablesGlobals.str;
            });
        }

        private void btn_tap_Click(object sender, RoutedEventArgs e)
        {
            TAPManager.Instance.OnTapped += OnTapped;

            TAPManager.Instance.SetTapInputMode(TAPInputMode.Controller());
            TAPManager.Instance.SetTapInputMode(TAPInputMode.Text());
            TAPManager.Instance.SetTapInputMode(TAPInputMode.ControllerWithMouseHID());

            TAPManager.Instance.Start();
        }

        //-----------------------------------
        //             RAW MODE
        //-----------------------------------

        private void btn_raw_Click(object sender, RoutedEventArgs e)
        {
            ///Setup Raw Mode
            TAPManager.Instance.OnRawSensorDataReceieved += OnRawSensorDataReceieved;
            ///Setup Sensitivity of the device accelerometre, mouse gyro, mouse accelerometre
            byte deviceAccelerometerSensitivity = 1;
            byte imuGyroSensitivity = 2;
            byte imuAccelerometerSensitivity = 1;
            TAPManager.Instance.SetTapInputMode(TAPInputMode.RawSensor(new RawSensorSensitivity(deviceAccelerometerSensitivity, imuGyroSensitivity, imuAccelerometerSensitivity)));

            TAPManager.Instance.Start();
        }

        void OnRawSensorDataReceieved(string identifier, RawSensorData rsData)
        {
            /// RawSensorData has a timestamp, type and an array of points(x,y,z)
            if (rsData.type == RawSensorDataType.Device)
            {
                Point3 thumb = rsData.GetPoint(RawSensorData.indexof_DEV_THUMB);
                if (thumb != null)
                {
                    // With the update of the version 2.30 it doesn't detect thumb
                    // thumb.x, thumb.y, thumb.z
                    VariablesGlobals.thumb_x = Math.Round(thumb.x).ToString();
                    VariablesGlobals.thumb_y = Math.Round(thumb.y).ToString();
                    VariablesGlobals.thumb_z = Math.Round(thumb.z).ToString();
                }
                // Etc.. use indexes: RawSensorData.indexof_DEV_THUMB, RawSensorData.indexof_DEV_INDEX, RawSensorData.indexof_DEV_MIDDLE, RawSensorData.indexof_DEV_RING, RawSensorData.indexof_DEV_PINKY
            }
            else if (rsData.type == RawSensorDataType.IMU)
            {
                Point3 gyro = rsData.GetPoint(RawSensorData.indexof_IMU_GYRO);
                if (gyro != null)
                {
                    // gyro.x, gyro.y, gyro.z
                    VariablesGlobals.gyro_x = Math.Round(gyro.x).ToString();
                    VariablesGlobals.gyro_y = Math.Round(gyro.y).ToString();
                    VariablesGlobals.gyro_z = Math.Round(gyro.z).ToString();
                }
                // Etc.. use indexes: RawSensorData.indexof_IMU_GYRO, RawSensorData.indexof_IMU_ACCELEROMETER
            }

            if (VariablesGlobals.raw_timer_bool == true)
            {
                this.Dispatcher.Invoke(() =>
                {
                    /// thumb axi values
                    txb_raw_tb_x.Text = " x: " + VariablesGlobals.thumb_x;
                    txb_raw_tb_y.Text = " y: " + VariablesGlobals.thumb_y;
                    txb_raw_tb_z.Text = " z: " + VariablesGlobals.thumb_z;
                    /// gyro values
                    txb_raw_gy_x.Text = " x: " + VariablesGlobals.gyro_x;
                    txb_raw_gy_y.Text = " y: " + VariablesGlobals.gyro_y;
                    txb_raw_gy_z.Text = " z: " + VariablesGlobals.gyro_z;
                });

                VariablesGlobals.raw_timer_bool = false;
            }
        }

        //-----------------------------------
        //             Vibrate MODE
        //-----------------------------------

        private void btn_vibrate_Click(object sender, RoutedEventArgs e)
        {
            TAPManager.Instance.Vibrate(new int[] { 500, 100, 500 });
            TAPManager.Instance.Start();
        }

        //-----------------------------------
        //             Mouse MODE
        //-----------------------------------


        private void btn_mouse_Click(object sender, RoutedEventArgs e)
        {
            TAPManager.Instance.OnMoused += OnMoused;
            TAPManager.Instance.SetTapInputMode(TAPInputMode.Controller());
            TAPManager.Instance.SetTapInputMode(TAPInputMode.ControllerWithMouseHID());
            TAPManager.Instance.SetTapInputMode(TAPInputMode.Text());

            TAPManager.Instance.Start();            
        }

        void OnMoused(string identifier, int vx, int vy, bool isMouse)
        {
            if (isMouse)
            {
                this.Dispatcher.Invoke(() =>
                {
                    txb_air.Text = "Mouse x: " + (int)vx + "\nMouse y: " + (int)vy;
                });
            }            
        }
    }
}