using System;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Threading;

namespace HotKeyTestProject
{
    public static class HotKeyManager
    {

        [DllImport("user32", SetLastError = true)]
        private static extern bool RegisterHotKey(IntPtr hWnd, int id, uint fsModifiers, uint vk);

        [DllImport("user32", SetLastError = true)]
        private static extern bool UnregisterHotKey(IntPtr hWnd, int id);

        private static int _id = 0;
        public static event EventHandler<HotKeyEventArgs> HotKeyPressed;
        public static event EventHandler<HotKeyEventArgs> HotKeyPressedCopy;
        public static event EventHandler<HotKeyEventArgs> HotKeyPressedPaste;
        public static volatile HotKeysForm _wnd;
        public static volatile IntPtr _hwnd;
        public static ManualResetEvent _windowReadyEvent = new ManualResetEvent(false);

        delegate void RegisterHotKeyDelegate(IntPtr hwnd, int id, uint modifiers, uint key);
        delegate void UnRegisterHotKeyDelegate(IntPtr hwnd, int id);

        static HotKeyManager()
        {

        }

        public static int RegisterHotKey(Keys key, KeyModifiers modifiers)
        {
            _windowReadyEvent.WaitOne();
            int id = System.Threading.Interlocked.Increment(ref _id);
            _wnd.Invoke(new RegisterHotKeyDelegate(RegisterHotKeyInternal), _hwnd, id, (uint)modifiers, (uint)key);
            return id;
        }

        public static void UnregisterHotKey(int id)
        {
            _wnd.Invoke(new UnRegisterHotKeyDelegate(UnRegisterHotKeyInternal), _hwnd, id);
        }      

        private static void RegisterHotKeyInternal(IntPtr hwnd, int id, uint modifiers, uint key)
        {
            RegisterHotKey(hwnd, id, modifiers, key);
        }

        private static void UnRegisterHotKeyInternal(IntPtr hwnd, int id)
        {
            UnregisterHotKey(_hwnd, id);
        }

        public static void OnHotKeyPressed(HotKeyEventArgs e)
        {
            if (HotKeyManager.HotKeyPressed != null)
            {
                HotKeyManager.HotKeyPressed(null, e);
            }
        }

    }

    [Flags]
    public enum KeyModifiers
    {
        Alt = 1,
        Control = 2,
        Shift = 4,
        Windows = 8,
        NoRepeat = 0x4000,
        NONE = 0
    }
}
