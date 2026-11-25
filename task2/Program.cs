//Задание 2. Уникальные числа (HashSet) ⭐⭐
//Создай консольное приложение для работы с HashSet<int>.
//Требования:
//Создай HashSet<int>.
//Добавь минимум 10 целых чисел.
//Попробуй добавить несколько повторяющихся чисел.
//Выведи все элементы через foreach.
//Проверь наличие определённого числа через Contains().
//Удали несколько элементов через Remove().
//Выведи количество элементов через Count.
//Очисти коллекцию через Clear().


//Дополнительные задания:
//Создай второй HashSet<int> и заполни его другими числами.
//Условия:
//Используй только HashSet<int>.
//Не создавай собственных классов и обёрток.
//Не используй LINQ.

using static System.Runtime.InteropServices.JavaScript.JSType;

var numbers = new HashSet <int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
Console.WriteLine($"Добавили 5 {numbers.Add(5)}");
Console.WriteLine($"Добавили 15 {numbers.Add(15)}");
Console.WriteLine("Все числа:");
foreach (var number in numbers)
{
    Console.WriteLine(number);
}
Console.WriteLine(numbers.Contains(7));
Console.WriteLine();
numbers.Remove(3);
numbers.Remove(6);
numbers.Remove(10);

Console.WriteLine("Все числа:");

foreach (var number in numbers)
{
    Console.WriteLine(number);
}
Console.WriteLine($"Количество элементов: {numbers.Count}");

numbers.Clear();
Console.WriteLine($"После Clear: {numbers.Count}");

Console.WriteLine();
Console.WriteLine("--- Дополнительные задания ---");
var set1 = new HashSet<int> { 1, 2, 3, 4, 5 };
var set2 = new HashSet<int> { 4, 5, 6, 7, 8 };
Console.WriteLine();
//Найди пересечение через IntersectWith().
var intersection = new HashSet<int>(set1);
intersection.IntersectWith(set2);
Console.WriteLine("Пересечение:");
foreach (var number in intersection)
{
    Console.WriteLine(number);
}
Console.WriteLine();
//Найди объединение через UnionWith().

var union = new HashSet<int>(set1);
union.UnionWith(set2);
Console.WriteLine("Объединение:");
foreach (var number in union)
{
    Console.WriteLine(number);
}
Console.WriteLine();
//Найди разность через ExceptWith().
var difference = new HashSet<int>(set1);
difference.ExceptWith(set2);
Console.WriteLine("Разность:");
foreach (var number in difference)
{
    Console.WriteLine(number);
}
Console.WriteLine();
//Проверь, является ли одно множество подмножеством другого через IsSubsetOf().
var small = new HashSet<int> { 4, 5 };
Console.WriteLine($"small подмножество set1? {small.IsSubsetOf(set1)}");