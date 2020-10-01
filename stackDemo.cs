using System;
using System.Collections;

namespace fundamentals
{
    class stackDemo
    {
        private static void Main(string[] args)
        {
            Stack st = new Stack();
            string s1 = "hiii";
            string s2 = "hello";
            st.Push(5);
            st.Push(6);
            st.Push(s1);  //push in stack
            st.Push(s2);
            //foreach loop
            foreach (var ie in st)
            {                                             //use var in for loop with stack object
                Console.WriteLine(ie);                    //retrieving from stack 

            }

            if (st.Contains(6))                           // contains function in stack
                Console.WriteLine("Contains");

            Console.WriteLine(st.Peek());                //peek function in stack

            Console.WriteLine(st.Pop().ToString());      //pop function in stack 
        }
    }

}
