using namespace Generics.cl
public class Generics{
    public void Print(int x){
        Console.WriteLine(x);
    }
     public void Print(float x){
        Console.WriteLine(x);
    }
    // <> this refers to generic method
     public void Print<T>(T x){
        Console.WriteLine(x);
    }
    public void Print(){
        Print<string>("hhh");
        Print<int>(566);
        Print<decimal>(66.8m);

        List<int> marks = [24,45,60, 30];
        marks.Add(89);
    }
}