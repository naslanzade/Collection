using Collection.Models;
using Service.Services;
using Service.Services.Interface;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;

namespace Collection
{
    class Program
    {
        static void Main(string[] args)
        {



            #region HomeTask1
            //List<Author> author = new List<Author>();
            //author.Add(new Author("Novrasta", "Aslanzade", 25));
            //author.Add(new Author("Ziya", "Nasirov", 38));
            //author.Add(new Author("Ulker", "Namazova", 32));
            //author.Add(new Author("Yevgeniya", "Yelfimpva", 41));

            //var result = author.FindAll(m => m.Age > 40);
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item.Name + " " + item.Surname);
            //}
            #endregion



            #region ClassWorkList



            //DateTime startDate = DateTime.Now.AddDays(2);
            //DateTime endDate = DateTime.Now.AddDays(25);

            //double salary = 2000;

            //IEmployeeService employee = new EmployeeService();

            //int result= employee.GetFilteredEmployeeCount(startDate, endDate, salary);
            //Console.WriteLine(result);




            //int[] arr = { 1, 2, 3, 4 };
            //Console.WriteLine(arr[0]);
            //Console.WriteLine(arr.Length);

            //List<int> numbers = new List<int>();
            //numbers.Add(5);
            //numbers.Add(9);
            //numbers.Add(11);

            //foreach (var item in numbers)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine(numbers.Count);
            //Console.WriteLine(numbers[2]);


            //List<int> numbers = new List<int>();
            //numbers.Add(5);
            //numbers.Add(9);
            //numbers.Add(11);
            //numbers.Add(1);
            //numbers.Add(112);
            //numbers.Add(91);
            //numbers.Add(3);

            //var result = numbers.Contains(5);
            //if (result)
            //{
            //    Console.WriteLine("yes");
            //}


            //List<int> numbers = new List<int>();
            //numbers.Add(5);
            //numbers.Add(9);
            //numbers.Add(11);
            //numbers.Add(1);
            //numbers.Add(112);
            //numbers.Add(91);
            //numbers.Add(3);

            //var result = numbers.Find(m => m > 100);
            //Console.WriteLine(result);


            //List<int> numbers = new List<int>();
            //numbers.Add(5);
            //numbers.Add(9);
            //numbers.Add(11);
            //numbers.Add(111);
            //numbers.Add(112);
            //numbers.Add(91);
            //numbers.Add(3);

            //var result = numbers.FindAll(m => m > 100);
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}


            //List<int> numbers = new List<int>();
            //numbers.Add(5);
            //numbers.Add(9);
            //numbers.Add(11);
            //numbers.Add(111);
            //numbers.Add(112);
            //numbers.Add(91);
            //numbers.Add(3);

            //var result = numbers.FindIndex(m => m > 100);
            //Console.WriteLine(result);

            //List<int> numbers = new List<int>();
            //numbers.Add(5);
            //numbers.Add(9);
            //numbers.Add(11);
            //numbers.Add(111);
            //numbers.Add(112);
            //numbers.Add(91);
            //numbers.Add(3);

            //var result = numbers.FindLastIndex(m => m > 100);
            //Console.WriteLine(result);


            //List<int> numbers = new List<int>();
            //numbers.Add(5);
            //numbers.Add(9);
            //numbers.Add(11);
            //numbers.Add(111);
            //numbers.Add(112);
            //numbers.Add(91);
            //numbers.Add(3);

            //numbers.Sort();
            //foreach (var item in numbers)
            //{
            //    Console.WriteLine(item);
            //}


            //List<int> numbers = new List<int>();
            //numbers.Add(5);
            //numbers.Add(9);
            //numbers.Add(11);
            //numbers.Add(111);
            //numbers.Add(112);
            //numbers.Add(91);
            //numbers.Add(3);

            //var result=numbers.ToArray();
            //var result2 = result.ToList();

            //foreach (var item in numbers)
            //{
            //    Console.WriteLine(item);
            //}



            //List<int> numbers = new List<int>();
            //numbers.Add(5);
            //numbers.Add(9);
            //numbers.Add(11);
            //numbers.Add(111);
            //numbers.Add(112);
            //numbers.Add(91);
            //numbers.Add(3);

            //var result = numbers.BinarySearch(11);

            //Console.WriteLine(result);



            //List<string> names = new List<string>() { "Resul", "Novreste","Gultac","Lale","Nicat" };

