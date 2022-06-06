using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using ArtExhWebApp;


namespace ArtExhWebApp.Models
{
    public class Style
    {
            public Style()
            {
                Paintings = new HashSet<Painting>();
            }

            public int Id { get; set; }

            [Required(ErrorMessage = "Поле необхідно заповнити")]
            [Display(Name = "Стиль")]
            public string Name { get; set; }

            public virtual ICollection<Painting> Paintings { get; set; }
        
    }
}
