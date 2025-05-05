using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arthur_Rodrigues_DR4_TP1
{
    internal class Logger
    {
        public void LogToConsole(string message)
        {
            Console.WriteLine($"[Console] {message}");
        }

        public void LogToFile(string message)
        {
            File.AppendAllText("log.txt", $"[Arquivo] {message}{Environment.NewLine}");
        }

        public void LogToDatabase(string message)
        {
            Console.WriteLine($"[Banco] (Simulado) {message}");
        }
    }
}
