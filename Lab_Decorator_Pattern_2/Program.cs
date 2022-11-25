using Lab_Decorator_Pattern_2;

ConcreteAuto auto = new(100, 150) { Title = "Mercedes", Model = "ML500", NumberRegistration = "AA5632BH"};
Console.WriteLine($"The base info of auto:\n{auto}");
DiscountAutoDecorator discountAutoDecorator = new(auto, 10, 25);
Console.WriteLine($"\nThe info of auto after receiving discount:\n{discountAutoDecorator}");
DataOfClientDecorator dataOfClientDecorator = new(auto, "Svit", "Lana", "AH5632698");
Console.WriteLine(dataOfClientDecorator);
