 using System;

public class Program {
  public static void Main (string[] args) 
  {
    ListPersonalInfo("Lucinda Potter", "6/24/1992", "work 000-000-0101", "cell 000-000-0189");
    ListPersonalInfo("John Smith", "8/15/1978", "work 000-000-0101", "cell 000-000-0189");
    ListPersonalInfo("Chris Johnson", "12/01/1987", "work 000-222-0101", "cell 000-222-0189");
    ListPersonalInfo("Robert Hall", "2/27/1949", "work 000-444-0101", "cell 000-444-0189");
  }
public static void ListPersonalInfo(string name, string date, string workphone, string cellphone) {
  Console.WriteLine(name);
  Console.WriteLine(date);
  Console.WriteLine("work " + workphone);
  Console.WriteLine("cell " + cellphone);
  Console.WriteLine();
}
}