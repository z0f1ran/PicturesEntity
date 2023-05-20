using ConsoleApp5.Model;
using ConsoleApp5.Model.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5.Service
{
    internal class PirctureDbService
    {
        public List<Picture> ListAll()
        {
            using (var db = new ApplicationDbContext())
            {
                return db.Picture_p.ToList();
            }
        }
        public Picture? FindById(int id)
        {
            using (var db = new ApplicationDbContext())
            {
                return db.Picture_p.FirstOrDefault(x => x.Id_p == id);
            }
        }
        public void AddPicture(Picture picture)
        {
            using (var db = new ApplicationDbContext())
            {
                db.Picture_p.Add(picture);
                db.SaveChanges();
            }
        }
        public void RemoveById(int id)
        {
            using (var db = new ApplicationDbContext())
            {
                var deleted = db.Picture_p.Where(i => i.Id_p == id).FirstOrDefault();
                if (deleted != null)
                {
                    db.Remove(deleted);
                    db.SaveChanges();
                }
            }
        }
        public void UpdatePicture(Picture Picture)
        {
            using (var db = new ApplicationDbContext())
            {
                if (db.Picture_p.Where(i => i.Id_p == Picture.Id_p).Count() > 0)
                    db.Picture_p.Update(Picture);
                db.SaveChanges();
            }
        }
    }
}
