using System.Diagnostics;
using System.IO.Ports;
using System.Text;
using ServoControllerCLI;
using System.Runtime.InteropServices;
using System.ComponentModel;

namespace ServoController
{
    public partial class Form1 : Form
    {
        public int x1, x2, x3, x4, y1, y2, y3, y4, s = 1000;

        private readonly ControllerCLI _cli;
        private SerialPort SerialPort;
        public Form1()
        {
            InitializeComponent();

            _cli = new ControllerCLI();

            //BackgroundWorker worker = new BackgroundWorker();
            //worker.DoWork += Worker_DoWork;
            //worker.RunWorkerAsync();

            statusLabel.ForeColor = Color.Red;
            statusLabel.Text = "Not Connected!";

            _cli.OnOutputComand += _cli_OnOutputComand;
            _cli.OnAppendComand += _cli_OnAppendComand;
            currentSpeedLabel.Text = $"Current Speed: {s}ms";

        }

        private void _cli_OnAppendComand(object? sender, ListEventArgs e)
        {
            foreach (var item in e.listEventArgs)
            {
                BeginInvoke(() =>
                {
                    listBox1.Items.Add(item);
                });
            }

        }

        private void _cli_OnOutputComand(object? sender, EventArgs e)
        {
            foreach (var item in listBox1.Items)
            {
                _cli._list.Add(item);
            }
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            _cli.Initialize();

            await Task.Run(async () =>
            {
                await _cli.CLILoop();
            });

            //_cli.CLILoop();

        }

        private void Servo1Lab_DoubleClick(object sender, EventArgs e)
        {
            Debug.WriteLine("new Servo name");
        }

        private void connectBut_Click(object sender, EventArgs e)
        {
            SerialPort = new SerialPort("COM" + numericUpDown1.Value, 115200);
            SerialPort.Open();
            if (SerialPort.IsOpen)
            {
                statusLabel.ForeColor = Color.Green;
                statusLabel.Text = "Connected!";
            }
            else
            {
                statusLabel.ForeColor = Color.Red;
                statusLabel.Text = "Not Connected!";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SerialPort.Close();
            statusLabel.ForeColor = Color.Red;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //0 90 1 1 40 7
            //string command = $"0 {Servo1Pos.Value} {ServoSpeed.Value} 1 {Servo2Pos.Value} {ServoSpeed.Value} 2 {Servo3Pos.Value} {ServoSpeed.Value} 3 {Servo4Pos.Value} {ServoSpeed.Value} 4 {Servo5Pos.Value} {ServoSpeed.Value} 5 {Servo6Pos.Value} {ServoSpeed.Value} 6 {Servo7Pos.Value} {ServoSpeed.Value} 7 {Servo8Pos.Value} {ServoSpeed.Value}";
            ////listBox1.Items.Add(command);
            string servoCommand = $"x{x1},{x2},{x3},{x4}y{y1},{y2},{y3},{y4}s{s}";
            listBox1.Items.Add(servoCommand);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
                listBox1.Update();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}");
            }

        }

