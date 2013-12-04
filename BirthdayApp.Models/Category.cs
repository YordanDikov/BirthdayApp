using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace BirthdayApp.Models
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }

        [Required]
        [StringLength(20,MinimumLength=5,ErrorMessage="The specified name is either too short or too long.")]
        public string Name { get; set; }

        public virtual ICollection<Image> Images { get; set; }

        public Category()
        {
            this.Images = new HashSet<Image>();
        }
    }
}
