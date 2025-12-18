using System;
using System.Windows.Forms;

namespace TrybikMacro;

static class Program
{
    [STAThread]
    static void Main()
    {
        ApplicationConfiguration.Initialize();
        Application.Run(new Main()); 
    }
}
