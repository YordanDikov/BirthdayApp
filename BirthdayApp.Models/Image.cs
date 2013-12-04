using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirthdayApp.Models
{
    public class Image
    {
        [Key]
        public int ImageId { get; set; }
        
        [MaxLength(141, ErrorMessage="The description is too long.")]
        public string Description { get; set; }

        [Required]
        public string Url { get; set; }

        [Required]
        public int CategoryId { get; set; }

        public virtual Category Category { get; set; }
    }
}
