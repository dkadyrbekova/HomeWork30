//using System.Xml.Linq;
//Задание 3. Телефонная книга (Индексаторы) ⭐⭐⭐
//Создай класс PhoneBook, который хранит контакты.
//Каждый контакт содержит:
//Name
//PhoneNumber
//Требования:
//Внутри класса используй List<Contact>.
//Реализуй индексатор, принимающий int index.
//Реализуй второй индексатор, принимающий string name.
//Первый индексатор должен позволять получать и изменять контакт по позиции.
//Второй индексатор должен позволять получать контакт по имени.
//Если контакт с указанным именем отсутствует, выбрасывай исключение.
//Добавь методы Add() и Remove().
//При получении контакта по имени учитывай регистр символов.

using task3;

var book = new PhoneBook();
book.Add(new Contact { Name = "Айбек", PhoneNumber = "+996 555 111 222" });
book.Add(new Contact { Name = "Дина", PhoneNumber = "+996 700 333 444" });

// по индексу: получить и изменить
Console.WriteLine(book[0].Name);
book[1] = new Contact { Name = "Аида", PhoneNumber = "+996 777 555 666" };
Console.WriteLine(book[1].Name);

// по имени
Console.WriteLine(book["Айбек"].PhoneNumber);

// регистр важен
try
{
    Console.WriteLine(book["айбек"].PhoneNumber);
}
catch (KeyNotFoundException ex)
{
    Console.WriteLine(ex.Message);
}

// выход за границы
try
{
    Console.WriteLine(book[10].Name);
}
catch (IndexOutOfRangeException ex)
{
    Console.WriteLine(ex.Message);
}

// удаление по имени
book.Remove("Айбек");
Console.WriteLine($"Контактов: {book.Count}");

// удаление несуществующего
try
{
    book.Remove("Айбек");
}
catch (KeyNotFoundException ex)
{
    Console.WriteLine(ex.Message);
}