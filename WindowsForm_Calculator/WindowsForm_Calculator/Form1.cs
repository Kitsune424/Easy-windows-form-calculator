using System.Reflection.Emit;

namespace WindowsForm_Calculator
{
    public partial class Form1 : Form
    {
        double operant1 = 0;
        double operant2 = 0;
        string operation_type;
        string operation_type_old;
        bool weSelectOperation = false;
        bool weTypeSomething = false;
        bool equalasrepit = false;
        bool longoperatn = false;

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

                if (Current_numstring.Text == "0") //если в строке у нас 0, просто 0
                {
                    if (num.Text == "0") { return; } //не даем вписать второй 0
                    else if (num.Text == ",")
                    {
                        if (!Current_numstring.Text.Contains(',') & num.Text == ",") { Current_numstring.Text += num.Text; } //проверяем на запятые, нельзя больше одной
                        else if (Current_numstring.Text.Contains(',') & num.Text == ",") { return; }
                    } 
                    else { Current_numstring.Text = ""; Current_numstring.Text += num.Text; } //убираем 0 и ставим число
                }

                else if (Current_numstring.Text == operant1.ToString()) //если текущая строка сформирована из элемента первого опперанта после операции
                {
                    if (num.Text == ",") 
                    {
                        if (!Current_numstring.Text.Contains(',') & num.Text == ",") { Current_numstring.Text = "0"; Current_numstring.Text += num.Text; } //проверяем на запятые, нельзя больше одной
                        else if (Current_numstring.Text.Contains(',') & num.Text == ",") { return; }
                    }
                    else { Current_numstring.Text = ""; Current_numstring.Text = num.Text; } //обнуляем, потом пишем свое число
                }

