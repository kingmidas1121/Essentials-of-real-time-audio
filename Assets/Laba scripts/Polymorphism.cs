using System;
using UnityEngine;

public class Polymorphism : MonoBehaviour
{ }
public class Shape
{
    public virtual void Draw()
    {
        Console.WriteLine("Малюємо фігуру");
    }
}
class Circle : Shape
{
    public override void Draw()
    {
        Console.WriteLine("Малюємо круг");
    }
}
class Square : Shape
{
    public override void Draw()
    {
        Console.WriteLine("Малюємо квадрат");
    }
}
public class DrawningFigures
{
    public Shape[] shapes;
    public Shape[] CreateShapes()
    {
        shapes = new Shape[2];
        shapes[0] = new Circle();
        shapes[1] = new Square();
        return shapes;
    }
    public void DowncastAccess()
    {
        shapes = new Shape[2];
        Circle circle = shapes[0] as Circle;
        circle.Draw();
        Square square = (Square)shapes[1];
        square.Draw();
    }

    public void UsingTypeChecking()
    {
        shapes = new Shape[2];
        if (shapes[0] is Circle)
        {
            Circle circle = shapes[0] as Circle;
            circle.Draw();
        }
        if (shapes[1] is Square)
        {
            Square square = (Square)shapes[1];
            square.Draw();
        }
    }
}
