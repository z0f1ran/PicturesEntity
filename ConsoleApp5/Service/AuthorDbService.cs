using ConsoleApp5.Model.Entity;
using ConsoleApp5.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5.Service
{
    internal class AuthorDbService
    {
        public List<Author> ListAll()
        {
            using (var db = new ApplicationDbContext())
            {
                return db.Author_p.ToList();
            }
        }
        public Author? FindById(int id)
        {
            using (var db = new ApplicationDbContext())
            {
                return db.Author_p.FirstOrDefault(x => x.Id == id);
            }
        }
        public void AddAuthor(Author author)
        {
            using (var db = new ApplicationDbContext())
            {
                db.Author_p.Add(author);
                db.SaveChanges();
            }
        }
        public void RemoveById(int id)
        {
            using (var db = new ApplicationDbContext())
            {
                var deleted = db.Author_p.Where(i => i.Id == id).FirstOrDefault();
                if (deleted != null)
                {
                    db.Remove(deleted);
                    db.SaveChanges();
                }
            }
        }
        public void UpdateAuthor(Author author)
        {
            using (var db = new ApplicationDbContext())
            {
                if (db.Author_p.Where(i => i.Id == author.Id).Count() > 0)
                    db.Author_p.Update(author);
                db.SaveChanges();
            }
        }
    }
}
