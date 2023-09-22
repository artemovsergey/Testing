using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace BaseCalculator
{
    /// <summary>
    /// оболочка для кода, анализирующего входное выражение.
    /// </summary>
    public class AnalaizerClass
    {
        /// <summary>
        /// позиция выражения на которой отловлена синтаксическая ошибка (в случае ловли на уровне выполнения - не определяется)
        /// </summary>
        private static int erposition = 0;
        /// <summary>
        /// Входное выражение
        /// </summary>
        public static string expression = "";
        public static System.Collections.ArrayList opz = null;
        /// <summary>
        /// Проверка корректности скобочной структуры входного выражения 
        /// </summary>
        /// <returns>true - если все нормально, false- если есть ошибка</returns>
        /// метод бежит по входному выражению символ за символом анализирую его и считая количество скобочек. В случае возникновения
        /// ошибки возвращает false а в erposition записывает позицию на которой возникла ошибка.
        public static bool CheckCurrency()
        {
            bool correct = true;
            int num = 0;
            for (int i=0; i<expression.Length;i++)
            {
                if (expression[i] == '(')
                {
                    num++;
                }
                else
                {
                    if (expression[i] == ')')
                    {
                        num--;
                    }
                }
                if (num < 0)
                {
                    correct = false;
                    erposition = i;
                    return correct;
                }
            }
            if (num != 0)
            {
                correct = false;
            }
            return correct;
        }
        /// <summary>
        /// Форматирует входное выражение, выставляя между операторами проьелы и удаляя лишние, а также отлавливает неопознанные операторы, следит за концом строки
        /// а также отлавливает ошибки на конце строки
        /// </summary>
        /// <returns>конечную строку или сообщение об ошибки, начинающиесь со спец символа &</returns>
        public static string Format()
        {
            string formstr = ""; // строка, формируемая из выражения
            string prev =""; // тип предыдущего символа
            if (expression.Length <= 65536)
            {
                //выбираем новый символ выражения и смотрим, что с ним можно сделать и какое отношение он имеет к предыдущему(переменная prev хранит тип предыдущего символа)
                for (int i = 0; i < expression.Length; i++)
                {
                    switch (expression[i])
                    {
                        case '0':
                            {
                                if (prev == "число" || prev == "")
                                {
                                    formstr += expression[i].ToString();
                                }
                                else
                                {

                                    formstr += " " + expression[i].ToString();
                                }
                                prev = "число";
                                break;
                            }
                        case '1':
                            {
                                if (prev == "число" || prev == "")
                                {
                                    formstr += expression[i].ToString();
                                }
                                else
                                {

                                    formstr += " " + expression[i].ToString();
                                }
                                prev = "число";
                                break;
                            }
                        case '2':
                            {
                                if (prev == "число" || prev == "")
                                {
                                    formstr += expression[i].ToString();
                                }
                                else
                                {

                                    formstr += " " + expression[i].ToString();
                                }
                                prev = "число";
                                break;
                            }
                        case '3':
                            {
                                if (prev == "число" || prev == "")
                                {
                                    formstr += expression[i].ToString();
                                }
                                else
                                {

                                    formstr += " " + expression[i].ToString();
                                }
                                prev = "число";
                                break;
                            }
                        case '4':
                            {
                                if (prev == "число" || prev == "")
                                {
                                    formstr += expression[i].ToString();
                                }
                                else
                                {

                                    formstr += " " + expression[i].ToString();
                                }
                                prev = "число";
                                break;
                            }
                        case '5':
                            {
                                if (prev == "число" || prev == "")
                                {
                                    formstr += expression[i].ToString();
                                }
                                else
                                {

                                    formstr += " " + expression[i].ToString();
                                }
                                prev = "число";
                                break;
                            }
                        case '6':
                            {
                                if (prev == "число" || prev == "")
                                {
                                    formstr += expression[i].ToString();
                                }
                                else
                                {

                                    formstr += " " + expression[i].ToString();
                                }
                                prev = "число";
                                break;
                            }
                        case '7':
                            {
                                if (prev == "число" || prev == "")
                                {
                                    formstr += expression[i].ToString();
                                }
                                else
                                {

                                    formstr += " " + expression[i].ToString();
                                }
                                prev = "число";
                                break;
                            }
                        case '8':
                            {
                                if (prev == "число" || prev == "")
                                {
                                    formstr += expression[i].ToString();
                                }
                                else
                                {

                                    formstr += " " + expression[i].ToString();
                                }
                                prev = "число";
                                break;
                            }
                        case '9':
                            {
                                if (prev == "число" || prev == "")
                                {
                                    formstr += expression[i].ToString();
                                }
                                else
                                {

                                    formstr += " " + expression[i].ToString();
                                }
                                prev = "число";
                                break;
                            }
                        case ' ':
                            {
                                break;
                            }
                        case '+':
                            {

                                if (prev != "")
                                {
                                    if (prev != "оператор")
                                    {
                                        formstr += " " + expression[i].ToString();
                                    }
                                    else
                                    {
                                        MessageBox.Show("Два подряд оператора на " + i.ToString() + " символе.");
                                        //Program.res = 4;
                                        return "&Error 04 at " + i.ToString();
                                    }
                                }
                                else
                                {
                                    formstr += expression[i].ToString();
                                }
                                prev = "оператор";
                                break;
                            }
                        case '-':
                            {

                                if (prev != "")
                                {
                                    if (prev != "оператор")
                                    {
                                        formstr += " " + expression[i].ToString();
                                    }
                                    else
                                    {
                                        MessageBox.Show("Два подряд оператора на " + i.ToString() + " символе.");
                                        //Program.res = 4;
                                        return "&Error 04 at " + i.ToString();
                                    }
                                }
                                else
                                {
                                    formstr += expression[i].ToString();
                                }
                                prev = "оператор";
                                break;
                            }
                        case '*':
                            {

                                if (prev != "")
                                {
                                    if (prev != "оператор")
                                    {
                                        formstr += " " + expression[i].ToString();
                                    }
                                    else
                                    {
                                        MessageBox.Show("Два подряд оператора на " + i.ToString() + " символе.");
                                        //Program.res = 4;
                                        return "&Error 04 at " + i.ToString();
                                    }
                                }
                                else
                                {
                                    formstr += expression[i].ToString();
                                }
                                prev = "оператор";
                                break;
                            }
                        case '/':
                            {

                                if (prev != "")
                                {
                                    if (prev != "оператор")
                                    {
                                        formstr += " " + expression[i].ToString();
                                    }
                                    else
                                    {
                                        MessageBox.Show("Два подряд оператора на " + i.ToString() + " символе.");
                                        //Program.res = 4;
                                        return "&Error 04 at " + i.ToString();
                                    }
                                }
                                else
                                {
                                    formstr += expression[i].ToString();
                                }
                                prev = "оператор";
                                break;
                            }
                        case '(':
                            {

                                if (prev != "")
                                {
                                    formstr += " " + expression[i].ToString();
                                }
                                else
                                {
                                    formstr += expression[i].ToString();
                                }
                                prev = "скобка";
                                break;
                            }
                        case ')':
                            {

                                if (prev != "")
                                {
                                    formstr += " " + expression[i].ToString();
                                }
                                else
                                {
                                    formstr += expression[i].ToString();
                                }
                                prev = "скобка";
                                break;
                            }
                        case 'm':
                            {
                                if (i + 1 < expression.Length && expression[i + 1] == 'o' && expression[i + 2] == 'd')
                                {
                                    if (prev != "")
                                    {
                                        if (prev != "оператор")
                                        {
                                            formstr += " " + expression[i].ToString() + expression[i + 1].ToString() + expression[i + 2].ToString();
                                        }
                                        else
                                        {
                                            MessageBox.Show("Два подряд оператора на " + i.ToString() + " символе.");
                                            //Program.res = 4;
                                            return "&Error 04 at " + i.ToString();
                                        }
                                    }
                                    else
                                    {
                                        formstr += expression[i].ToString() + expression[i + 1].ToString() + expression[i + 2].ToString();
                                    }
                                    prev = "оператор";
                                    i += 2;
                                }
                                else
                                {
                                    if (prev != "")
                                    {
                                        formstr += " " + expression[i].ToString();
                                    }
                                    else
                                    {
                                        formstr += expression[i].ToString();
                                    }
                                    prev = "унарный оператор";

                                }
                                break;
                            }
                        case 'p':
                            {
                                if (prev != "")
                                {
                                    formstr += " " + expression[i].ToString();
                                }
                                else
                                {
                                    formstr += expression[i].ToString();
                                }
                                prev = "унарный оператор";
                                break;
                            }

                        default:
                            {
                                MessageBox.Show("Неизвестный оператор на " + i.ToString() + " символе.");
                                //Program.res = 2;
                                return "&Error 02 at " + i.ToString();
                            }
                    }
                }
            }
            else
            {
                MessageBox.Show("Слишком длинное выражение. Максмальная длина - 65536 символов.");
                //Program.res = 7;
                return "&Error 07";
            }
            if (prev != "оператор" && prev != "унарный оператор")
            {
                return formstr + " ";
            }
            else
            {
                MessageBox.Show("Незаконченное выражение. ");
                //Program.res = 5;
                return "&Error 05";
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
                expr = expr.Substring(expr.IndexOf(" ")+1); // отсекаем от выражения взятый кусок
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
        /// <summary>
        /// Вычисление обратной польской записи
        /// </summary>
        /// <returns>результат вычислений или сообщение об ошибке</returns>
        public static string RunEstimate()
        {
            bool endwork = false;
            // этот цикл будет выполняться до тех пор , пока в массиве не остануться одни числа
            while (!endwork)
            {
                int i = 0;
                bool found = false;
                //этот цикл выполняется до тех пор, пока не будет найден первый оператор
                while (i < opz.Count && !found)
                {
                    found = true;
                    try
                    {
                        switch (opz[i].ToString())
                        {

                            case "+":
                                {

                                    opz[i - 2] = CalcClass.Add(Convert.ToInt64(opz[i - 2]), Convert.ToInt64(opz[i - 1]));
                                    opz.RemoveAt(i - 1);
                                    opz.RemoveAt(i - 1);

                                    break;
                                }
                            case "-":
                                {
                                    opz[i - 2] = CalcClass.Sub(Convert.ToInt64(opz[i - 2]), Convert.ToInt64(opz[i - 1]));
                                    opz.RemoveAt(i - 1);
                                    opz.RemoveAt(i - 1);
                                    break;
                                }
                            case "*":
                                {
                                    opz[i - 2] = CalcClass.Mult(Convert.ToInt64(opz[i - 2]), Convert.ToInt64(opz[i - 1]));
                                    opz.RemoveAt(i - 1);
                                    opz.RemoveAt(i - 1);
                                    break;
                                }
                            case "/":
                                {
                                    opz[i - 2] = CalcClass.Div(Convert.ToInt64(opz[i - 2]), Convert.ToInt64(opz[i - 1]));
                                    opz.RemoveAt(i - 1);
                                    opz.RemoveAt(i - 1);
                                    break;
                                }
                            case "mod":
                                {
                                    opz[i - 2] = CalcClass.Mod(Convert.ToInt64(opz[i - 2]), Convert.ToInt64(opz[i - 1]));
                                    opz.RemoveAt(i - 1);
                                    opz.RemoveAt(i - 1);
                                    break;
                                }

                            case "m":
                                {
                                    opz[i - 1] = CalcClass.IABS(Convert.ToInt64(opz[i - 1]));
                                    opz.RemoveAt(i);
                                    break;
                                }
                            case "p":
                                {
                                    opz[i - 1] = CalcClass.ABS(Convert.ToInt64(opz[i - 1]));
                                    opz.RemoveAt(i);
                                    break;
                                }

                            default:
                                {
                                    found = false;
                                    break;
                                }
                        }
                    }
                    catch (DivideByZeroException ex)
                    {
                        MessageBox.Show("Ошибка деления на 0");
                        //Program.res = 9;
                        return "Error 09";
                    }
                    catch (OverflowException ex)
                    {
                        //Перехватили ошибку переполнения - выдаем сообщение
                        MessageBox.Show("Слишком малое или слишком большое значение числа для int\n Числа должны быть в пределах от -2147483648 до 2147483647");
                        //Program.res = 6;
                        return "Error 06";
                    }
                    i++;
                }
                if (found == false && i == opz.Count)
                {
                    endwork = true;
                }
                string le = CalcClass.lastError;
                if (le!="")
                {
                    return le;
                }
            }
            if (opz.Count != 1)
            {
                // в результате вычислений в массиве осталось несколько чисел - значит где-то ошибка в выражении, которую мы не отловили на более раннем этапе.
                MessageBox.Show("Неверная синтаксическая конструкция входного выражения!");
                //Program.res = 3;
                return "Error 03";
            }
            else
            {
                return opz[0].ToString();
            }
        }
        /// <summary>
        /// Метод, организующий вычисления. По очереди запускает CheckCorrncy, Format, CreateStack и RunEstimate
        /// </summary>
        /// <returns></returns>
        public static string Estimate()
        {
            if (CheckCurrency())
            {
                string formstr = Format();
                if (formstr[0] == '&')
                {
                    return formstr.Substring(1);
                }
                expression = formstr;
                opz=CreateStack();
                if (opz != null)
                {
                    return RunEstimate();
                }
                else
                {
                    MessageBox.Show("Суммарное количество чисел и операторов превышает 30!");
                    //Program.res = 8;
                    return "Error 08";
                }
            }
            else
            {
                MessageBox.Show("Неправильная скобочная структура, ошибка на "+erposition.ToString()+" символе !");
                //Program.res = 1;
                return "Error 01 at "+erposition.ToString();
            }
        }
    }
}
