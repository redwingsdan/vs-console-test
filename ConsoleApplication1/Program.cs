using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApplication1;
using System.IO;

namespace ConsoleApplication1
{
    abstract class Rectangle {
        public abstract int area();     //virtual function can be used too
    }
    class Square : Rectangle
    {
        private int l;
        private int w;
        public Square()
        {
            l = 0;
            w = 0;
        }
        public override int area()
        {
            if(l == 0)
            {
                l = 2;
            }
            if(w == 0)
            {
                w = 2;
            }
            return l * w;
        }
    }

    public interface Cost
    {
        double getCost(double volume);
    }
    class Cube : Shape, Cost
    {
        public Cube()
        {
            length = 0.0;
            width = 0.0;
            height = 0.0;
        }
        public double getCost(double volume)
        {
            return volume * 8;
        }
    }
    class Shape : Program2
    {
        protected double height;
        private double volume;
        public Shape()
        {
            length = 0.0;
            width = 0.0;
            height = 0.0;
        }
        public double getVolume()
        {
            return volume;
        }
        public void setVolume()
        {
            volume = length * width * height;
        }
        public void setHeight(double height)
        {
            this.height = height;
        }
        public double getHeight()
        {
            return height;
        }
        public static Shape operator+ (Shape a, Shape b)
        {
            Shape x = new Shape();
            x.length = a.length + b.length;
            x.width = a.width + b.width;
            x.height = a.height + b.height;
            return x;
        }
    }
    class Program2
    {
        public const int SIZE = 100;
        public static String[] arr = new String[SIZE];
        dynamic var;    //type checking takes place @runtime
        protected double length;
        protected double width;
        public Program2(){
            Console.WriteLine("Created new Program2 object");
            length = 0.0;
            width = 0.0;
        }
        public void setDimens(double x, double y)
        {
            length = x;
            width = y;
        }  
        public double getArea()
        {
            return length * width;
        }
        public double getLength()
        {
            return length;
        }
        public double getWidth()
        {
            return width;
        }
        public dynamic getVar()
        {
            var = (length + width) / 2;
            return var;
        }
    }
    class Executable
    {
        enum State { NONE, Complete, Progress, Unassigned };    //enum is essentially constants for values

        static void Main(string[] args)
        {
            getInput();
            String str = "example.txt";
            FileStream file = new FileStream(str, FileMode.OpenOrCreate, FileAccess.ReadWrite);
            StreamWriter file2 = new StreamWriter(file);
            StreamReader file3 = new StreamReader(file);
            if (file.CanRead)
            {
                String s = file3.ReadLine();
                if (s != null)
                {
                    file2.Close();
                    File.Delete(str);
                    file = new FileStream(str, FileMode.OpenOrCreate, FileAccess.ReadWrite);
                    file2 = new StreamWriter(file);
                }
            }
        
                for (int i = 0; i < 26; i++)
                {
                    String s = Convert.ToString((char)(i + 65));  
                    file2.WriteLine(s);
                }
            file2.Close();
            file.Close();
            FileStream file5 = new FileStream(str, FileMode.OpenOrCreate, FileAccess.ReadWrite);
            StreamReader file4 = new StreamReader(file5);
                for (int i = 0; i < 26; i++)
                {
                    Console.WriteLine(file4.ReadLine());
                }
            file4.Close();
            
            Console.ReadKey();
        }
        public static void getInput()
        {
            Console.WriteLine("hello world");
            Console.Write("Length: ");
            String input = Console.ReadLine();
            //Convert.ToDouble(input);
            double length = Double.Parse(input);
            Console.Write("Width: ");
            input = Console.ReadLine();
            double width = Double.Parse(input);
            Program2 p = new Program2();
            int w = (int)State.Complete;
            p.setDimens(length, width);
            Cube c = new Cube();
            c.setDimens(3, 3);
            c.setHeight(3);
            c.setVolume();
            Console.WriteLine("Cube Volume = {0}", c.getVolume());
            Console.WriteLine("Length = {0}\nWidth = {1}\nArea = {2}\nVar = {3}", p.getLength(), p.getWidth(), p.getArea(), p.getVar());
            dynamic z = p.getVar();
            if (z is double)
            {
                p1();
            }
            else
            {
                p2();
            }
            int row = (int)z;
            if (z is double) {
               p1();
            }
            else
            {
               p2();
            }
            Console.WriteLine("Var = {0}", z);
            Books Book1 = new Books();
            Book1.setValues("1984", "George Orwell", 345, 109091561);
            Book1.display();
            Cube c2 = new Cube();
            c2.setDimens(3, 3);
            c2.setHeight(3);
            c2.setVolume();
            Shape c3 = new Cube();
            c3 = c2 + c;
            c3.setVolume();
            Console.WriteLine("C3 = {0}, {1}, {2}, {3}", c3.getWidth(), c3.getLength(), c3.getVolume(), c3.getHeight());
            Console.ReadKey();
            //recursivePrint("Hello", row);
            //for(int i = row; i > 0; i--)
            //{
            //    Console.WriteLine(Program2.arr[i-1]);
            //}
            primes2(1000000);     //one billion tried -> 1million
        }
        public static void p1()
        {
            Console.WriteLine("is double");
        }
        public static void p2()
        {
            Console.WriteLine("is not double");
        }

