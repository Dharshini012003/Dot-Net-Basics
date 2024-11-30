using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datatypes
{
    public class Childclass : Company,Ifees
    {
        //member
        public int ChildID { get; set; }
        public string ChildName { get; set; }

        public int fees { get; set; }

        //constructor
        public Childclass (int StuID, string StuName,int Childid, string Childname,int Fees) : base(StuID, StuName)
        {
            ChildID = Childid;
            ChildName=Childname;
            fees = Fees;
        }

        //fxn
        public void ChildDetails()
        {
            Console.WriteLine($"Child id:{ChildID},Child Name:{ChildName}");
        }

        //fxn2
        public void PrintChildCompany()
        {
            Console.WriteLine($"Child id:{ChildID},Child Name:{ChildName},Stud id:{StuID},Stud Name:{StuName}");
        }

        //fx3--implementing interface
        public void feesDetails()
        {
            Console.WriteLine($"Fees:{fees}");
        }
    }
}
