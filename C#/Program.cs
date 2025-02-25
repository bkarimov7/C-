// See https://aka.ms/new-console-template for more information

// *** Тып данных имя переменной


/* int a = 5;
bool variable = false;
bool Variable = true;
double b = 1.33;
char c = '#';
string s = "Бахром";
    
Console.WriteLine(s);
Console.WriteLine(c);
Console.WriteLine(b);
Console.WriteLine(a);
Console.WriteLine(variable);
Console.WriteLine(Variable);

int i = 5;
Console.WriteLine(i);

i = 455;
Console.WriteLine(i);
*/


// *** Консольный вывод

/*
string date;
date = Console.ReadLine();
Console.WriteLine("Привет " +  date + "!!!");
Console.WriteLine($"Привет {date} !!!");



string hallo = "Привет мир";
Console.WriteLine(hallo);
Console.WriteLine("Добро пожаловть в С#");
Console.WriteLine("Пока мир ...");
Console.WriteLine(24.5);

string name = "Том";
int age = 42;
double height = 1.7;
Console.WriteLine($"Имя: {name}, Возраст: {age}, Рост: {height}");
Console.WriteLine("Имя: " + name + ", Возраст: " + age + ", Рост: " + height);
Console.WriteLine("Имя: {0}, Возврат: {1}, Рост: {2}", name, age, height);
*/

// *** Консольный ввод

/*
Console.WriteLine("Введите своё имя: ");
string? name = Console.ReadLine();
Console.WriteLine("Привет " + name + "!");
Console.WriteLine($"Привет {name}!");
*/

// *** Конвертация строки класс Convert

/*
int a, b;
Console.WriteLine("Введите число 1");
a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число 2");
b = Convert.ToInt32(Console.ReadLine());
int result = a + b;
Console.WriteLine("Сумма чисел = " + result);
Console.WriteLine($"Сумма чисел = {result}");
*/

/*
Console.WriteLine("Введите имя: ");
string? name = Console.ReadLine();

Console.WriteLine("Введите возраст: ");
int age = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите рост: ");
double height = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите размер зарплаты ");
decimal salary = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine($"Имя: {name} Возраст: {age} Рост: {height} Зарплата: {salary}");
*/

// *** Конвертация строки  
//     методом parse и tryparse

/*
string str = "5,9";

double a = double.Parse(str);

Console.ReadKey();

*/


// *** Операторы
// *** Арифметические операции с числами

// Домашнее задание

/*
1.Напишите программу, вычисляющую среднее арифметическое двух чисел.
*/

/*
Console.WriteLine("Введите певое число");
double chislo_1 = double.Parse(Console.ReadLine());

Console.WriteLine("Введите второе число");
double chislo_2 = double.Parse(Console.ReadLine());

double result = ((double) chislo_1 + chislo_2) / 2;

Console.WriteLine($"Среднее двух чисель {result}");

Console.ReadLine();
*/

// 2. Введите три числа и выведите на экран значение суммы и произведения этих чисел

/*
Console.WriteLine("Введите певое число");
double chislo_1 = double.Parse(Console.ReadLine());

Console.WriteLine("Введите второе число");
double chislo_2 = double.Parse(Console.ReadLine());

Console.WriteLine("Введите третью число");
double chislo_3 = double.Parse(Console.ReadLine());

double result1 = (chislo_1 + chislo_2 + chislo_3);
double result2 = (chislo_1 * chislo_2 * chislo_3);

Console.WriteLine($"Значения трех чисел равна  {result1}");
Console.WriteLine($"Произведение трех чисел равна  {result2}");
*/


/*3.Напишите простой конвертер валют (без возможности динамического выбора валюты пользователем). Валюты заданы хардкодом и не изменяются.
Тип валют на выбор программиста*/

/*
Console.WriteLine("Введите сумму продажи в валюте сомони: ");
double chislo_1 = double.Parse(Console.ReadLine());

double USD = 10.01;
double EUR = 11.01;
double RUR = 0.12;

double result_USD = (chislo_1 / USD);
double result_EUR = (chislo_1 / EUR);
double result_RUR = (chislo_1 / RUR);

Console.WriteLine($"Сумма покупки в Долларах равна: \n {result_USD}");
Console.WriteLine($"Сумма покупки в Евро равна: \n {result_EUR}");
Console.WriteLine($"Сумма покупки в Рублях равна: \n {result_RUR}");
*/

// Несколько проектов в одном решении

/*
Операторы отношений
Операция сравнения
*/

/*
int a = 5;
int b = 4;
bool result = a == b;

Console.WriteLine(result);




Console.ReadKey();
*/


/*
 * Конструкция If Else
 */


/*bool isInfected = true;

if (isInfected)
{
    Console.WriteLine("Персонаж инфицирован!");
}
else
{
    Console.WriteLine("Персонаж здоров!");
}
*/

