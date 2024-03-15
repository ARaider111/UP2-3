using System;

class Worker 
{
  private string Name {get; set;}
  private string Surname  {get; set;}
  private int Rate {get; set;}
  private int Days {get; set;}
  
  public int GetSalary()
  {
    int salary = Rate * Days;;
    return salary;
  }
  
  public void EnterInformation()
  {
    Console.WriteLine("Введите имя: ");
    Name = Console.ReadLine();
    Console.WriteLine("Введите фамилию: ");
    Surname = Console.ReadLine();
    Console.WriteLine("Введити ставку за день работы: ");
    Rate = int.Parse(Console.ReadLine());
    Console.WriteLine("Введите количество отработанных дней: ");
    Days = int.Parse(Console.ReadLine());
    Console.WriteLine();
  }

  public string GetName()
  {
    return Name;
  }

  public string GetSurname()
  {
    return Surname;
  }

  public int GetRate()
  {
    return Rate;
  }

  public int GetDays()
  {
    return Days;
  }
}

class Program
{
  public static void Main (string[] args)
  {
    Worker worker = new Worker();
    worker.EnterInformation();
    Console.WriteLine("Имя: " + worker.GetName());
    Console.WriteLine("Фамилия: " + worker.GetSurname());
    Console.WriteLine("Ставка за день: " + worker.GetRate());
    Console.WriteLine("Количество отработанных дней: " + worker.GetDays());

    worker.GetSalary();
    Console.WriteLine("Зарплата: " + worker.GetSalary());
  }
}