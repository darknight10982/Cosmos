﻿using Cosmos.Debug.Kernel;

namespace Cosmos.IL2CPU
{
    partial class VTablesImpl
    {
        public static bool EnableDebug = true;
        private static void Debug(string message)
        {
            if (!EnableDebug)
            {
                return;
            }
            Debugger.DoSend(message);
        }

        private static void DebugHex(string message, uint value)
        {
            if (!EnableDebug)
            {
                return;
            }
            Debugger.DoSend(message);
            Debugger.DoSendNumber(value);
        }

        private static void DebugAndHalt(string message)
        {
            Debug(message);
            Debugger.DoRealHalt();
        }
    }
}
