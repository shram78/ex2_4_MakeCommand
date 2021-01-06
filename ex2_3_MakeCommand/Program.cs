using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
/*создать приложение, которое может обрабатывать команды. Т.е. вы создаете меню,
 ожидаете ввода нужной команды, после чего выполняете действие, которое присвоено этой команде.
Программа не должна завершаться после ввода, пользователь сам должен выйти из программы при помощи команды.*/
namespace ex2_4_Converter
{
    class Program
    {
        static void Main(string[] args)
        {
            int inputChoice; // выбор пункта меню
            do
            {
                Console.WriteLine("Волшебное меню. Выбери вариант\n");
                Console.WriteLine("1. Сыграть в игру 'Угадай число'\n2. Увидеть Матрицу\n3. Запустить Змейку!!!\n" +
               "4. Ввод пароля\n0. Выход\n");
                inputChoice = Convert.ToInt32(Console.ReadLine());

                switch (inputChoice)
                {
                    case 0:
                        break;
                    #region Вариант 1 Сыграть в игру
                    case 1:
                        {
                            Console.WriteLine("'Угадай число'");
                            int userInput;
                            int solutionCount = 5;
                            Random myRand = new Random();
                            int zagadalComp = myRand.Next(0, 11);
                            Console.WriteLine($"я загадал число от 0 до 10. Какое это число? У тебя есть {solutionCount} попыток");
                            while (solutionCount > 0)
                            {
                                solutionCount--;
                                userInput = Convert.ToInt32(Console.ReadLine());
                                if (userInput == zagadalComp)
                                {
                                    Console.WriteLine($"У Г А Д А Л, я загадывал число {zagadalComp}");
                                    break;
                                }
                                if (solutionCount == 0)
                                {
                                    Console.WriteLine($"Ты не отгодал. Я загадывал число {zagadalComp}");
                                }
                                else
                                {
                                    Console.WriteLine($"не угадал, осталось {solutionCount} попытки");
                                }
                            }
                            Console.WriteLine("\nthe end. Нажми любую клавишу");
                            Console.ReadKey();
                            Console.Clear();
                        }
                        break;
                    #endregion
                    #region Вариант 2 матрица
                    case 2:
                        {
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("\t\t\t\t The Matrix has you");
                            Random myRand = new Random();

                            for (int i = 0; i < 3000; i++)
                            {
                                Thread.Sleep(1);
                                Console.Write(myRand.Next(0, 2));
                            }
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.Gray;
                        }
                        break;
                    #endregion
                    #region Вариант 3 Змейка
                    case 3:
                        {
                            Console.WriteLine("А это только после свадьбы )) Ооо, то есть после выпуска из iJunior ))");
                            Console.ReadKey();
                            Console.Clear();
                        }
                        break;
                    #endregion
                    #region Вариант 4 Пароль
                    case 4:
                        {
                            string passwForExit = "exit";
                            string userInput;

                            Console.BackgroundColor = ConsoleColor.DarkBlue;
                            Console.Clear();
                            Console.WriteLine("Ты попал в ловушку, пока не найдешь exit- будешь здесь вращаться вечно");
                            for (; ; )
                            {
                                Console.WriteLine("Начинай ввод");
                                userInput = Console.ReadLine();
                                if (passwForExit == userInput)
                                    break;
                                Console.WriteLine("Еще варианты?");
                            }
                            Console.WriteLine("Молодец! Жмахай любую кнопку");
                            Console.ReadKey();
                            Console.BackgroundColor = ConsoleColor.Black;
                            Console.Clear();
                        }
                        break;
                    #endregion
                    default:
                        {
                            Console.WriteLine("Неправильный ввод");
                        }
                        break;
                }
            } while (inputChoice != 0);
            Console.ReadLine();
        }
    }
}