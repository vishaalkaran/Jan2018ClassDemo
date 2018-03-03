using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#region Additional Namespaces
using Chinook.Data.Entities;
using Chinook.Data.DTOs;
using Chinook.Data.POCOs;
using ChinookSystem.DAL;
using System.ComponentModel;
#endregion

namespace ChinookSystem.BLL
{
    [DataObject]
    class AlbumController
    {
        //list
        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public List<Album> Album_List()
        {
            using (var context = new ChinookContext())
            {
                return context.Albums.ToList();
            }
        }

        //get/play
        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public Album Album_Get(int albumid)
        {
            using (var context = new ChinookContext())
            {
                return context.Albums.Find(albumid);
            }
        }

        //add
        [DataObjectMethod(DataObjectMethodType.Insert, false)]
        public int Album_Add(Album item)
        {
            using (var context = new ChinookContext())
            {
                context.Albums.Add(item);
                context.SaveChanges();
                return item.AlbumId;
            }
        }

        //update
        [DataObjectMethod(DataObjectMethodType.Update, false)]
        public int Album_Update(Album item)
        {
            using (var context = new ChinookContext())
            {
                context.Entry(item).State = System.Data.Entity.EntityState.Modified;
                return context.SaveChanges();
            }
        }

        //delete 
        [DataObjectMethod(DataObjectMethodType.Delete, false)]
        public void Albums_Delete(Album item)
        {
            Albums_Delete(item.AlbumId);
        }

        public void Albums_Delete(int albumid)
        {
            using (var context = new ChinookContext())
            {
                var existing = context.Albums.Find(albumid);
                if (existing == null)
                {
                    throw new Exception("Album does not exists on file.");
                }
                context.Albums.Remove(existing);
                context.SaveChanges();
            }
        }

        //[DataObjectMethod(DataObjectMethodType.Select, false)]
        //public List<SelectionList> List_AlbumTitles()
        //{
        //    using (var context = new ChinookContext())
        //    {
        //        var results = ;
        //        return results.ToList();
        //    }
        //}
    }
}
