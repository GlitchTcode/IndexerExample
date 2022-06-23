using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexerExample
{
    internal class University
    {
        public string name;
        public List<Department> departments;// Collection of departments.

        
        public University(string name)
        {
            this.name = name;
            departments = new List<Department>();// initialization 
        }

        // Find Department Info by Name
        public Department getDepartmentInfo(string lookupName)
        {
            foreach(Department d in departments)
            {
                if(d.name == lookupName) // Department exists in the List of Departments.
                {
                    return d;
                }
            }
            Console.WriteLine("This Dept Name does not exist");
            return null;
        }

        // Find department info by ID
        public Department getDepartmentInfo(int lookupID)
        {
            foreach (Department d in departments)
            {
                if (d.deptID == lookupID) // Department exists in the List of Departments.
                {
                    return d;
                }
            }
            Console.WriteLine("This Dept ID does not exist");
            return null;
        }

        public Department this[int deptID]
        {
            get
            {
                foreach (Department d in departments)
                {
                    if (d.deptID == deptID) // Department exists in the List of Departments.
                    {
                        return d;
                    }
                }
                return null;
            }
            set { }
        }
        public Department this[string deptName]
        {
            get
            {
                foreach (Department d in departments)
                {
                    if (d.name == deptName) // Department exists in the List of Departments.
                    {
                        return d;
                    }
                }
                return null;
            }
            set { }
        }
    }
    public class Tester
    {
        /*static void Main(string[] args)
        {
            University univ = new University("Universitat of Saarland");


            univ.departments.Add(new Department{ deptID = 1, name = "Computer Science", address = "75600" });
            univ.departments.Add(new Department { deptID = 2, name = "System Architecture", address = "12600" });
            univ.departments.Add(new Department { deptID = 3, name = "Algorithms", address = "123 ABC" });
            univ.departments.Add(new Department { deptID = 4, name = "Cloud Computing", address = "76 DEF" });

            Department d = univ.getDepartmentInfo(1); // Looking up for deptID = 1
            Console.WriteLine(d.name);
            Console.WriteLine(d.address);
            d = univ.getDepartmentInfo("Cloud Computing");
            Console.WriteLine(d.deptID);
            Console.WriteLine(d.address);
            Console.WriteLine("\n\n\n\n");

            // Use Indexer now;
            d = univ[1];
            Console.WriteLine(d.name);
            Console.WriteLine(d.address);
            
            d = univ["Cloud Computing"];
            Console.WriteLine(d.deptID);
            Console.WriteLine(d.address);

        }*/

    }
}