        //Delay
        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(delayBox.Text);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var count = Convert.ToInt32(textBox2.Text); //user defined
            if (count == 0)
                count = +1;
            int i = 0;
            //make same moves {count}x times
            while (i < count)
            {
                foreach (var item in listBox1.Items)
                {
                    if (item.ToString().Length > 6)
                    {
                        SerialPort.WriteLine(item.ToString());
                        Debug.WriteLine(item.ToString());
                        Debug.WriteLine("------------------------");
                    }
                    else
                    {
                        Thread.Sleep(Convert.ToInt32(item));
                    }


                }
                i++;
            }


        }



        private void Servo1Pos_ValueChanged(object sender, EventArgs e)
        {
            Servo1Label.Text = Servo1Pos.Value.ToString();
            //Debug.WriteLine(Servo1Pos.Value);
            x1 = Servo1Pos.Value;
            string servoCommand = $"x{x1},{x2},{x3},{x4}y{y1},{y2},{y3},{y4}s{s}";
            Debug.WriteLine(servoCommand);
            //string command = $"0 {Servo1Pos.Value} {ServoSpeed.Value}";
            if (SerialPort != null)
            {
                SerialPort.WriteLine(servoCommand);
            }
            else
            {
                MessageBox.Show(this, "Not Connected", "Warning!", MessageBoxButtons.OK);
            }

        }

        private void Servo2Pos_ValueChanged(object sender, EventArgs e)
        {
            Servo2Label.Text = Servo2Pos.Value.ToString();
            x2 = Servo2Pos.Value;
            string servoCommand = $"x{x1},{x2},{x3},{x4}y{y1},{y2},{y3},{y4}s{s}";
            //string command = $"1 {Servo2Pos.Value} {ServoSpeed.Value}";
            if (SerialPort != null)
            {
                SerialPort.WriteLine(servoCommand);
            }
            else
            {
                MessageBox.Show(this, "Not Connected", "Warning!", MessageBoxButtons.OK);
            }
        }

        private void Servo3Pos_ValueChanged(object sender, EventArgs e)
        {
            Servo3Label.Text = Servo3Pos.Value.ToString();
            x3 = Servo3Pos.Value;
            string servoCommand = $"x{x1},{x2},{x3},{x4}y{y1},{y2},{y3},{y4}s{s}";
            //string command = $"2 {Servo3Pos.Value} {ServoSpeed.Value}";
            if (SerialPort != null)
            {
                SerialPort.WriteLine(servoCommand);
            }
            else
            {
                MessageBox.Show(this, "Not Connected", "Warning!", MessageBoxButtons.OK);
            }
        }

        private void Servo4Pos_ValueChanged(object sender, EventArgs e)
        {
            Servo4Label.Text = Servo4Pos.Value.ToString();
            x4 = Servo4Pos.Value;
            string servoCommand = $"x{x1},{x2},{x3},{x4}y{y1},{y2},{y3},{y4}s{s}";
            //string command = $"3 {Servo4Pos.Value} {ServoSpeed.Value}";
            if (SerialPort != null)
            {
                SerialPort.WriteLine(servoCommand);
            }
            else
            {
                MessageBox.Show(this, "Not Connected", "Warning!", MessageBoxButtons.OK);
            }
        }

        private void Servo5Pos_ValueChanged(object sender, EventArgs e)
        {
            Servo5Label.Text = Servo5Pos.Value.ToString();
            y1 = Servo5Pos.Value;
            string servoCommand = $"x{x1},{x2},{x3},{x4}y{y1},{y2},{y3},{y4}s{s}";
            //string command = $"4 {Servo5Pos.Value} {ServoSpeed.Value}";
            if (SerialPort != null)
            {
                SerialPort.WriteLine(servoCommand);
            }
            else
            {
                MessageBox.Show(this, "Not Connected", "Warning!", MessageBoxButtons.OK);
            }
        }

        private void Servo6Pos_ValueChanged(object sender, EventArgs e)
        {
            Servo6Label.Text = Servo6Pos.Value.ToString();
            y2 = Servo6Pos.Value;
            string servoCommand = $"x{x1},{x2},{x3},{x4}y{y1},{y2},{y3},{y4}s{s}";
            //string command = $"5 {Servo6Pos.Value} {ServoSpeed.Value}";
            if (SerialPort != null)
            {
                SerialPort.WriteLine(servoCommand);
            }
            else
            {
                MessageBox.Show(this, "Not Connected", "Warning!", MessageBoxButtons.OK);
            }

        }

        private void Servo7Pos_ValueChanged(object sender, EventArgs e)
        {
            Servo7Label.Text = Servo7Pos.Value.ToString();
            y3 = Servo7Pos.Value;
            string servoCommand = $"x{x1},{x2},{x3},{x4}y{y1},{y2},{y3},{y4}s{s}";
            //string command = $"6 {Servo7Pos.Value} {ServoSpeed.Value}";
            if (SerialPort != null)
            {
                SerialPort.WriteLine(servoCommand);
            }
            else
            {
                MessageBox.Show(this, "Not Connected", "Warning!", MessageBoxButtons.OK);
            }
        }

        private void Servo8Pos_ValueChanged(object sender, EventArgs e)
        {
            Servo8Label.Text = Servo8Pos.Value.ToString();
            y4 = Servo8Pos.Value;
            string servoCommand = $"x{x1},{x2},{x3},{x4}y{y1},{y2},{y3},{y4}s{s}";
            //string command = $"7 {Servo8Pos.Value} {ServoSpeed.Value}";
            if (SerialPort != null)
            {
                SerialPort.WriteLine(servoCommand);
            }
            else
            {
                MessageBox.Show(this, "Not Connected", "Warning!", MessageBoxButtons.OK);
            }
        }

        //set Slider Values
        private void button6_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                if (listBox1.Items[listBox1.SelectedIndex].ToString().Length > 6)
                {
                    var desiredValues = listBox1.Items[listBox1.SelectedIndex].ToString();
                    var arr = desiredValues.Split(",");

                    Servo1Pos.Value = Convert.ToInt32(arr[0].Split("x")[1]);
                    Servo2Pos.Value = Convert.ToInt32(arr[1]);
                    Servo3Pos.Value = Convert.ToInt32(arr[2]);
                    var arrY = arr[3].Split("y");
                    Servo4Pos.Value = Convert.ToInt32(arr[3].Split("y")[0]);
                    Servo5Pos.Value = Convert.ToInt32(arr[3].Split("y")[1]);
                    Servo6Pos.Value = Convert.ToInt32(arr[4]);
                    Servo7Pos.Value = Convert.ToInt32(arr[5]);
                    Servo8Pos.Value = Convert.ToInt32(arr[6].Split("s")[0]);
                    speedSlider.Value = Convert.ToInt32(arr[6].Split("s")[1]);
                }
            }
            else
            {
                MessageBox.Show(this, "please select item", "Warning!", MessageBoxButtons.OK);
            }


        }


        //Add Value
        private void button7_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(textBox1.Text))
                listBox1.Items.Add(textBox1.Text);
            else
                MessageBox.Show(this, "fill the textbox", "Warning!", MessageBoxButtons.OK);
        }

        private void saveAsTextFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text Files | *.txt";
            saveFileDialog.DefaultExt = "txt";
            if (saveFileDialog.ShowDialog() == DialogResult.OK && listBox1.Items != null)
            {
                System.IO.Stream fileStream = saveFileDialog.OpenFile();
                System.IO.StreamWriter sw = new System.IO.StreamWriter(fileStream);
                foreach (var item in listBox1.Items)
                {
                    sw.WriteLine(item);
                }
                sw.Flush();
                sw.Close();

                MessageBox.Show(this, $"{Path.GetFileName(saveFileDialog.FileName)} Saved Successfully", "Message", MessageBoxButtons.OK);
            }
        }

        private void uploadTextFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text Files | *.txt";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                System.IO.Stream fileStream = new FileStream(openFileDialog.FileName, FileMode.Open, FileAccess.Read);
                using (System.IO.StreamReader sr = new System.IO.StreamReader(fileStream, Encoding.UTF8))
                {
                    string line = String.Empty;
                    while ((line = sr.ReadLine()) != null)
                    {
                        listBox1.Items.Add(line);
                    }
                }
                fileStream.Dispose();
                MessageBox.Show(this, "MoveList Updated Successfully", "Message", MessageBoxButtons.OK);

            }
        }

        private void speedSlider_ValueChanged(object sender, EventArgs e)
        {
            s = speedSlider.Value;
            currentSpeedLabel.Text = $"Current Speed: {speedSlider.Value}ms";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            s = 1000;
            speedSlider.Value = s;
            currentSpeedLabel.Text = $"Current Speed: {speedSlider.Value}ms";
        }

        private void SetSliderDefaultBut_Click(object sender, EventArgs e)
        {
            Servo1Pos.Value = 0;
            Servo2Pos.Value = 0;
            Servo3Pos.Value = 0;
            Servo4Pos.Value = 0;
            Servo5Pos.Value = 0;
            Servo6Pos.Value = 0;
            Servo7Pos.Value = 0;
            Servo8Pos.Value = 0;
            Servo1Label.Text = Servo1Pos.Value.ToString();
            Servo2Label.Text = Servo2Pos.Value.ToString();
            Servo3Label.Text = Servo3Pos.Value.ToString();
            Servo4Label.Text = Servo4Pos.Value.ToString();
            Servo5Label.Text = Servo5Pos.Value.ToString();
            Servo6Label.Text = Servo6Pos.Value.ToString();
            Servo7Label.Text = Servo7Pos.Value.ToString();
            Servo8Label.Text = Servo8Pos.Value.ToString();

            SerialPort.WriteLine($"x0,0,0,0y0,0,0,0s1000");
        }

        private void ClearListBut_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }
    }
}