using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using ArtExhWebApp.Models;
using System.Linq;
using System.Threading.Tasks;

namespace ArtExhWebApp.Models
{
    public class Artist
    {
        public Artist()
        {
            ArtExhibitions = new HashSet<ArtExhibition>();
        }

        public int Id { get; set; }

        public int CountryId { get; set; }

        [Required(ErrorMessage = "Поле необхідно заповнити")]
        [Display(Name = "Ім\'я")]
        public string Name { get; set; }

        public virtual Country Country { get; set; }

        public virtual ICollection<ArtExhibition> ArtExhibitions { get; set; }
    }
}
