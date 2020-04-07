using transport_2.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace transport_2.Repositories
{
    class userRepository : IDisposable
    {
        private transportEntityContext db = new transportEntityContext();
        private int _totalItems;

        public BindingList<fos_user> GetAllUser(
            int page = 0,
            int itemsPerPage = 0,
            string search = null,
            string sortBy = null,
            bool ascending = true)
        {
            var query = db.fos_user.OrderBy(x => x.id).AsQueryable();

            // Keresés
            if (!string.IsNullOrWhiteSpace(search))
            {
                search = search.ToLower();

                //double fogyasztas;
                //double.TryParse(search, out fogyasztas);
                //if (fogyasztas > 0)
                //{
                //    query = query.Where(x => x.fogyasztas.Value.Equals(fogyasztas));
                //}
                //else
                //{
                //    query = query.Where(x => x.rendszam.ToLower().Contains(search) ||
                //                         x.tipus.ToLower().Contains(search) ||
                //                         x.modell.ToLower().Contains(search));
                //}
            }

            // Sorbarendezés
            if (!string.IsNullOrWhiteSpace(sortBy))
            {
                switch (sortBy)
                {
                    default:
                        query = ascending ? query.OrderBy(x => x.id) : query.OrderByDescending(x => x.id);
                        break;
                    case "username":
                        query = ascending ? query.OrderBy(x => x.username) : query.OrderByDescending(x => x.username);
                        break;
                    case "firstName":
                        query = ascending ? query.OrderBy(x => x.first_name) : query.OrderByDescending(x => x.first_name);
                        break;
                    case "lastName":
                        query = ascending ? query.OrderBy(x => x.last_name) : query.OrderByDescending(x => x.last_name);
                        break;
                    case "role":
                        query = ascending ? query.OrderBy(x => x.role) : query.OrderByDescending(x => x.role);
                        break;
                }
            }

            // Összes találat kiszámítása
            _totalItems = query.Count();

            // Oldaltördelés
            if (page + itemsPerPage > 0)
            {
                query = query.Skip((page - 1) * itemsPerPage).Take(itemsPerPage);
            }

            return new BindingList<fos_user>(query.ToList());
        }

        public int Count()
        {
            return _totalItems;
        }

        public void Insert(fos_user user)
        {
            if (db.fos_user.Any(x => x.username == user.username))
            {
                throw new Exception("A megadott felhasználónév már foglalt!");
            }
            db.fos_user.Add(user);
        }

        public void Delete(int id)
        {
            var user = db.fos_user.Find(id);
            db.fos_user.Remove(user);
        }

        public void Update(fos_user param)
        {
            var user = db.fos_user.Find(param.id);
            if (user != null)
            {
                db.Entry(user).CurrentValues.SetValues(param);
            }
        }

        public bool Exists(fos_user user)
        {
            return db.fos_user.Any(x => x.id == user.id);
        }

        public void Save()
        {
            db.SaveChanges();
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
        }
    }
}
