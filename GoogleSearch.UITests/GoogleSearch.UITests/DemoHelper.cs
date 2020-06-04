using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace GoogleSearch.UITests
{
    internal static class DemoHelper
    {
        /// <summary>
        /// Brief delay to slow down browser interactions for demo purposes
        /// </summary>
        /// <param name="secondsToPause"></param>
        public static void Pause(int secondsToPause = 3000)
        {
            Thread.Sleep(secondsToPause);
        }
    }
}
