using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.User_Logs
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<string, Dictionary<string, int>> userLogs = new SortedDictionary<string, Dictionary<string, int>>();
            string input = Console.ReadLine();
            while (input != "end")
            {
                var inputArg = input.Split(new char[] { '=', ' ' }, StringSplitOptions.RemoveEmptyEntries);
                var ip = inputArg[1];
                var user = inputArg[5];
                var counter = 1;
                if (!userLogs.ContainsKey(user))
                {
                    userLogs.Add(user, new Dictionary<string, int>());
                }

                if (!userLogs[user].ContainsKey(ip))
                {
                    userLogs[user].Add(ip, counter);
                }
                else
                {
                    userLogs[user][ip]++;
                }
                input = Console.ReadLine();
            }

            foreach (var user in userLogs)
            {
                Console.WriteLine($"{user.Key}: ");
                foreach (var log in user.Value)
                {
                    if (log.Key != user.Value.Keys.Last())
                    {
                        Console.Write($"{log.Key} => {log.Value}, ");
                    }
                    else
                    {
                        Console.WriteLine($"{log.Key} => {log.Value}.");
                    }
                }
            }
        }
    }
}