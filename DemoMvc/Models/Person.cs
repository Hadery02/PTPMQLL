using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DemoMvc.Models
{
     [Table("Persons")]
public class Person
{
     //2021050250- Chu Van Hiep

     [Key]
     [Required(ErrorMessage ="vui long nhap thong tin")]
    public string? PersonId { get; set; }
    [Required(ErrorMessage ="vui long nhap thong tin")]
    public string?  FullName { get; set; }
    [Required(ErrorMessage ="vui long nhap thong tin")]
    public string? Address { get; set; }
    
}}