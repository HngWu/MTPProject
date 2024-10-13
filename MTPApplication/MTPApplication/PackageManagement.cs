using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
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
            this.Width = 1200;
            this.Height = 1600;
            InitializeComponent();
            GetPackageData();
            DataGridViewLinkColumn reportLink = new DataGridViewLinkColumn();
            reportLink.UseColumnTextForLinkValue = true;
            reportLink.HeaderText = "Report";
            reportLink.DataPropertyName = "Report";
            reportLink.Name = "Report";
            reportLink.LinkBehavior = LinkBehavior.SystemDefault;
            reportLink.Text = "Report";
            packagegridview.Columns.Add(reportLink);
            DataGridViewLinkColumn deleteLink = new DataGridViewLinkColumn();
            deleteLink.UseColumnTextForLinkValue = true;
            deleteLink.HeaderText = "Delete";
            deleteLink.DataPropertyName = "Delete";
            deleteLink.Name = "Delete";
            deleteLink.LinkBehavior = LinkBehavior.SystemDefault;
            deleteLink.Text = "Delete";
            packagegridview.Columns.Add(deleteLink);
        }

        public void GetPackageData()
        {
            var packages = context.Packages.Select(x=> new
            {
                x.packageId,
                x.name,
                x.employeeId,
                x.image,
                x.introduction,
                x.cost,
                x.hits,
            }).ToList();
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
            else if (e.ColumnIndex == packagegridview.Columns["Report"].Index)
            {
                DataGridViewRow row = packagegridview.Rows[e.RowIndex];
                int packageId = Convert.ToInt32(row.Cells["packageId"].Value);
                var package = context.Packages.Where(p => p.packageId == packageId).FirstOrDefault();
                var commentsList = context.Comments.Where(p => p.packageId == packageId).ToList();
                
                var comments = context.Comments.Where(p=>p.packageId == packageId).Select(x=>x.comment1)?.ToList();
                var ratings = commentsList.Select(x=>x.rating).ToList();

                string filePath = $"{package.packageId}.csv";

                using (var writer = new StreamWriter(filePath))
                {
                    // Write header
                    writer.WriteLine("Name of the Tour Package,Hits of the Tour Package Post,Rating of the Tour Package ,1st Comment, 2nd Comment, 3rd Comment, 4th Comment, 5th Comment");

                    // Write each tour package data
                    {
                        // Combine the comments into a single string, separated by "|"

                        // Write data to the CSV
                        if(commentsList!=null)
                        {
                            writer.WriteLine($"{package.name.ToString()},{comments.Count.ToString()},{ratings.Average()},{comments[comments.Count - 1].ToString()},{comments[comments.Count - 2].ToString()},{comments[comments.Count - 3].ToString()},{comments[comments.Count - 4].ToString()},{comments[comments.Count - 5].ToString()}");
                        }
                        else
                        {
                            writer.WriteLine($"{package.name.ToString()},{comments.Count.ToString()},{ratings.Average()}");

                        }
                    }
                }

                Console.WriteLine($"CSV file created successfully at {Path.GetFullPath(filePath)}");

                try
                {
                    Process.Start(new ProcessStartInfo(filePath) { UseShellExecute = true });
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error opening file: {ex.Message}");
                }
            }
        }

        private void createbutton_Click(object sender, EventArgs e)
        {
            CreatePackage createpackage = new CreatePackage();
            createpackage.Show();
            this.Hide();

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
