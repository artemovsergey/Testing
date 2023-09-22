using System;
using System.Collections;
using System.Windows.Forms;
using BaseCalculator;

namespace Lab_2_TestDriver
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Кнопка для тестирования математической операции
        private void button1_Click(object sender, EventArgs e)
        {
            mainTextBox.Text = "";
            mainTextBox.Text = "Тестирование метода деления с остатком." + Environment.NewLine;

            // 1 тестовый пример
            try
            {
                mainTextBox.Text += "Test Case 1" + Environment.NewLine;
                mainTextBox.Text += "Входные данные: a = -2147483648, b = -2147483648" + Environment.NewLine;
                mainTextBox.Text += "Ожидаемый результат: res = 0" + Environment.NewLine;
                int res = CalcClass.Mod(-2147483648, -2147483648);
                string error = CalcClass.lastError;
                mainTextBox.Text += "Код ошибки: " + error + Environment.NewLine;
                mainTextBox.Text += "Получившийся результат: " + "res = " + res.ToString() + Environment.NewLine;
                if (res == 0 && error == "")
                {
                    mainTextBox.Text += "Тест пройден" + Environment.NewLine + Environment.NewLine;
                }
                else
                {
                    mainTextBox.Text += "Тест не пройден" + Environment.NewLine + Environment.NewLine;
                }
            }
            catch (Exception ex)
            {
                mainTextBox.Text += "Перехвачено исключение: " + ex.ToString() + Environment.NewLine + "Тест не пройден." + Environment.NewLine;
            }

            // 2 тестовый пример
            try
            {
                mainTextBox.Text += "Test Case 2" + Environment.NewLine;
                mainTextBox.Text += "Входные данные: a = 2147483647, b = -2147483648" + Environment.NewLine;
                mainTextBox.Text += "Ожидаемый результат: res = 2147483647" + Environment.NewLine;
                int res = CalcClass.Mod(2147483647, -2147483648);
                string error = CalcClass.lastError;
                mainTextBox.Text += "Код ошибки: " + error + Environment.NewLine;
                mainTextBox.Text += "Получившийся результат: " + "res = " + res.ToString() + Environment.NewLine;
                if (res == 2147483647 && error == "")
                {
                    mainTextBox.Text += "Тест пройден" + Environment.NewLine + Environment.NewLine;
                }
                else
                {
                    mainTextBox.Text += "Тест не пройден" + Environment.NewLine + Environment.NewLine;
                }
            }
            catch (Exception ex)
            {
                mainTextBox.Text += "Перехвачено исключение: " + ex.ToString() + Environment.NewLine + "Тест не пройден." + Environment.NewLine;
            }

            // 3 тестовый пример
            try
            {
                mainTextBox.Text += "Test Case 3" + Environment.NewLine;
                mainTextBox.Text += "Входные данные: a = -2147483648, b = 2147483647" + Environment.NewLine;
                mainTextBox.Text += "Ожидаемый результат: res = -1" + Environment.NewLine;
                int res = CalcClass.Mod(-2147483648, 2147483647);
                string error = CalcClass.lastError;
                mainTextBox.Text += "Код ошибки: " + error + Environment.NewLine;
                mainTextBox.Text += "Получившийся результат: " + "res = " + res.ToString() + Environment.NewLine;
                if (res == -1 && error == "")
                {
                    mainTextBox.Text += "Тест пройден" + Environment.NewLine + Environment.NewLine;
                }
                else
                {
                    mainTextBox.Text += "Тест не пройден" + Environment.NewLine + Environment.NewLine;
                }
            }
            catch (Exception ex)
            {
                mainTextBox.Text += "Перехвачено исключение: " + ex.ToString() + Environment.NewLine + "Тест не пройден." + Environment.NewLine;
            }

            // 4 тестовый пример
            try
            {
                mainTextBox.Text += "Test Case 4" + Environment.NewLine;
                mainTextBox.Text += "Входные данные: a = 2147483647, b = 2147483647" + Environment.NewLine;
                mainTextBox.Text += "Ожидаемый результат: res = 0" + Environment.NewLine;
                int res = CalcClass.Mod(2147483647, 2147483647);
                string error = CalcClass.lastError;
                mainTextBox.Text += "Код ошибки: " + error + Environment.NewLine;
                mainTextBox.Text += "Получившийся результат: " + "res = " + res.ToString() + Environment.NewLine;
                if (res == 0 && error == "")
                {
                    mainTextBox.Text += "Тест пройден" + Environment.NewLine + Environment.NewLine;
                }
                else
                {
                    mainTextBox.Text += "Тест не пройден" + Environment.NewLine + Environment.NewLine;
                }
            }
            catch (Exception ex)
            {
                mainTextBox.Text += "Перехвачено исключение: " + ex.ToString() + Environment.NewLine + "Тест не пройден." + Environment.NewLine;
            }

            // 5 тестовый пример
            try
            {
                mainTextBox.Text += "Test Case 5" + Environment.NewLine;
                mainTextBox.Text += "Входные данные: a = 66882233, b = 2147483646" + Environment.NewLine;
                mainTextBox.Text += "Ожидаемый результат: res = 66882233" + Environment.NewLine;
                int res = CalcClass.Mod(66882233, 2147483646);
                string error = CalcClass.lastError;
                mainTextBox.Text += "Код ошибки: " + error + Environment.NewLine;
                mainTextBox.Text += "Получившийся результат: " + "res = " + res.ToString() + Environment.NewLine;
                if (res == 66882233 && error == "")
                {
                    mainTextBox.Text += "Тест пройден" + Environment.NewLine + Environment.NewLine;
                }
                else
                {
                    mainTextBox.Text += "Тест не пройден" + Environment.NewLine + Environment.NewLine;
                }
            }
            catch (Exception ex)
            {
                mainTextBox.Text += "Перехвачено исключение: " + ex.ToString() + Environment.NewLine + "Тест не пройден." + Environment.NewLine;
            }

            // 6 тестовый пример
            try
            {
                mainTextBox.Text += "Test Case 6" + Environment.NewLine;
                mainTextBox.Text += "Входные данные: a = -2147483647, b = -112244" + Environment.NewLine;
                mainTextBox.Text += "Ожидаемый результат: res = -31439" + Environment.NewLine;
                int res = CalcClass.Mod(-2147483647, -112244);
                string error = CalcClass.lastError;
                mainTextBox.Text += "Код ошибки: " + error + Environment.NewLine;
                mainTextBox.Text += "Получившийся результат: " + "res = " + res.ToString() + Environment.NewLine;
                if (res == -31439 && error == "")
                {
                    mainTextBox.Text += "Тест пройден" + Environment.NewLine + Environment.NewLine;
                }
                else
                {
                    mainTextBox.Text += "Тест не пройден" + Environment.NewLine + Environment.NewLine;
                }
            }
            catch (Exception ex)
            {
                mainTextBox.Text += "Перехвачено исключение: " + ex.ToString() + Environment.NewLine + "Тест не пройден." + Environment.NewLine;
            }

            // 7 тестовый пример
            try
            {
                mainTextBox.Text += "Test Case 7" + Environment.NewLine;
                mainTextBox.Text += "Входные данные: a = 0, b = 2147483646" + Environment.NewLine;
                mainTextBox.Text += "Ожидаемый результат: res = 0" + Environment.NewLine;
                int res = CalcClass.Mod(0, 2147483646);
                string error = CalcClass.lastError;
                mainTextBox.Text += "Код ошибки: " + error + Environment.NewLine;
                mainTextBox.Text += "Получившийся результат: " + "res = " + res.ToString() + Environment.NewLine;
                if (res == 0 && error == "")
                {
                    mainTextBox.Text += "Тест пройден" + Environment.NewLine + Environment.NewLine;
                }
                else
                {
                    mainTextBox.Text += "Тест не пройден" + Environment.NewLine + Environment.NewLine;
                }
            }
            catch (Exception ex)
            {
                mainTextBox.Text += "Перехвачено исключение: " + ex.ToString() + Environment.NewLine + "Тест не пройден." + Environment.NewLine;
            }

            // 8 тестовый пример
            try
            {
                mainTextBox.Text += "Test Case 8" + Environment.NewLine;
                mainTextBox.Text += "Входные данные: a = 0, b = -2147483647" + Environment.NewLine;
                mainTextBox.Text += "Ожидаемый результат: res = 0" + Environment.NewLine;
                int res = CalcClass.Mod(0, -2147483647);
                string error = CalcClass.lastError;
                mainTextBox.Text += "Код ошибки: " + error + Environment.NewLine;
                mainTextBox.Text += "Получившийся результат: " + "res = " + res.ToString() + Environment.NewLine;
                if (res == 0 && error == "")
                {
                    mainTextBox.Text += "Тест пройден" + Environment.NewLine + Environment.NewLine;
                }
                else
                {
                    mainTextBox.Text += "Тест не пройден" + Environment.NewLine + Environment.NewLine;
                }
            }
            catch (Exception ex)
            {
                mainTextBox.Text += "Перехвачено исключение: " + ex.ToString() + Environment.NewLine + "Тест не пройден." + Environment.NewLine;
            }

            // 9 тестовый пример
            try
            {
                mainTextBox.Text += "Test Case 9" + Environment.NewLine;
                mainTextBox.Text += "Входные данные: a = -2147483647, b = 2147483646" + Environment.NewLine;
                mainTextBox.Text += "Ожидаемый результат: res = -1" + Environment.NewLine;
                int res = CalcClass.Mod(-2147483647, 2147483646);
                string error = CalcClass.lastError;
                mainTextBox.Text += "Код ошибки: " + error + Environment.NewLine;
                mainTextBox.Text += "Получившийся результат: " + "res = " + res.ToString() + Environment.NewLine;
                if (res == -1 && error == "")
                {
                    mainTextBox.Text += "Тест пройден" + Environment.NewLine + Environment.NewLine;
                }
                else
                {
                    mainTextBox.Text += "Тест не пройден" + Environment.NewLine + Environment.NewLine;
                }
            }
            catch (Exception ex)
            {
                mainTextBox.Text += "Перехвачено исключение: " + ex.ToString() + Environment.NewLine + "Тест не пройден." + Environment.NewLine;
            }

            // 10 тестовый пример
            try
            {
                mainTextBox.Text += "Test Case 10" + Environment.NewLine;
                mainTextBox.Text += "Входные данные: a = 2147483646, b = -2147483647" + Environment.NewLine;
                mainTextBox.Text += "Ожидаемый результат: res = 2147483646" + Environment.NewLine;
                int res = CalcClass.Mod(2147483646, -2147483647);
                string error = CalcClass.lastError;
                mainTextBox.Text += "Код ошибки: " + error + Environment.NewLine;
                mainTextBox.Text += "Получившийся результат: " + "res = " + res.ToString() + Environment.NewLine;
                if (res == 2147483646 && error == "")
                {
                    mainTextBox.Text += "Тест пройден" + Environment.NewLine + Environment.NewLine;
                }
                else
                {
                    mainTextBox.Text += "Тест не пройден" + Environment.NewLine + Environment.NewLine;
                }
            }
            catch (Exception ex)
            {
                mainTextBox.Text += "Перехвачено исключение: " + ex.ToString() + Environment.NewLine + "Тест не пройден." + Environment.NewLine;
            }

            // 11 тестовый пример
            try
            {
                mainTextBox.Text += "Test Case 11" + Environment.NewLine;
                mainTextBox.Text += "Входные данные: a = 2147483647, b = 779955" + Environment.NewLine;
                mainTextBox.Text += "Ожидаемый результат: res = 267532" + Environment.NewLine;
                int res = CalcClass.Mod(2147483647, 779955);
                string error = CalcClass.lastError;
                mainTextBox.Text += "Код ошибки: " + error + Environment.NewLine;
                mainTextBox.Text += "Получившийся результат: " + "res = " + res.ToString() + Environment.NewLine;
                if (res == 267532 && error == "")
                {
                    mainTextBox.Text += "Тест пройден" + Environment.NewLine + Environment.NewLine;
                }
                else
                {
                    mainTextBox.Text += "Тест не пройден" + Environment.NewLine + Environment.NewLine;
                }
            }
            catch (Exception ex)
            {
                mainTextBox.Text += "Перехвачено исключение: " + ex.ToString() + Environment.NewLine + "Тест не пройден." + Environment.NewLine;
            }

            // 12 тестовый пример
            try
            {
                mainTextBox.Text += "Test Case 12" + Environment.NewLine;
                mainTextBox.Text += "Входные данные: a = -2147483648, b = 123123" + Environment.NewLine;
                mainTextBox.Text += "Ожидаемый результат: res = -95405" + Environment.NewLine;
                int res = CalcClass.Mod(-2147483648, 123123);
                string error = CalcClass.lastError;
                mainTextBox.Text += "Код ошибки: " + error + Environment.NewLine;
                mainTextBox.Text += "Получившийся результат: " + "res = " + res.ToString() + Environment.NewLine;
                if (res == -95405 && error == "")
                {
                    mainTextBox.Text += "Тест пройден" + Environment.NewLine + Environment.NewLine;
                }
                else
                {
                    mainTextBox.Text += "Тест не пройден" + Environment.NewLine + Environment.NewLine;
                }
            }
            catch (Exception ex)
            {
                mainTextBox.Text += "Перехвачено исключение: " + ex.ToString() + Environment.NewLine + "Тест не пройден." + Environment.NewLine;
            }

            // 13 тестовый пример
            try
            {
                mainTextBox.Text += "Test Case 13" + Environment.NewLine;
                mainTextBox.Text += "Входные данные: a = 456, b = 2147483647" + Environment.NewLine;
                mainTextBox.Text += "Ожидаемый результат: res = 456" + Environment.NewLine;
                int res = CalcClass.Mod(456, 2147483647);
                string error = CalcClass.lastError;
                mainTextBox.Text += "Код ошибки: " + error + Environment.NewLine;
                mainTextBox.Text += "Получившийся результат: " + "res = " + res.ToString() + Environment.NewLine;
                if (res == 456 && error == "")
                {
                    mainTextBox.Text += "Тест пройден" + Environment.NewLine + Environment.NewLine;
                }
                else
                {
                    mainTextBox.Text += "Тест не пройден" + Environment.NewLine + Environment.NewLine;
                }
            }
            catch (Exception ex)
            {
                mainTextBox.Text += "Перехвачено исключение: " + ex.ToString() + Environment.NewLine + "Тест не пройден." + Environment.NewLine;
            }

            // 14 тестовый пример
            try
            {
                mainTextBox.Text += "Test Case 14" + Environment.NewLine;
                mainTextBox.Text += "Входные данные: a = 3010789, b = -2147483648" + Environment.NewLine;
                mainTextBox.Text += "Ожидаемый результат: res = 3010789" + Environment.NewLine;
                int res = CalcClass.Mod(3010789, -2147483648);
                string error = CalcClass.lastError;
                mainTextBox.Text += "Код ошибки: " + error + Environment.NewLine;
                mainTextBox.Text += "Получившийся результат: " + "res = " + res.ToString() + Environment.NewLine;
                if (res == 3010789 && error == "")
                {
                    mainTextBox.Text += "Тест пройден" + Environment.NewLine + Environment.NewLine;
                }
                else
                {
                    mainTextBox.Text += "Тест не пройден" + Environment.NewLine + Environment.NewLine;
                }
            }
            catch (Exception ex)
            {
                mainTextBox.Text += "Перехвачено исключение: " + ex.ToString() + Environment.NewLine + "Тест не пройден." + Environment.NewLine;
            }

            // 15 тестовый пример
            try
            {
                mainTextBox.Text += "Test Case 15" + Environment.NewLine;
                mainTextBox.Text += "Входные данные: a = 2147483648, b = 3" + Environment.NewLine;
                mainTextBox.Text += "Ожидаемый результат: Error 06" + Environment.NewLine;
                int res = CalcClass.Mod(2147483648, 3);
                string error = CalcClass.lastError;
                mainTextBox.Text += "Код ошибки: " + error + Environment.NewLine;
                mainTextBox.Text += "Получившийся результат: " + "res = " + res.ToString() + Environment.NewLine;
                if (res == 0 && error == "Error 06")
                {
                    mainTextBox.Text += "Тест пройден" + Environment.NewLine + Environment.NewLine;
                }
                else
                {
                    mainTextBox.Text += "Тест не пройден" + Environment.NewLine + Environment.NewLine;
                }
            }
            catch (Exception ex)
            {
                mainTextBox.Text += "Перехвачено исключение: " + ex.ToString() + Environment.NewLine + "Тест не пройден." + Environment.NewLine;
            }

            // 16 тестовый пример
            try
            {
                mainTextBox.Text += "Test Case 16" + Environment.NewLine;
                mainTextBox.Text += "Входные данные: a = 3, b = -2147483649" + Environment.NewLine;
                mainTextBox.Text += "Ожидаемый результат: Error 06" + Environment.NewLine;
                int res = CalcClass.Mod(3, -2147483649);
                string error = CalcClass.lastError;
                mainTextBox.Text += "Код ошибки: " + error + Environment.NewLine;
                mainTextBox.Text += "Получившийся результат: " + "res = " + res.ToString() + Environment.NewLine;
                if (res == 0 && error == "Error 06")
                {
                    mainTextBox.Text += "Тест пройден" + Environment.NewLine + Environment.NewLine;
                }
                else
                {
                    mainTextBox.Text += "Тест не пройден" + Environment.NewLine + Environment.NewLine;
                }
            }
            catch (Exception ex)
            {
                mainTextBox.Text += "Перехвачено исключение: " + ex.ToString() + Environment.NewLine + "Тест не пройден." + Environment.NewLine;
            }

            // 17 тестовый пример
            try
            {
                mainTextBox.Text += "Test Case 17" + Environment.NewLine;
                mainTextBox.Text += "Входные данные: a = 671, b = 0" + Environment.NewLine;
                mainTextBox.Text += "Ожидаемый результат: Error 09" + Environment.NewLine;
                int res = CalcClass.Mod(671, 0);
                string error = CalcClass.lastError;
                mainTextBox.Text += "Код ошибки: " + error + Environment.NewLine;
                mainTextBox.Text += "Получившийся результат: " + "res = " + res.ToString() + Environment.NewLine;
                if (res == 0 && error == "Error 09")
                {
                    mainTextBox.Text += "Тест пройден" + Environment.NewLine + Environment.NewLine;
                }
                else
                {
                    mainTextBox.Text += "Тест не пройден" + Environment.NewLine + Environment.NewLine;
                }
            }
            catch (Exception ex)
            {
                mainTextBox.Text += "Перехвачено исключение: " + ex.ToString() + Environment.NewLine + "Тест не пройден." + Environment.NewLine;
            }
        }

        // Кнопка для модульного тестирования класса AnalaizerClass.cs.
        // Компилируем класс AnalaizerClass в библиотеку My.dll прямо в рантайме, чтобы иметь возможность изменять тестируемый класс.
        private void button2_Click(object sender, EventArgs e)
        {
            // создаем провайдер для генерирования и компиляции кода на C#
            System.CodeDom.Compiler.CodeDomProvider prov = System.CodeDom.Compiler.CodeDomProvider.CreateProvider("CSharp");
            // создаем параметры компилирования
            System.CodeDom.Compiler.CompilerParameters cmpparam = new System.CodeDom.Compiler.CompilerParameters();
            // результат компиляции - библиотека
            cmpparam.GenerateExecutable = false;
            // не включаем информацию отладчика
            cmpparam.IncludeDebugInformation = false;
            // подключаем 2-е стандартные библиотеки и библиотеку CalcClass.dll
            cmpparam.ReferencedAssemblies.Add(Application.StartupPath + "\\CalcClass.dll");
            cmpparam.ReferencedAssemblies.Add("System.dll");
            cmpparam.ReferencedAssemblies.Add("System.Windows.Forms.dll");
            // имя выходной сборки - My.dll
            cmpparam.OutputAssembly = "My.dll";
            // компилируем класс AnalaizerClass с заданными параметрами
            System.CodeDom.Compiler.CompilerResults res = prov.CompileAssemblyFromFile(cmpparam, Application.StartupPath + "\\..\\..\\..\\AnalaizerClass.cs");
            // Выводим результат компилирования на экран
            if (res.Errors.Count != 0)
            {
                mainTextBox.Text += res.Errors[0].ToString();
            }
            else
            {
                // загружаем только что скомпилированную сборку(здесь тонкий момент - если мы просто загрузим сборку из файла - то он будет заблокирован,
                // acces denied, поэтому вначале читаем его в поток, и лишь потом подключаем)
                System.IO.BinaryReader reader = new System.IO.BinaryReader(new System.IO.FileStream(Application.StartupPath + "\\My.dll", System.IO.FileMode.Open, System.IO.FileAccess.Read));
                Byte[] asmBytes = new Byte[reader.BaseStream.Length];
                reader.Read(asmBytes, 0, (Int32)reader.BaseStream.Length);
                reader.Close();
                reader = null;
                System.Reflection.Assembly assm = System.Reflection.Assembly.Load(asmBytes);
                Type[] types = assm.GetTypes();
                Type analaizer = types[0];

                // находим метод RunEstimate - к счастью он единственный
                System.Reflection.MethodInfo addinfo = analaizer.GetMethod("CheckCurrency");
                System.Reflection.FieldInfo fieldExpression = analaizer.GetField("expression");
                System.Reflection.FieldInfo fieldOpz = analaizer.GetField("opz");

                // ТЕСТИРОВАНИЕ МЕТОДА CheckCurrency()
                mainTextBox.Text += "Тестирование класса AnalaizerClass." + Environment.NewLine + Environment.NewLine;
                mainTextBox.Text += "Тестирование метода CheckCurrency." + Environment.NewLine;
                {
                    // тестовый пример №1
                    mainTextBox.Text += "Тестирование выражения 3*(2+2):" + Environment.NewLine;
                    fieldExpression.SetValue(null, "3*(2+2)");
                    mainTextBox.Text += addinfo.Invoke(null, null).ToString();

                    // тестовый пример №2
                    mainTextBox.Text += Environment.NewLine + "Тестирование выражения 3*(2+2)):" + Environment.NewLine;
                    fieldExpression.SetValue(null, "3*(2+2))");
                    mainTextBox.Text += addinfo.Invoke(null, null).ToString();

                    // тестовый пример №3
                    mainTextBox.Text += Environment.NewLine + "Тестирование выражения ((2+2)*3:" + Environment.NewLine;
                    fieldExpression.SetValue(null, "((2+2)*3");
                    mainTextBox.Text += addinfo.Invoke(null, null).ToString();

                    // тестовый пример №4
                    mainTextBox.Text += Environment.NewLine + "Тестирование выражения 9+(34-65*(4/2)):" + Environment.NewLine;
                    fieldExpression.SetValue(null, "9+(34-65*(4/2))");
                    mainTextBox.Text += addinfo.Invoke(null, null).ToString();

                    // тестовый пример №5
                    mainTextBox.Text += Environment.NewLine + "Тестирование выражения 9+(34-65*((4/2)):" + Environment.NewLine;
                    fieldExpression.SetValue(null, "9+(34-65*((4/2))");
                    mainTextBox.Text += addinfo.Invoke(null, null).ToString();

                    // тестовый пример №6
                    mainTextBox.Text += Environment.NewLine + "Тестирование выражения 9+(34-65*(4/2))):" + Environment.NewLine;
                    fieldExpression.SetValue(null, "9+(34-65*(4/2)))");
                    mainTextBox.Text += addinfo.Invoke(null, null).ToString();

                    // тестовый пример №7
                    mainTextBox.Text += Environment.NewLine + "Тестирование выражения 9+(34-65*(4/)2):" + Environment.NewLine;
                    fieldExpression.SetValue(null, "9+(34-65*(4/)2)");
                    mainTextBox.Text += addinfo.Invoke(null, null).ToString();
                }

                // ТЕСТИРОВАНИЕ МЕТОДА Format()
                {
                    mainTextBox.Text += Environment.NewLine + Environment.NewLine;
                    addinfo = analaizer.GetMethod("Format");
                    mainTextBox.Text += "Тестирование метода Format." + Environment.NewLine;
                    // тестовый пример №1
                    mainTextBox.Text += "Тестирование выражения 3*(2+:" + Environment.NewLine;
                    fieldExpression.SetValue(null, "3*(2+");
                    mainTextBox.Text += addinfo.Invoke(null, null).ToString();

                    // тестовый пример №2
                    mainTextBox.Text += Environment.NewLine + "Тестирование выражения 5-3**2" + Environment.NewLine;
                    fieldExpression.SetValue(null, "5-3**2");
                    mainTextBox.Text += addinfo.Invoke(null, null).ToString();

                    // тестовый пример №3
                    mainTextBox.Text += Environment.NewLine + "Тестирование выражения 5432mod3" + Environment.NewLine;
                    fieldExpression.SetValue(null, "5432mod3");
                    mainTextBox.Text += addinfo.Invoke(null, null).ToString();

                    // тестовый пример №4
                    mainTextBox.Text += Environment.NewLine + "Тестирование выражения 5432modz3" + Environment.NewLine;
                    fieldExpression.SetValue(null, "5432modz3");
                    mainTextBox.Text += addinfo.Invoke(null, null).ToString();

                    // тестовый пример №5
                    mainTextBox.Text += Environment.NewLine + "Тестирование выражения p9+(mm34mod2-65*(4/2))" + Environment.NewLine;
                    fieldExpression.SetValue(null, "p9+(mm34mod2-65*(4/2))");
                    mainTextBox.Text += addinfo.Invoke(null, null).ToString();

                    // тестовый пример №6
                    //mainTextBox.Text += Environment.NewLine + "Тестирование выражения, число символов которого равно 65536" + Environment.NewLine;
                    //StringBuilder longExpression = new StringBuilder("");
                    //for (int i = 0; i < 65534; ++i)
                    //{
                    //    longExpression.Append("1");
                    //}
                    //longExpression.Append("+1");
                    //fieldExpression.SetValue(null, longExpression.ToString());
                    //mainTextBox.Text += addinfo.Invoke(null, null).ToString();

                    // тестовый пример №7
                    //mainTextBox.Text += Environment.NewLine + "Тестирование выражения, число символов которого равно 65537" + Environment.NewLine;
                    //longExpression.Append("1");
                    //fieldExpression.SetValue(null, longExpression.ToString());
                    //mainTextBox.Text += addinfo.Invoke(null, null).ToString();
                }

                // ТЕСТИРОВАНИЕ МЕТОДА CreateStack()
                {
                    mainTextBox.Text += Environment.NewLine + Environment.NewLine;
                    addinfo = analaizer.GetMethod("CreateStack");
                    mainTextBox.Text += "Тестирование метода CreateStack." + Environment.NewLine;

                    // тестовый пример №1
                    mainTextBox.Text += Environment.NewLine + "Тестирование выражения ( ( p 34 ) - 3 ) / 5 " + Environment.NewLine;
                    fieldExpression.SetValue(null, "( ( p 34 ) - 3 ) / 5 ");
                    ArrayList list = ((ArrayList)addinfo.Invoke(null, null));
                    foreach (var element in list)
                    {
                        mainTextBox.Text += element.ToString();
                    }

                    // тестовый пример №2
                    mainTextBox.Text += Environment.NewLine + "Тестирование выражения ( p 34 - 3 ) / 5 " + Environment.NewLine;
                    fieldExpression.SetValue(null, "( p 34 - 3 ) / 5 ");
                    try
                    {
                        ArrayList list2 = ((ArrayList)addinfo.Invoke(null, null));
                        foreach (var element in list2)
                        {
                            mainTextBox.Text += element.ToString();
                        }
                    }
                    catch (Exception ex)
                    {
                        mainTextBox.Text += "Исключение во время работы метода: " + ex.Message;
                    }

                    // тестовый пример №3
                    mainTextBox.Text += Environment.NewLine + "Тестирование выражения ( ( p 34 ) - 3 ) / " + Environment.NewLine;
                    fieldExpression.SetValue(null, "( ( p 34 ) - 3 ) / ");
                    try
                    {
                        ArrayList list1 = ((ArrayList)addinfo.Invoke(null, null));
                        foreach (var element in list1)
                        {
                            mainTextBox.Text += element.ToString();
                        }
                    }
                    catch (Exception ex)
                    {
                        mainTextBox.Text += "Исключение во время работы метода: " + ex.Message;
                    }

                    // тестовый пример №4
                    mainTextBox.Text += Environment.NewLine + "Тестирование выражения ( ( ( ( ( ( ( ( ( ( ( ( ( ( ( ( 1 + 1 ) + 1 ) + 1 ) + 1 ) + 1 ) + 1 ) + 1 ) + 1 ) + 1 ) + 1 ) + 1 ) + 1 ) + 1 ) + 1 ) + 1 ) + 1 ) " + Environment.NewLine;
                    fieldExpression.SetValue(null, "( ( ( ( ( ( ( ( ( ( ( ( ( ( ( ( 1 + 1 ) + 1 ) + 1 ) + 1 ) + 1 ) + 1 ) + 1 ) + 1 ) + 1 ) + 1 ) + 1 ) + 1 ) + 1 ) + 1 ) + 1 ) + 1 ) ");
                    try
                    {
                        ArrayList list1 = ((ArrayList)addinfo.Invoke(null, null));
                        if (list1 == null)
                        {
                            mainTextBox.Text += "Переполнение списка. Метод вернул значение null.";
                        }
                    }
                    catch (Exception ex)
                    {
                        mainTextBox.Text += "Исключение во время работы метода: " + ex.Message;
                    }
                }

                // ТЕСТИРОВАНИЕ МЕТОДА RunEstimate()
                {
                    mainTextBox.Text += Environment.NewLine + Environment.NewLine;
                    addinfo = analaizer.GetMethod("RunEstimate");
                    mainTextBox.Text += "Тестирование метода RunEstimate." + Environment.NewLine;

                    // тестовый пример №1
                    mainTextBox.Text += Environment.NewLine + "Тестирование записи 34 p 3 - 5 /" + Environment.NewLine;
                    ArrayList arrayList = new ArrayList();
                    arrayList.Add("34");
                    arrayList.Add("p");
                    arrayList.Add("3");
                    arrayList.Add("-");
                    arrayList.Add("5");
                    arrayList.Add("/");
                    fieldOpz.SetValue(null, arrayList);
                    mainTextBox.Text += addinfo.Invoke(null, null).ToString();

                    // тестовый пример №2
                    mainTextBox.Text += Environment.NewLine + "Тестирование записи 34 p 3 - 0 /" + Environment.NewLine;
                    arrayList.Clear();
                    arrayList.Add("34");
                    arrayList.Add("p");
                    arrayList.Add("3");
                    arrayList.Add("-");
                    arrayList.Add("0");
                    arrayList.Add("/");
                    fieldOpz.SetValue(null, arrayList);
                    mainTextBox.Text += addinfo.Invoke(null, null).ToString();

                    // тестовый пример №3
                    mainTextBox.Text += Environment.NewLine + "Тестирование записи 2147483500 m 2147483500 - 2 /" + Environment.NewLine;
                    arrayList.Clear();
                    arrayList.Add("2147483648");
                    arrayList.Add("m");
                    arrayList.Add("2147483647");
                    arrayList.Add("-");
                    arrayList.Add("2");
                    arrayList.Add("/");
                    fieldOpz.SetValue(null, arrayList);
                    mainTextBox.Text += addinfo.Invoke(null, null).ToString();

                    // тестовый пример №4
                    mainTextBox.Text += Environment.NewLine + "Тестирование записи 2147483648 m 2147483647 +" + Environment.NewLine;
                    arrayList.Clear();
                    arrayList.Add("2147483648");
                    arrayList.Add("m");
                    arrayList.Add("2147483647");
                    arrayList.Add("+");
                    fieldOpz.SetValue(null, arrayList);
                    mainTextBox.Text += addinfo.Invoke(null, null).ToString();

                    // тестовый пример №5
                    mainTextBox.Text += Environment.NewLine + "Тестирование записи 2147483646 m 2147483647 +" + Environment.NewLine;
                    arrayList.Clear();
                    arrayList.Add("2147483646");
                    arrayList.Add("m");
                    arrayList.Add("2147483647");
                    arrayList.Add("+");
                    fieldOpz.SetValue(null, arrayList);
                    mainTextBox.Text += addinfo.Invoke(null, null).ToString();

                    // тестовый пример №6
                    mainTextBox.Text += Environment.NewLine + "Тестирование записи 2147483647 m 2147483646" + Environment.NewLine;
                    arrayList.Clear();
                    arrayList.Add("2147483646");
                    arrayList.Add("m");
                    arrayList.Add("2147483647");
                    //arrayList.Add("+");
                    fieldOpz.SetValue(null, arrayList);
                    mainTextBox.Text += addinfo.Invoke(null, null).ToString();
                }

                asmBytes = null;
            }
            prov.Dispose();
        }
    }
}