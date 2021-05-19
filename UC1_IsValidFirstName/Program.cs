using System;

namespace UserRegistration
{
    class Program
    {
        static void Main(string[] args)
        {
            string first_name;
            Console.WriteLine("Welcome To User Registration !");

            var obj_userregistaration = new UserRegistration();


            first_name = obj_userregistaration.FristName();
            if (first_name is null)
                first_name = obj_userregistaration.FristName();


            Console.WriteLine("first name  : " + first_name);
        }
    }
}