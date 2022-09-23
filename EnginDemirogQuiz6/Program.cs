//First Clothes
Product Gucci = new Product();
Gucci.Type = "Sweatshirt";
Gucci.Price = "100$";
Gucci.Color = "Black";

//Second Clothes
Product Chanel = new Product();
Chanel.Type = "T-Shirt";
Chanel.Price = "50$";
Chanel.Color = "Red";

//Third Clothes
Product Dior = new Product();
Dior.Type = "T-Shirt";
Dior.Price = "75$";
Dior.Color = "Green";

//Array
Product[] clothes = new Product[] { Gucci, Chanel, Dior };

//For Loop
Console.WriteLine("-------------For-------------");
for (int i = 0; i < clothes.Length; i++)
{
    Console.WriteLine("Clothes Type: "+ clothes[i].Type);
    Console.WriteLine("Clothes Price: "+ clothes[i].Price);
    Console.WriteLine("Clothes Color: "+ clothes[i].Color);
    Console.WriteLine(" ");
}
Console.WriteLine("-------------For-------------");
Console.WriteLine(" ");
//While Loop
Console.WriteLine(" ");
Console.WriteLine("-------------While-------------");
int b = 0;
while (b<3)
{
    Console.WriteLine("Clothes Type: " + clothes[b].Type);
    Console.WriteLine("Clothes Price: " + clothes[b].Price);
    Console.WriteLine("Clothes Color: " + clothes[b].Color);
    Console.WriteLine(" ");
    b++;
}
Console.WriteLine("-------------While-------------");
Console.WriteLine(" ");
//Foreach Loop
Console.WriteLine(" ");
Console.WriteLine("-------------Foreach-------------");
foreach (var item in clothes)
{
    Console.WriteLine("Type: " + item.Type);
    Console.WriteLine("Price: " + item.Price);
    Console.WriteLine("Color: " + item.Color);
    Console.WriteLine(" ");
}
Console.WriteLine("-------------Foreach-------------");


class Product
{
    public string Type { get; set; }
    public string Price { get; set; }
    public string Color { get; set; }
}