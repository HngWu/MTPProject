using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System;
using System.Data.SqlClient;
using System.IO;
using System.Linq;



namespace MTPApplication
{
    public partial class storeimage : Form
    {
        static string connectionString = "Server=.\\SQLEXPRESS;Database=MTPDatabase;Trusted_Connection=true;TrustServerCertificate=true;";

        // Directory containing the images
        static string imageDirectory = @"C:\Users\hngwu\OneDrive\Korea\Data Files\Session 1\Employee Images";

        public storeimage()
        {
            InitializeComponent();
        }

        private void imagebutton_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string[] imageFiles = Directory.GetFiles(imageDirectory)
                        .Where(file => new[] { ".png", ".jpg", ".jpeg", ".gif" }
                            .Contains(Path.GetExtension(file).ToLower()))
                        .ToArray();

                    foreach (string filePath in imageFiles)
                    {
                        string fileName = Path.GetFileNameWithoutExtension(filePath);
                        if (int.TryParse(fileName, out int employeeNo))
                        {
                            byte[] imageData = File.ReadAllBytes(filePath);

                            using (SqlCommand command = new SqlCommand("UPDATE Employees SET image = @ImageData WHERE employee_no = @EmployeeNo", connection))
                            {
                                command.Parameters.Add("@ImageData", System.Data.SqlDbType.VarBinary, -1).Value = imageData;
                                command.Parameters.AddWithValue("@EmployeeNo", employeeNo);

                                int rowsAffected = command.ExecuteNonQuery();
                                Console.WriteLine($"Updated image for employee {employeeNo}. Rows affected: {rowsAffected}");
                            }
                        }
                        else
                        {
                            Console.WriteLine($"Skipping file {fileName} as it doesn't match the expected naming format.");
                        }
                    }
                }

                Console.WriteLine("Image upload process completed.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }
    }
    }


