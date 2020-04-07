using transport_2.Models;
using transport_2.Presenters;
using transport_2.ViewInterfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace transport_2.Views
{
    public partial class trasferStatusForm : Form, IDataGridList<transfer_status>
    {
        
        private transferStatusPresenter presenter;
        // Oldaltördelés
        private int pageCount;
        private int sortIndex;

        public trasferStatusForm()
        {
            InitializeComponent();
            presenter = new transferStatusPresenter(this);
            Init();
        }

        public void Init()
        {
            pageNumber = 1;
            itemsPerPage = 20;
            sortBy = "Id";
            sortIndex = 0;
            ascending = true;
        }

        public BindingList<transfer_status> bindingList
        {
            get => (BindingList<transfer_status>)dataGridView1.DataSource;
            set => dataGridView1.DataSource = value;
        }

        public int pageNumber { get; set; }
        public int itemsPerPage { get; set; }
        public string search { get => keresestoolStripTextBox.Text; }
        public string sortBy { get; set; }
        public bool ascending { get; set; }
        public int totalItems
        {
            set
            {
                pageCount = (value - 1) / itemsPerPage + 1;
                label1.Text = pageNumber.ToString() + "/" + pageCount.ToString();
                OsszesLabel.Text = "Összesen: " + value.ToString();
            }
        }

        private void trasferStatusForm_Load(object sender, EventArgs e)
        {
            presenter.LoadData();
        }

        private void TorlestoolStripButton_Click(object sender, EventArgs e)
        {
            //DelDGRow();
        }
    }
}
