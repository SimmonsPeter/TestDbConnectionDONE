namespace LaboratoireSQL10
{
    public partial class Form1 : Form
    {

        private EtudiantDataContext dbContext;
        public Form1()
        {
            InitializeComponent();
            dbContext = new EtudiantDataContext();
        }

        private void btnAjouterProg_Click(object sender, EventArgs e)
        {
            Programme p = new Programme(Convert.ToInt32(txtProgrammeId.Text), txtProgrammeName.Text);
            try
            {
                dbContext.InsertProgramme(p);
                MessageBox.Show("Programme ajouté avec succès");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void btnVoirListeProg_Click(object sender, EventArgs e)
        {
            dataGridProg.DataSource = this.dbContext.GetAllProgrammes();
        }
    }
}