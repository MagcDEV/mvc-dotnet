using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace mvc_dotnet.Models;
public class Category
{
    public int Id { get; set; }
    [Required]
    public required string Name { get; set;} 
    [DisplayName("Display Order")]
    [Range(1,100,ErrorMessage ="Display Order must be between 1 and 100 only!!")]
    public int DisplayOrder { get; set; }
    public DateTime CreatedDateTime { get; set; } = DateTime.Now;

}