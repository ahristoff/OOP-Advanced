using System;

namespace P02.Graphic_Editor
{
    class Program
    {
        static void Main()
        {
            //1
            IShape circle = new Circle();
            GraphicEditor myGrphicEditor = new GraphicEditor(circle);

            myGrphicEditor.DrawShape();   
            
            //2
            //IShape rectangle = new Rectangle();
            //GraphicEditor myGrphicEditor = new GraphicEditor();

            //myGrphicEditor.DrawShape(rectangle);
        }
    }
}
