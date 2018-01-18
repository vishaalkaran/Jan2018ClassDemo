using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Don's style
#region Additional Namespaces 
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
#endregion

namespace Chinook.Data.Entities
{
    [Table("Albums")] //sql name
    public class Album //private as deflaut
    {
        [Key]
        public int AlbumId { get; set; }

        [Required(ErrorMessage = "Must supply title")]
        [StringLength(160, ErrorMessage = "Album title has a max of 120 characters")]
        public string Title { get; set; }

        public int ArtistId { get; set; }
        public int ReleaseYear { get; set; }

        [StringLength(160, ErrorMessage = "Label anme has a max of 50 characters")]
        public string ReleaseLabel { get; set; }

        //navigational properties
        //Think ERD relationships
        public virtual Artist Artist { get; set; }
        public virtual ICollection<Track> tracks { get; set; }

    }
}
