using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopAndDesignPatterns.SOLIDPrinciples.SingleResponsibility
{
    internal class UserService
    {
        public void Register(User user)
        {
            //Send email
            EmailSender emailSender = new();
            emailSender.SendEmail(user.Email, "Welcome");
        }
    }
}
