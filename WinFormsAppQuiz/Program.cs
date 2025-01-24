using WinFormsAppQuiz.Forms;

namespace WinFormsAppQuiz
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


            // this 2 for user input
            LoginForm loginForm = new LoginForm();
            loginForm.Show();



            // these 2 for admin input
            //AdminLogin adminLogin = new AdminLogin(); 
            //adminLogin.Show();


            Application.Run();
        }
    }
}