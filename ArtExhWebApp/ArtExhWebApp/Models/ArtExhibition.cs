using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using ArtExhWebApp.Models;
using System.Linq;
using System.Threading.Tasks;

namespace ArtExhWebApp.Models
{
    public class ArtExhibition
    {
        public int Id { get; set; }

        public int? PaintingId { get; set; }

        public int? ArtistId { get; set; }

        public int? ExhibitionId { get; set; }

        [ForeignKey("PaintingId")]
        public virtual Painting Painting { get; set; }

        [ForeignKey("ArtistId")]
        public virtual Artist Artist { get; set; }

        [ForeignKey("ExhibitionId")]
        public virtual Exhibition Exhibition { get; set; }
    }
}
