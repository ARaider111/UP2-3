using System;

class Calculation 
{
  public string CalculationLine {get; set;}

  public void SetCalculationLine()
  {
    Console.WriteLine("-------------------------------------");
    Console.WriteLine("Введите строку: ");
    CalculationLine = Console.ReadLine();
  }

  public void SetLastSymbolCalculationLine()
  {
    Console.WriteLine("-------------------------------------");
    Console.WriteLine("Введите символ: ");
    string symbol = Console.ReadLine();
    CalculationLine = CalculationLine + symbol;
    Console.WriteLine("Символ добавлен!");
  }

  public void GetCalculationLine()
  {
    Console.WriteLine("-------------------------------------");
    Console.WriteLine("Строка: " + CalculationLine);
  }

  public void GetLastSymbolCalculationLine()
  {
    Console.WriteLine("-------------------------------------");
    Console.WriteLine("Последний символ: " + 
    CalculationLine[CalculationLine.Length - 1]);
  }

  public void ClearCalculationLine()
  {
    Console.WriteLine("-------------------------------------");
    CalculationLine = CalculationLine.Remove(CalculationLine.Length - 1);
    Console.WriteLine("Символ удален!");
  } 
}

class Program
{
  public static void Main (string[] args) 
  {
    Calculation calc = new Calculation();
    int temp = 0;
    do
    {
      Console.WriteLine("-------------------------------------");
      Console.WriteLine ("Выберете действие: ");
      Console.WriteLine("1 - Установить значение строки;");
      Console.WriteLine("2 - Добавить последний символ;");
      Console.WriteLine("3 - Вывести строку;");
      Console.WriteLine("4 - Вывести последний символ;");
      Console.WriteLine("5 - Удалить последний символ;");
      Console.WriteLine("0 - Выход.");
      Console.WriteLine("-------------------------------------");
      temp = int.Parse(Console.ReadLine());
      switch (temp)
      {
      case 1:
        calc.SetCalculationLine();
        break;
      case 2:
        calc.SetLastSymbolCalculationLine();
        break;
      case 3:
        calc.GetCalculationLine();
        break;
      case 4:
        calc.GetLastSymbolCalculationLine();
        break;
      case 5:
        calc.ClearCalculationLine();
        break;
      case 0:
         return;
      default:
         Console.WriteLine("Неверный ввод");
         break;
      }
    } while(temp != 0);
  }
}