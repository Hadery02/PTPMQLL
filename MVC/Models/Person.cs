using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVC.Models
{
     [Table("Person")]
public class Person
{
     //2021050250- Chu Van Hiep

     [Key]
     
    public string? PersonId { get; set; }

    public string?  FullName { get; set; }
  
    public string? Address { get; set; }
    
}}