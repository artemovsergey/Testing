using System;
using System.Collections;

namespace test_things
{
    class Program
    {
        static string expression;

        static void Main(string[] args)
        {
            // тестил как работает составление польской записи. тип: в switch кейсе проверяется маленькое тире в качестве знака минус!!

            expression = "( ( p 34 ) - 3 ) / 5 ";
            ArrayList list = CreateStack();
            foreach (var element in list)
            {
                Console.Write(element.ToString());
            }
        }

        /// <summary>
        /// Создает  массив, в котором располагаются операторы и символы представленные в обратной польской записи (безскобочной)
        /// На этом же этапе отлавливаются почти все остальные ошибки (см код). По сути - это компиляция.
        /// </summary>
        /// <returns>массив обратной польской записи</returns>
        public static System.Collections.ArrayList CreateStack()
        {
            //Собственно результирующий массив
            System.Collections.ArrayList strarr = new System.Collections.ArrayList(30);
            //Стек с операторами где они временно храняться
            System.Collections.Stack operators = new System.Collections.Stack(15);
            string expr = expression;
            //пооператорная обработка выражения
            while (expr != "")
            {
                string op = expr.Substring(0, expr.IndexOf(" ")); // берём кусок выражения обрамлённый пробелами
                expr = expr.Substring(expr.IndexOf(" ") + 1); // отсекаем от выражения взятый кусок
                switch (op)
                {
                    case "(": //1
                        {
                            //Кладем в стэк
                            operators.Push(op);
                            break;
                        }
                    case "m": //4
                        {
                            //вытаскиваем из стека все операторы чей приоритет больше либо равен унарному минусу
                            while (operators.Count != 0 && (operators.Peek().ToString() == "m" || operators.Peek().ToString() == "p"))
                            {
                                if (strarr.Capacity > strarr.Count)
                                {
                                    strarr.Add(operators.Pop());
                                }
                                else
                                {
                                    // переполнгение стека - возвращем null
                                    return null;
                                }
                            }
                            operators.Push(op);
                            break;
                        }
                    case "p": //4
                        {
                            while (operators.Count != 0 && (operators.Peek().ToString() == "m" | operators.Peek().ToString() == "p"))
                            {
                                if (strarr.Capacity > strarr.Count)
                                {
                                    strarr.Add(operators.Pop());
                                }
                                else
                                {
                                    return null;
                                }
                            }
                            operators.Push(op);
                            break;
                        }
                    case "*": //3
                        {
                            while (operators.Count != 0 && (operators.Peek().ToString() == "*" || operators.Peek().ToString() == "/" || operators.Peek().ToString() == "mod" || operators.Peek().ToString() == "m" || operators.Peek().ToString() == "p"))
                            {
                                if (strarr.Capacity > strarr.Count)
                                {
                                    strarr.Add(operators.Pop());
                                }
                                else
                                {
                                    return null;
                                }
                            }
                            operators.Push(op);
                            break;
                        }
                    case "/": //3
                        {
                            while (operators.Count != 0 && (operators.Peek().ToString() == "*" || operators.Peek().ToString() == "/" || operators.Peek().ToString() == "mod" || operators.Peek().ToString() == "m" || operators.Peek().ToString() == "p"))
                            {
                                if (strarr.Capacity > strarr.Count)
                                {
                                    strarr.Add(operators.Pop());
                                }
                                else
                                {
                                    return null;
                                }
                            }
                            operators.Push(op);
                            break;
                        }
                    case "mod": //3
                        {
                            while (operators.Count != 0 && (operators.Peek().ToString() == "*" || operators.Peek().ToString() == "/" || operators.Peek().ToString() == "mod" || operators.Peek().ToString() == "m" || operators.Peek().ToString() == "p"))
                            {
                                if (strarr.Capacity > strarr.Count)
                                {
                                    strarr.Add(operators.Pop());
                                }
                                else
                                {
                                    return null;
                                }
                            }
                            operators.Push(op);
                            break;
                        }
                    case "+": //2
                        {
                            while (operators.Count != 0 && (operators.Peek().ToString() == "*" || operators.Peek().ToString() == "/" || operators.Peek().ToString() == "mod" || operators.Peek().ToString() == "+" || operators.Peek().ToString() == "-" || operators.Peek().ToString() == "m" || operators.Peek().ToString() == "p"))
                            {
                                if (strarr.Capacity > strarr.Count)
                                {
                                    strarr.Add(operators.Pop());
                                }
                                else
                                {
                                    return null;
                                }
                            }
                            operators.Push(op);
                            break;
                        }
                    case "-": //2
                        {
                            while (operators.Count != 0 && (operators.Peek().ToString() == "*" | operators.Peek().ToString() == "/" | operators.Peek().ToString() == "mod" | operators.Peek().ToString() == "+" | operators.Peek().ToString() == "-" | operators.Peek().ToString() == "m" | operators.Peek().ToString() == "p"))
                            {
                                if (strarr.Capacity > strarr.Count)
                                {
                                    strarr.Add(operators.Pop());
                                }
                                else
                                {
                                    return null;
                                }
                            }
                            operators.Push(op);
                            break;
                        }
                    case ")":
                        {
                            while (operators.Peek().ToString() != "(")
                            {
                                if (strarr.Capacity > strarr.Count)
                                {
                                    strarr.Add(operators.Pop());
                                }
                                else
                                {
                                    return null;
                                }
                            }
                            operators.Pop();
                            break;
                        }
                    default:
                        {
                            //на входе - число - помещаем в выходной массив
                            if (strarr.Capacity > strarr.Count)
                            {
                                strarr.Add(op);
                            }
                            else
                            {
                                return null;
                            }
                            break;
                        }
                }
            }
            //записываем все что осталовь в стеке в выходной массив
            while (operators.Count != 0)
            {
                strarr.Add(operators.Pop());
            }
            return strarr;
        }
    }
}
