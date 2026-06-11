using PaintManagementSystem.Enums;
using PaintManagementSystem.Models;

// Testing Classes
PaintSpecification paintSpecification = new PaintSpecification("Pink", 2);
Console.WriteLine(paintSpecification.DisplaySpecification());

PaintProduct paintProduct = new PaintProduct("Love", PaintType.Glossy, paintSpecification, 30);
Console.WriteLine(paintProduct.DisplayInfo());