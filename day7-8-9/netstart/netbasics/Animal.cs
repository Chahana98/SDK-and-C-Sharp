class Animal{
    internal string name;
    internal string type;
    internal string scientificname;
    internal int weight;
    internal string bodycolor; 
    internal void PrintDetails(){
    Console.WriteLine($"{name} {type} {scientificname} {weight} {bodycolor}");
}
}