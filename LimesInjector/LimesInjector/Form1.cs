using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Text;

namespace LimesInjector
{
    public partial class Form1 : Form
    {
        ProcessStartInfo psInfo = new ProcessStartInfo
        {
            FileName = "https://github.com/LimeAndPyro",
            UseShellExecute = true
        };
        public Form1()
        {
            InitializeComponent();
            Process[] allproc = Process.GetProcesses().Where(p => (long)p.MainWindowHandle != 0).ToArray();
            ProcessList.Items.Clear();
            foreach (Process p in allproc)
            {
                ProcessList.Items.Add($"{p.ProcessName} -> {"[" + p.Id + "]"}");
            }
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        Point lastPoint;

        private void Toppanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void Toppanel_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void TitleLable_Click(object sender, EventArgs e)
        {
            Process.Start(psInfo);
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private static string DLLP { get; set; }
        private void DllButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.InitialDirectory = @"C:\";
            ofd.Title = "Locate DLL File To Inject";
            ofd.DefaultExt = ".dll";
            ofd.Filter = "DLL Files (*.dll)|*.dll";
            ofd.CheckFileExists = true;
            ofd.CheckPathExists = true;
            ofd.ShowDialog();

            DLLP = ofd.FileName;
            Pathtext.Text = DLLP;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Process[] allproc = Process.GetProcesses().Where(p => (long)p.MainWindowHandle != 0).ToArray();
            ProcessList.Items.Clear();
            foreach (Process p in allproc)
            {
                ProcessList.Items.Add($"{p.ProcessName} -> {"[" + p.Id + "]"}");
            }
        }

        //Injection
        static readonly IntPtr zero = (IntPtr)0;

        [DllImport("kernel32.dll", SetLastError = true)]
        static extern IntPtr OpenProcess(uint dwDesiredAccess, int bInheritHandle, uint dwProcessId);
        
        [DllImport("kernel32.dll", SetLastError = true)]
        static extern int CloseHandle(IntPtr hObject);

        [DllImport("kernel32.dll", SetLastError = true)]
        static extern IntPtr GetProcAddress(IntPtr hModule, string lpProcName);

        [DllImport("kernel32.dll", SetLastError = true)]
        static extern IntPtr GetModuleHandle(string lpModuleName);

        [DllImport("kernel32.dll", SetLastError = true)]

        static extern IntPtr VirtualAllocEx(IntPtr hProcess, IntPtr lpAddress, IntPtr dwSize, uint flAllocationType, IntPtr flProtect);

        [DllImport("kernel32.dll", SetLastError = true)]
        public static extern bool WriteProcessMemory(IntPtr hProcess, IntPtr lpBaseAddress, byte[] lpBuffer, uint nSize, int lpNumberOfBytesWritten);

        [DllImport("kernel32.dll")]
        static extern IntPtr CreateRemoteThread(IntPtr hProcess, IntPtr lpThreadAttributes, uint dwStackSize, IntPtr lpStartAddress, IntPtr lpParameter, uint dwCreationFlags, IntPtr lpThreadId);


        public static int Inject(string procName, string dllPath)
        {
            //ERROR HANDLING
            //1 = file does not exist
            //2 = proc does not exist
            //3 =  injection failed
            //4 = injection success

            if (!File.Exists(dllPath)) { return 1; }

            uint procId = 0;
            Process[] allproc = Process.GetProcesses();
            for (int i = 0; i < allproc.Length; i++)
            {
                if (allproc[i].ProcessName == procName)
                {
                    procId = (uint)allproc[i].Id;

                }
            }
            if (procId == 0)
            {
                return 2;
            }
            if (!Startinjection(procId, dllPath))
            {
                return 3;
            }

            return 4;

            
        }

        public static bool Startinjection(uint p, string dllp)
        {
            IntPtr hProc = OpenProcess((0x2 | 0x8 | 0x10 | 0x20 | 0x400), 1, p);

            if (hProc == IntPtr.Zero) { return false; }

            IntPtr lpAddress = VirtualAllocEx(hProc, (IntPtr)null, (IntPtr)dllp.Length, (0x1000 | 0x2000), (IntPtr)0x40);

            if (lpAddress == IntPtr.Zero) { return false; }

            byte[] bytesofdll = Encoding.ASCII.GetBytes(dllp);

            bool wpm = WriteProcessMemory(hProc, lpAddress, bytesofdll, (uint)bytesofdll.Length, 0);

            if (wpm == false)
            {
                return false;
            }

            CloseHandle(hProc);

            return true;
        }

        private void InjectButton_Click(object sender, EventArgs e)
        {
            int Result = Inject(ProcessList.Text, DLLP);


            if (Result == 1)
            {
                resulttext.ForeColor = Color.Red;
                resulttext.Text = "File Does Not Exist";
            }
            if (Result == 2)
            {
                resulttext.ForeColor = Color.Red;
                resulttext.Text = "Process Does Not Exist";
            }
            if (Result == 3)
            {
                resulttext.ForeColor = Color.Red;
                resulttext.Text = "Injection Failed";
            }
            if (Result == 4)
            {
                resulttext.ForeColor = Color.Lime;
                resulttext.Text = "Injection Success";
            }
        }
    }
}