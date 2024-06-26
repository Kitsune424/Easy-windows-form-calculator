﻿using System.Reflection.Emit;

namespace WindowsForm_Calculator
{
    // починить что при 9999 и операции если снова вводить 9999 то все стирается 
    public partial class Form1 : Form
    {
        double operant1 = 0;
        double operant2 = 0;

        string operation_type;
        string operation_type_old;              // При очень больших числах убрать вход в бесконечность

        bool weUseOperation = false;            // проверка использования операции на случай очистики строки при совпадении
        bool weSelectOperation = false;         // проверка на выбор операции
        bool weTypeSomething = false;           // проверка на использование нумпаад
        bool equalasrepit = false;              // проверка на повторное равно
        bool longoperatn = false;               // проверка огромное число операнта 
        bool error = false;                     // проверка входа в ошибку для смены поведения кнопок редактирования
        bool weUseEquals = false;               // проверка на вывод ответа через равно
        bool zeroDiv = false;                   // проверка деления на 0

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Current_numstring.Text = "0";
        }


        /// <summary>
        /// Функция для заполнения строки числами
        /// по нажатию кнопки
        /// </summary>
        private void num_Click(object sender, EventArgs e)
        {
            Button num = (Button)sender;

            if (Current_numstring.MaxLength != Current_numstring.Text.Length) //проверка длинны строки
            {
                weTypeSomething = true;
                enableallButton();

                //если в строке у нас 0, просто 0
                if (Current_numstring.Text == "0")
                {
                    if (weUseEquals)
                    {
                        Current_numstring.Text = "";
                        Current_numstring.Text = num.Text;
                        temp_numstring.Text = "";
                        weUseEquals = false;
                    }

                    else if (num.Text == "0")
                    { 
                        return; //не даем вписать второй 0
                    } 
                    else if (num.Text == ",")
                    {
                        if (!Current_numstring.Text.Contains(',') & num.Text == ",") { Current_numstring.Text += num.Text; } //проверяем на запятые, нельзя больше одной
                        else if (Current_numstring.Text.Contains(',') & num.Text == ",") { return; }
                    }
                    else { Current_numstring.Text = ""; Current_numstring.Text += num.Text; } //убираем 0 и ставим число
                }

                //если текущая строка сформирована из элемента первого опперанта после операции
                else if (Current_numstring.Text == operant1.ToString() || weUseEquals == true)
                {
                    if (num.Text == ",")
                    {
                        if (!Current_numstring.Text.Contains(',') & num.Text == ",") { Current_numstring.Text = "0"; Current_numstring.Text += num.Text; } //проверяем на запятые, нельзя больше одной
                        else if (Current_numstring.Text.Contains(',') & num.Text == ",") { return; }
                    }

                    //обнуляем послеоперационное число, потом пишем свое число
                    else if (weUseOperation == true) 
                    { 
                        Current_numstring.Text = "";
                        Current_numstring.Text = num.Text;
                        weUseOperation = false;

                        //очищаем память после нажатия равно, начинаем цепочку вычислений заново
                        if (weUseEquals)
                        {
                            temp_numstring.Text = "";
                            weUseEquals = false;
                        }
                    }

                    //выходим из ситуации, где при 9999 + 9999+9 уходим в цикл 9999
                    else 
                    {
                        if (num.Text == ",")
                        {
                            if (!Current_numstring.Text.Contains(',') & num.Text == ",") { Current_numstring.Text += num.Text; } //проверяем на запятые, нельзя больше одной
                            else if (Current_numstring.Text.Contains(',') & num.Text == ",") { return; }
                        }
                        else { Current_numstring.Text += num.Text; }
                    }
                }

                else 
                {
                    if
                        (
                        Current_numstring.Text == "деление на 0" ||
                        Current_numstring.Text == "Sqrt Error" ||
                        Current_numstring.Text == "Не число" ||
                        Current_numstring.Text == "∞" ||
                        Current_numstring.Text == "Переполнение"
                        )
                    {
                        string_clear();
                        Current_numstring.Text = "";
                    }

                    if (num.Text == ",")
                    {
                        if (!Current_numstring.Text.Contains(',') & num.Text == ",") { Current_numstring.Text += num.Text; } //проверяем на запятые, нельзя больше одной
                        else if (Current_numstring.Text.Contains(',') & num.Text == ",") { return; }
                    }
                    else { Current_numstring.Text += num.Text; }
                }
            }
            else
            {
                if (longoperatn == false)
                {
                    if (Current_numstring.Text == operant1.ToString() || weUseEquals) //если текущая строка сформирована из элемента первого опперанта после операции
                    {
                        if (num.Text == ",")
                        {
                            if (!Current_numstring.Text.Contains(',') & num.Text == ",") { Current_numstring.Text = "0"; Current_numstring.Text += num.Text; } //проверяем на запятые, нельзя больше одной
                            else if (Current_numstring.Text.Contains(',') & num.Text == ",") { return; }
                        }
                        else
                        {   //обнуляем, потом пишем свое число
                            Current_numstring.Text = "";
                            Current_numstring.Text = num.Text;

                            if (weUseEquals) // если мы жали равно, то стираем память, начинаем все с нуля
                                temp_numstring.Text = ""; weUseEquals = false;
                        }
                        longoperatn = true;
                    }
                }
                else { return; }
            }

            //очищаем память после нажатия равно, начинаем цепочку вычислений заново
            if (weUseEquals)
            {
                temp_numstring.Text = "";
                Current_numstring.Text = num.Text;
                weUseEquals = false;
            }

        }

