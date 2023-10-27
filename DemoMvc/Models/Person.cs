using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DemoMvc.Models
{
     [Table("Persons")]
public class Person
{
     //2021050250- Chu Van Hiep

     [Key]
    public string? PersonId { get; set; }
    public String?  FullName { get; set; }
    public string? Address { get; set; }
}}