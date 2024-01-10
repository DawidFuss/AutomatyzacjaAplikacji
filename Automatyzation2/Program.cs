using RobotFormsLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Automatyzation2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("czekam na przycisk");
            Console.ReadKey();
            string sqlManagementStudio = @"C:\Program Files (x86)\Microsoft SQL Server Management Studio 18\Common7\IDE\Ssms.exe";
            Robot.Execute(sqlManagementStudio);

          //  Robot.Screenshot().Save("test.bmp");
            Thread.Sleep(10000);
            Robot.SetCursorPos(900, 550);
            Robot.MouseLeftDown();
            Robot.MouseLeftUp();
            


        }
    }
}
