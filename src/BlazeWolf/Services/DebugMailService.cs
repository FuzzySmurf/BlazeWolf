using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace BlazeWolf.Services
{
    public class DebugMailService : IMailService
    {
        public bool SendMail(string to, string @from, string subject, string body)
        {
            //using string interpolation c# 6 feature
            Debug.WriteLine($"Sending mail: To: {to}, Subject: {subject}");
            return true;
        }
    }
}
