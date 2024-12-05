/// <summary>
/// Класс, представляющий мобильного клиента, наследующий от класса <see cref="Human"/>.
/// Содержит информацию о тарифе, балансе и номере телефона клиента.
/// Предоставляет методы для пополнения баланса, оплаты тарифа, изменения тарифа и отображения информации о клиенте.
/// </summary>
public class MobileClient : Human
{
    /// <summary>
    /// Тариф, выбранный мобильным клиентом.
    /// </summary>
    public Tariff tariff { get; set; }

    /// <summary>
    /// Номер телефона мобильного клиента.
    /// </summary>
    public string phoneNumber { get; set; }

    /// <summary>
    /// Баланс мобильного клиента.
    /// </summary>
    public double balance { get; set; }

    /// <summary>
    /// Конструктор, инициализирующий мобильного клиента с заданными значениями.
    /// </summary>
    /// <param name="firstName">Имя клиента.</param>
    /// <param name="lastName">Фамилия клиента.</param>
    /// <param name="birthDate">Дата рождения клиента.</param>
    /// <param name="gender">Пол клиента.</param>
    /// <param name="phoneNumber">Номер телефона клиента.</param>
    /// <param name="tariff">Тариф клиента.</param>
    /// <param name="balance">Баланс клиента.</param>
    public MobileClient(string firstName, string lastName, DateTime birthDate, string gender, string phoneNumber, Tariff tariff, double balance)
        : base(firstName, lastName, birthDate, gender)
    {
        this.phoneNumber = phoneNumber;
        this.tariff = tariff;
        this.balance = balance;
    }

    /// <summary>
    /// Конструктор по умолчанию, инициализирующий мобильного клиента с неизвестными значениями.
    /// </summary>
    public MobileClient()
        : base("Неизвестное имя", "Неизвестная фамилия", DateTime.MinValue, "Неизвестно")
    {
        this.phoneNumber = "Неизвестный номер";
        this.tariff = new Tariff();
        this.balance = 0;
    }

    /// <summary>
    /// Пополняет баланс мобильного клиента на указанную сумму.
    /// </summary>
    /// <param name="amount">Сумма пополнения баланса.</param>
    public void AddBalance(double amount)
    {
        if (amount > 0)
        {
            balance += amount;
            Console.WriteLine($"Баланс пополнен на {amount:C}. Текущий баланс: {balance:C}");
        }
        else
        {
            Console.WriteLine("Сумма пополнения должна быть больше 0.");
        }
    }

    /// <summary>
    /// Оплачивает тариф клиента, если на балансе достаточно средств.
    /// </summary>
    public void PayForTariff()
    {
        if (balance >= (double)tariff.cost)
        {
            balance -= (double)tariff.cost;
            Console.WriteLine($"Тариф {tariff.name} оплачен. Остаток на балансе: {balance:C}");
        }
        else
        {
            Console.WriteLine($"Недостаточно средств для оплаты тарифа {tariff.name}. Пополните баланс.");
        }
    }

    /// <summary>
    /// Выводит информацию о мобильном клиенте, включая номер телефона, баланс и текущий тариф.
    /// </summary>
    public override void DisplayInfo()
    {
        Console.WriteLine($"Клиент: {lastName} {firstName}");
        Console.WriteLine($"Номер телефона: {phoneNumber}");
        Console.WriteLine($"Баланс: {balance:C}");
        Console.WriteLine($"Текущий тариф:");
        tariff.DisplayInfo();
    }

    /// <summary>
    /// Изменяет тариф мобильного клиента на новый.
    /// </summary>
    /// <param name="newTariff">Новый тариф для клиента.</param>
    public void ChangeTariff(Tariff newTariff)
    {
        tariff = newTariff;
        Console.WriteLine($"Тариф изменён на {tariff.name}");
    }

    /// <summary>
    /// Устанавливает данные мобильного клиента.
    /// </summary>
    /// <param name="firstName">Имя клиента.</param>
    /// <param name="lastName">Фамилия клиента.</param>
    /// <param name="phoneNumber">Номер телефона клиента.</param>
    /// <param name="tariff">Тариф клиента.</param>
    /// <param name="balance">Баланс клиента.</param>
    public virtual void SetData(string firstName, string lastName, string phoneNumber, Tariff tariff, double balance)
    {
        this.firstName = firstName;
        this.lastName = lastName;
        this.phoneNumber = phoneNumber;
        this.tariff = tariff;
        this.balance = balance;
    }
}
