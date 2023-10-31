using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTest.Seminar3.HomeWork3
{
    public class MoodAnalyser
    {
        public string AnalyseMood(string message)
        {
            if (string.IsNullOrEmpty(message))
            {
                return "Неопределенное настроение"; // Вернуть "Неопределенное настроение" для пустых сообщений
            }

            if (message.Contains("счастлив"))
            {
                return "Счастливое настроение";
            }
            else if (message.Contains("груст"))
            {
                return "Грустное настроение";
            }
            else
            {
                return "Неопределенное настроение"; // Вернуть "Неопределенное настроение" для остальных случаев
            }
        }
    }


}
