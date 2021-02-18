using Agilent.CommandExpert.ScpiNet.AgMXG_A_01_80;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DashoardSignalGenerator
{
    static class main
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new View());



            int tst = 0;
            AgMXG SignalGenerator = new AgMXG("GPIB0::5::INSTR");
            SignalGenerator.SCPI.SOURce.FREQuency.CW.Command(3000000);
            Console.WriteLine(" deed het wel");
        }
    }
}
