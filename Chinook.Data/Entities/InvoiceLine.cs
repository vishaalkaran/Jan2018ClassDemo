namespace Chinook.Data.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class InvoiceLine
    {
        public int InvoiceLineId { get; set; }

        public int InvoiceId { get; set; }

        public int TrackId { get; set; }

        [Column(TypeName = "numeric")]
        public decimal UnitPrice { get; set; }

        public int Quantity { get; set; }

        public virtual Invoice Invoice { get; set; }

        //For some reason this was missing? I added it by hand on Friday March/2/2018 @10:33p
        public virtual Track Track { get; set; }
    }
}
