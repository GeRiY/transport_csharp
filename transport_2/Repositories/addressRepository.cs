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
    class addressRepository : IDisposable
    {
        private transportEntityContext db = new transportEntityContext();
        private int _totalItems;

        public BindingList<address> GetAllAddress(
            int page = 0,
            int itemsPerPage = 0,
            string search = null,
            string sortBy = null,
            bool ascending = true)
        {
            var query = db.address.OrderBy(x => x.id).AsQueryable();

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
                    case "city":
                        query = ascending ? query.OrderBy(x => x.city) : query.OrderByDescending(x => x.city);
                        break;
                    case "street_and_number":
                        query = ascending ? query.OrderBy(x => x.street_and_number) : query.OrderByDescending(x => x.street_and_number);
                        break;
                    case "zip_code":
                        query = ascending ? query.OrderBy(x => x.zipcode) : query.OrderByDescending(x => x.zipcode);
                        break;
                    case "is_storage":
                        query = ascending ? query.OrderBy(x => x.is_storage) : query.OrderByDescending(x => x.is_storage);
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

            return new BindingList<address>(query.ToList());
        }

        public int Count()
        {
            return _totalItems;
        }

        public void Insert(address address)
        {
            if (db.address.Any(x => x.street_and_number == address.street_and_number))
            {
                throw new Exception("A megadott cím már létezik!");
            }
            db.address.Add(address);
        }

        public void Delete(int id)
        {
            var address = db.address.Find(id);
            db.address.Remove(address);
        }

        public void Update(address param)
        {
            var address = db.address.Find(param.id);
            if (address != null)
            {
                db.Entry(address).CurrentValues.SetValues(param);
            }
        }

        public bool Exists(address address)
        {
            return db.address.Any(x => x.id == address.id);
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
