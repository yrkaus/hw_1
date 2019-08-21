using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;



namespace ConsoleApp1
{
    class Program
    {
        // Если а четное почитать а*б, иначе а+б
        static void PositiveInt()
        {
            int a = 5;
            int b = 3;
            if (a % b = 0)
            {
                int result = a * b;
                Console.WriteLine(result);
            }
            else
            {
                int result1 = a + b;
                Console.WriteLine("А число непарне, результат:", result1);
            }
        }
        // Определить какой чверти принадлежит точка с коорджинатами
        static void quarter(int x = 1, int y = 2)
        {
            try
            {

                if (x > 0 & y > 0)
                {
                    Console.WriteLine("точка з координатами лежить у I чверті");
                }
                if (x > 0 & y < 0)
                {
                    Console.Writeline("точка з координатами лежить у IV чверті");
                }
                if (x < 0 & y > 0)
                {
                    Console.WriteLine("точка з координатами лежить у II чверті");
                }
                if (x < 0 & y < 0)
                {
                    Console.WriteLine("точка з координатами лежить у III чверті");
                }
            }
            catch
            {
                Console.WriteLine("Значення має бути більше: 0");
            }
        }
        // Найти суммы только положительных из 3-х чисел
        static void summOfPair(int x = 1, int y = 2, int z = 8)
        {
            if (x % 2 = 0 & y % 2 = 0 & z % 2 = 0)
            {
                int result = x + y + z;
                Console.WriteLine(result);
            }
            if (x % 2 = 0 & y % 2 = 0 & z % 2 != 0)
            {
                int result = x + y;
                Console.WriteLine(result);
            }
            if (x % 2 = 0 & y % 2 != 0 & z % 2 = 0)
            {
                int result = x + z;
                Console.WriteLine(result);
            }
            if (x % 2 != 0 & y % 2 != 0 & z % 2 == 0)
            {
                int result = y + z;
                Console.WriteLine(result);
            }
        }

        // Посчитать выражение макса (a*b*c, a +b +c) +3
        static void max(int a = 1, int b = 2, int c = 8)
        {
            try
            {
                int resultOfMult = a * b * c;
                int resultOfSumm = a + b + c;

                if (resultOfMult > resultOfSumm)
                {
                    int result = resultOfMult + 3;
                }
                else
                {
                    int result = resultOfSumm + 3;
                }
            }
            catch
            {
                Console.WriteLine("Значення тотожні");
            }

        }

        // Написать программу определения оценки студента
        static void ratingStudent(int rating = a, int point = b)
        {
            int rating = a;
            int point = b;

            if (a >= 0 & a < 19)
            {
                Console.WriteLine("Оцінтка студента: F");
            }
            else if (a > 19 & a < 39)
            {
                Console.WriteLine("Оцінтка студента: E");
            }
            else if (a > 40 & a < 59)
            {
                Console.WriteLine("Оцінтка студента: D");
            }
            else if (a > 60 & a < 74)
            {
                Console.WriteLine("Оцінтка студента: C");
            }
            else if (a > 75 & a < 89)
            {
                Console.WriteLine("Оцінтка студента: B");
            }
            else if (a > 90 & a <= 100)
            {
                Console.WriteLine("Оцінтка студента: A");
            }
        }
        // Найти сумму четных чисел и их количество в диапазоне от 1 до 99

        static void summOfPositiveInt (int num)
        {
            int sum = 0;
            int val = 0;
            for (int i = 0; i <= 100; i++)
            {
                if (a % 2 = 0) ;
                {
                    sum += i;
                    val += 1;
                }
           }
            Console.WriteLine((sum));
            Console.WriteLine((val));      
        }

        // проверить простое ли число

        static void isSimpleNumber (int numnber)
        {
            if (numnber < 1) return;
            int numberOfDivision = 0;
            if (numnber >= 2 )
            {
                for (int i = 0; i <= number; i++)
                {
                    if (number % i == 0)
                    {
                        numberOfDivision++;
                    }

                }
                if (numberOfDivision > 2)
            }
          
          
        }
        // найти корень натурального числа с точностью до целого

        public static void squareOfNumber(double n)
        {
                 
            n = Math.Sqrt(n);

            Console.WriteLine("Квадратний корінь дорівнює" + n);

        }

        // вычислить сумму цифр заданного числа
        ////public static void sumOfPoint (uint n)
        ////{     
        ////    int num = 1;
        ////    int result = 0;

        ////    while (n > 0)

        ////    {
        ////        result = n % 10;
        ////        n = (n - result) / 10;
        ////        num = result

        ////    }

        ////    Console.WriteLine("Квадратний корінь дорівнює" + result);

    }

