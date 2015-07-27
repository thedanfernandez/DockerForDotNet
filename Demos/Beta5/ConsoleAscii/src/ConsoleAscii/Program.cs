
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleAscii
{
    public class Program
    {
        public void Main(string[] args)
        {

            //Make all Trace statements write to console
            Trace.Listeners.Add(new ConsoleTraceListener());

            //Show three examples of tracing
            Trace.TraceInformation("Starting jp2a - Information");
            Trace.TraceError("Starting jp2a - Error");
            Trace.TraceWarning("Starting jp2a - Warning");

            //Configure processes
            Process p = new Process();

            var start = new ProcessStartInfo("jp2a", "http://blogs.msdn.com/blogfiles/danielfe/WindowsLiveWriter/ThatKingCharlesSpanielEnglishToySpanieli_E6BE/582207017103_0_ALB%5B1%5D.jpg");
            start.UseShellExecute = false;
            start.RedirectStandardOutput = true;
            p.StartInfo = start;

            //Start!
            p.Start();

            //Get output written to standard out as a string
            string output = p.StandardOutput.ReadToEnd();
            p.WaitForExit();

            //Write to output
            Console.WriteLine(output);

            //Wait forever
            Console.Read();

        }
    }
}
