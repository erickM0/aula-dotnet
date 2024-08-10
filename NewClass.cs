// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Threading.Tasks;

// namespace Aula_CSharp
// {
//     public class NewClass
//     {
        
//             public static Dictionary<string, int> AverageAgeForEachCompany(List<Employee> employees)
//             {
//                 var averageAgeForEachCompany = new Dictionary<string, int>();
//                 List<string> companyList = new List<string>();

//                 foreach (Employee employee in employees)
//                 {
//                     if(!companyList.Contains(employee.Company)){
//                         companyList.Add(employee.Company);
//                     }
                    
//                 }
//                 foreach(var company in companyList){
//                     averageAgeForEachCompany.Add(company,);
//                 }

                
//                 return averageAgeForEachCompany;
//             }
            
//             // public static Dictionary<string, int> CountOfEmployeesForEachCompany(List<Employee> employees)
//             // {}
            
//             // public static Dictionary<string, Employee> OldestAgeForEachCompany(List<Employee> employees)
//             // {}

//             public static void Main()
//             {   
//                 int countOfEmployees = int.Parse(Console.ReadLine());
                
//                 var employees = new List<Employee>();
                
//                 for (int i = 0; i < countOfEmployees; i++)
//                 {
//                     string str = Console.ReadLine();
//                     string[] strArr = str.Split(' ');
//                     employees.Add(new Employee { 
//                         FirstName = strArr[0], 
//                         LastName = strArr[1], 
//                         Company = strArr[2], 
//                         Age = int.Parse(strArr[3]) 
//                         });
//                 }
                
//                 foreach (var emp in AverageAgeForEachCompany(employees))
//                 {
//                     Console.WriteLine($"The average age for company {emp.Key} is {emp.Value}");
//                 }
                
//                 // foreach (var emp in CountOfEmployeesForEachCompany(employees))
//                 // {
//                 //     Console.WriteLine($"The count of employees for company {emp.Key} is {emp.Value}");
//                 // }
                
//                 // foreach (var emp in OldestAgeForEachCompany(employees))
//                 // {
//                 //     Console.WriteLine($"The oldest employee of company {emp.Key} is {emp.Value.FirstName} {emp.Value.LastName} having age {emp.Value.Age}");
//                 // }
//             }
        
        
//         public class Employee
//         {
//             public string FirstName { get; set; }
//             public string LastName { get; set; }
//             public int Age { get; set; }
//             public string Company { get; set; }
//         }
//     }   
// }