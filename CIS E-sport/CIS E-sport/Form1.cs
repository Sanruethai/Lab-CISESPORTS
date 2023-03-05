namespace CIS_E_sport
{
    public partial class FromInfo : Form
    {
        private Player _newPlayer;
        public FromInfo()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = tbName.Text;
            string Lastname = tbSurname.Text;
            string studen = tbID.Text;
            string major = tbBranch.Text;
            string disgamenae = tbGamename.Text;
            string mail = tbMail.Text;
            string phone = tbNumber.Text;
            int iAge = 0;
            try
            {
                string age = tbAge.Text;
                iAge = Int32.Parse(age);
            }
            catch (FormatException ex)
            {
                MessageBox.Show("คุณส่ข้อมูลไม่ถูกต้อง");
                return;
            }
            catch (Exception) { }
            _newPlayer = new Player(name, Lastname, studen, major, disgamenae, mail, phone, iAge);

            this.DialogResult = DialogResult.OK;

        }
        public Player getPlayer() { return _newPlayer; }
    }
}