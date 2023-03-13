using Entity_Framework_Core_Code_first_forum_13_03_2023;

Console.WriteLine("");
addStudent();
ShowStudent();


static void addStudent()
{
    using (StudentContext db = new StudentContext())
    {
        Console.WriteLine("Введите имя студента");
        string? name = Console.ReadLine();
        Console.WriteLine("Введите фамилию студента");
        string? Fname = Console.ReadLine();
        Console.WriteLine("Введите возраст студента");
        int Age = Int32.Parse( Console.ReadLine());
        db.Students.Add(new Student(name, Fname, Age));
        db.SaveChanges();
    }
}

static void ShowStudent()
{
    using (StudentContext db = new StudentContext())
    {
        var data =db.Students.ToList();
        foreach (var item in data)
        {
            Console.WriteLine(item);
        }
    }
}