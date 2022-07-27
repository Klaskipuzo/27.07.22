using System.Text;


namespace dz_dairy
{
    internal class Programm
    {
        static void Main(string[] args)
        {
            //1.
            Console.WriteLine("Введите слово");
            var userEnterText = Console.ReadLine();
            Console.WriteLine("А теперь введите символ для нахождения доли в %");
            var userEnterSymbol = Console.ReadLine();
            var total = 0;
            for (int i = 0; i < userEnterText.Length; i++)
            {
                if (userEnterSymbol.Contains(userEnterText[i]))
                {
                    total++;


                }

            }
            float percentageShare = 100 / userEnterText.Length * total;
            Console.WriteLine($"Доля в процентах : {percentageShare}%");


            //2

            var numberOfWords = userEnterText.Split(' ').Length; // количество слов
            Console.WriteLine($"Количество слов {numberOfWords}");
            //3





















        }
        /// <summary>
        /// Составить программу, которая:
        ///а) запрашивает имя человека и повторяет его на экране;
        ///б) запрашивает имя человека и повторяет его на экране с приветствием.
        /// </summary>
        static void T1_1()
        {
            string text = Console.ReadLine();
            Console.WriteLine(text);
            var text1 = Console.ReadLine();
            Console.WriteLine($"Hi! {text1}");
        }
        /// <summary>
        /// Составить программу, которая запрашивает название футбольной команды и повторяет его на экране со словами 
        /// «— это чемпион!».
        /// </summary>
        static void T1_2()
        {
            Console.WriteLine("Введите любое название футбольной команды");
            var text = Console.ReadLine();
            Console.WriteLine($"Это чемпион {text}");
        }
        /// <summary>
        /// Составить программу, которая запрашивает отдельно имя и отдельно фамилию,
        /// а затем выводит их как одну символьную строку.
        /// </summary>
        static void T1_3()
        {
            Console.WriteLine("Введите ваше имя");
            Console.WriteLine("Введите вашу фамилию");
            var name = Console.ReadLine();
            var LastName = Console.ReadLine();
            Console.WriteLine($"Ваше имя {name}\nВаша фамилия {LastName}");
        }
        /// <summary>
        /// Составить программу, которая запрашивает название государства и его столицы,
        /// а затем выводит сообщение: «Столица государства … — город …»
        /// (на месте многоточий должны быть выведены соответствующие значения).
        /// </summary>
        static void T1_4()
        {
            Console.WriteLine("Введите название государства и его столицы");
            Console.WriteLine("Название государства ?");
            var state = Console.ReadLine();
            Console.WriteLine("А теперь название столицы");
            var capital = Console.ReadLine();
            Console.WriteLine($"Столица государства {state} — город {capital}");
        }
        /// <summary>
        /// Составить программу, которая запрашивает название романа и фамилию его автора,
        /// а затем выводит сообщение: «Писатель … — автор романа …»
        /// (на месте многоточий должны быть выведены соответствующие значения).
        /// </summary>
        static void T1_5()
        {
            Console.WriteLine("Введите название романа и фамилию его автора");
            Console.WriteLine("Название романа ?");
            var name = Console.ReadLine();
            Console.WriteLine("А теперь фамилию его автора");
            var novel = Console.ReadLine();
            Console.WriteLine($"Писатель {name} — автор романа {novel}");
        }
        /// <summary>
        /// Даны названия двух стран. Присвоить эти названия переменным величинам s1 и s2,
        /// после чего название s2 присвоить величине t1, название s1 — величине t2.
        /// </summary>
        static void T1_6()
        {
            var country1 = "Russia";
            var country2 = "Canada";
            var s1 = country1;
            var s2 = country2;
            Console.WriteLine($"t1 = {s1}  t2 = {s2}");
        }
        /// <summary>
        /// Дано название футбольного клуба. Определить количество символов в нем.
        /// </summary>
        static void T1_7()
        {
            var nameClub = "CHELSEA";
            var len = nameClub.Length;

            Console.WriteLine(len);
        }
        /// <summary>
        /// Дано название города. Определить, четно или нет количество символов в нем.
        /// </summary>
        static void T1_8()
        {
            Console.WriteLine("Напишите название города");
            var cityName = Console.ReadLine();
            var cityNameLenght = cityName.Length;
            if (cityNameLenght % 2 == 0)
            {
                Console.WriteLine("В названии города четное количество символов");
            }
            else
            {
                Console.WriteLine("В названии города нечетное количество символов");
            }


        }
        /// <summary>
        /// Даны две фамилии. Определить, какая из них длиннее.
        /// </summary>
        static void T1_9()
        {
            Console.WriteLine("Напишите первую фамилию");
            var LastName1 = Console.ReadLine();
            Console.WriteLine("Напишите вторую фамилию");
            var LastName2 = Console.ReadLine();
            var LastN = LastName1.Length;
            var LastN1 = LastName2.Length;
            if (LastN > LastN1)
            {
                Console.WriteLine("Первая фамилия имеет больше символов чем вторая");
            }
            else if (LastN < LastN1)
            {
                Console.WriteLine("Вторая фамилия имеет больше символов чем первая");
            }
            else if (LastN == LastN1)
            {
                Console.WriteLine("Количество символов в двух фамилия одинаково");
            }

        }
        /// <summary>
        /// Т2.1. Дано слово. Вывести на экран его третий символ.
        /// </summary>
        static void T2_1()
        {
            var text = "Свистоплчскин";
            Console.WriteLine(text[2]);
        }
        /// <summary>
        /// 1. Из слова информатика путем «вырезок» и «склеек» получить слова "форма" и "тик".
        /// </summary>
        static void dz1_1()
        {
            var text = "Информатика";
            Console.WriteLine($"{text[2]}{text[3]}{text[4]}{text[5]}{text[6]}");
            Console.WriteLine($"{text[7]}{text[8]}{text[9]}");
        }
        /// <summary>
        /// 2. Из слова "вирус" путем замены его букв получить слово "фокус".
        /// </summary>
        static void dz1_2()
        {
            var text = "вирус";
            StringBuilder text1 = new StringBuilder(text);
            text1[0] = 'ф';
            text1[1] = 'о';
            text1[2] = 'к';
            text1[3] = 'у';
            text1[4] = 'с';
            Console.WriteLine(text1);
        }
        /// <summary>
        /// 3. Дано ошибочно написанное слово "рпроцессо". Путем перемещения его букв получить слово "процессор".
        /// </summary>
        static void dz1_3()
        {
            var text = "рпроцессо";
            var v = text.Split(' ');
            foreach (var c in v)
                Console.WriteLine(c.PadRight(c.Length + 1, c[0]).Remove(0, 1));
        }
        /// <summary>
        /// 4. Программа, запрашивает название государства и его столицы, а затем выводит сообщение:
        /// «Столица государства … — город …» (nна месте многоточий должны быть выведены соответствующие значения).
        /// Реализовать 2мя способами: через string.Format и интерполяцию.
        /// </summary>
        static void dz1_4()
        {
            Console.WriteLine("Введите название государства и его столицы");
            Console.WriteLine("Название государства ?");
            var state = Console.ReadLine();
            Console.WriteLine("А теперь название столицы");
            var capital = Console.ReadLine();


            var country = string.Format("Столица государства {0} — город {1}", state, capital);

            Console.WriteLine(country);
        }
        /// <summary>
        /// 5. Пользователь вводит слово
        ///- вывести слово наоборот("abc" -> "cba")
        ///- вывести на экран его X-й символ
        /// - определить, одинаковы ли X-й и Y-й символы в нем
        /// - вывести на экран буквосочетание, состоящее из его X-й и Y-й символов
        /// - поменять местами буквы номера которых вычисляются как степень X.
        /// Пример: если пользователь ввел 2, то номерами символов будут: 1, 2, 4, 8...
        /// - определить, сколько различных букв в слове
        /// - определить, сколько одинаковых соседних букв
        /// Без использования оператора цикла и с использованием(2 версии метода) :
        ///  - вывести на экран его первую половину
        ///  - поменять местами его половины
        /// - переставить первые Х и последние Х буквы, сохранив порядок их следования
        ///  - проверить, является ли оно «перевертышем» 
        ///  (перевертышем называется слово, читаемое одинаково как с начала, так и с конца)
        /// </summary>
        static void dz1_5()
        {
            //1
            Console.WriteLine("Введите текст");
            var userText = Console.ReadLine();
            char[] textArray = userText.ToCharArray();

            Array.Reverse(textArray);

            Console.WriteLine(textArray);
            //2
            Console.WriteLine("Выведите на экран Х символ");
            var indexSymbolOfUser = int.Parse(Console.ReadLine());
            Console.WriteLine($"Символ Х равен: {textArray[indexSymbolOfUser]}");
            //3
            Console.WriteLine("Ввыведите на экран его Y символ");
            var secondIndexSymbolOfUser = int.Parse(Console.ReadLine());
            Console.WriteLine($"Символ Y равен: {textArray[secondIndexSymbolOfUser]}");
            Console.WriteLine("Теперь произойдет сравнение двух символов");
            var сomparisonSymbols = indexSymbolOfUser.Equals(secondIndexSymbolOfUser);
            if (indexSymbolOfUser == secondIndexSymbolOfUser || indexSymbolOfUser != secondIndexSymbolOfUser)
            {
                Console.WriteLine($"сравнение двух символов: {(сomparisonSymbols == true ? "одинаковы" : "разные")}");
            }
            //4
            Console.WriteLine("Выводим на экран буквосочетание заданных индексов");
            Console.WriteLine($"Буквосочетание индексов :{textArray[indexSymbolOfUser]}{textArray[secondIndexSymbolOfUser]}");
            //5
            Console.WriteLine("Определяем сколько различных символов в тексте");
            var distinct = textArray.Distinct();
            foreach (char c in distinct)
                Console.Write(c);
            Console.WriteLine("\n Различных букв в слове - {0}", distinct.Count());
            //6
            Console.WriteLine("определить, сколько одинаковых соседних букв");
            var dub = 0;

            for (int i = 0; i < textArray.Length - 1; i++)
                if (textArray[i] == textArray[i + 1] & char.IsLetter(textArray[i])) dub++;
            Console.WriteLine();
            Console.Write("одинаковых соседних букв {0}", dub);
            //7
            Console.WriteLine("\nВывести на экран первую половину слова");

            string firstUserEnterText = Console.ReadLine();
            var firstResultUserText = firstUserEnterText.Substring(0, firstUserEnterText.Length / 2);
            var secondResultUserText = firstUserEnterText.Substring(firstUserEnterText.Length / 2);
            Console.WriteLine(firstResultUserText);
            Console.WriteLine(secondResultUserText);
            //8
            Console.WriteLine("Поменять местами половины строки");
            //text = text.Replace(text1, text2);
            //text = text.Replace(text2, text1);
            //Console.WriteLine(text);
            Console.WriteLine($"{secondResultUserText}{firstResultUserText}");
            //9
            Console.WriteLine("Поменять первый и крайний символ в строке");
            var firstResultReplaceTextUser = secondResultUserText.First();
            Console.WriteLine($"Это первый символ - {firstResultReplaceTextUser}");
            var secondResultReplaceTextUser = secondResultUserText.Last();
            Console.WriteLine($"Это второй символ - {secondResultReplaceTextUser}");

            //firstUserEnterText.Replace(firstResultReplaceTextUser, secondResultReplaceTextUser);
            //Console.WriteLine(firstUserEnterText);


        }
        /// <summary>
        ///  Пользователь вводит предложение
        ///- определить долю(в %) букв Х в нем(запрашивается у пользователя)
        ///- число вхождений в него некоторого буквосочетания(запрашивается у пользователя)
        /// - определить количество слов в предложении
        /// - вывести текст, составленный из первых букв всех слов
        /// - определить, сколько в нем гласных букв
        /// - верно ли, что в нем есть пять идущих подряд одинаковых символов?
        /// - все его символы, стоящие на третьем, шестом, девятом и т.д.местах, заменить буквой Х
        /// (запрашивается у пользователя)
        /// -  напечатать его в обратном порядке слов, например: Мама мыла раму. -> Раму мыла мама.
        /// - составить программу, которая выводит все вхождения в предложение заданных слов
        /// </summary>
        static void dz1_6()
        {
            //1
            Console.WriteLine("Введите слово");
            var userEnterText = Console.ReadLine();
            Console.WriteLine("А теперь введите символ для нахождения доли в %");
            var userEnterSymbol = Console.ReadLine();
            var total = 0;
            for (int i = 0; i < userEnterText.Length; i++)
            {
                if (userEnterSymbol.Contains(userEnterText[i]))
                {
                    total++;


                }

            }
            float dol = 100 / userEnterText.Length * total;
            Console.WriteLine($"Доля в процентах : {dol}%");

            //2

            var numberOfWords = userEnterText.Split(' ').Length; // количество слов
            Console.WriteLine($"Количество слов {numberOfWords}");



        }


    }


}


