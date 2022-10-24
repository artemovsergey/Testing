using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ExerciseClasses
{
    // Variant #11
    // Exercise 1 (2.1)

    public struct Point
    {
        public double x_, y_;
    }

    public class Rectangle
    {
        Point[] vertices = new Point[4];
        double[] edges = new double[4];

        public Rectangle() { }
        public Rectangle(double[] x, double[] y)
        {
            SetVertices(x, y);
        }

        public void SetVertices(double[] x, double[] y)
        {
            for (int i = 0; i < vertices.Length; i++)
            {
                vertices[i].x_ = x[i];
                vertices[i].y_ = y[i];
            }
            CalculateEdges();
        }

        public bool IsRectangle()
        {
            return (Math.Pow(edges[0], 2) + Math.Pow(edges[1], 2) == DiagonalSquare()) ? true : false;
        }

        public double[] CalculateEdges()
        {
            edges[0] = Math.Sqrt(Math.Pow((vertices[1].x_ - vertices[0].x_), 2) + Math.Pow((vertices[1].y_ - vertices[0].y_), 2));
            edges[1] = Math.Sqrt(Math.Pow((vertices[2].x_ - vertices[1].x_), 2) + Math.Pow((vertices[2].y_ - vertices[1].y_), 2));
            edges[2] = Math.Sqrt(Math.Pow((vertices[3].x_ - vertices[2].x_), 2) + Math.Pow((vertices[3].y_ - vertices[2].y_), 2));
            edges[3] = Math.Sqrt(Math.Pow((vertices[0].x_ - vertices[3].x_), 2) + Math.Pow((vertices[0].y_ - vertices[3].y_), 2));

            if (!IsRectangle())
                throw new ArgumentException("\n ERROR! The points do not form a rectangle!");
            return new double[4] { edges[0], edges[1], edges[2], edges[3] };
        }

        public double DiagonalSquare()
        {
            return Math.Pow(edges[0], 2) + Math.Pow(edges[1], 2);
        }
    }

    // Exercise 2 (2.3)

    public class ArrayProcessor
    {
        public static int[] SortAndFilter(int[] a)
        {
            int[] arr = a;
            return Filter(Sort(arr));
        }

        public static int[] Sort(int[] arr)
        {
            for (int i = 1; i < arr.Length; i++)
            {
                for (int j = i; j > 0 && arr[j - 1] > arr[j]; j--)
                {
                    int tmp = arr[j - 1];
                    arr[j - 1] = arr[j];
                    arr[j] = tmp;
                }
            }
            return arr;
        }

        public static int[] Filter(int[] arr)
        {
            List<int> res = new List<int>();
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] >= 0)
                    res.Add(arr[i]);
                else
                    if (!res.Contains(arr[i]))
                    res.Add(arr[i]);
            }
            return res.ToArray();
        }
    }

    // Exercise 3 (3.2)

    public class StringFormatter
    {
        public static string ShortFileString(string path)
        {
            if (path == null)
                throw new NullReferenceException("ERROR!!! String param is Null ");
            if (path == string.Empty) return string.Empty;

            string ext = "", name = "";
            int i = path.Length - 1, j=0;
            path = path.ToUpper();

            while (path[i] != '\\') { name += path[i]; i--; }  

            if(name.Contains('.'))
            {
                while (name[j] != '.') { ext += name[j]; j++; }
                name = new string(name.ToCharArray().Reverse().ToArray());
                name = name.Replace($".{ext}", ".TMP");
                return name;
            }
   
            return new string(name.ToCharArray().Reverse().ToArray()) + ".TMP";
        }
    }
}
