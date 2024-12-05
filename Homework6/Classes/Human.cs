/// <summary>
/// Абстрактный класс, представляющий человека с базовой информацией, такой как имя, фамилия, возраст и пол.
/// Содержит методы для отображения информации и вычисления возраста на основе даты рождения.
/// </summary>
public abstract class Human
{
    /// <summary>
    /// Имя человека.
    /// </summary>
    public string firstName { get; set; }

    /// <summary>
    /// Фамилия человека.
    /// </summary>
    public string lastName { get; set; }

    /// <summary>
    /// Дата рождения человека.
    /// </summary>
    public DateTime age { get; private set; }

    /// <summary>
    /// Пол человека.
    /// </summary>
    public string gender { get; set; }

    /// <summary>
    /// Конструктор, инициализирующий имя, фамилию, дату рождения и пол.
    /// </summary>
    /// <param name="firstName">Имя человека.</param>
    /// <param name="lastName">Фамилия человека.</param>
    /// <param name="age">Дата рождения человека.</param>
    /// <param name="gender">Пол человека.</param>
    public Human(string firstName, string lastName, DateTime age, string gender)
    {
        this.firstName = firstName;
        this.lastName = lastName;
        this.age = age;
        this.gender = gender;
    }

    /// <summary>
    /// Возвращает текущий возраст человека в годах.
    /// </summary>
    public int Age
    {
        get
        {
            var today = DateTime.Today;
            var years = today.Year - age.Year;
            if (age.Date > today.AddYears(-years)) years--;
            return years;
        }
    }

    /// <summary>
    /// Устанавливает дату рождения человека, проверяя, что она не в будущем.
    /// </summary>
    /// <param name="birthDate">Дата рождения человека.</param>
    public void SetAge(DateTime birthDate)
    {
        if (birthDate < DateTime.Now)
        {
            age = birthDate;
        }
        else
        {
            Console.WriteLine("Дата рождения не может быть в будущем.");
        }
    }

    /// <summary>
    /// Выводит приветствие.
    /// </summary>
    public void SayHello()
    {
        Console.WriteLine("Привет!");
    }

    /// <summary>
    /// Представляет себя, выводя информацию о человеке.
    /// </summary>
    public void Introduce()
    {
        Console.WriteLine($"Меня зовут {lastName} {firstName}, мне {Age} лет, я {gender}.");
    }

    /// <summary>
    /// Абстрактный метод для отображения дополнительной информации о человеке.
    /// </summary>
    public abstract void DisplayInfo();
}
