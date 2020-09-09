using System;
using System.Collections.Generic;
using System.Text;

namespace Entity.Common
{
    public class LoggingService 
    {
        private static void WriteToFile(List<ILoggable> itemsToLog)
        {
            // since every object implements the Iloggable interface
            // you do not need to know anything abut the implementation in any project
            foreach(ILoggable item in itemsToLog)
            {
                Console.WriteLine(item.Log());
            }
        }
    }
}
