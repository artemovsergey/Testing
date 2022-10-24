using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_2_TestDriver
{
    static class Program
    {
        /// <summary>
        ///  Тестовый драйвер для программы калькулятора. Лабораторная работа №2.
        ///  Тут же модульное тестирование для класса AnalaizerClass.cs. Лабораторная работа №3.
        ///  Автор: Ежов Глеб
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
