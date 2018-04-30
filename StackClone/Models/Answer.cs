using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StackClone.Models
{

    [Table("Answers")]
    public class Answer
    {
        [Key]
        public int AnswerId { get; set; }
        public string Name { get; set; }
        public string Content { get; set; }
        public int PostId { get; set; }
        public virtual Answer Answers { get; set; }
    }
}
