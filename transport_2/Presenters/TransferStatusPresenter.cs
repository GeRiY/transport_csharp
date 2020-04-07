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
    class transferStatusPresenter
    {
        private IDataGridList<transfer_status> view;
        private transferStatusRepository repo = new transferStatusRepository();
        public transferStatusPresenter(IDataGridList<transfer_status> param)
        {
            view = param;
        }

        public void LoadData()
        {
            view.bindingList = repo.GetAllStatus(
                view.pageNumber, view.itemsPerPage, view.search, view.sortBy, view.ascending);
            view.totalItems = repo.Count();
        }

        public void Add(transfer_status status)
        {
            view.bindingList.Add(status);
            // hozzáadás ehhez a contexthez is
            repo.Insert(status);
        }

        public void Remove(int index)
        {
            var status = view.bindingList.ElementAt(index);
            view.bindingList.RemoveAt(index);
            if (status.id > 0)
            {
                repo.Delete(status.id);
            }
        }

        public void Modify(transfer_status status)
        {
            repo.Update(status);
        }

        public void Save()
        {
            repo.Save();
        }
    }
}
