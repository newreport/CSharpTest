using EF_MySQL.BLL;

namespace EF_MySQL
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            dgvClass.DataSource = new BLL_ClassGrade().QueryAll();

        }
    }
}