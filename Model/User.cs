using System.ComponentModel.DataAnnotations;

namespace LatihanAPI.Models
{
    public class User {

    [Key]

    public int UserID { get; set;}
    public int Age { get; set;}
    public int UserName { get; set;}
    public int FullName { get; set;}
    public int Address { get; set;}
    }
}