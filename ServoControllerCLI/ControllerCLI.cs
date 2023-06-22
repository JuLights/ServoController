using System.IO;
using System.Runtime.InteropServices;
using System.Text;

namespace ServoControllerCLI
{
    public class ControllerCLI
    {
        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool AllocConsole();

        public event EventHandler ?OnOutputComand;
        public event EventHandler<ListEventArgs> ?OnAppendComand;

        public List<object> _list = new List<object>();

        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
        }

        public void Initialize()
        {
            AllocConsole();
            Console.Title = "ServoControllerCLI";
            CLIColor();
            Console.WriteLine("### Welcome to Servo Controller Command Line Interface! ###");
            Console.WriteLine();
            Console.WriteLine("type -help to get info about commands");
            WriterColor();
        }

        public async Task CLILoop()
        {
            while (true)
            {
                var input = Console.ReadLine();
                if (input != null)
                {
                    if (input == "-help")
                    {
                        HelpOutput();
                    }
                    else if (input.Contains("output") || input.Contains("append"))
                    {
                        
                        var arr = input.Split(" ");

                        if (arr[0] == "-output" && arr[2] == "desktop")
                        {
                            OnOutputComand?.Invoke(this, EventArgs.Empty);
                            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                            System.IO.StreamWriter sw = new System.IO.StreamWriter(Path.Combine(path,arr[4]));
                            foreach (var item in _list)
                            {
                                sw.WriteLine(item);
                            }
                            sw.Flush();
                            sw.Close();
                            Console.WriteLine("######## command executed Successfully");
                        }

                        if (arr[0] == "-append" && arr[2] == "desktop")
                        {
                            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                            System.IO.StreamReader sr = new System.IO.StreamReader(Path.Combine(path, arr[4]), Encoding.UTF8);

                            string line = String.Empty;
                            _list.Clear();
                            while ((line = sr.ReadLine()) != null)
                            {
                                _list.Add(line);
                            }

                            OnAppendComand?.Invoke(this, new ListEventArgs()
                            {
                                listEventArgs = _list
                            });
                        }
                        Console.WriteLine("######## command executed Successfully");
                    }
                    else
                    {
                        ErrorOutput();
                    }
                }

                await Task.Delay(1);
            }
        }



        private void CLIColor()
        {
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
        }
        private void WriterColor()
        {
            //Console.BackgroundColor = ConsoleColor.Black;
            //Console.ForegroundColor = ConsoleColor.White;
        }

        private void HelpOutput()
        {
            CLIColor();
            Console.WriteLine("to output list in txt file, specify destination and name of a file");
            Console.WriteLine();
            Console.WriteLine("for example:");
            Console.WriteLine("-output -d desktop -n list.txt");
            Console.WriteLine();
            Console.WriteLine("to append txt file to list, specify destination and name of a file");
            Console.WriteLine();
            Console.WriteLine("for example:");
            Console.WriteLine("-append -d desktop -n list.txt");
            Console.WriteLine();
            Console.WriteLine("####################################################################");
            WriterColor();
        }

        private void ErrorOutput()
        {
            CLIColor();
            Console.WriteLine("wrong command");
            Console.WriteLine("type -help to get info about commands");
            Console.WriteLine();
            WriterColor();
        }

        





    }
}