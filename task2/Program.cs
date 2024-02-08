

using task2;

double radius = 3;
double length = 2;
double width = 4 ;
double bas = 5;
double height = 2;
double side1 = 3;
double  side2 = 4;
double side3 = 5;


System.Console.WriteLine(Circle.CalcCircleArea(radius));


System.Console.WriteLine(Circle.CalcCirclePerimeter(radius));

System.Console.WriteLine($"----------------");

System.Console.WriteLine(Rectangle.CalcRectangleArea(length,width));



System.Console.WriteLine(Rectangle.CalcRectanglePerimeter(length,width));



System.Console.WriteLine($"--------------");


System.Console.WriteLine(Triangle.CalcTriangleArea(bas,height));
System.Console.WriteLine(Triangle.CalcTrianglePerimeter(side1,side2,side3));