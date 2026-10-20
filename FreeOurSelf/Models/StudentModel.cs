using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FreeOurSelf.Models
{
    //[Table("tbl_Students")]
    public class StudentModel
    {
        //[Key]
        public int Id { get; set; }     
        public string? Name { get; set; }
        public int Age { get; set; }
        public string College { get; set; }
        public string EmailId { get; set; }

        
    }
}