// Напишите программу, проверяющую число, введенное в клавиатуры на четность.

/*
Console.WriteLine("Введите число: ");
int chislo = int.Parse(Console.ReadLine());
int с = chislo % 2;
if (с > 0)
    Console.WriteLine("Вводимое число не четное");
else
    Console.WriteLine("Вводимое число четное");
*/

/*
    Упражнение 1
Напишите консольную программу, в которую пользователь вводит с клавиатуры два числа. А программа сранивает 
два введенных числа и выводит на консоль результат сравнения (два числа равны, первое число больше второго 
или первое число меньше второго).
*/
/*
Console.WriteLine("Введите первое число: ");
double first_number = double.Parse(Console.ReadLine());

Console.WriteLine("Введите первое число: ");
double second_number = double.Parse(Console.ReadLine());

if (first_number == second_number )
{
    Console.WriteLine($"Два числа равны : {first_number} = {second_number}");
}
else if (first_number > second_number)
{
    Console.WriteLine($"Первое число больше второго : {first_number} > {second_number}");
}
else    Console.WriteLine($"Первое число меньше второго : {first_number} < {second_number}");
*/
/*
    Упражнение 2
Напишите консольную программу, в которую пользователь вводит с клавиатуры число.
Если число одновременно больше 5 и меньше 10, то программа выводит "Число больше 5 и меньше 10".
Иначе программа выводит сообщение "Неизвестное число".
*/

/*
Console.WriteLine("Введите число: ");
double number = double.Parse(Console.ReadLine());

if (number > 5 && number < 10) Console.WriteLine($"Число больше 5 и меньше 10 : 5 > {number} > 10 ");
else Console.WriteLine($"Неизвестное число");
*/

/*
    Упражнение 3
Напишите консольную программу, в которую пользователь вводит с клавиатуры число.
Если число либо равно 5, либо равно 10, то программа выводит "Число либо равно 5, либо равно 10".
Иначе программа выводит сообщение "Неизвестное число".
*/

/*
Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine());

if (number == 5 || number == 10) Console.WriteLine($"Число либо равно 5, либо равно 10:  {number} = 10 или {number} = 5 ");
else Console.WriteLine($"Неизвестное число");
*/

/*
    Упражнение 4
В банке в зависимости от суммы вклада начисляемый процент по вкладу может отличаться. Напишите консольную программу,
в которую пользователь вводит сумму вклада. Если сумма вклада меньше 100, то начисляется 5%. Если сумма вклада от 100 до 200, то начисляется 7%.
Если сумма вклада больше 200, то начисляется 10%. В конце программа должна выводить сумму вклада с начисленными процентами.
Для получения вводимого с клавиатуры числа используйте выражение Convert.ToDouble(Console.ReadLine())
*/

/*

Console.Write("Введите сумму вклада: ");

if (!double.TryParse(Console.ReadLine(), out double sum) || sum < 0)
{
    Console.WriteLine("Ошибка ввода! Введите корректное положительное число.");
    return;
}

double interestRate = sum < 100 ? 0.05 :
                      sum <= 200 ? 0.07 : 0.1;

sum += sum * interestRate;

Console.WriteLine($"Сумма вклада после начисления {interestRate * 100:F2}%: {sum:F2}");

 */



/*
Упражнение 5
Изменим предыдущую задачу. Допустим, банк периодически начисляет по всем вкладам кроме процентов бонусы.
И, допустим, сейчас банк решил доначислить по всем вкладам 15 единиц вне зависимости от их суммы.
Измените программу таким образом, чтобы к финальной сумме дочислялись бонусы.
*/

/*

Console.Write("Введите сумму вклада: ");

if (!double.TryParse(Console.ReadLine(), out double sum) || sum < 0)
{
    Console.WriteLine("Ошибка ввода! Введите корректное положительное число.");
    return;
}

double interestRate = sum < 100 ? 0.05 :
                      sum <= 200 ? 0.07 : 0.10;

sum += sum * interestRate;
       double bonus = 15;

Console.WriteLine($"Сумма вклада после насисления и бонуса {(sum + bonus):F2}");

*/


/*
Упражнение 6
Напишите консольную программу, которая выводит пользователю сообщение "Введите номер операции: 1.Сложение 2.Вычитание 3.Умножение".
Рядом с названием каждой операции указан ее номер, например, операция вычитания имеет номер 2.
Пусть пользователь вводит в программу номер операции, и в зависимости от номера операции программа выводит ему название операции.
Для определения операции по введенному номеру используйте конструкцию switch...case.
Если введенное пользователем число не соответствует никакой операции (например, число 120), то выведите пользователю сообщение о том,
что операция неопределена.
*/

