namespace OOP
{
    public static class ShapeFactory
    {
        public static IShape CreateShape(string shapeType)
        {
            return shapeType switch
            {
                "Rectangle" => new Rectangle(),
                "Circle" => new Circle(),
                _ => throw new ArgumentException("Unknown shape type")
            };
        }
    }
}
