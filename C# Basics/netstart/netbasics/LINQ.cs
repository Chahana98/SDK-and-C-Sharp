// Language Integrated Query

// programming are of two types: Imperative(C,C++,C# etc.)[Procedural , OOP] and Declarative(SQL) [Haskell, SQL]

class LINQ{
    int[] ages = [22,33,44,55,66,77];

    // Find squares of all numbers in age collection
    public void LearnLinq()
    {
        // Imperative
        List<int> squares = [];
        foreach (var age in ages)
        {
            var square = age * age;
            squares.Add(square);
        }
        // Declarative
        var squares = ages.Select(age => age * age);

        // Find odd numbers within ages
        var odds = ages.Where(x => x% 2 == 1);

        // Find cubes of all even numbers
        var even=ages.Where(age => age % 2 == 0).Select(age => age * age * age);

    }
}