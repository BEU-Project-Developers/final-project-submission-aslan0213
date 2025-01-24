using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsAppQuiz.DataAccess;

namespace WinFormsAppQuiz.Services
{
    public static class LoginService
    {
        public static bool Authenticate(string login, string password)
        {
            using (var context = new QuestionDbContext())
            {

                var admin = context.Admins.FirstOrDefault(a => a.Login == login && a.Password == password);

                return admin != null;
            }
        }

        public static bool AdminAuthenticate(string full_name, string login, string password)
        {
            using (var context = new QuestionDbContext())
            {

                var oneadmin = context.OneAdmin.FirstOrDefault(a => a.Login == login && a.Password == password && a.Full_Name==full_name);

                return oneadmin != null;
            }
        }

    }
}
