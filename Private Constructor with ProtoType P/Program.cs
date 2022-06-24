using System;

namespace Private_Constructor_with_ProtoType_P
{
    class Program
    {
        private Program()
        {
            Console.WriteLine(" Private Constructor Hii:");
        }

        // opstional 

      /*  public void show()
        {
            Console.WriteLine("Hello :");
        }*/
        public static Program Getobj()
        {
            Program obj = new Program();
            return obj;
        }
    }
    class p { 
        static void Main(string[] args)
        {
            Program obj2 = Program.Getobj();
            Program obj3 = Program.Getobj();
           /* obj2.show();
            obj3.show();*/
        }
    }
}
