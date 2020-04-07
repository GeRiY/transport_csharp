using transport_2.Models;
using transport_2.Properties;
using transport_2.Repositories;
using transport_2.ViewInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace transport_2.Presenters
{
    class PackageStatusPresenter
    {
        private IDataGridList<package_status> view;
        private PackageStatusRepository repo = new PackageStatusRepository();
        public PackageStatusPresenter(IDataGridList<package_status> param)
        {
            view = param;
        }

        public void LoadData()
        {
            view.bindingList = repo.GetAllPackageStatus(
                view.pageNumber, view.itemsPerPage, view.search, view.sortBy, view.ascending);
            view.totalItems = repo.Count();
        }

        public void Add(package_status packageStatus)
        {
            view.bindingList.Add(packageStatus);
            // hozzáadás ehhez a contexthez is
            repo.Insert(packageStatus);
        }

        public void Remove(int index)
        {
            var uf = view.bindingList.ElementAt(index);
            view.bindingList.RemoveAt(index);
            if (uf.id > 0)
            {
                repo.Delete(uf.id);
            }
        }

        public void Modify(package_status packageStatus)
        {
            repo.Update(packageStatus);
        }

        public void Save()
        {
            repo.Save();
        }
    }
}
