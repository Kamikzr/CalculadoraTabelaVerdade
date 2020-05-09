using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace CalculadoraTabelaVerdade
{
    public static class Debug
    {
        private static int LastIndexOfInstruction;
        private static double NumberOfInstruction = 1f;
        private static String Country = "en-US", Time;
        private static Random GenerateInstruction = new Random();
        private static List<Log> Instructions = new List<Log>();
        public static void Logger(params string[] _args)
        {
            Time = GetTime();
            LastIndexOfInstruction = Instructions.Count;
            foreach (string arg in _args)
            {
                NumberOfInstruction += GenerateInstruction.NextDouble();
                Instructions.Add(new Log() { LogString = arg, LogInstruct = NumberOfInstruction.ToString("F"), LogTime = Time });
                if(LastIndexOfInstruction != 0)
                {
                    if (Instructions[LastIndexOfInstruction].LogString != Instructions[LastIndexOfInstruction - 1].LogString)
                        Console.WriteLine("[{0:N2}] Logged |  {1}  - At {2}", NumberOfInstruction, arg, Time);
                }
                else if(LastIndexOfInstruction == 0)
                    Console.WriteLine("[{0:N2}] Logged |  {1}  - At {2}", NumberOfInstruction, arg, Time);
            }
        }

        private static string GetTime()
        {
            DateTime LocalTime = DateTime.Now;
            var culture = new CultureInfo(Country);
            return LocalTime.ToString(culture);
        }

        public static void ShowLogs()
        {
            foreach (Log AlocatedLog in Instructions)
                Console.WriteLine(AlocatedLog);
        }
    }

    public class Log : IEquatable<Log>
    {
        public string LogString { get; set; }

        public string LogInstruct { get; set; }

        public string LogTime { get; set; }

        public override string ToString()
        {
            return "Instruct: " + LogInstruct + "   String: " + LogString + "  -  At Time: " + LogTime;
        }
        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            Log objAsLog = obj as Log;
            if (objAsLog == null) return false;
            else return Equals(objAsLog);
        }
        public string GetHash()
        {
            return LogInstruct;
        }
        public bool Equals(Log other)
        {
            if (other == null) return false;
            return (this.LogInstruct.Equals(other.LogInstruct));
        }
    }
}
