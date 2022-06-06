using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using ArtExhWebApp.Models;
using System.Linq;
using System.Threading.Tasks;

namespace ArtExhWebApp.Models
{
    public class Exhibition
    {
        private const string ERR_REQ = "Поле необхідно заповнити";

        public Exhibition()
        {
            ArtExhibitions = new HashSet<ArtExhibition>();
        }

        public int Id { get; set; }

        [Required(ErrorMessage = ERR_REQ)]
        [Display(Name = "Назва")]
        public string Name { get; set; }

        [Required(ErrorMessage = ERR_REQ)]
        [Display(Name = "Місце проведення")]
        public string Location { get; set; }

        [Required(ErrorMessage = ERR_REQ)]
        [Display(Name = "Ціна")]
        public decimal Price { get; set; }

        [Required(ErrorMessage = ERR_REQ)]
        [Display(Name = "Дата проведення")]
        public DateTime Date { get; set; }

        public virtual ICollection<ArtExhibition> ArtExhibitions { get; set; }
    }
}
