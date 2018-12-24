using System;
using System.Collections.Generic;
using System.Text;

namespace P02.Graphic_Editor
{
    public class GraphicEditor
    {
        //1 
        private IShape shape;

        public GraphicEditor(IShape shape)
        {
            this.shape = shape;
        }

        public void DrawShape()
        {
            shape.Draw();
        }

        //2
        //public void DrawShape(IShape shape)
        //{
        //    shape.Draw();
        //}
    }
}