        public static int recursivePrint(String str, int rows)
        {
            if(rows == 0)
            {
                return 1;
            }
            else
            {
                int num = recursivePrint(str, (rows - 1));
                String temp = "";
                for (int j = 0; j < num; j++)
                {
                    if (j % 10 == 0 & j != 0)
                    {
                        Console.Write("|");
                        temp += "|";
                    }
                    else if ((j % 5 == 0) & (j != 0) & (j % 10 != 0))
                    {
                        Console.Write("?");
                        temp += "?";
                    }
                    else if ((j % 5 != 0) & (j != 0) & (j % 10 != 0) & (j % 3 == 0))
                    {
                        Console.Write("$");
                        temp += "$";
                    }
                    else if ((j % 5 != 0) & (j != 0) & (j % 10 != 0) & (j % 3 != 0) & (j % 2 == 0))
                    {
                        Console.Write("^");
                        temp += "^";
                    }
                    else if ((j % 5 != 0) & (j != 0) & (j % 10 != 0) & (j % 3 != 0) & (j % 2 != 0) & (j % 7 == 0))
                    {
                        Console.Write("*");
                        temp += "*";
                    }
                    else
                    {
                        Console.Write(" ");
                        temp += " ";
                    }
                }
                Console.WriteLine(str);
                temp += str;
                if (temp != null)
                {
                    Program2.arr[num - 1] = temp;
                }
                return (num + 1);
            }
        }
     /*   public static int primes(int n)
        {
            if (n == 3)
            {
                return n;
            }
            else
            {
                int num = primes((n - 1));
                bool flag = true;
                for (int i = 2; i < num; i++)
                {
                    if(num % i == 0)
                    {
                        flag = false;
                        break;
                    }
                }
                if(flag == true)
                {
                    Console.WriteLine(num);
                }
                return (num+1);
            }
        }
        */
        public static void primes2(long n)
        {
            bool[] arr2 = new bool[n];
            for(long i = 0; i < arr2.Length; i++)
            {
                arr2[i] = true;
            }
            for(long k = 2; k < Math.Sqrt(n); k++)
            {
                if(arr2[k] == true)
                {
                    double res = Math.Pow(k, 2);
                    for (long j = (long)res; j < n; j = j+k)
                    {
                        arr2[j] = false;
                    }
                }
            }
            for(int z = arr2.Length -1000; z < arr2.Length; z++)
            {
                if (arr2[z] == true)
                {
                    Console.WriteLine(z);
                }
            }
          //  for (int z = 0; z < arr2.Length; z++)
          //  {
          //      if(arr2[z] == true){
          //          Console.WriteLine(z);
          //      }
          //  }

           // for (long z = (arr2.Length - 1); z > 1; z--)
           // {
           //     if (arr2[z] == true)
           //     {
           //         Console.WriteLine(z);
           //    }
           // }
        }
    }
    struct Books
    {
        private String name;
        private String author;
        private int pages;
        private int id;
        public void setValues(String name, String author, int pages, int id)
        {
            this.name = name;
            this.author = author;
            this.pages = pages;
            this.id = id;
        }
        public void display()
        {
            Console.WriteLine("Title: {0}\nAuthor: {1}\nPages: {2}\nId: {3}", name, author, pages, id);
        }
    };
}

class Test
{
    static void main(String[] args)
    {
        Shape test = new Shape();
        test.getArea();
    }
}