                else //если не впали в первые два условия
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
                if (longoperatn == false)
                {
                    if (Current_numstring.Text == operant1.ToString()) //если текущая строка сформирована из элемента первого опперанта после операции
                    {
                        if (num.Text == ",")
                        {
                            if (!Current_numstring.Text.Contains(',') & num.Text == ",") { Current_numstring.Text = "0"; Current_numstring.Text += num.Text; } //проверяем на запятые, нельзя больше одной
                            else if (Current_numstring.Text.Contains(',') & num.Text == ",") { return; }
                        }
                        else { Current_numstring.Text = ""; Current_numstring.Text = num.Text; } //обнуляем, потом пишем свое число
                        longoperatn = true;
                    }
                }
                else
                {
                    return;
                }
            }
            
        }

        /// <summary>
        /// все виды стирания на любой вкус
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void string_clear(object sender, EventArgs e)
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

                weSelectOperation = false;
                weTypeSomething = false;
                equalasrepit = false;
            }

            //Clear entry - чистит только строку ввода
            else if (((Button)sender).Text == "CE")
            {
                Current_numstring.Text = "0";
            }

            //backspace - убирает строку посимвольно
            else
            {
                if (Current_numstring.Text == operant1.ToString())
                    return;
                if (Current_numstring.Text != "0")
                {
                    if(Current_numstring.Text == operant1.ToString())
                    {
                        return;
                    }
                    else
                    {
                        Current_numstring.Text = Current_numstring.Text.Remove(Current_numstring.Text.Length - 1, 1);
                    }
                }
            }

            if (Current_numstring.Text == "")
                Current_numstring.Text = "0";
        }

        /// <summary>
        /// Функция для реализации алгебраических операций по нажатию кнопки
        /// </summary>
        private void operation(object sender, EventArgs e)
        {
            //сложение
            if (((Button)sender).Text == "+")
            {
                operation_type_old = operation_type; //если мы уже соверашали какую-то операцию до нее, то уводим ее в operation_type_old
                operation_type = "+"; //задаем новое значение типа операции

                if (weSelectOperation == false)
                    operant1 = double.Parse(Current_numstring.Text);//если мы еще не задавали никаких значений (operant1 = 0), нужно присвоить что-то
                else
                {
                    if (operation_type_old == operation_type  & weTypeSomething == true) //если мы повторяем операцию, то просто дублируем ее для первого операнта
                    {
                        operant1 += double.Parse(Current_numstring.Text);
                    }
                    else 
                    {
                        if (weTypeSomething == true)
                        {
                            operant1 = Operation_class.previous_operation(operation_type_old, operant1, Current_numstring, temp_numstring);
                        }
                    }
                }

                weTypeSomething = false;
                weSelectOperation = true; //говорим о том, что мы теперь уже выбрали операцию и другие работают по другому правилу
                temp_numstring.Text = operant1.ToString() + ((Button)sender).Text; //уводим предворительную форму в temp_numstring для удобства
                Current_numstring.Text = operant1.ToString(); //не знаб зачем но Windows calculator дает изначально в вод предварительный результат
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
                            operant1 = Operation_class.previous_operation(operation_type_old, operant1, Current_numstring, temp_numstring);
                        }
                    }
                }

                weTypeSomething = false;
                weSelectOperation = true;
                temp_numstring.Text = operant1.ToString() + ((Button)sender).Text;
                Current_numstring.Text = operant1.ToString();
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
                            operant1 = Operation_class.previous_operation(operation_type_old, operant1, Current_numstring, temp_numstring);
                        }
                    }
                }

                weTypeSomething = false;
                weSelectOperation = true;
                temp_numstring.Text = operant1.ToString() + ((Button)sender).Text;
                Current_numstring.Text = operant1.ToString();
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
                            operant1 = Operation_class.previous_operation(operation_type_old, operant1, Current_numstring, temp_numstring);
                        }
                    }
                }

                weTypeSomething = false;
                weSelectOperation = true;
                temp_numstring.Text = operant1.ToString() + ((Button)sender).Text;
                Current_numstring.Text = operant1.ToString();
            }

            //смена знака
            if (((Button)sender).Text == "±")
            {
                double num = double.Parse(Current_numstring.Text) * (-1);
                Current_numstring.Text = num.ToString();
            }

            //вывод корня
            if (((Button)sender).Text == "√")
            {
                operant1 = double.Parse(Current_numstring.Text);
                double num = Math.Sqrt(operant1);

                temp_numstring.Text = $"√({operant1})";

                operant1 = num;
                Current_numstring.Text = operant1.ToString();
            }

            //возведение в квадрат
            if (((Button)sender).Text == "x²")
            {
                operant1 = double.Parse(Current_numstring.Text);
                temp_numstring.Text = $"sqrt({operant1})";

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
        }

        /// <summary>
        /// Метод для реализации РОВНО, если мы хотим узнать конечный, копируемый ответ операций
        /// </summary>
        private void equals_operation(object sender, EventArgs e)
        {
            if (operation_type == "+")
            {
                if (equalasrepit == false)
                {
                    operant2 = double.Parse(Current_numstring.Text);
                    temp_numstring.Text = operant1.ToString() + operation_type + operant2.ToString() + ((Button)sender).Text;
                    Current_numstring.Text = (operant1 + operant2).ToString();
                    equalasrepit = true;
                }
                else
                {
                    operant1 = double.Parse(Current_numstring.Text);
                    temp_numstring.Text = operant1.ToString() + operation_type + operant2.ToString() + ((Button)sender).Text;
                    Current_numstring.Text = (operant1 + operant2).ToString();
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
                    Current_numstring.Text = (operant1 * operant2).ToString();
                    equalasrepit = true;
                }
                else
                {
                    operant1 = double.Parse(Current_numstring.Text);
                    temp_numstring.Text = operant1.ToString() + operation_type + operant2.ToString() + ((Button)sender).Text;
                    Current_numstring.Text = (operant1 * operant2).ToString();
                }
            }

            if (operation_type == "÷")
            {
                if (equalasrepit == false)
                {
                    operant2 = double.Parse(Current_numstring.Text);
                    temp_numstring.Text = operant1.ToString() + operation_type + operant2.ToString() + ((Button)sender).Text;
                    Current_numstring.Text = (operant1 / operant2).ToString();
                    equalasrepit = true;
                }
                else
                {
                    operant1 = double.Parse(Current_numstring.Text);
                    temp_numstring.Text = operant1.ToString() + operation_type + operant2.ToString() + ((Button)sender).Text;
                    Current_numstring.Text = (operant1 / operant2).ToString();
                }
            }

            weSelectOperation = false;
        }
    }


    // Класс для дополнительныйх подопераций
    public class Operation_class
    {
        /// <summary>
        /// метод реализующий завершение предыдущей операции, прежде чем дать пользователю выполнения следующей
        /// </summary>
        /// <param name="old_operation"> недовыполненная операция без знакак = </param>
        /// <param name="operant"> оперант с которым мы работаем </param>
        /// <param name="current"> текущая строка ввода символов </param>
        /// <param name="temp"> строка памяти, отображающая действие выполняемое в данный момент</param>
        /// <returns></returns>
        public static double previous_operation(string old_operation, double operant, TextBox current, TextBox temp)
        {
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
                temp.Text = operant.ToString() + old_operation;
                current.Text = operant.ToString();
                return operant;
            }

            return 0;
        }
    }
}
