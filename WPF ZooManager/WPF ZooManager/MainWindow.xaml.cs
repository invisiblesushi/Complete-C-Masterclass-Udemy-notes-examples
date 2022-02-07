using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace WPF_ZooManager
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        SqlConnection sqlConnection;

        public MainWindow()
        {
            InitializeComponent();


            string connectionString = ConfigurationManager.ConnectionStrings["WPF_ZooManager.Properties.Settings.DBConnectionString"].ConnectionString;
            //Initialize sqlConnection
            sqlConnection = new SqlConnection(connectionString);

            ShowZoos();
            ShowAllAnimals();
        }



        private void ShowAllAnimals()
        {
            string query = "select * from Animal";
            //Advantege, dont need to open/close connection manually
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, sqlConnection);

            using (sqlDataAdapter)
            {
                try
                {
                    DataTable animalTable = new DataTable();
                    sqlDataAdapter.Fill(animalTable);

                    listAllAnimals.DisplayMemberPath = "Name";
                    listAllAnimals.SelectedValuePath = "Id";
                    listAllAnimals.ItemsSource = animalTable.DefaultView;
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
            }
        }


        private void ShowZoos()
        {
            try
            {
                string query = "select * from Zoo";
                // The SqlDataAdapter can be imagined like an Interface to make Tables usable by C#-objects
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, sqlConnection);

                using (sqlDataAdapter)
                {
                    //Store data from tables within a object
                    DataTable zooTable = new DataTable();

                    sqlDataAdapter.Fill(zooTable);

                    //Which information of the table should be shown
                    listZoos.DisplayMemberPath = "Location";
                    //Which value should be delivered, when an item from ListBox is selected
                    listZoos.SelectedValuePath = "Id";
                    //The reference to data ListBox should populate
                    listZoos.ItemsSource = zooTable.DefaultView;

                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
            
        }

        private void ShowAssociatedAnimals()
        {
            try
            {
                //@zooId is like a variable
                string query = "select * from Animal a inner join ZooAnimal " +
                    "za on a.Id = za.AnimalId where za.ZooId = @zooId";


                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                // The SqlDataAdapter can be imagined like an Interface to make Tables usable by C#-objects
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);


                using (sqlDataAdapter)
                {
                    //Adding parameter to sqlCommand
                    sqlCommand.Parameters.AddWithValue("@ZooId", listZoos.SelectedValue);

                    //Store data from tables within a object
                    DataTable animalTable = new DataTable();

                    sqlDataAdapter.Fill(animalTable);

                    //Which information of the table should be shown (Column name)
                    listAssociatedAnimals.DisplayMemberPath = "Name";
                    //Which value should be delivered, when an item from ListBox is selected
                    listAssociatedAnimals.SelectedValuePath = "Id";
                    //The reference to data ListBox should populate
                    listAssociatedAnimals.ItemsSource = animalTable.DefaultView;

                }
            }
            catch (Exception e)
            {
                //MessageBox.Show(e.ToString());
            }

        }

        //Selection changed event
        private void listZoos_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ShowAssociatedAnimals();
            ShowSelectedZooInTextBox();
        }

        //Button click event handler
        private void DeleteZoo_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string query = "delete from Zoo where id = @ZooId";
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                sqlConnection.Open();
                sqlCommand.Parameters.AddWithValue("@ZooId", listZoos.SelectedValue);
                sqlCommand.ExecuteScalar();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                sqlConnection.Close();
                ShowZoos();
            }
        }

        private void AddZoo_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string query = "insert into Zoo values (@Location)";
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                sqlConnection.Open();
                sqlCommand.Parameters.AddWithValue("@Location", myTextBox.Text);
                sqlCommand.ExecuteScalar();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                sqlConnection.Close();
                ShowZoos();
            }
        }

        private void addAnimalToZoo_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string query = "insert into ZooAnimal values (@ZooId, @AnimalId)";
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                sqlConnection.Open();
                sqlCommand.Parameters.AddWithValue("@ZooId", listZoos.SelectedValue);
                sqlCommand.Parameters.AddWithValue("@AnimalId", listAllAnimals.SelectedValue);
                sqlCommand.ExecuteScalar();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                sqlConnection.Close();
                ShowAssociatedAnimals();
            }
        }

        private void UpdateZoo_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string query = "update Zoo Set Location = @Location where Id = @ZooId";
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                sqlConnection.Open();
                sqlCommand.Parameters.AddWithValue("@ZooId", listZoos.SelectedValue);
                sqlCommand.Parameters.AddWithValue("@Location", myTextBox.Text);
                sqlCommand.ExecuteScalar();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                sqlConnection.Close();
                ShowZoos();
            }
        }


        private void UpdateAnimal_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string query = "update Animal Set Name = @Name where Id = @AnimalId";
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                sqlConnection.Open();
                sqlCommand.Parameters.AddWithValue("@AnimalId", listAllAnimals.SelectedValue);
                sqlCommand.Parameters.AddWithValue("@Name", myTextBox.Text);
                sqlCommand.ExecuteScalar();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                sqlConnection.Close();
                ShowAllAnimals();
            }
        }


        private void deleteAnimal_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string query = "delete from Animal where id = @AnimalId";
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                sqlConnection.Open();
                sqlCommand.Parameters.AddWithValue("@AnimalId", listAllAnimals.SelectedValue);
                sqlCommand.ExecuteScalar();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                sqlConnection.Close();
                ShowAllAnimals();
            }
        }

        private void AddAnimal_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string query = "insert into Animal values (@Name)";
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                sqlConnection.Open();
                sqlCommand.Parameters.AddWithValue("@Name", myTextBox.Text);
                sqlCommand.ExecuteScalar();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                sqlConnection.Close();
                ShowAllAnimals();
            }
        }

        private void ShowSelectedZooInTextBox()
        {
            try
            {
                //@zooId is like a variable
                string query = "select location from Zoo where Id = @ZooId";


                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                // The SqlDataAdapter can be imagined like an Interface to make Tables usable by C#-objects
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);


                using (sqlDataAdapter)
                {
                    //Adding parameter to sqlCommand
                    //Gives 1 particular item
                    sqlCommand.Parameters.AddWithValue("@ZooId", listZoos.SelectedValue);

                    //Store data from tables within a object
                    DataTable zooDataTable = new DataTable();

                    sqlDataAdapter.Fill(zooDataTable);
                    //DataTable has only 1 item, therefore row 0
                    myTextBox.Text = zooDataTable.Rows[0]["Location"].ToString();

                }
            }
            catch (Exception)
            {
                //MessageBox.Show(e.ToString());
            }
        }

        private void ShowSelectedAnimalInTextBox()
        {
            try
            {
                //@zooId is like a variable
                string query = "select name from Animal where Id = @AnimalId";


                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                // The SqlDataAdapter can be imagined like an Interface to make Tables usable by C#-objects
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);


                using (sqlDataAdapter)
                {
                    //Adding parameter to sqlCommand
                    //Gives 1 particular item
                    sqlCommand.Parameters.AddWithValue("@AnimalId", listAllAnimals.SelectedValue);

                    //Store data from tables within a object
                    DataTable animalDataTable = new DataTable();

                    sqlDataAdapter.Fill(animalDataTable);
                    //DataTable has only 1 item, therefore row 0
                    myTextBox.Text = animalDataTable.Rows[0]["Name"].ToString();

                }
            }
            catch (Exception)
            {
                //MessageBox.Show(e.ToString());
            }
        }

        private void listAllAnimals_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ShowSelectedAnimalInTextBox();
        }
    }
}
