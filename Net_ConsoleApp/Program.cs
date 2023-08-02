using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Net_ConsoleApp
{

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct InitReqest
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ConverterInterfaces.SLText)]
        public string _connectionString;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ConverterInterfaces.SLText)]
        public string _connectionAlias;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ConverterInterfaces.SLText)]
        public string _serverName;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ConverterInterfaces.SLText)]
        public string _databaseName;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ConverterInterfaces.SLShortText)]
        public string _applicationUserName;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ConverterInterfaces.SLShortText)]
        public string _applicationApplicationUserPassword;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ConverterInterfaces.SLText)]
        public string _workingFolder;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ConverterInterfaces.SLShortText)]
        public string _schemaName;
        public int _isImportGeneralData; // 0-no, 1-yes

        // // response - answer
        public int _status; // 0-ok, other value - failure
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ConverterInterfaces.SLText)]
        public string _message; // Resulting error or warning message. Details in log.
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ConverterInterfaces.SLText)]
        public string _logPath; // Resulting error or warning message. Details in log.
    }

    internal static class NativeMethods
    {
        [DllImport("D:\\RAMC32\\BIN\\SC_ConvertorDll.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern int ConvertorDllStart( InitReqest parameters);
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            int ret = 0;
            InitReqest param = new InitReqest();
            ret = NativeMethods.ConvertorDllStart( param);
        }
    }
}
