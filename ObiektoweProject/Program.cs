using Npgsql;
using System.Data;

namespace ObiektoweProject
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());

        }
    }
}