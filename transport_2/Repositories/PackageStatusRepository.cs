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
    class PackageStatusRepository : IDisposable
    {
        private transportEntityContext db = new transportEntityContext();
        private int _totalItems;

        public BindingList<package_status> GetAllPackageStatus(
            int page = 0,
            int itemsPerPage = 0,
            string search = null,
            string sortBy = null,
            bool ascending = true)
        {
            var query = db.package_status.OrderBy(x => x.id).AsQueryable();

            // Keresés
            if (!string.IsNullOrWhiteSpace(search))
            {
                search = search.ToLower();
            }

            // Sorbarendezés
            if (!string.IsNullOrWhiteSpace(sortBy))
            {
                switch (sortBy)
                {
                    default:
                        query = ascending ? query.OrderBy(x => x.id) : query.OrderByDescending(x => x.id);
                        break;
                    case "name":
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

            return new BindingList<package_status>(query.ToList());
        }

        public int Count()
        {
            return _totalItems;
        }

        public void Insert(package_status packageStatus)
        {
            if (db.package_status.Any(x => x.name == packageStatus.name))
            {
                throw new Exception("A megadott felhasználónév már foglalt!");
            }
            db.package_status.Add(packageStatus);
        }

        public void Delete(int id)
        {
            var packageStatus = db.package_status.Find(id);
            db.package_status.Remove(packageStatus);
        }

        public void Update(package_status param)
        {
            var packageStatus = db.package_status.Find(param.id);
            if (packageStatus != null)
            {
                db.Entry(packageStatus).CurrentValues.SetValues(param);
            }
        }

        public bool Exists(package_status packageStatus)
        {
            return db.package_status.Any(x => x.id == packageStatus.id);
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
