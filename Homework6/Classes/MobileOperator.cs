using System;

namespace Homework6
{
    /// <summary>
    /// Класс, представляющий мобильного оператора с данными о покрытии, тарифах, количестве клиентов и доходе.
    /// </summary>
    public class MobileOperator

    {/// <summary>
     /// Название оператора.
     /// </summary>
        public string name { get; set; }

        /// <summary>
        /// Покрытие сети оператора в процентах.
        /// </summary>
        public double coverage { get; set; }

        /// <summary>
        /// Количество клиентов у оператора.
        /// </summary>
        public int clientsCount { get; private set; }

        /// <summary>
        /// Средняя стоимость тарифа оператора.
        /// </summary>
        public double tariffCost { get; set; }

        /// <summary>
        /// Список доступных тарифов оператора.
        /// </summary>
        public List<Tariff> tariffs { get; set; }

        /// <summary>
        /// Инициализация нового объекта мобильного оператора с заданными параметрами.
        /// </summary>
        /// <param name="name">Название оператора.</param>
        /// <param name="coverage">Покрытие сети оператора в процентах.</param>
        /// <param name="tariffCost">Средняя стоимость тарифа.</param>
        /// <param name="tariffs">Список тарифов оператора.</param>

        public MobileOperator(string name, double coverage, double tariffCost, List<Tariff> tariffs)
        {
            this.name = name;
            this.coverage = coverage;
            this.tariffCost = tariffCost;
            this.tariffs = tariffs ?? new List<Tariff>();
            this.clientsCount = 0;
        }

        /// <summary>
        /// Инициализация объекта мобильного оператора с дефолтными значениями.
        /// </summary>
        public MobileOperator() : this("Неизвестный оператор", 0, 0, new List<Tariff>())
        {
        }

        /// <summary>
        /// Добавление нового клиента.
        /// </summary>
        public void AddClient()
        {
            clientsCount++;
        }

        /// <summary>
        /// Удаление клиента (например, при уходе из сети).
        /// </summary>
        public void RemoveClient()
        {
            if (clientsCount > 0)
                clientsCount--;
            else
                Console.WriteLine("Нет клиентов для удаления.");
        }

        /// <summary>
        /// Вычисление дохода оператора.
        /// </summary>
        /// <returns>Общий доход оператора.</returns>
        public double CalculateIncome()
        {
            return clientsCount * tariffCost;
        }

        /// <summary>
        /// Отображение информации об операторе.
        /// </summary>
        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Оператор: {name}\nПокрытие: {coverage}%\nКлиентов: {clientsCount}\nСредняя стоимость тарифа: {tariffCost:C}");
            Console.WriteLine("Список доступных тарифов:");
            foreach (var tariff in tariffs)
            {
                tariff.DisplayInfo();
                Console.WriteLine();
            }
        }

        /// <summary>
        /// Обновление данных оператора.
        /// </summary>
        /// <param name="name">Имя оператора.</param>
        /// <param name="coverage">Покрытие сети.</param>
        /// <param name="tariffCost">Средняя стоимость тарифа.</param>
        /// <param name="tariffs">Список тарифов.</param>
        public virtual void SetData(string name, double coverage, double tariffCost, List<Tariff> tariffs)
        {
            this.name = name;
            this.coverage = coverage;
            this.tariffCost = tariffCost;
            this.tariffs = tariffs ?? new List<Tariff>();
        }
    }
}
