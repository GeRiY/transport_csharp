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
    class packageToGetFromCustomerPresenter
    {
        private IDataGridList<package> view;
        private packageToGetFromCustomerRepository repo = new packageToGetFromCustomerRepository();
        public packageToGetFromCustomerPresenter(IDataGridList<package> param)
        {
            view = param;
        }

        public void LoadData()
        {
            view.bindingList = repo.GetAllPackage(
                view.pageNumber, view.itemsPerPage, view.search, view.sortBy, view.ascending);
            view.totalItems = repo.Count();
        }

        public void Add(package pack)
        {
            view.bindingList.Add(pack);
            // hozzáadás ehhez a contexthez is
            repo.Insert(pack);
        }

        public void Remove(int index)
        {
            var pack = view.bindingList.ElementAt(index);
            view.bindingList.RemoveAt(index);
            if (pack.id > 0)
            {
                repo.Delete(pack.id);
            }
        }

        public void Modify(package pack)
        {
            repo.Update(pack);
        }

        public void Save()
        {
            repo.Save();
        }
    }
}