        /// <summary>
        /// все виды стирания на любой вкус
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void string_clear(object sender, EventArgs e)
        {
            if (error == false)
            {
                //Clear - очищает вообще все
                if (((Button)sender).Text == "C")
                {
                    operation_type = "";
                    operation_type_old = "";

                    Current_numstring.Text = "0";
                    temp_numstring.Text = "";

                    operant1 = 0;
                    operant2 = 0;

                    zeroDiv = false;
                    weUseEquals = false;
                    weSelectOperation = false;
                    weTypeSomething = false;
                    equalasrepit = false;

                    enableallButton();
                }

                //Clear entry - чистит только строку ввода
                else if (((Button)sender).Text == "CE")
                {
                    Current_numstring.Text = "0";
                    weUseEquals = false;
                }

                //backspace - убирает строку посимвольно
                else
                {
                    if (weUseEquals == true)
                    {
                        temp_numstring.Text = "";
                        //weUseEquals = false;
                    }

                    else if (Current_numstring.Text == operant1.ToString())
                        return;

                    else if (Current_numstring.Text != "0")
                    {
                        if (weUseEquals == true)
                        {
                            temp_numstring.Text = "";
                            //weUseEquals = false;
                        }

                        else if (Current_numstring.Text == operant1.ToString())
                        {
                            return;
                        }
                        else if (
                            Current_numstring.Text == "деление на 0" ||
                            Current_numstring.Text == "Sqrt Error" ||
                            Current_numstring.Text == "Не число" ||
                            Current_numstring.Text == "∞" ||
                            Current_numstring.Text == "Переполнение"
                            )
                        {
                            Current_numstring.Text = "";
                        }
                        else
                        {
                            Current_numstring.Text = Current_numstring.Text.Remove(Current_numstring.Text.Length - 1, 1);
                        }
                    }
                }

                if (Current_numstring.Text == "" || Current_numstring.Text == "-")
                    Current_numstring.Text = "0";
            }
            else // если мы вошли в ошибку у нас любая кнопка редактирования должна стирать все
            {
                operation_type = "";
                operation_type_old = "";

                Current_numstring.Text = "0";
                temp_numstring.Text = "";

                operant1 = 0;
                operant2 = 0;

                zeroDiv = false;
                weUseEquals = false;
                weSelectOperation = false;
                weTypeSomething = false;
                equalasrepit = false;

                enableallButton();

                if (Current_numstring.Text == "" || Current_numstring.Text == "-")
                    Current_numstring.Text = "0";
            }

        }

