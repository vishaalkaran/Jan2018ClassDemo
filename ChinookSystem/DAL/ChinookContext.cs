using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//under project/ Chinook.Data 
//System.Data.Entity
//Entity Framework from NuGut
#region Additional Namespaces 
using Chinook.Data.Entities;
using System.Data.Entity;
#endregion

namespace ChinookSystem.DAL
{
    //only acessable inside this project
    internal class ChinookContext : DbContext
    {
        //name holds the name value of your web conneection string
        public ChinookContext() : base("name=ChinookDB")
        {

        }

        //a reference to each table in the database as a virtual data set
        public virtual DbSet<Artist> Artists { get; set; }  //add s to end because it's pural/many
        public virtual DbSet<Album> Albums { get; set; }
        public virtual DbSet<Track> Tracks { get; set; } 
    }
}
