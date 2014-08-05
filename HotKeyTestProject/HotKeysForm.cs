using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Threading;

namespace HotKeyTestProject
{
    public partial class HotKeysForm : Form
    {
        public static string[] storedStrings { get; set; }
        private static List<int> ids = new List<int>();

        public static KeyModifiers CopyModifiers { get; set; }
        public static KeyModifiers PasteModifiers { get; set; }

        [STAThread]
        static void Main(string[] args)
        {
            CopyModifiers = KeyModifiers.Control;
            PasteModifiers = KeyModifiers.Control | KeyModifiers.Shift;
            Application.EnableVisualStyles();
            Application.Run(new HotKeysForm());
        }

        [DllImport("user32.dll")]
        static extern IntPtr GetActiveWindow();

        [DllImport("user32.dll")]
        public static extern IntPtr GetWindowThreadProcessId(IntPtr hWnd, out uint ProcessId);

        [DllImport("user32.dll")]
        private static extern IntPtr GetForegroundWindow();

        [DllImport("user32.dll", SetLastError = true)]
        private static extern bool BringWindowToTop(IntPtr hWnd);

        [DllImport("user32.dll")]
        static extern IntPtr GetTopWindow(IntPtr hWnd);

        [DllImport("kernel32.dll")]
        static extern IntPtr GetCurrentThreadId();

        [DllImport("user32.dll")]
        static extern bool AttachThreadInput(IntPtr idAttach, IntPtr idAttachTo, bool fAttach);

        [DllImport("user32.dll")]
        static extern IntPtr GetFocus();

        [DllImport("user32.dll")]
        public static extern IntPtr SendMessage(IntPtr hWnd, int msg, IntPtr wParam, IntPtr lParam);

        [DllImport("user32.dll", SetLastError = true)]
        static extern IntPtr FindWindowEx(IntPtr hwndParent, IntPtr hwndChildAfter, string lpszClass, string lpszWindow);

        [DllImport("User32.dll")]
        private static extern bool SetForegroundWindow(IntPtr hWnd);


        const int WM_SYSCOMMAND = 0x0112;
        const int WM_SETTEXT = 0x0C;
        const int WM_COPY = 0x0301;
        const int WM_PASTE = 0x0302;
        const int SC_CLOSE = 0xF060;
        const int WM_HOTKEY = 0x312;


        private static void paste(int index)
        {

            Clipboard.Clear();

            IntPtr windowHandle = GetForegroundWindow();
            IntPtr top = GetTopWindow(windowHandle);

            const int WM_KEYDOWN = 0x100;
            const int WM_KEYUP = 0x101;
            const int VK_F5 = 0x74;

            uint pid = 0;
            IntPtr remoteThreadId = GetWindowThreadProcessId(top, out pid);
            IntPtr currThread = GetCurrentThreadId();

            AttachThreadInput(remoteThreadId, currThread, true);
            IntPtr focussed = GetFocus();

            IntPtr focussed1 = new IntPtr(5179204);

            StringBuilder activechild = new StringBuilder(256);

            if (storedStrings[index] != null && storedStrings[index] != String.Empty)
                Clipboard.SetText(storedStrings[index]);


            SendMessage(focussed, WM_PASTE, IntPtr.Zero, IntPtr.Zero);


            AttachThreadInput(remoteThreadId, currThread, false);

        }

        public HotKeysForm()
        {
            InitializeComponent();
            textBox1.Text = CopyModifiers.ToString();
            PasteTextBox.Text = PasteModifiers.ToString();
            HotKeyManager._wnd = this;
            HotKeyManager._hwnd = this.Handle;
            HotKeyManager._windowReadyEvent.Set();
        }

        public void Start()
        {
            storedStrings = Enumerable.Range(0, 10).Select(i => string.Empty).ToArray();
            toolStrip1.BackColor = System.Drawing.Color.LightGreen;
            ids.Clear();
            ids.Add(HotKeyManager.RegisterHotKey(Keys.D1, CopyModifiers));
            ids.Add(HotKeyManager.RegisterHotKey(Keys.D2, CopyModifiers));
            ids.Add(HotKeyManager.RegisterHotKey(Keys.D3, CopyModifiers));
            ids.Add(HotKeyManager.RegisterHotKey(Keys.D4, CopyModifiers));
            ids.Add(HotKeyManager.RegisterHotKey(Keys.D5, CopyModifiers));
            ids.Add(HotKeyManager.RegisterHotKey(Keys.D6, CopyModifiers));
            ids.Add(HotKeyManager.RegisterHotKey(Keys.D7, CopyModifiers));
            ids.Add(HotKeyManager.RegisterHotKey(Keys.D8, CopyModifiers));
            ids.Add(HotKeyManager.RegisterHotKey(Keys.D9, CopyModifiers));
            ids.Add(HotKeyManager.RegisterHotKey(Keys.D0, CopyModifiers));

            ids.Add(HotKeyManager.RegisterHotKey(Keys.D1, PasteModifiers));
            ids.Add(HotKeyManager.RegisterHotKey(Keys.D2, PasteModifiers));
            ids.Add(HotKeyManager.RegisterHotKey(Keys.D3, PasteModifiers));
            ids.Add(HotKeyManager.RegisterHotKey(Keys.D4, PasteModifiers));
            ids.Add(HotKeyManager.RegisterHotKey(Keys.D5, PasteModifiers));
            ids.Add(HotKeyManager.RegisterHotKey(Keys.D6, PasteModifiers));
            ids.Add(HotKeyManager.RegisterHotKey(Keys.D7, PasteModifiers));
            ids.Add(HotKeyManager.RegisterHotKey(Keys.D8, PasteModifiers));
            ids.Add(HotKeyManager.RegisterHotKey(Keys.D9, PasteModifiers));
            ids.Add(HotKeyManager.RegisterHotKey(Keys.D0, PasteModifiers));

            HotKeyManager.HotKeyPressed += new EventHandler<HotKeyEventArgs>(HotKeyManager_HotKeyPressed);
        }