        /// <summary>
        /// не зависязая от кнопок функция полной отчистки
        /// </summary>
        private void string_clear()
        {
            operation_type = "";
            operation_type_old = "";

            Current_numstring.Text = "0";
            temp_numstring.Text = "";

            operant1 = 0;
            operant2 = 0;

            zeroDiv = false;
            weUseEquals = false;
            weSelectOperation = false;
            weTypeSomething = false;
            equalasrepit = false;
        }

        /// <summary>
        /// Функция для реализации алгебраических операций по нажатию кнопки
        /// </summary>
        private void operation(object sender, EventArgs e)
        {
            weUseEquals = false;
            equalasrepit = false;

            if (Current_numstring.Text == "Не число" || Current_numstring.Text == "∞")
            {
                disabledAllButton();
                Current_numstring.Text = "Переполнение";
            }


            //сложение
            if (((Button)sender).Text == "+")
            {
                operation_type_old = operation_type; //если мы уже соверашали какую-то операцию до нее, то уводим ее в operation_type_old
                operation_type = "+"; //задаем новое значение типа операции

                if (weSelectOperation == false)
                    operant1 = double.Parse(Current_numstring.Text);//если мы еще не задавали никаких значений (operant1 = 0), нужно присвоить что-то
                else
                {
                    if (operation_type_old == operation_type & weTypeSomething == true) //если мы повторяем операцию, то просто дублируем ее для первого операнта
                    {
                        operant1 += double.Parse(Current_numstring.Text);
                    }
                    else
                    {
                        if (weTypeSomething == true)
                        {
                            operant1 = previous_operation(operation_type_old, operant1, Current_numstring, temp_numstring);
                        }
                    }
                }

                weTypeSomething = false;
                weSelectOperation = true; //говорим о том, что мы теперь уже выбрали операцию и другие работают по другому правилу
                if (!zeroDiv)
                {
                    temp_numstring.Text = operant1.ToString() + ((Button)sender).Text;
                    Current_numstring.Text = operant1.ToString();
                }
            }

            //вычетание
            if (((Button)sender).Text == "-")
            {
                operation_type_old = operation_type;
                operation_type = "-";

                if (weSelectOperation == false)
                    operant1 = double.Parse(Current_numstring.Text);
                else
                {
                    if (operation_type_old == operation_type & weTypeSomething == true)
                    {
                        operant1 -= double.Parse(Current_numstring.Text);
                    }
                    else
                    {
                        if (weTypeSomething == true)
                        {
                            operant1 = previous_operation(operation_type_old, operant1, Current_numstring, temp_numstring);
                        }
                    }
                }

                weTypeSomething = false;
                weSelectOperation = true;
                if (!zeroDiv)
                {
                    temp_numstring.Text = operant1.ToString() + ((Button)sender).Text;
                    Current_numstring.Text = operant1.ToString();
                }
            }

            //умножение
            if (((Button)sender).Text == "×")
            {
                operation_type_old = operation_type;
                operation_type = "×";

                if (weSelectOperation == false)
                    operant1 = double.Parse(Current_numstring.Text);
                else
                {
                    if (operation_type_old == operation_type & weTypeSomething == true)
                    {
                        operant1 *= double.Parse(Current_numstring.Text);
                    }
                    else
                    {
                        if (weTypeSomething == true)
                        {
                            operant1 = previous_operation(operation_type_old, operant1, Current_numstring, temp_numstring);
                        }
                    }
                }

                weTypeSomething = false;
                weSelectOperation = true;
                if (!zeroDiv)
                {
                    temp_numstring.Text = operant1.ToString() + ((Button)sender).Text;
                    Current_numstring.Text = operant1.ToString();
                }
            }

            //деление
            if (((Button)sender).Text == "÷")
            {
                operation_type_old = operation_type;
                operation_type = "÷";

                if (weSelectOperation == false)
                    operant1 = double.Parse(Current_numstring.Text);
                else
                {
                    if (operation_type_old == operation_type & weTypeSomething == true)
                    {
                        operant1 /= double.Parse(Current_numstring.Text);
                    }
                    else
                    {
                        if (weTypeSomething == true)
                        {
                            operant1 = previous_operation(operation_type_old, operant1, Current_numstring, temp_numstring);
                        }
                    }
                }

                
                weTypeSomething = false;
                weSelectOperation = true;
                if (!zeroDiv)
                {
                    temp_numstring.Text = operant1.ToString() + ((Button)sender).Text;
                    Current_numstring.Text = operant1.ToString();
                }
            }

            //смена знака
            if (((Button)sender).Text == "±")
            {
                if (Current_numstring.Text == "0")
                    return;
                double num = double.Parse(Current_numstring.Text) * (-1);
                Current_numstring.Text = num.ToString();
            }

            //вывод корня
            if (((Button)sender).Text == "√")
            {
                operant1 = double.Parse(Current_numstring.Text);
                if (operant1 < 0)
                {
                    temp_numstring.Text = $"√({operant1})";
                    Current_numstring.Text = "Sqrt Error";
                    disabledAllButton();
                }
                else
                {
                    double num = Math.Sqrt(operant1);
                    temp_numstring.Text = $"√({operant1})";
                    operant1 = num;
                    Current_numstring.Text = operant1.ToString();
                }
            }

            //возведение в квадрат
            if (((Button)sender).Text == "x²")
            {
                operant1 = double.Parse(Current_numstring.Text);
                temp_numstring.Text = $"sqr({operant1})";

                operant1 = operant1 * operant1;
                Current_numstring.Text = operant1.ToString();
            }

            //нахождение процента от числа
            if (((Button)sender).Text == "%")
            {
                if (weSelectOperation == true)
                    operant2 = double.Parse(Current_numstring.Text);

                operant2 = (operant1 / 100) * operant2;
                temp_numstring.Text = operant1.ToString() + operation_type + operant2.ToString();
                Current_numstring.Text = operant2.ToString();
            }

            if (Current_numstring.Text == "Не число" || Current_numstring.Text == "∞")
            {
                disabledAllButton();
                Current_numstring.Text = "Переполнение";
            }

            weUseOperation = true;
        }

