using System;
using System.Collections.Generic;
using System.Text;

namespace prjFirstApplication
{
    class Organization
    {
      internal  static string OrgName = "LTI"; //static variable
        string City = "Chennai"; //non-static variable
        internal static  void GetOrgDetails()
        {
            int value = 90;
            Console.WriteLine(OrgName);
          //  Console.WriteLine(City); //error it can access only static variable
        }
    }

    class Employee
    {
        
        //Property
        int Eid { get; set; }
        string? Empname { get; set; }
        string? Location { get; set; }
      public  int Salary { get; private set; }

        int Did { get; } //Ready only property

        //Constructor
        //Initialize values for the variables
        Employee()
        {
            Did = 101;
        }

        //Constructor Overloading
        Employee(int Eid,string Empname,string Location,int Sal)
        {
            //This represents current class instance(employee) variable
            this.Eid = Eid;
            this.Empname = Empname;
            this.Location = Location;
            Salary = Sal;

        }

        void DisplayEmployee(Employee emp)
        {
            Console.WriteLine("Eid:{0} || EmppName:{1} || Location:{2} || Salary:{3} || did:{4} ||Orgname:{5}",
                 Eid,Empname,Location,Salary,emp.Did, Organization.OrgName);
        }

       static void Main()
        {
            int Empid,Esalary;
            string ELocation, Ename;
           Employee employee = new Employee();

            //Property
            /*  employee.Eid = 1001;
              employee.Empname = "ANU";
              employee.Location = "Chennai";
              employee.Salary = 670000;
              // employee.Did = 101; //error its read only

              Console.WriteLine("eid:{0}  ename:{1} location:{2} salary:{3} did:{4}",
                  employee.Eid,employee.Empname,employee.Location,employee.Salary,employee.Did);*/
           
            int n = 2;
            //array of objects
            Employee[] employee1 = new Employee[n];
            for (int i=0;i<n;i++)
            { 
            //Constructor
            Console.WriteLine("Enter the Eid");
            Empid = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the name");
            Ename = Console.ReadLine();
            Console.WriteLine("Enter the Location");
            ELocation = Console.ReadLine();
            Console.WriteLine("Enter the Salary");
            Esalary = Convert.ToInt32(Console.ReadLine());

                employee1[i] = new Employee(Empid, Ename, ELocation, Esalary);
            }

            //Employee employee1 = new Employee(Empid,Ename,ELocation,Esalary);

           
            for(int i=0;i<n;i++)
            { 
                employee1[i].DisplayEmployee(employee);
            }

            //calling static method

            Organization.GetOrgDetails();


        }

    }
}
