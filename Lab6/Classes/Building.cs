using System;

namespace Lab6;

/// <summary>
/// Класс для описания здания, включая уникальный номер, высоту, этажность, количество квартир и подъездов.
/// </summary>
class Building
{
    /// <summary>
    /// Уникальный номер здания.
    /// </summary>
    private int buildingNumber;

    /// <summary>
    /// Статическая переменная для генерации уникальных номеров зданий.
    /// </summary>
    private static int nextBuildingNumber = 1;

    /// <summary>
    /// Высота здания.
    /// </summary>
    private int height = 1;

    /// <summary>
    /// Количество этажей в здании.
    /// </summary>
    private int numberOfFloors = 1;

    /// <summary>
    /// Общее количество квартир в здании.
    /// </summary>
    private int numberOfApartments;

    /// <summary>
    /// Количество подъездов в здании.
    /// </summary>
    private int numberOfEntrances;

    /// <summary>
    /// Конструктор класса Building. 
    /// Устанавливает высоту, этажность, количество квартир и подъездов.
    /// </summary>
    /// <param name="height">Высота здания (в метрах).</param>
    /// <param name="numberOfFloors">Количество этажей в здании.</param>
    /// <param name="numberOfApartments">Общее количество квартир в здании.</param>
    /// <param name="numberOfEntrances">Количество подъездов в здании.</param>
    /// <exception cref="ArgumentException">
    /// Выбрасывается, если переданные значения не удовлетворяют ограничениям.
    /// </exception>
    public Building(int height, int numberOfFloors, int numberOfApartments, int numberOfEntrances)
    {
        if (height <= 0)
            throw new ArgumentException("Высота должна быть больше 0.");
        if (numberOfFloors <= 0)
            throw new ArgumentException("Количество этажей должно быть больше 0.");
        if (numberOfApartments <= 0)
            throw new ArgumentException("Количество квартир должно быть больше 0.");
        if (numberOfEntrances <= 0)
            throw new ArgumentException("Количество входов должно быть больше 0.");
        if (numberOfApartments / numberOfEntrances != Math.Round((double)numberOfApartments / numberOfEntrances))
            throw new ArgumentException("Количество квартир в доме должно делиться на количество подъездов");
        if ((numberOfApartments / numberOfEntrances) / numberOfFloors != Math.Round((double)numberOfApartments / numberOfEntrances) / numberOfFloors)
            throw new ArgumentException("Количество квартир в подъезде должно делиться на количество этажей" + " " + (numberOfApartments / numberOfEntrances) / numberOfFloors + " " + Math.Round((double)numberOfApartments / numberOfEntrances) / numberOfFloors);

        this.buildingNumber = BuildingNumberGenerator();
        this.height = height;
        this.numberOfFloors = numberOfFloors;
        this.numberOfApartments = numberOfApartments;
        this.numberOfEntrances = numberOfEntrances;
    }


    /// <summary>
    /// Устанавливает или обновляет параметры здания.
    /// </summary>
    /// <param name="height">Высота здания (в метрах).</param>
    /// <param name="numberOfFloors">Количество этажей в здании.</param>
    /// <param name="numberOfApartments">Общее количество квартир в здании.</param>
    /// <param name="numberOfEntrances">Количество подъездов в здании.</param>
    /// <exception cref="ArgumentException">
    /// Выбрасывается, если переданные значения не удовлетворяют ограничениям.
    /// </exception>
    public void SetBuilding(int height, int numberOfFloors, int numberOfApartments, int numberOfEntrances)
    {
        if (height <= 0)
            throw new ArgumentException("Высота должна быть больше 0.");
        if (numberOfFloors <= 0)
            throw new ArgumentException("Количество этажей должно быть больше 0.");
        if (numberOfApartments <= 0)
            throw new ArgumentException("Количество квартир должно быть больше 0.");
        if (numberOfEntrances <= 0)
            throw new ArgumentException("Количество входов должно быть больше 0.");
        if (numberOfApartments / numberOfEntrances != Math.Round((double)numberOfApartments / numberOfEntrances))
            throw new ArgumentException("Количество квартир в доме должно делиться на количество подъездов");
        if ((numberOfApartments / numberOfEntrances) / numberOfFloors != Math.Round((double)numberOfApartments / numberOfEntrances) / numberOfFloors)
            throw new ArgumentException("Количество квартир в подъезде должно делиться на количество этажей" + " " + (numberOfApartments / numberOfEntrances) / numberOfFloors + " " + Math.Round((double)numberOfApartments / numberOfEntrances) / numberOfFloors);

        this.buildingNumber = BuildingNumberGenerator();
        this.height = height;
        this.numberOfFloors = numberOfFloors;
        this.numberOfApartments = numberOfApartments;
        this.numberOfEntrances = numberOfEntrances;
    }


    /// <summary>
    /// Генерирует уникальный номер для здания.
    /// </summary>
    /// <returns>Уникальный номер здания.</returns>
    private int BuildingNumberGenerator()
    {
        return nextBuildingNumber++;
    }

    /// <summary>
    /// Метод для вывода информации о здании.
    /// </summary>
    public void PrintBuildingInfo()
    {
        Console.WriteLine($"Номер здания: №{buildingNumber}\nВысота здания: {height} {GetHeightWord(height)}\nКоличество этажей: {numberOfFloors}\nКоличество квартир: {numberOfApartments}\nКоличество подъездов: {numberOfEntrances}");
    }

    /// <summary>
    /// Получает правильное склонение слова "метр" в зависимости от числа.
    /// </summary>
    /// <param name="height">Высота здания.</param>
    /// <returns>Правильное склонение слова "метр".</returns>
    public string GetHeightWord(int height)
    {
        if (height % 10 == 1 && height % 100 != 11)
            return "метр";
        else if ((height % 10 >= 2 && height % 10 <= 4) && (height % 100 < 10 || height % 100 >= 20))
            return "метра";
        else
            return "метров";
    }

    /// <summary>
    /// Метод для вычисления высоты этажа.
    /// </summary>
    /// <returns>Высота одного этажа.</returns>
    public double CalculatFloorHeight()
    {
        return (double)height / numberOfFloors;
    }

    /// <summary>
    /// Метод для вычисления количества квартир в одном подъезде.
    /// </summary>
    /// <returns>Количество квартир на подъезд.</returns>
    public int CalculateApartmentsPerEntrance()
    {
        return numberOfApartments / numberOfEntrances;
    }

    /// <summary>
    /// Метод для вычисления количества квартир на одном этаже.
    /// </summary>
    /// <returns>Количество квартир на этаж.</returns>
    public int CalculateApartmentsPerFloor()
    {
        return CalculateApartmentsPerEntrance() / numberOfFloors;
    }

    /// <summary>
    /// Метод для вычисления количества количества лестничных пролетов.
    /// </summary>
    /// <returns>Количествo лестничных пролетов.</returns>
    public int CalculatingTheNumberOfFlightsOfStairs()
    {
        return numberOfFloors > 1 ? numberOfFloors - 1 : 0;
    }

}