        public void Stop()
        {
            toolStrip1.BackColor = System.Drawing.Color.LightCoral;
            foreach(var id in ids)
            {
                HotKeyManager.UnregisterHotKey(id);
            }
            ids.Clear();

            HotKeyManager.HotKeyPressed -= new EventHandler<HotKeyEventArgs>(HotKeyManager_HotKeyPressed);

        }

        static void HotKeyManager_HotKeyPressed(object sender, HotKeyEventArgs e)
        {
            var key = e.Key;
            var modifiers = e.Modifiers;

            switch (key)
            {
                case Keys.D1:
                    Console.WriteLine("Switch is working 1");
                    execute(1, modifiers);
                    break;
                case Keys.D2:
                    Console.WriteLine("Switch is working 2");
                    execute(2, modifiers);
                    break;
                case Keys.D3:
                    Console.WriteLine("Switch is working 3");
                    execute(3, modifiers);
                    break;
                case Keys.D4:
                    Console.WriteLine("Switch is working 4");
                    execute(4, modifiers);
                    break;
                case Keys.D5:
                    Console.WriteLine("Switch is working 5");
                    execute(5, modifiers);
                    break;
                case Keys.D6:
                    Console.WriteLine("Switch is working 6");
                    execute(6, modifiers);
                    break;
                case Keys.D7:
                    Console.WriteLine("Switch is working 7");
                    execute(7, modifiers);
                    break;
                case Keys.D8:
                    Console.WriteLine("Switch is working 8");
                    execute(8, modifiers);
                    break;
                case Keys.D9:
                    Console.WriteLine("Switch is working 9");
                    execute(9, modifiers);
                    break;
                case Keys.D0:
                    Console.WriteLine("Switch is working 0");
                    execute(0, modifiers);
                    break;
                default:
                    Console.WriteLine("whoops");
                    break;
            }
        }
        private static void execute(int pos, KeyModifiers modifier)
        {
            if (modifier == CopyModifiers)
            {
                copy(pos);
            }
            else if (modifier == (PasteModifiers))
            {
                paste(pos);
            }
        }

        private static void copy(int pos)
        {
            IntPtr windowHandle = GetForegroundWindow();

            var x = GetTopWindow(windowHandle);

            uint pid = 0;
            IntPtr remoteThreadId = GetWindowThreadProcessId(x, out pid);
            IntPtr currentThreadId = GetCurrentThreadId();

            AttachThreadInput(remoteThreadId, currentThreadId, true);

            IntPtr focussed = GetFocus();

            StringBuilder activechild = new StringBuilder(256);
            AttachThreadInput(remoteThreadId, currentThreadId, false);


            SendMessage(focussed, WM_COPY, IntPtr.Zero, IntPtr.Zero);

            if (Clipboard.ContainsText())
            {
                storedStrings[pos] = Clipboard.GetText();
            }

            Clipboard.Clear();
        }

        protected override void WndProc(ref Message m)
        {
            if (m.Msg == WM_HOTKEY)
            {
                HotKeyEventArgs s = new HotKeyEventArgs(m.LParam);
                HotKeyManager.OnHotKeyPressed(s);
            }

            base.WndProc(ref m);
        }

        private void HotKeysForm_Resize(object sender, EventArgs e)
        {
            if (FormWindowState.Minimized == this.WindowState)
            {
                mynotifyIcon.Visible = true;
                mynotifyIcon.ShowBalloonTip(500);
                this.Hide();
            }
            else
            {
                this.Visible = true;
                mynotifyIcon.Visible = false;
            }
        }

        private void HotKeysForm_Show(object sender, EventArgs e)
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            textBox1.Enabled = false;
            PasteTextBox.Enabled = false;
            StartButton.Enabled = false;
            ToolLabel.Text = "Status: Active";
            StopButton.Enabled = true;
            Start();
        }

        private void TextChange(object sender, EventArgs e)
        {
            var x = textBox1.Text;
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            CopyModifiers = setKeys(e);
            textBox1.Text = CopyModifiers.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void StopButton_Click(object sender, EventArgs e)
        {
            textBox1.Enabled = true;
            PasteTextBox.Enabled = true;
            ToolLabel.Text = "Status: Stopped";
            StopButton.Enabled = false;
            StartButton.Enabled = true;
            Stop();
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void PasteTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            PasteModifiers = setKeys(e);
            PasteTextBox.Text = PasteModifiers.ToString();
        }

        private KeyModifiers setKeys(KeyEventArgs e)
        {
            var key = new KeyModifiers();

            var modifiers = String.Empty;
            var keys = String.Empty;

            if (e.Alt)
            {
                modifiers = modifiers + "(Alt)";
                key = key | KeyModifiers.Alt;
            }
            if (e.Control)
            {
                modifiers = modifiers + "(Ctrl)";
                key = key | KeyModifiers.Control;
            }
            if (e.Shift)
            {
                modifiers = modifiers + "(Shift)";
                key = key | KeyModifiers.Shift;
            }
            
            e.Handled = true;
            e.SuppressKeyPress = true;

            return key;
        }
    }
}
