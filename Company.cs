using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datatypes
{
    public class Company(int id,string name)//constructor with arguments
    {
         //easy getter setter metho
        public string StuName { get; set; } =name;
        public int StuID { get; set; } =id;

        /*
        public Company()
        {
            //empty constructor
        }
        */

            //getter setter method 2
           public string StudentName
           {

           get
             {
                return StuName;
             }

            set
             {
              StuName = value;
             }
           }
        
        
            public string getter()
             {
               return StuName;
             }
            
        //getter setter method 3
            public void setter(string name)
            {
            this.StuName = name; 
            }

           //class inside fxn
            public void printInfo()
            {
            Console.WriteLine($"{StuName} : {StuID}");
            }

    }
}
