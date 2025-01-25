using Dapper;

namespace Gestionnaire
{
    public partial class Form1 : Form
    {
        private readonly Database _database;
        public Form1()
        {
            InitializeComponent();
            _database = new Database();
            ChargementUtilisateurs();
        }

        public void ChargementUtilisateurs()
        {
            using (var connection = _database.CreateConnection())
            {
                string query = "SELECT * FROM gestionnaire";
                var users = connection.Query<Utilisateur>(query);
                dataGridView1.Visible = true;
                dataGridView1.DataSource = new List<Utilisateur>(users);
            }
        }
    }
}
