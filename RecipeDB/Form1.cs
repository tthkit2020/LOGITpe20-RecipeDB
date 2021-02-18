using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace RecipeDB
{
    public partial class CookBook : Form
    {
        string connectionString;
        SqlConnection connection;

        public CookBook()
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["RecipeDB.Properties.Settings.RecipeDBConnectionString"].ConnectionString;
        }

        private void CookBook_Load(object sender, EventArgs e)
        {
            PopulateRecipes();
        }

        private void PopulateRecipes()
        {
            using(connection = new SqlConnection(connectionString))
            using(SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Recipe", connection))
            {
                DataTable recipeTable = new DataTable();
                adapter.Fill(recipeTable);

                listRecipe.DisplayMember = "Name";
                listRecipe.ValueMember = "Id";
                listRecipe.DataSource = recipeTable;

            }
        }
    }
}
