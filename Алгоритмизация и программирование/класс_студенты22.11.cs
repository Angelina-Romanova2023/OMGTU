using System;
using System.Runtime.ExceptionServices;
class Student
{
    private string Name;
    private int Year;
    private string Group;

    public Student(string Name, int Year, string Group)//Описываем "Тип переменной" Student. Стандартные значения - this
    {
        this.Name = Name;
        this.Year = Year;
        this.Group = Group;
    }

    public string getName(Student students)//get хранит информацию
    { 
        return Name; 
    }
    public int getYear(Student students)
    {
        return Year;
    }
    public string getGroup(Student students)
    {
        return Group;
    }
    public void setName(string name)//Для замены имени экземпляра(студента) на заданное
    {
        this.Name = name;
    }
    public void setYear(int year)
    {
        this.Year = year;
    }
    public void setGroup(string group)
    {
        this.Group = group;
    }
    public string getInformation(Student students)//Для получения всей информации об экземпляре(конкретном студенте)
    {
        if (students!=null)//Если значение не пустое и информация вообще есть
        {
            return " " + students.Name +"  "+ Convert.ToString(students.Year) +"  "+ students.Group;//Просто строкой возвращается всё по порядку
        }
        else
        {
            return " ";
        }  
    }
    public Student sortedByYear(Student students, int sortyear)//Метод для сортировки по заданному году рождения
    {
        if (students.Year == sortyear)
        {
            return students;//Возвращаем студента, удовлетворяющего условию
        }
        else
        {
            return null;
        }
    }
    public Student sortedByGroup(Student students, string sortgroup)//Метод для сортировки по группе
    {
        if (students.Group.Equals(sortgroup))
        {                                    //Equals(эквивалентно) - то же самое, что "==", только для string
            return students;
        }
        else
        {
            return null;
        }
    }
}
class program
{
    static void Main()
    {
        Console.WriteLine("Введите год рождения, по которому необходимо найти студентов: "); int sortyear = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите название группы, студентов из которой необходимо найти: "); string sortgroup = Console.ReadLine();
        Student[] students = new Student[5];//Создаем массив со всеми студентами в "базе данных"
        students[0] = new Student("Romanova Angelina", 2005, "fit-231");
        students[1] = new Student("Petrov Roman", 2005, "atp-231");
        students[2] = new Student("Ivanov Ivan", 2005, "fit-231");
        students[3] = new Student("Vetrov Petr", 2004, "ivt-221");
        students[4] = new Student("Rein Dasha", 2004, "fit-231");
        Console.WriteLine("\nВсе студенты нужного года рождения:");// \n отступает строку
        for (int i = 0; i < students.Length; i++)//Проходим по всей бд и используем метод сортировки
        {  
            if (students[i].sortedByYear(students[i], sortyear) != null)//Используем метод и проверяем чтобы проверка не попадала в элс 
            {
                Console.WriteLine(students[i].getInformation(students[i]));//Выводим то, что возвращается в результате применения метода "getInformation"
            }
        }
        Console.WriteLine("\nВсе студенты из данной группы:");
        for (int i = 0; i < students.Length; i++)
        {
            if (students[i].sortedByGroup(students[i], sortgroup) != null)
            {
                Console.WriteLine(students[i].getInformation(students[i]));
            }       
        }
    }
}
