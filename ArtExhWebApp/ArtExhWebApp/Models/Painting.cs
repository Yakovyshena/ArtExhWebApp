using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using ArtExhWebApp.Models;

namespace ArtExhWebApp.Models
{
    public class Painting
    {
        public Painting()
        {
            ArtExhibitions = new HashSet<ArtExhibition>();
        }

        public int Id { get; set; }

        public int StyleId { get; set; }

        [Required(ErrorMessage = "Поле необхідно заповнити")]
        [Display(Name = "Композиція")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Поле необхідно заповнити")]
        [Display(Name = "Лейбл")]

        public virtual Style Style { get; set; }

        public virtual ICollection<ArtExhibition> ArtExhibitions { get; set; }
    }
}
