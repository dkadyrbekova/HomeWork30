//Задание 1. Каталог товаров (Dictionary) ⭐⭐
//Создай консольное приложение для управления каталогом товаров с использованием Dictionary<int, Product>.
//Каждый товар содержит:
//Id
//Name
//Price
//Quantity
//Требования:
//Создай Dictionary<int, Product>, где ключом является Id товара.
//Условия:
//Используй Add(), TryGetValue(), ContainsKey(), Remove(), Count, Clear().
//Не создавай собственных классов для управления словарём.
//Не используй LINQ.

using Lesson30;

//Добавь минимум 5 товаров.

var products = new Dictionary<int, Product>
{
    { 1, new Product { Id = 1, Name = "Клавиатура", Price = 1500, Quantity = 10 } },
    { 2, new Product { Id = 2, Name = "Мышь", Price = 800, Quantity = 25 } },
    { 3, new Product { Id = 3, Name = "Монитор", Price = 12000, Quantity = 5 } },
    { 4, new Product { Id = 4, Name = "Наушники", Price = 2300, Quantity = 12 } },
    { 5, new Product { Id = 5, Name = "Веб-камера", Price = 3100, Quantity = 7 } }
};
//Выведи все товары через foreach.
Console.WriteLine("Все товары:");
foreach (var pair in products)
{
    Console.WriteLine($"Ключ {pair.Key}: {pair.Value}");
}
Console.WriteLine();
//Найди товар по его Id.

if (products.TryGetValue(3, out var found))
{
    Console.WriteLine($"Нашли: {found}");
}
else
{
    Console.WriteLine("Товара с Id 3 нет");
}

Console.WriteLine();
//Проверь существование товара через ContainsKey().
Console.WriteLine(products.ContainsKey(4));  // True
Console.WriteLine(products.ContainsKey(99)); // False
Console.WriteLine();
//Измени цену одного из товаров.
if (products.TryGetValue(2, out var mouse))
{
    mouse.Price = 950;
    Console.WriteLine(mouse);
}
Console.WriteLine();
//Удали товар через Remove().
if (products.ContainsKey(5))
{
    products.Remove(5);
    Console.WriteLine("Товар 5 удалён");
}
else
{
    Console.WriteLine("Товара 5 нет");
}

Console.WriteLine();
// Добавляем новый товар с свободным Id
products.Add(6, new Product { Id = 6, Name = "Коврик", Price = 400, Quantity = 30 });
Console.WriteLine("Товар 6 добавлен");
Console.WriteLine();
// Пробуем добавить товар с уже существующим Id
try
{
    products.Add(1, new Product { Id = 1, Name = "Флешка", Price = 600, Quantity = 15 });
}
catch (ArgumentException)
{
    Console.WriteLine("Ошибка: товар с Id 1 уже есть");
}

Console.WriteLine();
//Выведи количество товаров через Count.

Console.WriteLine($"Товаров в каталоге: {products.Count}");

Console.WriteLine();
//Очисти словарь через Clear().
products.Clear();
Console.WriteLine($"После Clear: {products.Count}"); // 0