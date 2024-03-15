using System;

class Worker 
{
  public string Name {get; set;}
  public string Surname  {get; set;}
  public int Rate {get; set;}
  public int Days {get; set;}
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
}
class Program
{
  public static void Main (string[] args)
  {
    Worker worker = new Worker();
    worker.EnterInformation();
    Console.WriteLine("Имя: " + worker.Name);
    Console.WriteLine("Фамилия: " + worker.Surname);
    Console.WriteLine("Ставка за день: " + worker.Rate);
    Console.WriteLine("Количество отработанных дней: " + worker.Days);
    
    worker.GetSalary();
    Console.WriteLine("Зарплата: " + worker.GetSalary());
  }
}