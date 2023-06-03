using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;



namespace LINQ_Snippet
{
    public class Snippets
    {
        static public void BasicLinQ()
        {
            string[] cars =
            {
               "VW Golf",
               "VW California",
               "Audi A3",
               "Audi A5",
               "Fiat Punto",
               "Seat Ibiza",
               "Seat Leon"
            };

            //1. haremos un select de toda la lista
            var carlist = from car in cars select car;
            foreach (var car in carlist)
            {
                Console.WriteLine(car);
            }

            //2. SELECT WHERE
            var audiList = from car in cars
                           where car.Contains("Audi")
                           select car;
            foreach (var audi in audiList)
            {
                Console.WriteLine(audi);
            }

        }


        //Number Examples
        static public void NumbersLinQ()
        {
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            //each number multiplied by 3
            //take all numbers but not 9
            //Order numbers by asending value

            var processedNumberList = numbers
                .Select(num => num * 3)
                .Where(num => num != 9)
                .OrderBy(num => num);
        }

        static public void SearchExamples()
        {
            List<string> textList = new List<string>
            {
                "a",
                "bx",
                "b",
                "y",
                "cj",
                "f",
                "c"
            };

            //1.First of all elements
            var first = textList.First();

            //2.First element with "c" character
            var cText = textList.First(text => text.Equals("c"));

            //3.First element that contains J character
            var jText = textList.First(text => text.Contains("j"));

            //4. First element that cointains z or default value
            var firstOrDefault = textList.FirstOrDefault(text => text.Contains("z"));

            //5. Last element with z or default
            var lastOrDefault = textList.LastOrDefault(text => text.Contains("z"));

            //6. Single value
            var uniqueText = textList.Single();
            var singleOrDefault = textList.SingleOrDefault();

            int[] evenNumbers = { 0, 2, 4, 6, 8 };
            int[] otherEvenNumbers = { 0, 2, 6 };

            //Obtain 4 and 8

            var myEvenNumber = evenNumbers.Except(otherEvenNumbers);
        }


        static public void MultipleSelect()
        {
            string[] myOpinions =
            {
                "Opinion 1: text 1",
                "Opinion 2: text 2",
                "Opinion 3: text 3",
                "Opinion 4: text 4",
                "Opinion 5: text 5"
            };

            var myOpinionSelection = myOpinions.SelectMany(Opinion => Opinion.Split(","));

            var enterprises = new[]
            {
                new Enterprise()
                {
                    Id = 1,
                    Name = "Enterprise 1",
                    Employees = new[]
                    {
                        new Employee()
                        {
                            Id=1,
                            Name = "Martin",
                            Email = "Martin123@gmail.com",
                            Salary = 1000
                        },
                        new Employee()
                        {
                            Id=2,
                            Name = "Juanjo",
                            Email = "Juanjo123@gmail.com",
                            Salary = 1100
                        },
                        new Employee()
                        {
                            Id=3,
                            Name = "Jorge",
                            Email = "Jorge123@gmail.com",
                            Salary = 1500
                        },
                        new Employee()
                        {
                            Id=4,
                            Name = "Maria",
                            Email = "Maria123@gmail.com",
                            Salary = 1200
                        },
                    }
                },
                new Enterprise()
                {
                    Id = 2,
                    Name = "Enterprise 2",
                    Employees =new[]
                    {
                        new Employee()
                        {
                            Id=5,
                            Name = "Marisa",
                            Email = "Marisa123@gmail.com",
                            Salary = 1500
                        },
                        new Employee()
                        {
                            Id=6,
                            Name = "Juana",
                            Email = "juanita456@gmail.com",
                            Salary = 1700
                        },
                        new Employee()
                        {
                            Id=7,
                            Name = "Nestor",
                            Email = "Nestor789@gmail.com",
                            Salary = 1400
                        },
                        new Employee()
                        {
                            Id=8,
                            Name = "Alberto",
                            Email = "AlbertitoInflacion@gmail.com",
                            Salary = 4000
                        },
                    }
                }
            };

            //Obtain all employee of all enterprises
            var employeeList = enterprises.SelectMany(enterprise => enterprise.Employees);
            bool hasEnterprises = enterprises.Any();
            bool hasEmployees = enterprises.Any(enterprise => enterprise.Employees.Any());

            //All enterprises at least has an employee with more than 1000 of salary
            bool hasEmployeeWithSalaryMoreThan1000 =
                enterprises.Any(enterprise => enterprise.Employees.Any(employee => employee.Salary >= 1000);

        }



        static public void linqCollections()
        {
            var firstList = new List<string>() { "a", "b", "c", "d", "m", "h" };
            var secondList = new List<string>() { "b", "d", "c", "z", "x", "y" };

            //INNER JOIN
            var commonResult = from element in firstList
                               join secondElement in secondList
                               on element equals secondElement
                               select new { element, secondElement };

            var commonResult2 = firstList.Join(
                                secondList,
                                element => element,
                                secondElement => secondElement
                                (secondElement, secondElement) => new { element, secondElement }
                                );

            //OUTER JOIN - LEFT

            var leftOuterJoin = from element in firstList
                                join secondElement in secondList
                                on element equals secondElement
                                into temporalList
                                from temporalElement in temporalList.DefaultIfEmpty()
                                where temporalElement != temporalElement
                                select new { Element = element };

            var leftOuterJoin2 = from element in firstList
                                 from secondElement in secondList.Where(s => s == element).DefaultIfEmpty()
                                 select new { Element = element, SecondElement = secondElement };


            //OUTER JOIN RIGHT
            var rightOuterJoin = from secondElement in secondList
                                 join element in firstList
                                 on secondElement equals element
                                 into temporalList
                                 from temporalElement in temporalList.DefaultIfEmpty()
                                 where temporalElement != temporalElement
                                 select new { Element = secondElement };


            //union
            var unionList = leftOuterJoin.Union(rightOuterJoin);

        }

        static public void SkipTakeLinq()
        {
            var myList = new[]
            {
                1,2,3,4,5,6,7,8,9,10
            };


            var skipTwoFirstValues = myList.Skip(2);
            var skipTwoLastValues = myList.SkipLast(2);
            var skipWhile = myList.SkipWhile(num => num < 4);


            //TAKE
            var takeFirstTwoValues = myList.Take(2);
            var takeLastTwoValues = myList.TakeLast(2);
            var takeSmallerThanFour = myList.TakeWhile(num => num < 4);
        }
    }
}