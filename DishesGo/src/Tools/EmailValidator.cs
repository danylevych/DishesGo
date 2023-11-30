using System;
using System.Net.Mail;

namespace DishesGo.src.Tools
{
    public static class EmailValidator
    {
        public static bool IsValidEmail(string email)
        {
            try
            {
                // Trying to create an instance of mail.
                MailAddress mailAddress = new MailAddress(email);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
