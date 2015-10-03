using System;
using System.IO;

namespace UnitTestObserver.mocks
{
    /// <summary>
    /// Redirects Console output to a memory string
    /// </summary>
    public class ConsoleMock
    {
        private StringWriter consoleStream = null;

        public ConsoleMock()
        {
            consoleStream = new StringWriter();
            Console.SetOut(consoleStream);
        }

        public string Output()
        {
            String s = consoleStream.ToString().Trim();
            consoleStream.GetStringBuilder().Clear();
            return s;
        }
    }
}
