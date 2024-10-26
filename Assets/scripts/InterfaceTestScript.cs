using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class InterfaceTestScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Trapezium trapezium = new Trapezium { Base1 = 5, Base2 = 10, Height = 3 };
        Circle circle = new Circle { Radius = 5 };
        Nonagon nonagon = new Nonagon { SideLength = 4 };

        //Debug.Log("Trapezium Area: " + trapezium.CalculateUnknownSides());
        Debug.Log("Trapezium Area: " + trapezium.CalculateArea());
        Debug.Log("Trapezium Perimeter: " + trapezium.CalculatePerimeter());

        Debug.Log("Circle Area: " + circle.CalculateArea());
        Debug.Log("Circle Radius: " + circle.CalculateRadius());
        Debug.Log("Circle Perimeter: " + circle.CalculatePerimeter());

        Debug.Log("Nonagon Area: " + nonagon.CalculateArea());
        Debug.Log("Nonagon Sides: " + nonagon.CalculateNumberOfSides());
        Debug.Log("Nonagon Perimeter: " + nonagon.CalculatePerimeter());  
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

public interface IShape
{
    double CalculateArea();
    double CalculatePerimeter();
}

public class Trapezium : IShape
{
    public double Base1 { get; set; }
    public double Base2 { get; set; }
    public double Height { get; set; }
    public double Side1 { get; set; }
    public double Side2 { get; set; }

    //public double 

    public void CalculateUnknownSides()
    {

    }

    public double CalculateArea()
    {
         return 0.5 * Height * (Base1 + Base2);
    }

    public double CalculatePerimeter()
    {
        return Base1 + Base2 + Side1 + Side2;
    }
}

public class Circle : IShape
{
    public double Radius { get; set; }
    public double CalculateArea()
    {
       return Math.PI * Radius * Radius; 
    }

    public double CalculateRadius()
    {
        return Radius;
    }

    public double CalculatePerimeter()
    {
        return 2 * Math.PI * Radius;
    }
}

public class Nonagon : IShape
{
    public double SideLength { get; set; }
    int numberOfSides =9;

    public double CalculateArea()
    {
         return (9.0 / 4.0) * SideLength * SideLength * Math.Tan(Math.PI / 9.0);
    }
        
    

    public double CalculatePerimeter()
    {
         return 9 * SideLength;
    }

    public int CalculateNumberOfSides()
    {
        return numberOfSides;
    }
}
