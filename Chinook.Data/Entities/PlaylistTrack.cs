namespace Chinook.Data.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PlaylistTrack
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int PlaylistId { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int TrackId { get; set; }

        public int TrackNumber { get; set; }

        public virtual Playlist Playlist { get; set; }

        //For some reason this was missing? I added it by hand on Friday March/2/2018 @10:33p
        public virtual Track Track { get; set; }
    }
}
