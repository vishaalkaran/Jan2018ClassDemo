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
    [Table("Tracks")] //sql name
    public class Track //private as deflaut
    {
        [Key]
        public int TrackId { get; set; }

        [StringLength(120, ErrorMessage = "Composer name has a max of 120 characters")]
        public string Name { get; set; }

        public int AlbumId { get; set; }
        public int MediaTypeId { get; set; }
        public int GenreId { get; set; }

        [StringLength(120, ErrorMessage = "Composer name has a max of 120 characters")]
        public string Composer { get; set; }

        public int Milliseconds { get; set; }
        public int Bytes { get; set; }
        public decimal UnitPrice { get; set; }

        //navigational properties
        //Think ERD relationships
        public virtual Album Album { get; set; }
    }
}