        /// <summary>
        /// Метод для реализации РОВНО, если мы хотим узнать конечный, копируемый ответ операций
        /// </summary>
        private void equals_operation(object sender, EventArgs e)
        {
            weUseEquals = true;

            if (Current_numstring.Text == "Не число" || Current_numstring.Text == "∞")
            {
                disabledAllButton();
                Current_numstring.Text = "Переполнение";
            }

            if (operation_type == "+")
            {
                if (equalasrepit == false)
                {
                    operant2 = double.Parse(Current_numstring.Text);
                    temp_numstring.Text = operant1.ToString() + operation_type + operant2.ToString() + ((Button)sender).Text;
                    Current_numstring.Text = (Math.Round(operant1 + operant2, 6)).ToString();
                    equalasrepit = true;
                }
                else
                {
                    operant1 = double.Parse(Current_numstring.Text);
                    temp_numstring.Text = operant1.ToString() + operation_type + operant2.ToString() + ((Button)sender).Text;
                    Current_numstring.Text = (Math.Round(operant1 + operant2, 6)).ToString();
                }

            }

            if (operation_type == "-")
            {
                if (equalasrepit == false)
                {
                    operant2 = double.Parse(Current_numstring.Text);
                    temp_numstring.Text = operant1.ToString() + operation_type + operant2.ToString() + ((Button)sender).Text;
                    Current_numstring.Text = (operant1 - operant2).ToString();
                    equalasrepit = true;
                }
                else
                {
                    operant1 = double.Parse(Current_numstring.Text);
                    temp_numstring.Text = operant1.ToString() + operation_type + operant2.ToString() + ((Button)sender).Text;
                    Current_numstring.Text = (operant1 - operant2).ToString();
                }
            }

            if (operation_type == "×")
            {
                if (equalasrepit == false)
                {
                    operant2 = double.Parse(Current_numstring.Text);
                    temp_numstring.Text = operant1.ToString() + operation_type + operant2.ToString() + ((Button)sender).Text;
                    Current_numstring.Text = (Math.Round((operant1 * operant2), 2)).ToString();
                    equalasrepit = true;
                }
                else
                {
                    operant1 = double.Parse(Current_numstring.Text);
                    temp_numstring.Text = operant1.ToString() + operation_type + operant2.ToString() + ((Button)sender).Text;
                    Current_numstring.Text = (Math.Round((operant1 * operant2), 2)).ToString();
                }
            }

            if (operation_type == "÷")
            {
                if (equalasrepit == false)
                {
                    operant2 = double.Parse(Current_numstring.Text);
                    if (operant2 != 0)
                    {
                        temp_numstring.Text = operant1.ToString() + operation_type + operant2.ToString() + ((Button)sender).Text;
                        Current_numstring.Text = (operant1 / operant2).ToString();
                        equalasrepit = true;
                    }
                    else
                    {
                        temp_numstring.Text = operant1.ToString() + operation_type + operant2.ToString() + ((Button)sender).Text;
                        Current_numstring.Text = "деление на 0";
                        disabledAllButton();
                    }

                }
                else
                {
                    operant1 = double.Parse(Current_numstring.Text);
                    temp_numstring.Text = operant1.ToString() + operation_type + operant2.ToString() + ((Button)sender).Text;
                    Current_numstring.Text = (operant1 / operant2).ToString();
                }
            }

            if (Current_numstring.Text == "Не число" || Current_numstring.Text == "∞")
            {
                disabledAllButton();
                Current_numstring.Text = "Переполнение";
            }
            weSelectOperation = false;
        }