        // факториал числа
        public static void factorialOfNumber (int n)
        {
            int factorial = n;
            while (n >1 )
            {
                factorial = factorial * (n - 1);
                n = n - 1;            }

            Console.WriteLine( "факторіал числа дорівнює" + factorial);
           
        }

        // найти минимальный элемент массива
        public static void minElementOfArry (int [] arrey)
        {
            int nim = arrey[0];
            int indexOfmin = 0;
            for (int i = 0; i < arrey.Length; i++)
            {
                if (arrey [i] < nim)
                {
                    nim = arrey[i];
                    indexOfmin = i;
                }
            }
            Console.Write(nim + "індекс елементу масиву: " + indexOfmin);
        }

        // найти максимальный элемент массива
        public static void maxElementOfArry(int[] arrey)
        {
            int max = arrey[0];
            int indexOfmax = 0;
            for (int i = 0; i < arrey.Length; i++)
            {
                if (arrey[i] > max)
                {
                    max = arrey[i];
                    indexOfmax= i;
                }
            }
            Console.Write("Максимальний елемент масиву: " + max + "індекс елементу масиву: " + indexOfmax);
        }
                     
        //Получить строковое название дня недели по номеру дня.
        public static void dayOfWeek(int day)
        {
            switch (day)
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                case 6:
                    Console.WriteLine("Saturday");
                    break;
                case 7:
                    Console.WriteLine("Sunday");
                    break;

            }
        }
        public static void func21(string num)
        {
            string[] arrNum = num.Split(' ');
            long thousands = 0, millions = 0, billions = 0;
            long newNum = 0, newNum1 = 0, newNum2 = 0, newNum3 = 0;

            for (long i = 0; i < arrNum.Length; i++)
            {

                switch (arrNum[i])
                {
                    case "один": newNum += 1; break;
                    case "одна": newNum += 1; break;
                    case "два": newNum += 2; break;
                    case "две": newNum += 2; break;
                    case "три": newNum += 3; break;
                    case "четыре": newNum += 4; break;
                    case "пять": newNum += 5; break;
                    case "шесть": newNum += 6; break;
                    case "семь": newNum += 7; break;
                    case "восемь": newNum += 8; break;
                    case "девять": newNum += 9; break;
                    case "ноль": newNum += 0; break;

                    case "десять": newNum += 10; break;
                    case "одиннадцать": newNum += 11; break;
                    case "двенадцать": newNum += 12; break;
                    case "тринадцать": newNum += 13; break;
                    case "четырнадцать": newNum += 14; break;
                    case "пятнадцать": newNum += 15; break;
                    case "шестнадцать": newNum += 16; break;
                    case "семнадцать": newNum += 17; break;
                    case "восемнадцать": newNum += 18; break;
                    case "девятнадцать": newNum += 19; break;

                    case "двадцать": newNum += 20; break;
                    case "тридцать": newNum += 30; break;
                    case "сорок": newNum += 40; break;
                    case "пятьдесят": newNum += 50; break;
                    case "шестьдесят": newNum += 60; break;
                    case "семьдесят": newNum += 70; break;
                    case "восемьдесят": newNum += 80; break;
                    case "девяносто": newNum += 90; break;

                    case "сто": newNum += 100; break;
                    case "двести": newNum += 200; break;
                    case "триста": newNum += 300; break;
                    case "четыреста": newNum += 400; break;
                    case "пятьсот": newNum += 500; break;
                    case "шестьсот": newNum += 600; break;
                    case "семьсот": newNum += 700; break;
                    case "восемьсот": newNum += 800; break;
                    case "девятьсот": newNum += 900; break;

                    case "тысяча": thousands += 1000; break;
                    case "тысячи": thousands += 1000; break;
                    case "тысяч": thousands += 1000; break;

                    case "миллион": millions += 1000000; break;
                    case "миллиона": millions += 1000000; break;
                    case "миллионов": millions += 1000000; break;

                    case "миллиард": billions += 1000000000; break;
                    case "миллиарда": billions += 1000000000; break;
                    case "миллиардов": billions += 1000000000; break;
                }

                if (arrNum[i] == "миллиард" || arrNum[i] == "миллиарда" || arrNum[i] == "миллиардов")
                {
                    newNum *= billions;
                    newNum2 = newNum;
                    newNum = 0;
                }
                if (arrNum[i] == "миллион" || arrNum[i] == "миллиона" || arrNum[i] == "миллионов")
                {
                    newNum *= millions;
                    newNum1 = newNum;
                    newNum = 0;
                }
                if (arrNum[i] == "тысяча" || arrNum[i] == "тысячи" || arrNum[i] == "тысяч")
                {
                    newNum *= thousands;
                    newNum3 = newNum;
                    newNum = 0;
                }
            }
            long nums = newNum1 + newNum2 + newNum3 + newNum;
            Console.Write(nums);

        }



             //Вводим строку, которая содержит число, написанное прописью(0-999). Получить само число
      
        public static int intConvertToString (string words)
        {
            string[] wordArr = words.Split(' ');
            for (int i = 0; i < wordArr.Length; i++)
            {
                Console.Write("-" + wordArr[i] + "-");
            }
            String h = "hundred";
            String[] oneArr = { "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            String[] twoArr = { "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen" };
            String[] threeArr = { "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety" };
            if (wordArr.Length == 1)
            {
                for (int i = 0; i < oneArr.Length; i++)
                {//перша десятка
                    if (oneArr[i] == wordArr[0])
                        return i + 1;
                }

                for (int i = 0; i < twoArr.Length; i++)
                {//14
                    if (twoArr[i] == wordArr[0])
                    {
                        return i + 10;
                    }
                }
                for (int i = 0; i < threeArr.Length; i++)
                {//40
                    if (threeArr[i] == wordArr[0])
                        return (i + 2) * 10;
                }
            }
            Console.Write(!wordArr[1].Equals(h));
            Console.Write(wordArr[1].Equals(h));
            Console.Write(wordArr.Length == 2);
            if (wordArr.Length == 2 && wordArr[1].Equals(h))
            {//200
                for (int i = 0; i < oneArr.Length; i++)
                {
                    if (oneArr[i].Equals(wordArr[0]))
                    {
                        int res = (i + 1) * 100;
                        return res;
                    }
                }
            }
            if (wordArr.Length == 2 && !wordArr[1].Equals(h))
            {///22
                String first = null;
                String second = null;
                int f = 0;
                int s = 0;
                for (int i = 0; i < threeArr.Length; i++)
                {
                    if (threeArr[i].Equals(wordArr[0]))
                        f = i + 2;
                    first = f.ToString();
                }
                for (int i = 0; i < oneArr.Length; i++)
                {
                    if (oneArr[i].Equals(wordArr[1]))
                        s = i + 1;
                    second = s.ToString();
                }
                String res = first + second;
                return Convert.ToInt32(res);
            }
            if (wordArr.Length == 3)
            {
                String first = null;
                String second = null;
                int f = 0;
                int s = 0;
                for (int i = 0; i < oneArr.Length; i++)
                {
                    if (oneArr[i].Equals(wordArr[0]))
                    {
                        f = i + 1;
                        first = f.ToString();
                        for (i = 0; i < oneArr.Length; i++)
                        {//101
                            if (oneArr[i].Equals(wordArr[2]))
                            {
                                s = i + 1;
                                second = s.ToString();
                                String res = first + "0" + second;
                                return Convert.ToInt32(res);
                            }
                        }
                        for (i = 0; i < twoArr.Length; i++)
                        {//111
                            if (twoArr[i].Equals(wordArr[2]))
                            {
                                s = i + 10;
                                second = s.ToString();
                                String res = first + second;
                                return Convert.ToInt32(res);
                            }
                        }
                        for (i = 0; i < threeArr.Length; i++)
                        {//120
                            if (threeArr[i].Equals(wordArr[2]))
                            {
                                s = (i + 2) * 10;
                                second = s.ToString();
                                String res = first + second;
                                return Convert.ToInt32(res);
                            }
                        }
                    }
                }
            }
            if (wordArr.Length == 4)
            {
                String first = null;
                String second = null;
                String third = null;
                int f = 0;
                int s = 0;
                int t = 0;
                for (int i = 0; i < oneArr.Length; i++)
                {
                    if (oneArr[i].Equals(wordArr[0]))
                    {
                        f = i + 1;
                        first = f.ToString();
                    }
                }
                for (int i = 0; i < threeArr.Length; i++)
                {
                    if (threeArr[i].Equals(wordArr[2]))
                    {
                        s = i + 2;
                        second = s.ToString();
                    }
                }
                for (int i = 0; i < oneArr.Length; i++)
                {
                    if (oneArr[i].Equals(wordArr[3]))
                    {
                        t = i + 1;
                        third = t.ToString();
                        String res = first + second + third;
                        return Convert.ToInt32(res);
                    }
                }
            }
            return 0;
        }




        //4. Найти расстояние между двумя точками в двумерном декартовом пространстве.
        private static double func23(int xa, int ya, int xb, int yb)
        {
            double dist = Math.Sqrt(Math.Pow((xb - xa), 2) + Math.Pow((yb - ya), 2));
            return dist;
        }

    }
}



        //{


//    if x = 0;

//    int y = 0;

//    if (x == 0&& y==0)
//    {
//        return;
//    }
//    if (x == 0)
//    {
//        return;
//    }
//    else if (y == 0)
//    {
//        return;
//    }
//    if (x > 0 && y > 0)
//    {
//        return;
//    }
