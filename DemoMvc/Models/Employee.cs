using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using DemoMvc.Models;
namespace DemoMvc.Models
{
    
public class Employee : Person
{
    //2021050250- Chu Van Hiep
    public string? EmployeeId { get; set; }
    public int Age { get; set; }
}}