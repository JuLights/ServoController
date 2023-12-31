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

            await Task.Run(async() =>
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
            SerialPort = new SerialPort("COM" + numericUpDown1.Value, 9600);
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
            string command = $"0 {Servo1Pos.Value} {ServoSpeed.Value} 1 {Servo2Pos.Value} {ServoSpeed.Value} 2 {Servo3Pos.Value} {ServoSpeed.Value} 3 {Servo4Pos.Value} {ServoSpeed.Value} 4 {Servo5Pos.Value} {ServoSpeed.Value} 5 {Servo6Pos.Value} {ServoSpeed.Value} 6 {Servo7Pos.Value} {ServoSpeed.Value} 7 {Servo8Pos.Value} {ServoSpeed.Value}";
            listBox1.Items.Add(command);

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
                count =+ 1;
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
            string command = $"0 {Servo1Pos.Value} {ServoSpeed.Value}";
            if (SerialPort != null)
            {
                SerialPort.WriteLine(command);
            }
            else
            {
                MessageBox.Show(this, "Not Connected", "Warning!", MessageBoxButtons.OK);
            }

        }

        private void Servo2Pos_ValueChanged(object sender, EventArgs e)
        {
            Servo2Label.Text = Servo2Pos.Value.ToString();
            string command = $"1 {Servo2Pos.Value} {ServoSpeed.Value}";
            if (SerialPort != null)
            {
                SerialPort.WriteLine(command);
            }
            else
            {
                MessageBox.Show(this, "Not Connected", "Warning!", MessageBoxButtons.OK);
            }
        }

        private void Servo3Pos_ValueChanged(object sender, EventArgs e)
        {
            Servo3Label.Text = Servo3Pos.Value.ToString();
            string command = $"2 {Servo3Pos.Value} {ServoSpeed.Value}";
            if (SerialPort != null)
            {
                SerialPort.WriteLine(command);
            }
            else
            {
                MessageBox.Show(this, "Not Connected", "Warning!", MessageBoxButtons.OK);
            }
        }

        private void Servo4Pos_ValueChanged(object sender, EventArgs e)
        {
            Servo4Label.Text = Servo4Pos.Value.ToString();
            string command = $"3 {Servo4Pos.Value} {ServoSpeed.Value}";
            if (SerialPort != null)
            {
                SerialPort.WriteLine(command);
            }
            else
            {
                MessageBox.Show(this, "Not Connected", "Warning!", MessageBoxButtons.OK);
            }
        }

        private void Servo5Pos_ValueChanged(object sender, EventArgs e)
        {
            Servo5Label.Text = Servo5Pos.Value.ToString();
            string command = $"4 {Servo5Pos.Value} {ServoSpeed.Value}";
            if (SerialPort != null)
            {
                SerialPort.WriteLine(command);
            }
            else
            {
                MessageBox.Show(this, "Not Connected", "Warning!", MessageBoxButtons.OK);
            }
        }

        private void Servo6Pos_ValueChanged(object sender, EventArgs e)
        {
            Servo6Label.Text = Servo6Pos.Value.ToString();
            string command = $"5 {Servo6Pos.Value} {ServoSpeed.Value}";
            if (SerialPort != null)
            {
                SerialPort.WriteLine(command);
            }
            else
            {
                MessageBox.Show(this, "Not Connected", "Warning!", MessageBoxButtons.OK);
            }

        }

        private void Servo7Pos_ValueChanged(object sender, EventArgs e)
        {
            Servo7Label.Text = Servo7Pos.Value.ToString();
            string command = $"6 {Servo7Pos.Value} {ServoSpeed.Value}";
            if (SerialPort != null)
            {
                SerialPort.WriteLine(command);
            }
            else
            {
                MessageBox.Show(this, "Not Connected", "Warning!", MessageBoxButtons.OK);
            }
        }

        private void Servo8Pos_ValueChanged(object sender, EventArgs e)
        {
            Servo8Label.Text = Servo8Pos.Value.ToString();
            string command = $"7 {Servo8Pos.Value} {ServoSpeed.Value}";
            if (SerialPort != null)
            {
                SerialPort.WriteLine(command);
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
                    var arr = desiredValues.Split(" ");

                    Servo1Pos.Value = Convert.ToInt32(arr[1]);
                    Servo2Pos.Value = Convert.ToInt32(arr[4]);
                    Servo3Pos.Value = Convert.ToInt32(arr[7]);
                    Servo4Pos.Value = Convert.ToInt32(arr[10]);
                    Servo5Pos.Value = Convert.ToInt32(arr[13]);
                    Servo6Pos.Value = Convert.ToInt32(arr[16]);
                    Servo7Pos.Value = Convert.ToInt32(arr[19]);
                    Servo8Pos.Value = Convert.ToInt32(arr[22]);
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
    }
}