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
    class userPresenter
    {
        private IDataGridList<fos_user> view;
        private userRepository repo = new userRepository();
        public userPresenter(IDataGridList<fos_user> param)
        {
            view = param;
        }

        public void LoadData()
        {
            view.bindingList = repo.GetAllUser(
                view.pageNumber, view.itemsPerPage, view.search, view.sortBy, view.ascending);
            view.totalItems = repo.Count();
        }

        public void Add(fos_user user)
        {
            view.bindingList.Add(user);
            // hozzáadás ehhez a contexthez is
            repo.Insert(user);
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

        public void Modify(fos_user user)
        {
            repo.Update(user);
        }

        public void Save()
        {
            repo.Save();
        }
    }
}
