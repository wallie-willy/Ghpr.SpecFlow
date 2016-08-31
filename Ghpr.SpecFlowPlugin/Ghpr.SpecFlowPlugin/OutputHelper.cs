﻿using System.IO;

namespace Ghpr.SpecFlowPlugin
{
    public static class OutputHelper
    {
        private static readonly StringWriter Sw;

        static OutputHelper()
        {
            Sw = new StringWriter();
        }

        public static void Flush()
        {
            Sw.Flush();
        }

        public static void Dispose()
        {
            Sw.Dispose();
        }

        public static void Write(string s)
        {
            Sw.Write(s);
        }
    }
}