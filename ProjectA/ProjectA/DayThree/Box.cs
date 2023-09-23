using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*namespace ProjectA.DayThree
{
    internal class Box
    {
        public int Height;
        public int length;
        public int width;

        public Box(int x) //Parent constructor(class and method name same)
        {
            Console.WriteLine("Box Object Created");
        }
        public void Open()
        {
            Console.WriteLine("Box is Open");
        }
        public void Close()
        {
            Console.WriteLine("Box is Closed");
        }
        public override string ToString() [used to convert a value to string]
        {
            return $"Height: {Height}, Length: {length}, Width: {width}";
        }
    }
    internal class WoodenBox : Box //child constructor 
    {
        public int Area;
        public WoodenBox():base(1) 
        {
            Console.WriteLine("Wooden Box Constructor");
        }
        public WoodenBox(int x) : base(x)
        {
            Console.WriteLine("Wooden Box Constructor");
        }
        public WoodenBox(int x, int y) : base(x)
        {
            Console.WriteLine("Wooden Box Constructor");
        }
        public void Move() 
        {
            Console.WriteLine("Wooden Box Shifted");        
        }

    }
    internal class BoxTester
    {
        public static void TestOne()
        {
            Box box = new Box(1);
            box.Height = 10;
            box.width = 5;
            box.length = 20;
            box.Open();
            box.Close();
            String output = box.ToString();
            Console.WriteLine(output);
            //box.Area = 300; 
            //box.Move();
        }

        public static void TestTwo()
        {
            WoodenBox box = new WoodenBox();
            box.Height = 100;
            box.width = 50;
            box.length = 100;
            box.Open();
            box.Close();
            String output = box.ToString();
            Console.WriteLine(output);
            box.Area = 300;
            box.Move();

        }

        public static void TestThree() 
        {
            Box box = new WoodenBox();   
            box.Height = 100;
            box.width = 50;
            box.length = 100;
            box.Open();
            box.Close();
            String output = box.ToString();
            Console.WriteLine(output);
            //box.Area = 300;
            //box.Move();
        }
    }
}*/
