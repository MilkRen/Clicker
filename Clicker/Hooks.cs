using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Hooks
{
    public static class KBDHook
    {
        #region Declarations
        public delegate void HookKeyPress(LLKHEventArgs e);
        public static event HookKeyPress KeyUp;
        public static event HookKeyPress KeyDown;

        [StructLayout(LayoutKind.Sequential)]
        struct KBDLLHOOKSTRUCT
        {
            public uint vkCode;
            public uint scanCode;
            public KBDLLHOOKSTRUCTFlags flags;
            public uint time;
            public IntPtr dwExtraInfo;
        }

        [Flags]
        enum KBDLLHOOKSTRUCTFlags : int
        {
            LLKHF_EXTENDED = 0x01,
            LLKHF_INJECTED = 0x10,
            LLKHF_ALTDOWN = 0x20,
            LLKHF_UP = 0x80,
        }

        static IntPtr hHook = IntPtr.Zero;
        static IntPtr hModule = IntPtr.Zero;
        static bool hookInstall = false;
        static bool localHook = true;
        static API.HookProc hookDel;
        #endregion

        /// <summary>
        /// Hook install method.
        /// </summary>
        public static void InstallHook()
        {
            if (IsHookInstalled) return;

            hModule = Marshal.GetHINSTANCE(AppDomain.CurrentDomain.GetAssemblies()[0].GetModules()[0]);
            hookDel = new API.HookProc(HookProcFunction);

            if (localHook)
                hHook = API.SetWindowsHookEx(API.HookType.WH_KEYBOARD,
                    hookDel, IntPtr.Zero, AppDomain.GetCurrentThreadId());
            else
                hHook = API.SetWindowsHookEx(API.HookType.WH_KEYBOARD_LL,
                    hookDel, hModule, 0);

            if (hHook != IntPtr.Zero)
                hookInstall = true;
            else
                throw new Win32Exception("Can't install low level keyboard hook!");
        }
        /// <summary>
        /// If hook installed return true, either false.
        /// </summary>
        public static bool IsHookInstalled
        {
            get { return hookInstall && hHook != IntPtr.Zero; }
        }
        /// <summary>
        /// Module handle in which hook was installed.
        /// </summary>
        public static IntPtr ModuleHandle
        {
            get { return hModule; }
        }
        /// <summary>
        /// If true local hook will installed, either global.
        /// </summary>
        public static bool LocalHook
        {
            get { return localHook; }
            set
            {
                if (value != localHook)
                {
                    if (IsHookInstalled)
                        throw new Win32Exception("Can't change type of hook than it install!");
                    localHook = value;
                }
            }
        }
        /// <summary>
        /// Uninstall hook method.
        /// </summary>
        public static void UnInstallHook()
        {
            if (IsHookInstalled)
            {
                if (!API.UnhookWindowsHookEx(hHook))
                    throw new Win32Exception("Can't uninstall low level keyboard hook!");
                hHook = IntPtr.Zero;
                hModule = IntPtr.Zero;
                hookInstall = false;
            }
        }
        /// <summary>
        /// Hook process messages.
        /// </summary>
        /// <param name="nCode"></param>
        /// <param name="wParam"></param>
        /// <param name="lParam"></param>
        /// <returns></returns>
        static IntPtr HookProcFunction(int nCode, IntPtr wParam, [In] IntPtr lParam)
        {
            if (nCode == 0)
            {
                LLKHEventArgs args = null;
                if (localHook)
                {
                    bool pressed = false;
                    if (lParam.ToInt32() >> 31 == 0)
                        pressed = true;

                    Keys keys = (Keys)wParam.ToInt32();
                    args = new LLKHEventArgs(keys, pressed, 0U, 0U);

                    if (pressed)
                    {
                        if (KeyDown != null)
                            KeyDown(args);
                    }
                    else
                    {
                        if (KeyUp != null)
                            KeyUp(args);
                    }
                }
                else
                {
                    KBDLLHOOKSTRUCT kbd = (KBDLLHOOKSTRUCT)Marshal.PtrToStructure(lParam, typeof(KBDLLHOOKSTRUCT));

                    bool pressed = false;
                    if (wParam.ToInt32() == 0x100 || wParam.ToInt32() == 0x104)
                        pressed = true;

                    Keys keys = (Keys)kbd.vkCode;
                    args = new LLKHEventArgs(keys, pressed, kbd.time, kbd.scanCode);

                    if (pressed)
                    {
                        if (KeyDown != null)
                            KeyDown(args);
                    }
                    else
                    {
                        if (KeyUp != null)
                            KeyUp(args);
                    }
                }

                if (args != null && args.Hooked)
                    return (IntPtr)1;
            }
            return API.CallNextHookEx(hHook, nCode, wParam, lParam);
        }
    }

    public class LLKHEventArgs
    {
        Keys keys;
        bool pressed;
        uint time;
        uint scCode;

        public LLKHEventArgs(Keys keys, bool pressed, uint time, uint scanCode)
        {
            this.keys = keys;
            this.pressed = pressed;
            this.time = time;
            this.scCode = scanCode;
        }

        /// <summary>
        /// Key.
        /// </summary>
        public Keys Keys
        { get { return keys; } }
        /// <summary>
        /// Is key pressed or no.
        /// </summary>
        public bool IsPressed
        { get { return pressed; } }
        /// <summary>
        /// The time stamp for this message, equivalent to what GetMessageTime would return for this message.
        /// </summary>
        public uint Time
        { get { return time; } }
        /// <summary>
        /// A hardware scan code for the key.
        /// </summary>
        public uint ScanCode
        { get { return scCode; } }
        /// <summary>
        /// Is user hook key.
        /// </summary>
        public bool Hooked { get; set; }
    }

    static class API
    {
        public delegate IntPtr HookProc(int nCode, IntPtr wParam, [In] IntPtr lParam);

        [DllImport("user32.dll")]
        public static extern IntPtr CallNextHookEx(IntPtr hhk, int nCode, IntPtr wParam, [In] IntPtr lParam);

        [DllImport("user32.dll", SetLastError = true)]
        public static extern IntPtr SetWindowsHookEx(HookType hookType, HookProc lpfn,
        IntPtr hMod, int dwThreadId);

        [DllImport("user32.dll", SetLastError = true)]
        public static extern bool UnhookWindowsHookEx(IntPtr hhk);

        [DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern IntPtr GetModuleHandle(string lpModuleName);

        public enum HookType : int
        {
            WH_JOURNALRECORD = 0,
            WH_JOURNALPLAYBACK = 1,
            WH_KEYBOARD = 2,
            WH_GETMESSAGE = 3,
            WH_CALLWNDPROC = 4,
            WH_CBT = 5,
            WH_SYSMSGFILTER = 6,
            WH_MOUSE = 7,
            WH_HARDWARE = 8,
            WH_DEBUG = 9,
            WH_SHELL = 10,
            WH_FOREGROUNDIDLE = 11,
            WH_CALLWNDPROCRET = 12,
            WH_KEYBOARD_LL = 13,
            WH_MOUSE_LL = 14
        }
    }
}