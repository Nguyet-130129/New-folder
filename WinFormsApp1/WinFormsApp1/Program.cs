
//using WinFormsApp1.connect;

using WinFormsApp1.connect;

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
            //ApplicationConfiguration.Initialize();
            //Application.Run(new GUI.ForgetPassword());
            //ketnoi cont = new ketnoi();
            //cont.connection();
            //cont.closeconect(cont.connection());
            Application.Run(new index());

        }
    }
}