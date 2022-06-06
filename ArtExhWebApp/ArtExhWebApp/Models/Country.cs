using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using ArtExhWebApp.Models;

namespace ArtExhWebApp.Models
{
    public class Country
    {
        public Country()
        {
            Artists = new HashSet<Artist>();
            
        }

        public int Id { get; set; }

        [Required(ErrorMessage = "Поле необхідно заповнити")]
        [Display(Name = "Країна")]
        public string Name { get; set; }

        public virtual ICollection<Artist> Artists { get; set; }
        
    }
}
