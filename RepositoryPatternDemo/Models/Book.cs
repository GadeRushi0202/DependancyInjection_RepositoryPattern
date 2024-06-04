using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RepositoryPatternDemo.Models
{
    [Table("Book")]  // Map class with table in
    public class Book
    {
        [Key]  // this is primary key col in DB
        public int Id { get; set; }
        [Required]
        public string? Name { get; set; }
        [Required]
        public string? Author { get; set; }
        [Required]
        public int Price { get; set; }


    }

}

