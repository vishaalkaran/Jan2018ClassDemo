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
    [Table("Artists")] //sql name
    public class Artist //private as deflaut
    {
        [Key]
        public int ArtistId { get; set; }

        [StringLength(120, ErrorMessage = "Artist name has a max of 120 characters")]
        public string Name { get; set; }

        //navigational properties
        //Think ERD relationships
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Album> Albums { get; set; }
    }
}
