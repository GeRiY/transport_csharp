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
    class packageRepository : IDisposable
    {
        private transportEntityContext db = new transportEntityContext();
        private int _totalItems;

        public BindingList<package> GetAllPackage(
            int page = 0,
            int itemsPerPage = 0,
            string search = null,
            string sortBy = null,
            bool ascending = true)
        {
            //var query = db.package.OrderBy(x => x.id).AsQueryable();
            var query = db.package.Where(x => x.courier.Value.Equals(1));  // le kell kérdezni az adott user szállító id-jét
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
                    case "targetAddress":
                        query = ascending ? query.OrderBy(x => x.target_address) : query.OrderByDescending(x => x.target_address);
                        break;
                    case "packageStatus":
                        query = ascending ? query.OrderBy(x => x.package_status) : query.OrderByDescending(x => x.package_status);
                        break;
                    case "transferStatus":
                        query = ascending ? query.OrderBy(x => x.transfer_status) : query.OrderByDescending(x => x.transfer_status);
                        break;
                    case "handler":
                        query = ascending ? query.OrderBy(x => x.handler) : query.OrderByDescending(x => x.handler);
                        break;
                    case "owner":
                        query = ascending ? query.OrderBy(x => x.owner) : query.OrderByDescending(x => x.owner);
                        break;
                    case "width":
                        query = ascending ? query.OrderBy(x => x.width) : query.OrderByDescending(x => x.width);
                        break;
                    case "height":
                        query = ascending ? query.OrderBy(x => x.height) : query.OrderByDescending(x => x.height);
                        break;
                    case "length":
                        query = ascending ? query.OrderBy(x => x.length) : query.OrderByDescending(x => x.length);
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

            return new BindingList<package>(query.ToList());
        }

        public int Count()
        {
            return _totalItems;
        }

        public void Insert(package pack)
        {
            if (db.package.Any(x => x.id == pack.id))
            {
                throw new Exception("Van már ilyen azonosítójú csomag.");
            }
            db.package.Add(pack);
        }

        public void Delete(int id)
        {
            var package = db.package.Find(id);
            db.package.Remove(package);
        }

        public void Update(package param)
        {
            var package = db.package.Find(param.id);
            if (package != null)
            {
                db.Entry(package).CurrentValues.SetValues(param);
            }
        }

        public bool Exists(package pack)
        {
            return db.package.Any(x => x.id == pack.id);
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
