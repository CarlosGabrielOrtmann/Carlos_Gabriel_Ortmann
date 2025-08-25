using System.Collections;

namespace WinFormsApp1
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
            //ArrayList

            ArrayList lista = new ArrayList();

            lista.Add(1203);
            lista.Add("Hello World");
            lista.Add(46546.6546);
            lista.Add("TB");
        }
    }
}