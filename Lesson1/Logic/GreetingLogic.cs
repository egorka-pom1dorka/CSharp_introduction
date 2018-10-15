using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public static class GreetingLogic
    {
        public static string GetGreetingMessage(string userName)
        //=> $"Hello, {userName}";
        {
            if (userName == null)
            {
                throw new ArgumentNullException($"{nameof(userName)}can't be empty");
            }

            userName = userName != string.Empty ? userName : "User";
            //return "hello, " + userName + "!";
            //return string.format("hello, {0}!", userName);
            return $"Hello, {userName}!";
        }
    }
}