        /// <summary>
        /// метод реализующий завершение предыдущей операции, прежде чем дать пользователю выполнения следующей
        /// </summary>
        /// <param name="old_operation"> недовыполненная операция без знакак = </param>
        /// <param name="operant"> оперант с которым мы работаем </param>
        /// <param name="current"> текущая строка ввода символов </param>
        /// <param name="temp"> строка памяти, отображающая действие выполняемое в данный момент</param>
        /// <returns></returns>
        public double previous_operation(string old_operation, double operant, TextBox current, TextBox temp)
        {
            if (Current_numstring.Text == "Не число" || Current_numstring.Text == "∞")
            {
                disabledAllButton();
                Current_numstring.Text = "Переполнение";
            }

            if (old_operation == "+")
            {
                operant += double.Parse(current.Text);
                temp.Text = operant.ToString() + old_operation;
                current.Text = operant.ToString();
                return operant;
            }

            if (old_operation == "-")
            {
                operant -= double.Parse(current.Text);
                temp.Text = operant.ToString() + old_operation;
                current.Text = operant.ToString();
                return operant;
            }

            if (old_operation == "×")
            {
                operant *= double.Parse(current.Text);
                temp.Text = operant.ToString() + old_operation;
                current.Text = operant.ToString();
                return operant;
            }

            if (old_operation == "÷")
            {
                operant /= double.Parse(current.Text);
                if (double.Parse(current.Text) == 0)
                {
                    temp.Text = operant.ToString() + old_operation;
                    current.Text = "деление на 0";
                    zeroDiv = true;
                    disabledAllButton();
                }
                else
                {
                    temp.Text = operant.ToString() + old_operation;
                    current.Text = operant.ToString();
                    return operant;
                }

            }

            return 0;
        }

        /// <summary>
        /// включает все выключенные кнопки операций
        /// </summary>
        public void enableallButton()
        {
            error = false;
            button_procent.Enabled = true;
            button_squaring.Enabled = true;
            button_sqrt.Enabled = true;
            button_plus.Enabled = true;
            button_division.Enabled = true;
            button_minus.Enabled = true;
            button_multiply.Enabled = true;
            button_plusminus.Enabled = true;
            button_comma.Enabled = true;
            button_equals.Enabled = true;
        }

        /// <summary>
        /// позволяет отключить все кнопки операции по необходиомсти
        /// </summary>
        public void disabledAllButton()
        {
            error = true;
            button_procent.Enabled = false;
            button_squaring.Enabled = false;
            button_sqrt.Enabled = false;
            button_plus.Enabled = false;
            button_division.Enabled = false;
            button_minus.Enabled = false;
            button_multiply.Enabled = false;
            button_plusminus.Enabled = false;
            button_comma.Enabled = false;
            button_equals.Enabled = false;
        }

        public void Zerodev()
        {
            Current_numstring.Text = "деление на 0";
        }
    }
}
