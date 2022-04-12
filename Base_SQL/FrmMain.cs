using System.Data;

namespace Base_SQL
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        void LinkMySQL()
        {

            string conString = "Data Source={0};Initial Catalog={1};Integrated Security=false;User ID=sa;Password={3}";
            //IDbConnection con = con = new System.Data.SqlClient.SqlConnection(conString);
        }
    }
}