/// <summary>
/// Класс, представляющий сотрудника службы поддержки, наследующий от класса <see cref="Human"/>.
/// Содержит информацию о должности, стаже, специализации и доступности для клиентов.
/// </summary>
public class Support : Human
{
    /// <summary>
    /// Должность сотрудника службы поддержки.
    /// </summary>
    public string position { get; set; }

    /// <summary>
    /// Количество лет опыта работы сотрудника.
    /// </summary>
    public int experienceYears { get; set; }

    /// <summary>
    /// Специализация сотрудника.
    /// </summary>
    public string specialization { get; set; }

    /// <summary>
    /// Доступность сотрудника для оказания помощи.
    /// </summary>
    public bool isAvailable { get; set; }

    /// <summary>
    /// Конструктор, инициализирующий сотрудника службы поддержки с заданными параметрами.
    /// </summary>
    /// <param name="firstName">Имя сотрудника.</param>
    /// <param name="lastName">Фамилия сотрудника.</param>
    /// <param name="birthDate">Дата рождения сотрудника.</param>
    /// <param name="gender">Пол сотрудника.</param>
    /// <param name="position">Должность сотрудника.</param>
    /// <param name="experienceYears">Количество лет опыта работы.</param>
    /// <param name="specialization">Специализация сотрудника.</param>
    /// <param name="isAvailable">Доступность для помощи.</param>
    public Support(string firstName, string lastName, DateTime birthDate, string gender,
                   string position, int experienceYears, string specialization, bool isAvailable)
        : base(firstName, lastName, birthDate, gender)
    {
        this.position = position;
        this.experienceYears = experienceYears;
        this.specialization = specialization;
        this.isAvailable = isAvailable;
    }

    /// <summary>
    /// Конструктор по умолчанию, инициализирующий сотрудника службы поддержки с неизвестными данными.
    /// </summary>
    public Support()
        : base("Неизвестно", "Неизвестно", DateTime.MinValue, "Неизвестно")
    {
        this.position = "Неизвестная должность";
        this.experienceYears = 0;
        this.specialization = "Неизвестная специализация";
        this.isAvailable = false;
    }

    /// <summary>
    /// Метод для оказания помощи клиенту по указанной проблеме, если сотрудник доступен.
    /// </summary>
    /// <param name="issue">Проблема, по которой требуется помощь.</param>
    public void AssistClient(string issue)
    {
        if (isAvailable)
        {
            Console.WriteLine($"Сотрудник {lastName} {firstName} оказывает помощь по вопросу: {issue}");
        }
        else
        {
            Console.WriteLine($"Сотрудник {lastName} {firstName} сейчас недоступен для помощи.");
        }
    }

    /// <summary>
    /// Выводит информацию о сотруднике службы поддержки.
    /// </summary>
    public override void DisplayInfo()
    {
        Console.WriteLine($"Сотрудник поддержки: {lastName} {firstName}\nДолжность: {position}\nСтаж: {experienceYears} лет\nСпециализация: {specialization}\nДоступен для клиентов: {(isAvailable ? "Да" : "Нет")}");
    }

    /// <summary>
    /// Обновляет данные сотрудника службы поддержки.
    /// </summary>
    /// <param name="firstName">Имя сотрудника.</param>
    /// <param name="lastName">Фамилия сотрудника.</param>
    /// <param name="birthDate">Дата рождения сотрудника.</param>
    /// <param name="gender">Пол сотрудника.</param>
    /// <param name="position">Должность сотрудника.</param>
    /// <param name="experienceYears">Количество лет опыта работы.</param>
    /// <param name="specialization">Специализация сотрудника.</param>
    /// <param name="isAvailable">Доступность для помощи.</param>
    public void UpdateData(string firstName, string lastName, DateTime birthDate, string gender,
                           string position, int experienceYears, string specialization, bool isAvailable)
    {
        this.firstName = firstName;
        this.lastName = lastName;
        SetAge(birthDate);
        this.gender = gender;
        this.position = position;
        this.experienceYears = experienceYears;
        this.specialization = specialization;
        this.isAvailable = isAvailable;
    }
}
