/// <summary>
/// Класс, представляющий тариф с информацией о его стоимости, объеме интернета, скорости и количестве минут.
/// Содержит методы для отображения информации о тарифе, изменения его данных и выполнения некоторых расчетов.
/// </summary>
public class Tariff
{
    /// <summary>
    /// Название тарифа.
    /// </summary>
    public string name { get; set; }

    /// <summary>
    /// Стоимость тарифа.
    /// </summary>
    public decimal cost { get; set; }

    /// <summary>
    /// Количество гигабайт интернета, включенных в тариф.
    /// </summary>
    public int gigabytesCount { get; set; }

    /// <summary>
    /// Скорость интернета в мегабитах в секунду.
    /// </summary>
    public int speed { get; set; }

    /// <summary>
    /// Количество минут, включенных в тариф.
    /// </summary>
    public int minutesCount { get; set; }

    /// <summary>
    /// Конструктор, инициализирующий тариф с заданными значениями.
    /// </summary>
    /// <param name="name">Название тарифа.</param>
    /// <param name="cost">Стоимость тарифа.</param>
    /// <param name="gigabytesCount">Количество гигабайт интернета.</param>
    /// <param name="speed">Скорость интернета в Мбит/с.</param>
    /// <param name="minutesCount">Количество минут для звонков.</param>
    public Tariff(string name, decimal cost, int gigabytesCount, int speed, int minutesCount)
    {
        this.name = name;
        this.cost = cost;
        this.gigabytesCount = gigabytesCount;
        this.speed = speed;
        this.minutesCount = minutesCount;
    }

    /// <summary>
    /// Конструктор по умолчанию, инициализирующий тариф с неизвестными значениями.
    /// </summary>
    public Tariff()
    {
        name = "Неизвестный тариф";
        cost = 0;
        gigabytesCount = 0;
        speed = 0;
        minutesCount = 0;
    }

    /// <summary>
    /// Выводит информацию о тарифе.
    /// </summary>
    public virtual void DisplayInfo()
    {
        Console.WriteLine($"Тариф: {name}\nСтоимость: {cost:C}\nИнтернет: {gigabytesCount} ГБ\nСкорость: {speed} Мбит/с\nМинуты: {minutesCount}");
    }

    /// <summary>
    /// Устанавливает данные о тарифе.
    /// </summary>
    /// <param name="name">Название тарифа.</param>
    /// <param name="cost">Стоимость тарифа.</param>
    /// <param name="gigabytesCount">Количество гигабайт интернета.</param>
    /// <param name="speed">Скорость интернета в Мбит/с.</param>
    /// <param name="minutesCount">Количество минут для звонков.</param>
    public virtual void SetData(string name, decimal cost, int gigabytesCount, int speed, int minutesCount)
    {
        this.name = name;
        this.cost = cost;
        this.gigabytesCount = gigabytesCount;
        this.speed = speed;
        this.minutesCount = minutesCount;
    }

    /// <summary>
    /// Рассчитывает стоимость одного гигабайта интернета в тарифе.
    /// </summary>
    /// <returns>Стоимость одного гигабайта.</returns>
    public decimal CostPerGigabyte()
    {
        return gigabytesCount > 0 ? cost / gigabytesCount : 0;
    }

    /// <summary>
    /// Рассчитывает стоимость одной минуты в тарифе.
    /// </summary>
    /// <returns>Стоимость одной минуты.</returns>
    public decimal CostPerMinute()
    {
        return minutesCount > 0 ? cost / minutesCount : 0;
    }

    /// <summary>
    /// Проверяет, является ли текущий тариф дешевле другого тарифа.
    /// </summary>
    /// <param name="other">Другой тариф для сравнения.</param>
    /// <returns>Возвращает <c>true</c>, если текущий тариф дешевле, иначе <c>false</c>.</returns>
    public bool IsCheaperThan(Tariff other)
    {
        return cost < other.cost;
    }

    /// <summary>
    /// Проверяет, является ли тариф с неограниченным интернетом.
    /// </summary>
    /// <returns>Возвращает <c>true</c>, если интернет в тарифе неограниченный, иначе <c>false</c>.</returns>
    public bool IsUnlimitedInternet()
    {
        return gigabytesCount == int.MaxValue;
    }

    /// <summary>
    /// Добавляет дополнительные минуты в тариф.
    /// </summary>
    /// <param name="additionalMinutes">Количество минут, которое нужно добавить.</param>
    public void AddMinutes(int additionalMinutes)
    {
        if (additionalMinutes > 0)
            minutesCount += additionalMinutes;
    }

    /// <summary>
    /// Добавляет дополнительные гигабайты в тариф.
    /// </summary>
    /// <param name="additionalGigabytes">Количество гигабайт, которое нужно добавить.</param>
    public void AddGigabytes(int additionalGigabytes)
    {
        if (additionalGigabytes > 0)
            gigabytesCount += additionalGigabytes;
    }
}
