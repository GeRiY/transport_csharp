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
    class addressPresenter
    {
        private IDataGridList<address> view;
        private addressRepository repo = new addressRepository();
        public addressPresenter(IDataGridList<address> param)
        {
            view = param;
        }

        public void LoadData()
        {
            view.bindingList = repo.GetAllAddress(
                view.pageNumber, view.itemsPerPage, view.search, view.sortBy, view.ascending);
            view.totalItems = repo.Count();
        }

        public void Add(address address)
        {
            view.bindingList.Add(address);
            // hozzáadás ehhez a contexthez is
            repo.Insert(address);
        }

        public void Remove(int index)
        {
            var address = view.bindingList.ElementAt(index);
            view.bindingList.RemoveAt(index);
            if (address.id > 0)
            {
                repo.Delete(address.id);
            }
        }

        public void Modify(address address)
        {
            repo.Update(address);
        }

        public void Save()
        {
            repo.Save();
        }
    }
}
