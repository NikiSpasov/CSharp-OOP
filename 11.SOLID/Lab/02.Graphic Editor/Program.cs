namespace _02.Graphic_Editor
{
    public class Program
    {
        public static void Main()
        {

            IShape sq = new Square();
            GraphicEditor gr = new GraphicEditor();
            gr.DrawShape(sq);
        }
    }
}
