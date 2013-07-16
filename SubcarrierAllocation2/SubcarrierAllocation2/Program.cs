using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace SubcarrierAllocation2
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            /*DataToXML test = new DataToXML();
            Solution sol = new Solution(3, 3, "ala");
            test.combinedSolutions.Add(sol);
            XmlSerializer.Serialize<DataToXML>("test.xml", test);*/

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainWindow());
            
         
        }
    }
}