            //var result = names.FindAll(m => m == "Nicat");
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}


            //List<int> nums = new List<int>() { 200, 300, 400, 500 };
            //List<int> numbers = new List<int>();
            //numbers.Add(5);
            //numbers.Add(9);
            //numbers.Add(11);
            //numbers.Add(111);
            //numbers.Add(112);
            //numbers.Add(91);
            //numbers.Add(3);

            //numbers.AddRange(nums);

            //foreach (var item in numbers)
            //{
            //    Console.WriteLine(item);
            //}



            //List<string> names = new List<string>() { "Resul", "Novreste", "Gultac", "Lale", "Nicat" };

            //var result = Search(names, "r");
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            //List<string> names = new List<string>() { "Resul", "Novreste", "Gultac", "Lale", "Nicat" };

            //var result = Search(names, "r");
            //Console.WriteLine(result.Count);



            //List<string> names = new List<string>() { "Resul", "Novreste", "Gultac", "Lale", "Nicat" };

            //var result = Search(names, "r");
            //Console.WriteLine(result.Count);



            //List<string> names = new List<string>() { "Resul", "Novreste", "Gultac", "Lale", "Nicat" };

            //var result = Search(names, "r");

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}


            //List<string> names = new List<string>() { "Resul", "Novreste", "Gultac", "Lale", "Nicat" };                      

            //var searchtext = Console.ReadLine();
            //var result = Search(names, searchtext);

            //if (result.Count==0)
            //{
            //    Console.WriteLine("Not found");
            //}
            //else
            //{
            //    foreach (var item in result)
            //    {
            //        Console.WriteLine(item);
            //    }
            //}


            //List<Person> people = new List<Person>();

            //people.Add(new Person { FullName = "Qoshqar Narimanli", Birthday=DateTime.Now.AddDays(-10),Salary=1500});
            //people.Add(new Person { FullName = "Ramil Allahverdiyev", Birthday = DateTime.Now.AddDays(10),Salary=1700});
            //people.Add(new Person { FullName = "Nihat Valiyev", Birthday = DateTime.Now.AddDays(12),Salary=1800});
            //people.Add(new Person { FullName = "Gultac Ceferova", Birthday = DateTime.Now.AddDays(10),Salary=2500});

            //foreach (var person in people)
            //{
            //    Console.WriteLine("FullName : {0},Birthday : {1}, Salary : {2}", person.FullName, person.Birthday, person.Salary);
            //}




            //List<Person> people = new List<Person>();

            //people.Add(new Person { FullName = "Qoshqar Narimanli", Birthday = DateTime.Now.AddDays(-10), Salary = 1500 });
            //people.Add(new Person { FullName = "Ramil Allahverdiyev", Birthday = DateTime.Now.AddDays(10), Salary = 1700 });
            //people.Add(new Person { FullName = "Nihat Valiyev", Birthday = DateTime.Now.AddDays(12), Salary = 1800 });
            //people.Add(new Person { FullName = "Gultac Ceferova", Birthday = DateTime.Now.AddDays(10), Salary = 2500 });


            //var result = people.FindAll(m => m.Salary > 1600);

            //foreach (var person in result)
            //{
            //    Console.WriteLine("FullName : {0},Birthday : {1}, Salary : {2}", person.FullName, person.Birthday, person.Salary);
            //}



            #endregion



            #region ClassWork



            //Hashtable hashtable = new Hashtable();

            //hashtable.Add(1, "Resul");
            //hashtable.Add(2, "Nicat");
            //hashtable.Add(3, "Vugar");

            //foreach (var item in hashtable.Keys)
            //{
            //    Console.WriteLine(item);
            //}


            //Hashtable hashtable = new Hashtable();

            //hashtable.Add(1, "Resul");
            //hashtable.Add(2, "Nicat");
            //hashtable.Add(3, "Vugar");

            //foreach (var item in hashtable.Values)
            //{
            //    Console.WriteLine(item);
            //}


            //Hashtable hashtable = new Hashtable();

            //hashtable.Add(1, "Resul");
            //hashtable.Add(2, "Nicat");
            //hashtable.Add(3, "Vugar");

            //foreach (DictionaryEntry item in hashtable)
            //{
            //    Console.WriteLine(item.Key + " " + item.Value);
            //}





            //SortedList sortedList = new SortedList();

            //sortedList.Add(1, "Resul");
            //sortedList.Add(2, "Nicat");
            //sortedList.Add(3, "Vugar");

            //foreach (DictionaryEntry item in sortedList)
            //{
            //    Console.WriteLine(item.Key + " " + item.Value);
            //}



            //ArrayList arraylist = new ArrayList();

            //arraylist.Add("Salam");
            //arraylist.Add(155);

            //foreach (var item in arraylist)
            //{
            //    Console.WriteLine(item);
            //}




            //SortedList<string, string> list = new SortedList<string, string>();
            //list.Add("Admin", "Qoshqar");
            //list.Add("Member", "Resul");

            //foreach (KeyValuePair<string,string> item in list)
            //{
            //    if (item.Key=="Admin")
            //    {
            //        Console.WriteLine(item.Value);
            //    }
            //}




            //Dictionary<string, string> dictionarylist = new Dictionary<string, string>();
            //dictionarylist.Add("Admin", "Ramil");

            //Console.WriteLine(dictionarylist["Admin"]);



            //Queue<int> queue = new Queue<int>();
            //queue.Enqueue(5);
            //queue.Enqueue(10);
            //queue.Enqueue(3);

            //foreach (var item in queue)
            //{
            //    Console.WriteLine(item);
            //}


            //Stack<int> stack = new Stack<int>();
            //stack.Push(11);
            //stack.Push(22);
            //stack.Push(3);

            //foreach (var item in stack)
            //{
            //    Console.WriteLine(item);
            //}


            #endregion





        }


        //private static List<string> Search(List<string> datas,string str)
        //{
        //    var result = datas.FindAll(m => m.Contains(str));
        //    return result;
        //}




        //private static List<string> Search(List<string> datas, string str)
        //{
        //    var result = datas.FindAll(m => m.ToLower().Contains(str.ToLower()));
        //    return result;
        //}



        //public static int GetEmployeeCount(DateTime start,DateTime end)
        //{

        //    Person person1 = new Person(DateTime.Now.AddDays(5), 3000);
        //    Person person2 = new Person(DateTime.Now.AddDays(15), 6000);
        //    Person person3 = new Person(DateTime.Now.AddDays(10), 1000);
        //    Person person4 = new Person(DateTime.Now.AddDays(25), 2500);

        //    Person[] people = { person1, person2, person3, person4 };


        //    int empCount = 0;
        //    foreach (Person person in people)
        //    {
        //        if ((person.Birthday>start && person.Birthday<end) && person.Salary>2000)
        //        {
        //            empCount++;
        //        }
        //    }
        //    return empCount;
        //}
    }
}
