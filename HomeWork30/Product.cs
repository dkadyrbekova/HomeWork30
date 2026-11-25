namespace Lesson30;

public class Product
{
    public required int Id { get; set; }
    public required string Name { get; set; }
    public required decimal Price { get; set; }
    public required int Quantity { get; set; }

    public override string ToString() => $"[{Id}] {Name}: {Price} сом, {Quantity} шт.";
}
//или через  return после переопределения метода ToString();