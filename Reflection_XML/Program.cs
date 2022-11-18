using System;
using Lab07_Akopyants;
namespace Reflection_XML
{
    class Program
    {
        static void Main(string[] args)
        {

            {
                Type animal_type = typeof(Animal);
                foreach (var attribute in animal_type.GetCustomAttributes(false))
                {
                    if (attribute is My_attribute myAttr)
                    {
                        Console.Write("Comment in attribute is: ");
                        Console.WriteLine(myAttr.Comment);
                        Console.WriteLine();
                    }
                }
                foreach (var member in animal_type.GetMembers())
                {
                    Console.WriteLine($"{member.DeclaringType} {member.MemberType} {member.Name}");
                }
                Console.WriteLine("===========================");
            }

            {
                Type animal_type = typeof(Cow);
                foreach (var attribute in animal_type.GetCustomAttributes(false))
                {
                    if (attribute is My_attribute myAttr)
                    {
                        Console.Write("Comment in attribute is: ");
                        Console.WriteLine(myAttr.Comment);
                        Console.WriteLine();
                    }
                }
                foreach (var member in animal_type.GetMembers())
                {
                    Console.WriteLine($"{member.DeclaringType} {member.MemberType} {member.Name}");
                }
                Console.WriteLine("===========================");
            }

            {
                Type animal_type = typeof(Lion);
                foreach (var attribute in animal_type.GetCustomAttributes(false))
                {
                    if (attribute is My_attribute myAttr)
                    {
                        Console.Write("Comment in attribute is: ");
                        Console.WriteLine(myAttr.Comment);
                        Console.WriteLine();
                    }
                }
                foreach (var member in animal_type.GetMembers())
                {
                    Console.WriteLine($"{member.DeclaringType} {member.MemberType} {member.Name}");
                }
                Console.WriteLine("===========================");
            }

            {
                Type animal_type = typeof(Pig);
                foreach (var attribute in animal_type.GetCustomAttributes(false))
                {
                    if (attribute is My_attribute myAttr)
                    {
                        Console.Write("Comment in attribute is: ");
                        Console.WriteLine(myAttr.Comment);
                        Console.WriteLine();
                    }
                }
                foreach (var member in animal_type.GetMembers())
                {
                    Console.WriteLine($"{member.DeclaringType} {member.MemberType} {member.Name}");
                }
                Console.WriteLine("===========================");
            }
        }
        
    }
}
