//using System;

//namespace ConsoleApp5
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {


//            Console.WriteLine("������� �������� 1 ���  2");

//            string number = Console.ReadLine();

//            switch (number)
//            {
//                case "1":
//                    {
//                        Console.WriteLine("����");
//                        break;
//                    }
//                case "2":
//                    {
//                        Console.WriteLine("���");
//                        break;
//                    }
//                case "3":
//                    {
//                        Console.WriteLine("�����, ��� ��?");
//                        break;
//                    }

//                default:
//                    {
//                        Console.WriteLine("�� ����� �������� �������� �� 1 � 2.");
//                        break;
//                    }
				

//            }
//        }
//    }
//}



//namespace HomeWork1

//{
//    class Program
//    {
//        static void Main(int a, int b);

//		if (a % 2 == 0) 
//			{
			
//			int resalt = a * b;
//        Console.WriteLine(result)
//			}

//			else {
//			int resaltOfSumm = a + b;

//    Console.WriteLine( "��������� ���������:" resultOfSumm);
//			}


//string sentence = "����� ����� ������ ����� � �� ���������� � ���������";
//console.writeline(sentence);
//            int wordlength = 0;
//wordlength = convert.toint32(console.readline());
//            while (true)
//            {
//                console.writeline("enter word length: ");
//                try
//                {
//                    wordlength = convert.toint32(console.readline());
//                    break;
//                }
//                catch (exception)
//                {
//                    console.writeline("not a number");
//                }
//            }

//            string[] words = sentence.split(" ");

//            for (int i = 0; i <= words.length - 1; i++)
//            {
//                if (words[i].length == wordlength && wordlength >= 3)
//                {
//                    words[i] = words[i].substring(0, words[i].length - 3) + "$$$";
//                }
//            }
//            console.writeline(string.join(" ", words));
//}
//}