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

int n;
Console.WriteLine("Введите кол-во элементов");
int.TryParse(Console.ReadLine(), out n);
Console.Write("Введите текст: ");
string[] zadachka = new string[n];
for (int i = 0; i < zadachka.Length; i++)
{
  zadachka[i] = Console.ReadLine();
}
Console.Write($"[");
for (int j = 0; j < zadachka.Length; j++)
{
  Console.Write($"\"{zadachka[j]}\" ");
}
Console.Write($"]");

string[] sort = new string[n];
  int num = 0;
  for (int j = 0; j < zadachka.Length; j++)
  {
    if (zadachka[j].Length < 4)
    {
      sort[num] = zadachka[j];
      num++;
    }
  }
sort = sort.Where(x => x != null).ToArray();


Console.Write($"-> [");
for (int j = 0; j < sort.Length; j++)
{
  if(sort[j]!="")
  {
  Console.Write($"\"{sort[j]}\" ");
  }
}
Console.Write($"]");