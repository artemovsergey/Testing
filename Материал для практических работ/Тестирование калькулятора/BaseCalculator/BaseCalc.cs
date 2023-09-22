using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BaseCalculator
{
    public partial class BaseCalc : Form
    {
        public static int mem = 0;
        private DateTime dt = DateTime.Now;

        // для тестирования приватных textBox'ов можно завести статические поля, которые должны изменяться
        // вместе с текст боксами в ходе работы программы
        public static String resultTextBox;
        public static String expressionTextBox;

        public BaseCalc()
        {
            InitializeComponent();
        }

        #region Управление_Фокусом
        private void bAnswer_Leave(object sender, EventArgs e)
        {
            bAnswer.Focus();
        }

        private void BaseCalc_Load(object sender, EventArgs e)
        {
            bAnswer.Focus();
        }
        #endregion
        /// <summary>
        /// Вычисляем входное выражение
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bAnswer_Click(object sender, EventArgs e)
        {
            AnalaizerClass.expression = textBoxExpression.Text;
            textBoxResult.Text = AnalaizerClass.Estimate();
        }
        #region Кнопки_Цифры_и_Операторы
        private void b1_Click(object sender, EventArgs e)
        {
            textBoxExpression.Text += "1";
        }

        private void b2_Click(object sender, EventArgs e)
        {
            textBoxExpression.Text += "2";
        }

        private void b3_Click(object sender, EventArgs e)
        {
            textBoxExpression.Text += "3";
        }

        private void b4_Click(object sender, EventArgs e)
        {
            textBoxExpression.Text += "4";
        }

        private void b5_Click(object sender, EventArgs e)
        {
            textBoxExpression.Text += "5";
        }

        private void b6_Click(object sender, EventArgs e)
        {
            textBoxExpression.Text += "6";
        }

        private void b7_Click(object sender, EventArgs e)
        {
            textBoxExpression.Text += "7";
        }

        private void b8_Click(object sender, EventArgs e)
        {
            textBoxExpression.Text += "8";
        }

        private void b9_Click(object sender, EventArgs e)
        {
            textBoxExpression.Text += "9";
        }

        private void b0_Click(object sender, EventArgs e)
        {
            textBoxExpression.Text += "0";
        }

        private void bDiv_Click(object sender, EventArgs e)
        {
            textBoxExpression.Text += "/";
        }

        private void bMult_Click(object sender, EventArgs e)
        {
            textBoxExpression.Text += "*";
        }

        private void bMin_Click(object sender, EventArgs e)
        {
            textBoxExpression.Text += "-";
        }

        private void bPlus_Click(object sender, EventArgs e)
        {
            textBoxExpression.Text += "+";
        }

        private void bPoint_Click(object sender, EventArgs e)
        {
            textBoxExpression.Text += "mod";
        }

        private void bLbrackets_Click(object sender, EventArgs e)
        {
            textBoxExpression.Text += "(";
        }

        private void bRbrackets_Click(object sender, EventArgs e)
        {
            textBoxExpression.Text += ")";
        }
        #endregion

        /// <summary>
        /// Удаляем последний оператор
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bBackSpace_Click(object sender, EventArgs e)
        {
            if (textBoxExpression.Text.Length >= 3)
            {
                if (textBoxExpression.Text.Substring(textBoxExpression.Text.Length - 3) == "mod")
                {
                    textBoxExpression.Text = textBoxExpression.Text.Substring(0, textBoxExpression.Text.Length - 3);
                }
                else
                {
                    textBoxExpression.Text = textBoxExpression.Text.Substring(0, textBoxExpression.Text.Length - 1);
                }
            }
            else
            {
                if (textBoxExpression.Text.Length != 0)
                {
                    textBoxExpression.Text = textBoxExpression.Text.Substring(0, textBoxExpression.Text.Length - 1);
                }
            }
        }

        /// <summary>
        /// Очищаем текст
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bEmpty_Click(object sender, EventArgs e)
        {
            textBoxExpression.Text = "";
        }

        #region Работа_с_памятью
        public void bMR_Click(object sender, EventArgs e)
        {
            textBoxExpression.Text += mem.ToString();
        }

        public void bMPlus_Click(object sender, EventArgs e)
        {
            if (textBoxResult.Text != "")
            {
                try
                {
                    mem = CalcClass.Add(mem, Convert.ToInt32(textBoxResult.Text));
                }
                catch (OverflowException ex)
                {
                    MessageBox.Show("Слишком малое или слишком большое значение числа для int\nЧисла должны быть в пределах от -2147483648 до 2147483647");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Невозможно преобразовать к числу!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        
        public void bMC_Click(object sender, EventArgs e)
        {
            mem = 0;
        }
        #endregion

        /// <summary>
        /// Унарный плюс минус
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bPlusMinus_Click(object sender, EventArgs e)
        {
            if (-dt.Second + DateTime.Now.Second <= 1)
            {
                if (textBoxExpression.Text.Length > 0)
                {
                    if (textBoxExpression.Text[textBoxExpression.Text.Length - 1] == 'm')
                    {
                        textBoxExpression.Text = textBoxExpression.Text.Substring(0, (textBoxExpression.Text.Length - 1)) + "p";
                    }
                    else
                    {
                        if (textBoxExpression.Text[textBoxExpression.Text.Length - 1] == 'p')
                        {
                            textBoxExpression.Text = textBoxExpression.Text.Substring(0, (textBoxExpression.Text.Length - 1)) + "m";
                        }
                        else
                        {
                            textBoxExpression.Text += "m";
                        }
                    }
                }
                else
                {
                    textBoxExpression.Text += "m";
                }
            }
            else
            {
                textBoxExpression.Text += "m";
            }
            dt = DateTime.Now;
        }

        private void BaseCalc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 27)
            {
                this.Close();
            }
        }
    }
}