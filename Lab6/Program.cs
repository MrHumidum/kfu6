using System;

namespace Lab6
{
    class Program
    {
        /// <summary>
        /// Точка входа в программу. Выполняет задания из главы 7.
        /// </summary>
        /// <param name="args">Аргументы командной строки.</param>
        static void Main(string[] args)
        {
            Console.WriteLine("Упражнение 7.1\n");
            /*Создать класс счет в банке с закрытыми полями: номер счета, баланс, тип
            банковского счета (использовать перечислимый тип из упр. 3  .1). Предусмотреть методы для
            доступа к данным – заполнения и чтения. Создать объект класса, заполнить его поля и
            вывести информацию об объекте класса на печать.*/
            Ex1();

            Console.WriteLine("Упражнение 7.2\n");
            /*Изменить класс счет в банке из упражнения 7.1 таким образом, чтобы
            номер счета генерировался сам и был уникальным. Для этого надо создать в классе
            статическую переменную и метод, который увеличивает значение этого переменной.*/
            Ex2();

            Console.WriteLine("Упражнение 7.3\n");
            /*Добавить в класс счет в банке два метода: снять со счета и положить на
            счет. Метод снять со счета проверяет, возможно ли снять запрашиваемую сумму, и в случае
            положительного результата изменяет баланс.*/
            Ex3();

            Console.WriteLine("Домашнее задание 7.1\n");
            /*Реализовать класс для описания здания (уникальный номер здания,
            высота, этажность, количество квартир, подъездов). Поля сделать закрытыми,
            предусмотреть методы для заполнения полей и получения значений полей для печати.
            Добавить методы вычисления высоты этажа, количества квартир в подъезде, количества
            квартир на этаже и т.д. Предусмотреть возможность, чтобы уникальный номер здания
            генерировался программно. Для этого в классе предусмотреть статическое поле, которое бы
            хранило последний использованный номер здания, и предусмотреть метод, который
            увеличивал бы значение этого поля.*/
            Ex4();
        }
        /// <summary>
        /// Упражнение 7.1. Создание и вывод информации о банковском счете.
        /// </summary>
        static void Ex1()
        {
            BankAccount myFirstBankAccount = new BankAccount();
            myFirstBankAccount.SetAccountData(1000000000, BankAccountType.Savings);
            myFirstBankAccount.PrintAccountInfo();
        }
        /// <summary>
        /// Упражнение 7.2. Демонстрация автогенерации уникального номера счета.
        /// </summary>
        static void Ex2()
        {
            BankAccount mySecondBankAccount = new BankAccount(423432, BankAccountType.Savings);
            mySecondBankAccount.PrintAccountInfo();
        }
        /// <summary>
        /// Упражнение 7.3. Пополнение, снятие и проверка баланса банковского счета.
        /// </summary>
        static void Ex3()
        {
            Console.WriteLine("Создаю третий счет с балансом 100$\n");
            BankAccount myThirdBankAccount = new BankAccount(100, BankAccountType.Savings);
            myThirdBankAccount.PrintAccountInfo();

            Console.WriteLine("\nПополняю баланс на 1000$\n");
            myThirdBankAccount.DepositMoney(1000);
            myThirdBankAccount.PrintAccountInfo();

            Console.WriteLine("\nСнимаю со счета 100$\n");
            myThirdBankAccount.WithdrawMoney(100);
            myThirdBankAccount.PrintAccountInfo();

            Console.WriteLine("\nСнимаю со счета 10000$\n");
            myThirdBankAccount.WithdrawMoney(100010);
            myThirdBankAccount.PrintAccountInfo();
        }
        /// <summary>
        /// Домашнее задание 7.1. Работа с классом для описания здания.
        /// </summary>
        static void Ex4()
        {
            try
            {
                Building firstBuilding = new Building(800, 16, 800, 1);
                firstBuilding.PrintBuildingInfo();
                Console.WriteLine($"Высота одного этажа: {firstBuilding.CalculatFloorHeight()} {firstBuilding.GetHeightWord((int)firstBuilding.CalculatFloorHeight())}");
                Console.WriteLine($"Количество квартир на подъезд: {firstBuilding.CalculateApartmentsPerEntrance()}");
                Console.WriteLine($"Количество квартир на этаж: {firstBuilding.CalculateApartmentsPerFloor()}");
                Console.WriteLine($"Количествo лестничных пролетов: {firstBuilding.CalculatingTheNumberOfFlightsOfStairs()}");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex);
            }
        }
    }
}

