using System.Collections;

namespace Datatypes
{
    class Program
    {
        static void Main(String[] args)
        {
            long a1 = 100000000000000000;
            long a2 = 456;
            long a3 = a1 + a2;
            Console.WriteLine("long " + a3);


            float b1 = 3.145f;
            float b2 = 4.567f;
            float b3 = b1 / b2;
            Console.WriteLine("float " + b3);

            double c1 = 3.145;
            double c2 = 4.567;
            double c3 = c1 / c2;
            Console.WriteLine("double " + c3);

            //float to int(explicit)
            float d1 = 3.56f;
            int d2 = (int)d1;
            Console.WriteLine("explicit typ conversn " + d2);

            //int to double(implicit)
            int e1 = 908;
            double e2 = e1;
            Console.WriteLine("Implicit typ conversn " + e2);
            Console.WriteLine(e2.GetType());


            //read line str to int
            Console.WriteLine("enter 2 nos:");
            string f1 = Console.ReadLine();
            string f2 = Console.ReadLine();
            int f3 = Int32.Parse(f1);  //str to int
            int f4 = Int32.Parse(f2);
            Console.WriteLine(f3 + f4);

            //diff ways to print
            string name = "Dharshu";
            int age = 21;
            string place = "pondy";
            Console.WriteLine("Hi I'm " + name + "age is " + age + "place is " + place); //normal concat
            Console.WriteLine("Hi I'm {0} age is {1} place is {2}", name, age, place);//formatting
            Console.WriteLine($"Hi I'm {name} age is {age}\n palce is {place}");//interpolatn
            Console.WriteLine(@"Hi I'm {name} \n age is {age} palce is {place}");//verbatim

            //str manipulatn
            Console.WriteLine(name.ToLower());
            Console.WriteLine(place.ToUpper());
            Console.WriteLine(name.Substring(2));
            string fullName = String.Concat(" " + name, place + " ");
            bool say = String.IsNullOrWhiteSpace(fullName);
            Console.WriteLine(fullName.Trim());
            Console.WriteLine(name.IndexOf('a'));
            Console.WriteLine(say);

            //fxn call and passing value
            Console.WriteLine("Enter preson age:");
            string g1 = Console.ReadLine();
            int personAge;
            bool g2 = int.TryParse(g1, out personAge);
            mall(personAge);

            //switch
            Console.WriteLine("enter colour:");
            string colour = Console.ReadLine();
            switch (colour.ToLower())
            {
                case "green":
                    Console.WriteLine("entered green");
                    break;

                case "red":
                    Console.WriteLine("entered red");
                    break;

                default:
                    Console.WriteLine("Invalid colour");
                    break;

            }

            //array generic
            int[] num = new int[5];
            num[0] = 1;
            num[1] = 2;
            num[2] = 3;
            num[3] = 4;
            num[4] = 5;
            Console.WriteLine("foreach loop res");
            foreach (int i in num)
                Console.WriteLine(i);
            Console.WriteLine("for loop res");
            for (int i = 0; i < num.Length; i++)
            {
                Console.WriteLine(num[i]);
            }

            //arraylist non generic
            ArrayList dataBook = new ArrayList();
            dataBook.Add(20);
            dataBook.Add("Dharshu");
            dataBook.Add(6.78f);
            dataBook.Add(20);
            dataBook.Add(20);
            Console.WriteLine("ArrayList");
            foreach (var item in dataBook)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("After Removing:");
            dataBook.Remove(20);
            dataBook.RemoveAt(2);
            foreach (var item in dataBook)
            {
                Console.WriteLine(item);
            }

            //list genric
            List<int> list1 = new List<int>();
            list1.Add(20);
            list1.Add(56);
            list1.Add(90);
            Console.WriteLine("before list");
            foreach (var item in list1)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("after remove list");
            list1.Remove(20);
            list1.RemoveAt(1);
            foreach (var item in list1)
            {
                Console.WriteLine(item);
            }

            //hashtable non generic
            Hashtable htable = new Hashtable();
            htable.Add(1, "dhar");
            htable.Add(2, "hars");
            htable.Add("ui", "hars");
            Console.WriteLine("before hashtable");
            foreach (DictionaryEntry item in htable)
            {
                Console.WriteLine($"{item.Key} : {item.Value}");
            }
            Console.WriteLine("after delete hashtable");
            htable.Remove("ui");
            foreach (DictionaryEntry item in htable)
            {
                Console.WriteLine($"{item.Key} : {item.Value}");
            }

            //dictionary genric
            Dictionary<int, string> dic = new Dictionary<int, string>();
            Console.WriteLine("added dict");
            dic.Add(1, "vidha");
            dic.Add(2, "figha");
            dic.Add(3, "kidha");
            for (int i = 0; i < dic.Count; i++)
            {
                Console.WriteLine($"{dic.Keys.ElementAt(i)} : {dic.Values.ElementAt(i)} ");
            }
            Console.WriteLine("After del dict");
            dic.Remove(2);
            for (int i = 0; i < dic.Count; i++)
            {
                Console.WriteLine($"{dic.Keys.ElementAt(i)} : {dic.Values.ElementAt(i)} ");
            }

            //stack generic
            Console.WriteLine("Stack");
            Stack<int> st = new Stack<int>();
            st.Push(1);
            st.Push(2);
            st.Push(3);
            st.Push(40);
            Console.WriteLine(st.Peek());
            Console.WriteLine(st.Count());
            while (st.Count > 0)
            {
                Console.WriteLine(st.Pop());

            }

            //queue generic
            Console.WriteLine("Queue");
            Queue<int> qu = new Queue<int>();
            qu.Enqueue(10);
            qu.Enqueue(20);
            qu.Enqueue(30);
            qu.Enqueue(40);
            Console.WriteLine(qu.Count());
            Console.WriteLine(qu.Peek());
            while(qu.Count > 0)
            {
                Console.WriteLine(qu.Dequeue());
            }

            //Class implementatn
            Console.WriteLine("Class implementatn");
            Company comp = new Company(6,"kiyu");
            comp.StuID = 2;
            // comp.stuName = "DHarsh";
            comp.setter("asdfh");
            Console.WriteLine("ID:{0}",comp.StuID);
            Console.WriteLine("Name:{0}",comp.StuName);
            Console.WriteLine("Name:{0}", comp.getter());

            comp.printInfo();

            Company stud = new Company(6, "kiyu");
            stud.printInfo();

            /*----------while having empty constructor in company class----
             Company staff = new Company
            {
                StuID = 26,
                StuName = "thuiou"
            };
            staff.printInfo();  */

            //----------------------acces class in list---------------
            //List<Company> companyDetails = new List<Company>
            //{
            //     new Company(28,"ghpo")
            //     ,
            //  new Company(24,"pfg")
            //   ,
            //   new Company(24,"odh")

            // };
            // foreach (var item in companyDetails)
            //  {
            //     Console.WriteLine("ID:{0},name:{1}", comp.StuID,comp.StuName);
            // }

            //inheritance
            Childclass child = new Childclass(78, "rgft",101,"max",30000);
            //parent class fxn
            child.printInfo();
            child.StuName = "manga";
            //child class fxn
            child.ChildDetails();
            child.PrintChildCompany();
            //interface fxn
            child.feesDetails();

            //multilevel inheritance
            Console.WriteLine("multilevel inheritance");
            Boss bossinfo = new Boss(63,"kertin",210,"fafa",89000);
            //parent class fxn
            bossinfo.printInfo();
            //child class fxn
            bossinfo.ChildDetails();
            bossinfo.PrintChildCompany();
            //interface fxn
            bossinfo.feesDetails();

            //hirearchial inheritance
            Console.WriteLine("hirearchial inheritance");
            Mentor ment = new Mentor("raju",1245,45,"bcoz");
            //parent fxn
            ment.printInfo();
            //mentor fxn
            ment.printMentorInfo();

            //overriding
            //bus class fxn
            Bus businfo = new Bus(6);
            businfo.PrintBusDetails();
            //mini bus class info
            miniBus mini = new miniBus(5);
            mini.PrintBusDetails();

            //override---parent(bus) to child(mini bus)
            Bus overrideMiniBus = new miniBus(5);
            overrideMiniBus.PrintBusDetails();



        }

        public static void mall(int PersonAge)
        {
            if (PersonAge > 10)
            {
                if (PersonAge > 18)
                {
                    Console.WriteLine("Can enter movie");
                }
                Console.WriteLine("Can enter mall");
            }
            else if (PersonAge < 10)
            {
                Console.WriteLine("Cannot enter mall");

            }
            else
            {
                Console.WriteLine("Enter correct age value");

            }
        }
    }
}
