using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MTPApplication
{
    public partial class PackageManagement : Form
    {
        MTPDbContext context = new MTPDbContext();
        BindingSource BindingSource = new BindingSource();
        public PackageManagement()
        {
            InitializeComponent();
            GetPackageData();
            DataGridViewLinkColumn deleteLink = new DataGridViewLinkColumn();
            deleteLink.UseColumnTextForLinkValue = true;
            deleteLink.HeaderText = "Delete";
            deleteLink.DataPropertyName = "Delete";
            deleteLink.LinkBehavior = LinkBehavior.SystemDefault;
            deleteLink.Text = "Delete";
            packagegridview.Columns.Add(deleteLink);
        }

        public void GetPackageData()
        {
            var packages = context.Packages.ToList();
            BindingSource.DataSource = packages;
            packagegridview.DataSource = BindingSource;
        }


        private void PackageManagement_Load(object sender, EventArgs e)
        {

        }

        private void packagegridview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == packagegridview.Columns["Delete"].Index)
            {
                DataGridViewRow row = packagegridview.Rows[e.RowIndex];
                int packageId = Convert.ToInt32(row.Cells["packageId"].Value);
                var package = context.Packages.Where(p => p.packageId == packageId).FirstOrDefault();
                context.Packages.Remove(package);
                context.SaveChanges();
                GetPackageData();
                MessageBox.Show("Package Deleted Successfully");
            }
        }
    }
}
