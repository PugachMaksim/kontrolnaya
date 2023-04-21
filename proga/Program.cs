#pragma warning disable
/*
Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
лучше обойтись исключительно массивами.

Примеры:
[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
[“1234”, “1567”, “-2”, “computer science”] → [“-2”]
[“Russia”, “Denmark”, “Kazan”] → []
*/


int count=1;
List<string>zdch = new List<string>();
Console.WriteLine("Введите текст");
for (int i = 0; i < count; i++)
{
  string xxx = Console.ReadLine();
  if (xxx != "")
  {
  zdch.Add(xxx);
  count++;
  }
  else
  {
    Console.WriteLine("Ввода не было");
    break;
  }
}

Console.Write("[");
foreach (var item in zdch)
{
  Console.Write($"\"{item}\" ");
}
Console.Write("]");
Console.Write("-> ");

List<string>zdchNew = new List<string>();
for (int i = 0; i < zdch.Count; i++)
{
  if (zdch[i].Length < 4)
    zdchNew.Add(zdch[i]);
}
Console.Write("[");
foreach (var item in zdchNew)
{
  Console.Write($"\"{item}\" ");
}
Console.Write("]");