// program to find area and perimeter of different 2D shapes.
class Rectangle: IShape2D{
    public Rectangle(double l, double b){
        length=l;
        breadth=b;
    }
    double length;
    double breadth;
    public double GetArea()=> length*breadth;
    // or public GetArea(){
    //     return length*breadth;
    // }
    public double GetPerimeter()=> 2*(length+breadth);
}