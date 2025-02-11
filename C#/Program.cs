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






Console.ReadKey();







