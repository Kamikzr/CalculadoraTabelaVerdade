using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraTabelaVerdade
{
    public static class Debug
    {
        private static int LastIndexOfInstruction;
        private static double Instruction = 1f;
        private static Random GenerateInstruction = new Random();
        private static List<Log> LastInstructions = new List<Log>();
        public static void Logger(params string[] _args)
        {
            LastIndexOfInstruction = LastInstructions.Count;
            foreach (string arg in _args)
            {
                Instruction += GenerateInstruction.NextDouble();
                LastInstructions.Add(new Log() { LogString = arg, LogInstruct = Instruction });
                if(LastIndexOfInstruction != 0)
                {
                    if (LastInstructions[LastIndexOfInstruction].LogString != LastInstructions[LastIndexOfInstruction - 1].LogString)
                        Console.WriteLine("[{0:N2}] Logged |  {1}", Instruction, arg);
                }
                else if(LastIndexOfInstruction == 0)
                    Console.WriteLine("[{0:N2}] Logged |  {1}", Instruction, arg);
            }
        }

        public static void ShowLogs()
        {
            foreach (Log AlocatedLog in LastInstructions)
                Console.WriteLine(AlocatedLog);
        }
    }

    public class Log : IEquatable<Log>
    {
        public string LogString { get; set; }

        public double LogInstruct { get; set; }

        public override string ToString()
        {
            return "Instruct: " + LogInstruct + "   String: " + LogString;
        }
        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            Log objAsLog = obj as Log;
            if (objAsLog == null) return false;
            else return Equals(objAsLog);
        }
        public double GetHash()
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