/*
Console.Write("Введите номер операции: ");

if (!double.TryParse(Console.ReadLine(), out double sum) || sum < 0)
{
    Console.WriteLine("Ошибка ввода! Введите корректное положительное число.");
    return;
}

switch (sum)
{
    case 1:
        Console.WriteLine($"Сложение");
        break;
    case 2:
        Console.WriteLine($"Вычитание");
        break;
    case 3:
        Console.WriteLine($"Умножение");
        break;
    default:
        Console.WriteLine($"Операция не определена");
        break;
}
*/

/*
Упражнение 7
Измените предыдущую программу. Пусть пользователь кроме номера операции вводит два числа, и в зависимости от номера операции
с введенными числами выполняются определенные действия (например, при вводе числа 3 числа умножаются). Результа операции выводиться на консоль.
*/

/*
Console.Write("Введите номер операции: 1.Сложение  2.Вычитание  3.Умножение  ");

if (!double.TryParse(Console.ReadLine(), out double arithmeticOperator) || arithmeticOperator < 0)
{
    Console.WriteLine("Ошибка ввода! Введите корректное положительное число.");
    return;
}

Console.Write("Введите первое число: ");

if(!double.TryParse(Console.ReadLine(), out double sum1) || sum1 < 0)
{
    Console.WriteLine("Ошибка ввода! Введите корректное положительное число.");
    return;
}

Console.Write("Введите второе число: ");

if (!double.TryParse(Console.ReadLine(), out double sum2) || sum2 < 0)
{
    Console.WriteLine("Ошибка ввода! Введите корректное положительное число.");
    return;
}

switch (arithmeticOperator)
{
    case 1:
        Console.WriteLine($"Сложение двух чисел равна: {sum1+sum2 }");
        break;
    case 2:
        Console.WriteLine($"Вычитание двух чисел равна: {sum1 - sum2}");
        break;
    case 3:
        Console.WriteLine($"Умножение двух чисел равна: {sum1 * sum2}");
        break;
    default:
        Console.WriteLine($"Операция не определена");
        break;

}

*/
/*

Console.Write("Введите первое число: ");

if (!double.TryParse(Console.ReadLine(), out double sum1) || sum1 < 0)
{
    Console.WriteLine("Ошибка ввода! Введите корректное положительное число.");
    return;
}

Console.Write("Введите оператор ( + , - , * , / ):   ");

if (!char.TryParse(Console.ReadLine(), out char arithmeticOperator))
{
    Console.WriteLine("Ошибка ввода! Введите корректное положительное число.");
    return;
}

Console.Write("Введите первое число: ");

if (!double.TryParse(Console.ReadLine(), out double sum2) || sum2 < 0)
{
    Console.WriteLine("Ошибка ввода! Введите корректное положительное число.");
    return;
}

switch (arithmeticOperator)
{
    case '+':
        Console.WriteLine($"Сумма сложений равна: {sum1 + sum2}");
        break;
    case '-':
        Console.WriteLine($"Сумма вычитания равна: {sum1 - sum2}");
        break;
    case '*':
        Console.WriteLine($"Сумма умножение равна: {sum1 * sum2}");
        break;
    case '/':
        if (sum2 != 0)
            Console.WriteLine($"Сумма деления равна: {sum1 / sum2}");
        else
            Console.WriteLine("Ошибка: деление на ноль!");
        break;
    default:
        Console.WriteLine($"Простите такого оператора я не знаю");
        break;

        Console.ReadKey();

}

*/

/*
while (true)
{
    Console.Clear();
    Console.WriteLine("Введите первое число: ");

    if (!double.TryParse(Console.ReadLine(), out double sum1) || sum1 < 0)
    {
        Console.WriteLine("Ошибка ввода! Введите корректное положительное число.");
        return;
    }

    Console.WriteLine("Введите оператор ( + , - , * , / ):   ");

    if (!char.TryParse(Console.ReadLine(), out char arithmeticOperator))
    {
        Console.WriteLine("Ошибка ввода! Введите корректное положительное число.");
        return;
    }

    Console.WriteLine("Введите первое число: ");

    if (!double.TryParse(Console.ReadLine(), out double sum2) || sum2 < 0)
    {
        Console.WriteLine("Ошибка ввода! Введите корректное положительное число.");
        return;
    }


    if (arithmeticOperator == '+')
        Console.WriteLine($"Сумма сложений равна: {sum1 + sum2}");

    else if (arithmeticOperator == '-')
        Console.WriteLine($"Сумма вычитания равна: {sum1 - sum2}");

    else if (arithmeticOperator == '*')
        Console.WriteLine($"Сумма умножение равна: {sum1 * sum2}");

    else if (arithmeticOperator == '/')
        if (sum2 != 0)
            Console.WriteLine($"Сумма деления равна: {sum1 / sum2}");
        else
            Console.WriteLine("Ошибка: деление на ноль!");

    else Console.WriteLine("Ошибка: неверный оператор!");

    Console.ReadKey();

}

*/



