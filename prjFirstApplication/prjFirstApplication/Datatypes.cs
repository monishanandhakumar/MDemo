using System;
using System.Collections.Generic;
using System.Text;

namespace prjFirstApplication
{
    class Datatypes
    {
        /*accessspecifier returntype methodname(parameterlist){code}*/
        void Types()
        {
            String name;
            int age;
            float salary=67900.89f;
            Console.WriteLine("Enter the Name" );
            name= Console.ReadLine();
            Console.WriteLine("Enter the Age");
            age =Convert.ToInt32(Console.ReadLine());
                                    //placeholder
            Console.WriteLine("Name:{0}  && Age: {1} && Salary:{2}",name,age,salary);
        }
        void TypeConversion()
        {
            //Implicit type conversion and Expilicit

            //Implicit type conversion
            //int<float<double
            int num = 100;
            float petrol = num;
            double disel = petrol;
            Console.WriteLine("Implicit type conversion:{0}",disel);

            //Explicit type Conversion

            //trainees


        }
        void BoxingandUnboxing()
        {
            //converting value type to reference type is boxing 
            //Converting reference type to value type
            int salary = 20000; //value type
            Object obj = salary;  //converting int to object --boxing
            int number =(int) obj; //reference type to value type //unboxing
            Console.WriteLine("BoxingandUnboxing:{0}",number);

        }

        void NullableTypes()
        {
            //Value Nullable Type
            //int age1 = null;
            int? age = null; //nullable type

            int a;string s;
           // Console.WriteLine(a+" "+s);
            Console.WriteLine("Age is {0}",age??0);
            //Reference nullable type
            string? City = null;
            Console.WriteLine(City);
            Console.WriteLine("city is {0}",City??"chennai");
        }
        static void Main()
        {
                                   //creats memory 
            Datatypes datatypes = new Datatypes();
            datatypes.Types();
            Console.WriteLine("------------------------");
            datatypes.TypeConversion();
            Console.WriteLine("------------------------");
            datatypes.BoxingandUnboxing();

            datatypes.NullableTypes();

        }
    }
}
