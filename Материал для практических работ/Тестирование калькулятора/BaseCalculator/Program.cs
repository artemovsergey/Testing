using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BaseCalculator
{
    public class Program
    {
        public static int res = 0;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        public static int Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // проверяем, что на входе приложения.
            string execstring = "";
            foreach (string str in args)
            {
                execstring += str;
            }
            
            // если ничего - запускаем стандартную версию
            if (execstring == "")
            {
                Console.SetWindowSize(1, 1);
                Application.Run(new BaseCalc());
                return 0;
            }
            else
            {
                // если что-то есть - считаем выражение и возвращаем результат на консоль
                AnalaizerClass.expression = execstring;
                AnalaizerClass.ShowMessage = false;
                string resstr = AnalaizerClass.Estimate();              
                Console.WriteLine(resstr);
                Console.ReadLine();
                return Convert.ToInt32(res);
            }
        }

        /// <summary>
        /// Тот же самый метод Main() только без вывод в консоль.
        /// Сделано это по причине того, что с ними тесты "зависают".
        /// </summary>
        /// <param name="args">Аргументы командной строки</param>
        /// <returns>Код результата</returns>
        public static int Main2(string[] args)
        {
            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);

            // проверяем, что на входе приложения.
            string execstring = "";
            foreach (string str in args)
            {
                execstring += str;
            }

            // если ничего - запускаем стандартную версию
            if (execstring == "")
            {
                Console.SetWindowSize(1, 1);
                Application.Run(new BaseCalc());
                return 0;
            }
            else
            {
                // если что-то есть - считаем выражение и возвращаем результат на консоль
                AnalaizerClass.expression = execstring;
                AnalaizerClass.ShowMessage = false;
                string resstr = AnalaizerClass.Estimate();
                //Console.WriteLine(resstr);
                //Console.ReadLine();
                return Convert.ToInt32(res);
            }
        }
    }
}