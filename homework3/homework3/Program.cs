using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace homework3
{
    //抽象图表接口：抽象产品类
    public interface Graphical{
        void Area();
    }

    //三角形：具体产品类
    class Triangle : Graphical
    {
        int a, b, c;

        public void Area()
        {
            int p = (a + b + c) / 2;
            double s = p * (p - a) * (p - b) * (p - c);
            Console.WriteLine("三角形面积的平方为:" +s);
        }

        public Triangle(int a,int b,int c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
            Console.WriteLine("创建了一个三角形，三边为:{1},{2},{3}",a,b,c);
        }
    }

    //圆形：具体产品类
    class Circle : Graphical
    {
        int r;
        public void Area()
        {
            double s = 3.14 * r * r;
            Console.WriteLine("圆形的面积为:" + s);
        }

        public Circle(int r)
        {
            this.r = r;
            Console.WriteLine("创建了一个圆形，半径为:" + r);
        }
    }

    //正方形：具体产品类
    class Square : Graphical
    {
        int a;
        public void Area()
        {
            int s = a * a;
            Console.WriteLine("正方形的面积为:" + s);
        }

        public Square(int a)
        {
            this.a = a;
            Console.WriteLine("创建了一个正方形，边长为:" + a);
        }
    }

    //长方形：具体产品类
    class Rectangle : Graphical
    {
        int a, b;
        public void Area()
        {
            int s = a * b;
            Console.WriteLine("长方形的面积为:" + s);
        }

        public Rectangle(int a,int b)
        {
            this.a = a;
            this.b = b;
            Console.WriteLine("创建了一个长方形，长宽为:{1},{2}",a,b);
        }
    }

    //图表工厂类：工厂类 
    class Shape
    {
        //静态工厂方法
        public static Graphical Create(string type)
        {
            Graphical graphical = null;
            if (type.Equals("Triangle"))
            {
                graphical = new Triangle(3,4,5);
                graphical.Area();
            }
            else if (type.Equals("Circle"))
            {
                graphical = new Circle(3);
                graphical.Area();
            }
            else if (type.Equals("Square"))
            {
                graphical = new Square(3);
                graphical.Area();
            }
            else if (type.Equals("Rectangle"))
            {
                graphical = new Rectangle(3,4);
                graphical.Area();
            }

            return graphical;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Graphical graphical;
            graphical = Shape.Create("Square");//通过静态工厂方法创建产品
        }
    }
}
