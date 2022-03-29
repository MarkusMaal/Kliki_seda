using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Click_it
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        public static Form2 secret = new Form2();
        [STAThread]
        static void Main()
        {
            Application.Run(new Form1());
        }
    }
}
