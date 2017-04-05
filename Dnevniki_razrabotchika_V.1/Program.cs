using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Dnevniki_razrabotchika_V._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Metods.face();
            Console.Clear();
            Console.WriteLine("Повтори часть кода:");
            Metods.MetodUsingSystem();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\t\t\t\t\tTHE END");
            Console.ReadLine();
        }
    }

    class Metods
    {
        public static void face()
        {
            Console.Write("Введите имя: ");
            string _UName = Console.ReadLine();
            Console.WriteLine("Привет {0}", _UName);
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Это была программа, которая выводит на экран всего 2 сторочки. Ее робота \nвыглядит так:");
            Console.WriteLine("1. В консоли выводится текст\"Введите имя:\"");
            Console.ReadLine();
            Console.WriteLine("2. В той же строке консоли, осуществляется ввод неоприделенного числа символов");
            Console.ReadLine();
            Console.WriteLine("3. На следующей строке консоли выводится текст \"Привет\", и к нему прибавляется  введеная ранее строка");
            Console.ReadLine();
            Console.WriteLine("Все это происходит следующим образом:");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Повторите часть кода:");
        }
        public static void MetodUsingSystem()
        {           
             ConsoleColor standart = Console.ForegroundColor;
               ConsoleColor blue = ConsoleColor.Blue;
            ConsoleColor green = ConsoleColor.Green;
            ConsoleColor yellow = ConsoleColor.Yellow;
               Console.ForegroundColor = blue;
             string _message1;

                  Console.WriteLine("using System;");                    
                  Console.ForegroundColor = green;  
                  pravilniyVvod("using System;", standart);
                  _message1 = tabl1_txt();
                  Wind1(_message1);
                                                                                    //          using System;
                  Console.Clear();
                  Console.ForegroundColor = yellow;
                  Console.WriteLine("using System;");

                  Console.ForegroundColor = standart;
                  Console.WriteLine("Теперь введи:");                    

                                                                                 /////////////////////////////////////////

                  Console.ForegroundColor = blue;                       
                  Console.WriteLine("namespace Program1 {");
                  Console.ForegroundColor = green;  
                  pravilniyVvod("namespace Program1 {", standart);
                  _message1 = tabl2_txt();            
                  Wind1(_message1);
                                                                                 //          namespace Program1 {
                  Console.Clear();
                  Console.ForegroundColor = yellow;
                  Console.WriteLine("using System;");
                  Console.WriteLine("namespace Program1\n{");               
      
                                                                                 /////////////////////////////////////////////
                  Console.ForegroundColor = blue;
                  Console.WriteLine("   class ClassName {");
                  Console.ForegroundColor = green;  
                  Console.Write("   ");
                  pravilniyVvod("class ClassName {", standart, 1);               //           class ClassName {
                  _message1 = tabl3_txt();
                  Wind1(_message1);

                  Console.Clear();
                  Console.ForegroundColor = yellow;
                  Console.WriteLine("using System;\n");
                  Console.WriteLine("namespace Program1\n{");
                  Console.WriteLine("   class NameClass\n   {");
                                                                                 ///////////////////////////////////////////////
                  Console.ForegroundColor = blue;
                  Console.WriteLine("      static void Main() {");
                  Console.ForegroundColor = green;
                  Console.Write("      ");
                  pravilniyVvod("static void Main() {", standart,2);
                  _message1 = tabl4_txt(0);                                        //          static void Main() {
                  Wind1(_message1);

                  Console.Clear();
                  Console.ForegroundColor = yellow;
                  Console.WriteLine("using System;\n");
                  Console.WriteLine("namespace Program1\n{");
                  Console.WriteLine("   class NameClass\n   {");
                  Console.WriteLine("      static void Main()\n      {");
                  Console.ReadLine();
                  Console.ForegroundColor = ConsoleColor.Red;
                  Console.WriteLine("Разсмотрим эту строку более детально");
                  Console.ReadLine(); 
                  Console.Clear();
                                                                                 ////////////////////////////////////////////    
                  Console.ForegroundColor = ConsoleColor.Red;
                  Console.Write("\t\t\t\tstatic ");
                  Console.ForegroundColor = standart;
                  Console.WriteLine("void Main() {");
                  Console.ForegroundColor = blue;
                  Console.WriteLine("static");
                  Console.ForegroundColor = green;
                  pravilniyVvod("static", standart);                              //                 static
                  _message1 = tabl4_txt(1);
                  Wind1(_message1);
                  _message1 = tabl4_txt(2);
                  Wind1(_message1);
                  Console.Clear();                                                ////////////////////////////////////////////

                  Console.ForegroundColor = standart;
                  Console.Write("\t\t\t\tstatic ");
                  Console.ForegroundColor = ConsoleColor.Red;
                  Console.Write("void ");
                  Console.ForegroundColor = standart;
                  Console.WriteLine("Main() {");
                  Console.ForegroundColor = blue;                                    //              void
                  Console.WriteLine("void");
                  Console.ForegroundColor = green;
                  pravilniyVvod("void", standart);
                  _message1 = tabl4_txt(3);
                  Wind1(_message1);
                  Console.Clear();                                                //////////////////////////////////////////////

                  Console.ForegroundColor = standart;
                  Console.Write("\t\t\t\tstatic void ");
                  Console.ForegroundColor = ConsoleColor.Red;
                  Console.WriteLine("Main() {");
                  Console.ForegroundColor = blue;                                   //              Main() {
                  Console.WriteLine("Main() {");
                  Console.ForegroundColor = green;
                  pravilniyVvod("Main() {", standart);
                  _message1 = tabl4_txt(4);
                  Wind1(_message1);
                  Console.Clear();                                                ///////////////////////////////////////////
             
       
             Console.ForegroundColor = standart;
            Console.WriteLine("Весь код рассматриваемой программы выглядит следующим образом:\n");
            Console.ForegroundColor = yellow;
            Console.WriteLine("using System;\n");
            Console.WriteLine("namespace Program1\n{");
            Console.WriteLine("   class NameClass\n   {");
            Console.WriteLine("      static void Main()\n      {");
            Console.WriteLine("         Console.Write(\"Введите имя: \");");
            Console.WriteLine("         string _UName = Console.ReadLine();");
            Console.WriteLine("         Console.WriteLine(\"Привет {0}\", _UName);");
            Console.WriteLine("         Console.ReadLine();");
            Console.WriteLine("      }\n   }\n}");
            Console.ForegroundColor = standart;
            Console.WriteLine("Обрати внимание на строки находящиеся в теле метода Main()");
            Console.ReadLine();
            Console.Clear();

            Console.ForegroundColor = yellow;
            Console.WriteLine("using System;\n");
            Console.WriteLine("namespace Program1\n{");
            Console.WriteLine("   class NameClass\n   {");
            Console.WriteLine("      static void Main()\n      {");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("         Console.Write(\"Введите имя: \");");
            Console.ForegroundColor = yellow;
            Console.WriteLine("         string _UName = Console.ReadLine();");
            Console.WriteLine("         Console.WriteLine(\"Привет {0}\", _UName);");
            Console.WriteLine("         Console.ReadLine();");
            Console.WriteLine("      }\n   }\n}");
            Console.ReadLine();
            _message1 = tabl5_txt(0);
            Wind1(_message1);
            Console.Clear();

            Console.ForegroundColor = yellow;
            Console.WriteLine("using System;\n");
            Console.WriteLine("namespace Program1\n{");
            Console.WriteLine("   class NameClass\n   {");
            Console.WriteLine("      static void Main()\n      {");
            Console.WriteLine("         Console.Write(\"Введите имя: \");");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("         string _UName = Console.ReadLine();");
            Console.ForegroundColor = yellow;
            Console.WriteLine("         Console.WriteLine(\"Привет {0}\", _UName);");
            Console.WriteLine("         Console.ReadLine();");
            Console.WriteLine("      }\n   }\n}");
            Console.ReadLine();
            _message1 = tabl5_txt(1);
            Wind1(_message1);
            Console.Clear();

            Console.ForegroundColor = yellow;
            Console.WriteLine("using System;\n");
            Console.WriteLine("namespace Program1\n{");
            Console.WriteLine("   class NameClass\n   {");
            Console.WriteLine("      static void Main()\n      {");
            Console.WriteLine("         Console.Write(\"Введите имя: \");");
            Console.WriteLine("         string _UName = Console.ReadLine();");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("         Console.WriteLine(\"Привет {0}\", _UName);");
            Console.ForegroundColor = yellow;
            Console.WriteLine("         Console.ReadLine();");
            Console.WriteLine("      }\n   }\n}");
            Console.ReadLine();
            _message1 = tabl5_txt(2);
            Wind1(_message1);
            Console.Clear();

            Console.ForegroundColor = yellow;
            Console.WriteLine("using System;\n");
            Console.WriteLine("namespace Program1\n{");
            Console.WriteLine("   class NameClass\n   {");
            Console.WriteLine("      static void Main()\n      {");
            Console.WriteLine("         Console.Write(\"Введите имя: \");");
            Console.WriteLine("         string _UName = Console.ReadLine();");
            Console.WriteLine("         Console.WriteLine(\"Привет {0}\", _UName);");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("         Console.ReadLine();");
            Console.ForegroundColor = yellow;
            Console.WriteLine("      }\n   }\n}");
            Console.ReadLine();
            _message1 = tabl5_txt(3);
            Wind1(_message1);
            

            Console.ReadLine();
            Console.Clear();

        }
        static void pravilniyVvod(string strokkka, ConsoleColor standart, int c_tab = 0 )
        {
            string tab;
            switch (c_tab){                
                case 1:
                    tab = "   ";
                    break;
                case 2:
                    tab = "      ";
                    break;
                case 3:
                    tab = "         ";
                    break;
                case 4:
                    tab = "            ";
                    break;
                default:
                    tab = "";
                    break;
            }
            string _poftorStroki;
            _poftorStroki = Console.ReadLine();
            while (_poftorStroki != strokkka)
            {
                Console.ForegroundColor = standart;
                Console.WriteLine("Повтори часть кода:");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("{0}{1}", tab, strokkka);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("{0}",tab);
                _poftorStroki = Console.ReadLine();
            }
        }
        static string tabl1_txt()
        {
            string _t1 = "using System;     - обясняет прогаме, что некоторые команды будут исользоватся из пространства имен System\n\n";
            _t1 += "Простанство имен - это как отдел в городской библиотеке. ";
            _t1 += "Там есть отдел \"Детективы\", есть \"Романы\", \"Научная фантастика\", \"Приключения\", \"Детская литература\", и т.д.";
            _t1 += " Не мудрено догадатся, на какой полке ты будеш искать \"Шерлок Холмса\".\n   В пространстве имен \"Детективы\", есть книга \"Шерлок Холмс\"\n\n\tДетективы.Шерлок Холмс\n\n";
            _t1 += "  В C#, в пространствах имен находятся не книги, а класы. Например в пространстве имен \"System\", есть клас \"Console\", а в нем метод\"WriteLine()\"\n\n\tSystem.Console.WriteLine();\n\n";

            _t1 += "Окончание инструкции/выражения обозначается символом\";\"";
            return _t1;
        }
        static string tabl2_txt()
        {
            string _t2 = "namespace Program1\n\n\n";
            _t2 += "Создается пространство имен с именем \"Program1\". А фигурная скобка \"{\" открывает, так званное, тело пространства имен. ";
            _t2 += "В этой области находятся все, подконтрольные этому пространству имен, класы\n";
            _t2 += "\n_________________________________________________________________________\n";
            _t2 += "using System;\n\nnamespace Program1\n{\n   Клас 1 Постранства имен \"Program1\"\n   Клас 2 Постранства имен \"Program1\"\n   Клас 3 Постранства имен \"Program1\"\n}";
            _t2 += "\n_________________________________________________________________________\n";
            return _t2;
        }
        static string tabl3_txt()
        {
            string _t3 = "class ClassName\n\n";
            _t3 += "В теле  Program1 создается клас ClassName\n\n\n";
            _t3 += "______________________________________________________________________________________\n";
            _t3 += "Клас являет собой некий чертеж, план или инструкцию. Например, я сижу на кухне(класс Я_На_Кухне), какие у меня возможные действия?";
            _t3 += "\n1 Заварить себе чай\n2 Сделать бутерброд\n3 Открыть холодильник и молча смотреть в него\n4 Пожарить яичницу\n5 доесть вчерашний борщ\n";
            _t3 += "Все эти 5 пунктов - это методы класа Я_На_Кухне. И если мне понадобится использовать метод ЗаваритьЧай(), необходимо будет обретится к нему с помощю этого класса:\n\n";
            _t3 += "Я_На_Кухне.ЗаваритьЧай()\n";
            _t3 += "______________________________________________________________________________________\n\n\n";
            _t3 += "Слово \"class\" служит для того, чтоб обяснить компютеру, что ты создал новый клас. ";
            _t3 += "А ClassName является именем этого класа.\n\n";
            _t3 += "using System;\n\nnamespace Program1\n{\n\tclass ClassName\n\t{\n\t\tТело класа \"ClassName\"\n\t}\n}";
            return _t3;
        }
        static string tabl4_txt(int a)
        {
            string _t4 = " ";
            switch (a)
            {
                case 0:
                    _t4 = "Строка \"static void Main() {\"обявляет об открытии нового метода с именем \"Main\".\n ";
                    _t4 += "Как упоминалось ранее, клас, словно пазл, может состоять из множества частей";
                    _t4 += "В языке C# они називаются методами. Метод - ето часть кода которая которая в основном виполняет одну оприделенную задачу.";
                    _t4 += "К тому же, методы позволяют существенно сократить размер кода";
                    _t4 += "Давайте представим метод на примере приготовления чая.";
                    _t4 += "\n_________________________________________________________________________";
                    _t4 += "\nstatic void ЗаваркаЧая() \n{\n\t1.Взять чашку\n\t2.Засыпать заварку\n\t3.Положыть сахар\n\t4Залить кипятком\n}";
                    _t4 += "\n_________________________________________________________________________\n";
                    _t4 += "И  при необходимости заварить чашку чая, не нужно больше описывать весь процес, достаточно вызвать метод \"Заварка чая();\" ";
                    break;
                case 1:
                    _t4 = "static\t - Метод может быть статическим (как в данном случае) и нестатическим(простым). ";
                    _t4 += "Простой метод имеет доступ к данным объекта. ";
                    _t4 += "К примеру. В качестве объекта, возьмем телевизор. у него есть два состояния: \"Включен\" и \"Выключен\".";
                    _t4 += "\n_________________________________________________________________________\n";
                    _t4 += "class TV\n{\n   bool switched;\n   public void TVon()\n   {\n      switched = true;\n   }\n   public void TVoff()\n   {\n      switched = false;\n   }\n} ";
                    _t4 += "\n_________________________________________________________________________\n";
                    _t4 += "\"class TV\" - это наш объект \"телевизор\". В теле класа, переменная типа bool, с именем switched (переменные типа bool могут принимать лишь 2 значения true - правда и false - ложь). ";
                    _t4 += "Методы TVon и TVoff присваивают переменной switched значение true и false соответственно.  ";
                    _t4 += "\n чтобы использовать объект \"class TV\" Создается его копия , и все последующие изминения происходят с этой копиеей. ";
                    _t4 += "Таким образом, чтоб вызвать не статический метод, необходимо указать объект в котором он находится.";
                    _t4 += "\n_________________________________________________________________________\n";
                    _t4 += "class Program\n{\n   static void Main()\n   {\n      TV myTv = new TV();            //Создание новой копии объекта TV. \n\t\t\t//Копии дается имя myTv\n      myTv.TVon();\n   }\n}";
                    _t4 += "\n_________________________________________________________________________\n";
                    break;
                case 2:
                    _t4 = "Статический метод, чаще всего, используется независимо от других членов класа, но при необходимости ему можно передать данные.";
                    _t4 += " Абстрактный приер такого метода уже приводился на примере приготовления чая:\n";
                    _t4 += "\n_________________________________________________________________________";
                    _t4 += "\nstatic void ЗаваркаЧая() \n{\n\t1.Взять чашку\n\t2.Засыпать заварку";
                    _t4 += "\n\t3.Положыть сахар\n\t4Залить кипятком\n}";
                    _t4 += "\n_________________________________________________________________________\n";
                    _t4 += "\n\nСтатический метод вызывается без создания экземпляра(копии) объекта, и поетому не может оперировать обектами.  Такой метод визивается по его имени. \n";
                    _t4 += "\n_________________________________________________________________________\n";
                    _t4 += "class Program\n{\n   static void Main()\n   {\n     ЗаваркаЧая();\n   }\n}";
                    _t4 += "\n_________________________________________________________________________";
                    break;
                case 3:
                    _t4 = "\t\t\tvoid\n\n   Метод может возвращать, а может не возвращать значение. Ключевое слово \"Void\" означает, что метод не возвращяет значение. ";
                    _t4 += "Если метод не возвращяет значение, значит он скорее всего исполняет оприделенную команду. ";
                    _t4 += "Вспоминаем наш теоретический метод заварки чая. Он не возвращяет никаких значений, он заваривает чай, тоесть исполняет инструкцию. \n";
                    _t4 += "  Но давй посмотрим на метод, который бы возвращял значение. Пускай возвращямым значением будет температура чая. ";
                    _t4 += "Температуру будем определять как целое число(без дробной части), а значит, тип возвращаемого значения будет \"int\" ";
                    _t4 += "\n_________________________________________________________________________\n";
                    _t4 += "static int Temperatura()\n{\n   int t;\t\t\t\t// создаем переменную t\n";
                    _t4 += "   1 засовываем термометер в чай\n   2 видим цыфру на термометре\n   t = цифра на термометре";
                    _t4 += "\t\t//присваиваем переменной t \n";
                    _t4 += "\t\t\t\t//показания термометра\n   return t;\n}";
                    _t4 += "\n_________________________________________________________________________\n";
                    _t4 += "  Обрати внимание на ключевое слово return. Именно эта комада, дает понять програме, какое значение будет возвращено методу из его тела\n";

                    break;
                case 4:
                    _t4 = "\t\t\tMain()\n\n    Main - имя метода. При создании нового метода, ты можеш назвать его каким угодно словом";
                    _t4 += " (кроме тех слов, что являются ключевыми в C#, и уже занятые для выполнения других действий).";
                    _t4 += " Метод Main() служит началом выполнения всех приложений на C#.";


                    _t4 += " Круглые скобки\"()\" служат для передачи значений методу. Если они пустые, значит методу не передается никакой информации из внешней части кода. \n   ";
                    _t4 += "Изменим наш метод ЗаваркаЧая(), так чтобы он принимал целочислиное значение(int). Для примера, присвоим это значение сахару:";
                    _t4 += "\n_________________________________________________________________________";
                    _t4 += "\nstatic void ЗаваркаЧая(int sahar) \n{\n\t1.Взять чашку\n\t2.Засыпать заварку\n\t3.Положыть сахар\n";
                    _t4 += "\tКоличество ложек = sahar;\n\t4Залить кипятком\n}";
                    _t4 += "\n_________________________________________________________________________\n\n";
                    _t4 += "   Обрати внимание на то, как метод получает переменную sahar.";
                    _t4 += "   Теперь, с помощю этого метода можно приготовить несколько чашек чая, с разным количеством сахара. Например, один чай без сахара, второй с двумя:";
                    _t4 += "\n\n_________________________________________________________________________";
                    _t4 += "\nstatic void Main()\n{\n   ЗаваркаЧая(0);\n   ЗаваркаЧая(2);\n}";
                    _t4 += "\n_________________________________________________________________________\n";

                    break;
            }
            return _t4;
        }
        static string tabl5_txt(int a)
        {
            string _t5= " ";
            switch (a)
            {
                case 0:

                    _t5 += "Первая строка метода Main: \n\nConsole.Write(\"Введите имя: \";\n\n";
                    _t5 += "Console - это стандартный для языка C# клас. В нем содержится много методов, одним из которых является метод Write(). ";
                    _t5 += "Метод Write() служит для вывода, переданого ему значения, на экран (если передается не переменная, а текст, его необходимо вводить";
                    _t5 += "между скобками (\"\"). И как говорилось ранее, конец строки кода обозначается символом (;)\n\n";
                    break;
                case 1:
                    _t5 += "Вторая строка: \n\nstring _UName = Console.ReadLine();\n\n";
                    _t5 += "string _UName - это обявление переменной строкового типа (другое название переменной: поле). Что такое переменная? Вообрази себе картонный ящик. Теперь давай наполним его чем нибудь, ";
                    _t5 += "Апельсинами! Допустим положили в коробку 4 апельсина. У нас получилась переменная целочисленого типа (int), О ней уже упоминали ранее. ";
                    _t5 += "Коробка - это выделеное в памяти компютера место. апельсины - ето иммя переменной, а ее значение = 4. Обявление такой переменной выглядило бы так: (int апельсины = 4;)\n";
                    _t5 += "Для вывода на экран текста, необходимо использовать переменную строкового типа(текстового типа) string.";
                    _t5 += " Имя переменной (_UName) должно отображать ее смысл. Для того чтобы дать имя переменной, можно использовать все буквы верхнего и нижнего регистра, ";
                    _t5 += "цыфры и символ\"_\", с одной оговоркой: нельзя ставить цыфру в начале имени.\nВ этой же строке переменной _UName";
                    _t5 += "символом \"=\" (Важно, символ \"=\" это не равно, это присваивание!) присваиваем значение введенной в консоли строки.";
                    _t5 += "Console.ReadLine(); - в класе Console также присутствует метод ReadLine(). Его задача считывать набор символов(строку) введенную пользывателем.\n";
                    _t5 += "Теперь понятна строка кода:\nstring _UName = Console.ReadLine();\nВ памяти компютера отводится место для текста. Этому месту в памяти дается имя _UName, ";
                    _t5 += "и отведенная память заплняется текстом, которй пользователь введет в окне консоли. И заканчиваем строкусимволом\";\"\n\n";
                    break;
                case 2:
                    _t5 += "Третья строка кода\n\nConsole.WriteLine(\"Привет {0}\",_UName);\n\n";
                    _t5 += "Метод WriteLine() означает практически тоже, что и метод Write(),но кроми етого, после вывода текста на экран, он переносит каретку на новую строку";
                    _t5 += "(Каретка - это та маленькая мигающая штучка, которая обозначает местоположение вводимого текста).";
                    _t5 += "Здесь методу WriteLine() передается текст \"Привет\" и значение переменной _UName.";
                    _t5 += "в круглых скобках обозначен порядковый номер используемых при передаче переменных(В програмировании, отсчет наченается с нуля, а не с еденицы).";
                    _t5 += "Так например такая последовательность\n\nstring a = \"один\";\nstring b = \"два\";\nstring c = \"три\";\nConsole.WriteLine(\"{2} {0} {1}\",a,b,c)\");\n\n";
                    _t5 += "Дает такой результат:\n\nтри один два";
                    break;
                case 3:
                    _t5 += "Четвертая строка кода:\n\nConsole.ReadLine();\n\nМетод Console.ReadLine() уже встречался двумя строками выше. ";
                     _t5 += "Здесь же он служит в качестве такого себе \"Стоп-сигнала\". Програма, дойдя до четвертой строки, ожидает ввода от пользователя. ";
                     _t5 += "Эсли бы этот метод отсутствовал, после ввода пользователем имени, програма бы выполнила третью строку, ";
                     _t5 += "и сразу закрила свое окно";
                     break;
            }
            return _t5;
        }
        static void Wind1(string txt)
        {
            System.Windows.MessageBox.Show(txt);
        }
    }
}
