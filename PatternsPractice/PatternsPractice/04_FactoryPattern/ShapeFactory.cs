﻿namespace PatternsPractice._04_FactoryPattern;

public class ShapeFactory
{
    public IShape CreateShape(string shapeType)
    {
        switch (shapeType.ToLower())            
        {
            case "circle":
                return new Circle();
            case "square":
                return new Square();
            case "triangle":
                return new Triangle();
            default:
                throw new ArgumentException("Invalid shape type");
            
        }
    }
}