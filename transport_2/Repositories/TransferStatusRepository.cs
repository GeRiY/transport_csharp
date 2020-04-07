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
    class transferStatusRepository : IDisposable
    {
        private transportEntityContext db = new transportEntityContext();
        private int _totalItems;

        public BindingList<transfer_status> GetAllStatus(
            int page = 0,
            int itemsPerPage = 0,
            string search = null,
            string sortBy = null,
            bool ascending = true)
        {
            var query = db.transfer_status.OrderBy(x => x.id).AsQueryable();

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
                        query = ascending ? query.OrderBy(x => x.name) : query.OrderByDescending(x => x.name);
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

            return new BindingList<transfer_status>(query.ToList());
        }

        public int Count()
        {
            return _totalItems;
        }

        public void Insert(transfer_status status)
        {
            if (db.transfer_status.Any(x => x.name == status.name))
            {
                throw new Exception("A megadott felhasználónév már foglalt!");
            }
            db.transfer_status.Add(status);
        }

        public void Delete(int id)
        {
            var status = db.transfer_status.Find(id);
            db.transfer_status.Remove(status);
        }

        public void Update(transfer_status param)
        {
            var status = db.fos_user.Find(param.id);
            if (status != null)
            {
                db.Entry(status).CurrentValues.SetValues(param);
            }
        }

        public bool Exists(transfer_status status)
        {
            return db.transfer_status.Any(x => x.id == status.id);
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