/*
 * Цикл While
 *
 */

/*

int chotnoe = 0;
int neChotnoe = 0;

int cont = 0;
int limit = int.Parse(Console.ReadLine());

while (cont < limit)
{
    cont++;

    int chislo = cont % 2;
    if (chislo == 0)
        chotnoe++;
    else 
        neChotnoe++;
            
}

Console.WriteLine($"Четные числа   : {chotnoe} \nНечетные числа : {neChotnoe}");
*/

/*

Console.WriteLine("Введите число");
int chislo = int.Parse(Console.ReadLine());
Console.WriteLine("Введите Степен");
int stepen = int.Parse(Console.ReadLine());

Console.WriteLine($"Резултарь равно : {Math.Pow(chislo, stepen)}");

*/

// ***  Цикл for 

/*
for (int i = 1; i < 3; i++)
{
    switch (i)
    {
        default:
            Console.WriteLine($"i = {i++}");
            break;
    }
}
*/

// ***   Упражнение 1


/*

    Console.Write("Введите сумму вклада : ");
    if (!double.TryParse(Console.ReadLine(), out double summ) || summ < 0)
    {
        Console.WriteLine("Ошибка ввода! Введите корректное положительное число.");
        return;
    }

    Console.Write("Введите кол-во месяцев : ");
    if (!double.TryParse(Console.ReadLine(), out double month) || month < 0)
    {
        Console.WriteLine("Ошибка ввода! Введите корректное положительное число.");
    }

    double percent_bank = summ * 7 / 100;
    double result = 0;
    double percent = percent_bank;
    for (int i = 1; i <= month; i++)
    {
        result = summ + percent;
        Console.WriteLine($"Месяц {i} = {result:F2}");
        percent += percent_bank = summ * 7 / 100;
        
    }

    Console.ReadKey();

*/

// ***  Упражнение 1

/*
Console.WriteLine("Введите сумму вклада: ");
decimal sum = Convert.ToDecimal(Console.ReadLine());
Console.WriteLine("Введите срок вклада в месяцах: ");
int period = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i <= period; i++)
{
    sum += sum * 0.07M;
}
Console.WriteLine($"После {period} месяцев сумма вклада составит {sum:F2}");
Console.ReadKey();
*/



// *** Упражнение 2


/*
Console.WriteLine("Введите сумму вклада: ");
decimal sum = Convert.ToDecimal(Console.ReadLine());
Console.WriteLine("Введите срок вклада в месяцах: ");
int period = Convert.ToInt32(Console.ReadLine());

int i = 1;
while ( i <= period)
{
    sum += sum * 0.07M;
    i++;
}
Console.WriteLine($"После {period} месяцев сумма вклада составит {sum:F2}");
Console.ReadKey();
*/


// *** Упражнение 3

/*

for (int i = 1; i <= 9; i++)
{
    for (int j = 1; j <= 9; j++)
    {
       Console.Write($"{j} * {i} = {j * i} \t");
    }

    Console.WriteLine();
}

 */

/*
while (true)
{
    Console.WriteLine("Введите первое число:");
    int num1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите второе число:");
    int num2 = Convert.ToInt32(Console.ReadLine());

    if (num1 < 0 || num1 > 10 || num2 < 0 || num2 > 10)
    {
        Console.WriteLine("Оба числа должны быть в диапазоне от 0 до 10");
    }
    else
    {
        Console.WriteLine($"{num1} * {num2} = {num1 * num2}");
        break;
    }

}
*/

/*
Console.WriteLine("Введите высоту прямоугольника: ");
int height = int.Parse(Console.ReadLine());

Console.WriteLine("Введите ширину прямоугольника: ");
int width = int.Parse(Console.ReadLine());

for (int j = 0; j < height; j++)
{
    for (int i = 0; i < width; i++)
    {
        Console.Write("#");
    }
    Console.WriteLine();
}


Console.ReadKey();
*/


/*
Console.WriteLine("Введите высоту треугольника: ");
int height = int.Parse(Console.ReadLine());

for (int i = 0; i < height; i++)
{
    for (int j = 0; j < i; j++)
    {
        Console.Write("*");
    }
    Console.WriteLine();
}



Console.ReadKey();
*/

// *******   Массивы



Console.Write("Введите количество элеметов массива:\t ");
int elementsCount = int.Parse(Console.ReadLine());


int[] myArray = new int[elementsCount];

for (int i = 0; i < myArray.Length; i++)
{
    Console.Write($"\nВведите элемкнт массива под индексом {i}:\t ");
    myArray[i]= int.Parse(Console.ReadLine());
}

Console.WriteLine("\nВывод массива: ");
for (int i = 0; i < myArray.Length; i++)
{
    Console.WriteLine($"\n {myArray[i]}" );
}

Console.ReadLine();    