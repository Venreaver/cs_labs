using System;
using System.Collections.Generic;
using System.Linq;

namespace lab_1
{
    class Program
    {
        static void Main(string[] args)
        {
            ShowMainMenu();
        }

        public static void ShowMainMenu()
        {
            while (true)
            {
                Console.WriteLine(
@"Выберете необходимое действие:
    1 – Общая информация по типам
    2 – Выбрать из списка
    3 – Ввести имя типа
    4 – Параметры консоли
    0 - Выход из программы");
                switch (Console.ReadKey(true).KeyChar)
                {
                    case '1':
                        ShowAllTypeInfo();
                        break;
                    case '2':
                        var v = SelectType();
                        if (v != null)
                        {
                            ShowInfo(v);
                        }
                        break;
                    case '3':
                        Console.Clear();
                        Console.WriteLine("Write name of type in English here: ");
                        string s = null;
                        Type t = null;
                        while (true)
                        {
                            try
                            {
                                s = Console.ReadLine();
                                t = AppDomain.CurrentDomain.GetAssemblies().SelectMany(x => x.GetTypes()).First(x => x.Name.ToLower() == s.ToLower());
                                Console.WriteLine(t.GetType());
                                ShowInfo(t);
                                break;
                            }
                            catch (InvalidOperationException)
                            {
                                Console.Clear();
                                Console.WriteLine("Wrong name of type.\nPlease, try again.\nWrite name of type in English here: ");
                                continue;
                            }
                        }
                        break;
                    case '4':
                        ChangeConsoleView();
                        break;
                    case '0':
                        Environment.Exit(0);
                        break;
                    default: break;
                }
            }
        }
        public static void ShowAllTypeInfo()
        {
            List<Type> types = new List<Type>(AppDomain.CurrentDomain.GetAssemblies().SelectMany(g => g.GetTypes()));
            
            int CountMaxMethods = types.Max(t => t.GetMethods().Length);
            var TypeMaxMethods = types.First(t => t.GetMethods().Length == CountMaxMethods);
            int MaxNameOfMethod = types.Max(g => g.GetMethods().Length > 0 ? g.GetMethods().Max(n => n.Name.Length):0);
            var mNameOfMethod = types.SelectMany(g => g.GetMethods()).First(n => n.Name.Length == MaxNameOfMethod);
            int MaxParamOfMethod = types.Max(g => g.GetMethods().Length > 0 ? g.GetMethods().Max(p => p.GetParameters().Length) : 0);
            var mParamMethod = types.SelectMany(g => g.GetMethods()).First(p => p.GetParameters().Length == MaxParamOfMethod);

            Console.Clear();
            Console.WriteLine("Общая информация по типам" + '\n'
                + '\n' + "\tПодключенные сборки:".PadRight(45) + AppDomain.CurrentDomain.GetAssemblies().Length
                + '\n' + "\tВсего типов по всем подключенным сборкам:".PadRight(45) + types.Count
                + '\n' + "\tСсылочные типы:".PadRight(45) + types.Count(g => g.IsClass)
                + '\n' + "\tЗначимые типы:".PadRight(45) + types.Count(g => g.IsValueType)
                + '\n' + "\tТипы-интерфейсы:".PadRight(45) + types.Count(g => g.IsInterface)
                + '\n' + "\tТип с максимальным числом методов:".PadRight(45) + TypeMaxMethods.Name.PadRight(10) + "\t" + CountMaxMethods
                + '\n' + "\tСамое длинное название метода:".PadRight(45) + mNameOfMethod.Name
                + '\n' + "\tМетод с наибольшим числом аргументов:".PadRight(45) + mParamMethod.Name + '\n'
                + '\n' + "Нажмите любую клавишу, чтобы вернуться в главное меню");

            Console.ReadKey(true);
            Console.Clear();
        }
        public static Type SelectType()
        {
            Console.Clear();
            Console.WriteLine(
@"Выберете необходимое действие:
    1 – uint
    2 – int
    3 – long
    4 – float
    5 – double
    6 – char
    7 - string
    8 – MyClass
    9 – MyStruct
    0 – Выход в главное меню");
            
            while(true)
            {
                switch (Console.ReadKey(true).KeyChar)
                {
                    case '1': return typeof(uint);
                    case '2': return typeof(int);
                    case '3': return typeof(long);
                    case '4': return typeof(float);
                    case '5': return typeof(double);
                    case '6': return typeof(char);
                    case '7': return typeof(string);
                    case '8': return typeof(MyClass);
                    case '9': return typeof(MyStruct);
                    case '0':
                        Console.Clear();
                        return null;
                    default: break;
                }
            }
        }
        public static void ShowInfo(Type t) {
            Console.Clear();
            Console.WriteLine("Информация по типу: " + t + '\n'
                            + '\n' + "\tЗначимый тип:".PadRight(30) + (t.IsValueType ? "+" : "-")
                            + '\n' + "\tПространство имен:".PadRight(30) + t.Namespace
                            + '\n' + "\tСборка:".PadRight(30) + t.Assembly.GetName().Name
                            + '\n' + "\tОбщее число элементов:".PadRight(30) + t.GetMembers().Length
                            + '\n' + "\tЧисло методов:".PadRight(30) + t.GetMethods().Length
                            + '\n' + "\tЧисло свойств:".PadRight(30) + t.GetProperties().Length
                            + '\n' + "\tЧисло полей:".PadRight(30) + t.GetFields().Length
                            + '\n' + "\tСписок полей:".PadRight(30)
                                + (t.GetFields().Length == 0 ? "-" : string.Join(", ", t.GetFields().Select(p => p.Name)))
                            + '\n' + "\tСписок свойств:".PadRight(30)
                                + (t.GetProperties().Length == 0 ? "-" : string.Join(", ", t.GetProperties().Select(p => p.Name))) + '\n'
                            + '\n' + "Нажмите \'M\' для вывода дополнительной информации по методам:"
                            + '\n' + "Нажмите \'0\' для выхода в главное меню");
            while (true)
            {
                switch (char.ToLower(Console.ReadKey(true).KeyChar))
                {
                    case 'm':
                        Console.Clear();
                        Console.WriteLine("Методы типа " + t
                                        + '\n' + "\nНазвание".PadRight(20) + "Число перегрузок".PadRight(20) + "Число параметров" + '\n'
                                        + string.Join("\n", t.GetMethods().GroupBy(m => m.Name).Select(g => g.Key.PadRight(25) + g.Count().ToString().PadRight(20)
                                        + g.Min(param => param.GetParameters().Length)
                                        + (g.Max(param => param.GetParameters().Length) == g.Min(param => param.GetParameters().Length)
                                            ? "" : ".." + g.Max(param => param.GetParameters().Length)))) + '\n'
                                        + '\n' + "Нажмите \'0\' для выхода в главное меню");
                        break;
                    case '0':
                        Console.Clear();
                        return;
                    default: break;
                }
            }
        }
        public static void ChangeConsoleView()
        {
            Console.Clear();

            while (true)
            {
                Console.WriteLine(
@"Выберете необходимое действие:
    1 – Изменить цвет фона
    2 – Изменить цвет текста
    0 - Выход в главное меню");
                switch (Console.ReadKey(true).KeyChar)
                {
                    case '1':
                        ChangeBackgroundColor();
                        break;
                    case '2':
                        ChangeForegroundColor();
                        break;
                    case '0':
                        Console.Clear();
                        return;
                    default: break;
                }
            }
        }
        public static void ChangeBackgroundColor()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine(
@"Выберете необходимое действие:
    1 – Изменить цвет фона на белый
    2 – Изменить цвет фона на темно-синий
    3 – Изменить цвет фона на темно-зеленый
    4 – Изменить цвет фона на темно-красный
    5 – Изменить цвет фона на черный
    0 - Выход в предыдущее меню");
                switch (Console.ReadKey(true).KeyChar)
                {
                    case '1':
                        Console.BackgroundColor = ConsoleColor.White;
                        break;
                    case '2':
                        Console.BackgroundColor = ConsoleColor.DarkBlue;
                        break;
                    case '3':
                        Console.BackgroundColor = ConsoleColor.DarkGreen;
                        break;
                    case '4':
                        Console.BackgroundColor = ConsoleColor.DarkRed;
                        break;
                    case '5':
                        Console.BackgroundColor = ConsoleColor.Black;
                        break;
                    case '0':
                        Console.Clear();
                        return;
                    default: break;
                }
            }
        }
        public static void ChangeForegroundColor()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine(
    @"Выберете необходимое действие:
    1 – Изменить цвет шрифта на белый
    2 – Изменить цвет шрифта на темно-синий
    3 – Изменить цвет шрифта на темно-зеленый
    4 – Изменить цвет шрифта на темно-красный
    5 – Изменить цвет шрифта на черный
    0 - Выход в предыдущее меню");
                switch (Console.ReadKey(true).KeyChar)
                {
                    case '1':
                        Console.ForegroundColor = ConsoleColor.White;
                        break;
                    case '2':
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        break;
                    case '3':
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        break;
                    case '4':
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        break;
                    case '5':
                        Console.ForegroundColor = ConsoleColor.Black;
                        break;
                    case '0':
                        Console.Clear();
                        return;
                    default: break;
                }
            }
        }
    } 
    struct MyStruct
    {
        //public void PamParam(int n, int s, int k, int l, int f, int g, int w, int q, int i, int p, int t, int o, int z, int y, int x, int a, int b, int c, int d) { }
    }
    class MyClass
    {
        //public void MyLongestMethodInOurGorgeousWorldHeyIWantToBeatThisLongestMethodChallengeIBelieveICan() { }
    }
}
