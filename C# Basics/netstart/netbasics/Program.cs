// top level statement
// Student s1=new();
// Student s2=new();
// Student s3=new();
// Student s4=new();

// s1.name="Laxman";
// s1.address="Ktm";
// s1.roll=33;
// s1.dob=new DateTime(1999,10,20);

// Console.WriteLine($"{s1.name} {s1.address} {s1.roll} {s1.dob}");
// Animal a1=new();
// Animal a2=new();
// Console.WriteLine($"{a1.name="Cat"} {a1.type="Pet"} {a1.scientificname="Felis catus"} {a1.weight=5} {a1.bodycolor="gray"}");
// Console.WriteLine($"{a1.name="Tiger"} {a1.type="Wild"} {a1.scientificname="Panthera tigris"} {a1.weight=40} {a1.bodycolor="orange with black stripes"}");

// var rec1=new Rectangle(22.5,11.5);
// var p=rec1.GetPerimeter();
// var a=rec1.GetPerimeter();

// var sqr1=new Square(22.5);
// var a=sqr1.GetArea();
// var p=sqr1.GetPerimeter();

// Circle c1=new Circle(2.2);
// double a=c1.GetArea();
// double p=c1.GetPerimeter();
// Console.WriteLine("Area="+a);
// Console.WriteLine("Perimeter="+p);

// var Sphere1= new Sphere(22.55);
// var a=Sphere1.GetArea();
// Console.WriteLine("Area="+a);

 string filePath = @"D:\SDK-and-C-Sharp\C# Basics\netstart\netbasics\People Management\People.csv";

 CSVParser csvParser = new CSVParser();
 csvParser.Parse(filePath);
 csvParser.PrintNames();