namespace GMS
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void login_Load(object sender, EventArgs e)
        {
            lblusername.Hide();
            lblpass.Hide();
            txtuser.Hide();
            txtpass.Hide();
            btnlogin.Hide();
        }

        private void adminicon_Click(object sender, EventArgs e)
        {
            lblusername.Show();
            lblpass.Show();
            txtuser.Show();
            txtpass.Show();
            btnlogin.Show();
        }

        private void lbladmin_Click(object sender, EventArgs e)
        {
            lblusername.Show();
            lblpass.Show();
            txtuser.Show();
            txtpass.Show();
            btnlogin.Show();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            string username = "admin";
            string password = "admin";
            if (txtuser.Text == username && txtpass.Text == password)
            {
                MessageBox.Show("Logged In successfully, Directed to Admin panel!");
                adminpanel adp = new adminpanel();
                adp.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Wrong username and password, please login with correct credentials!");
            }
            txtuser.Clear();
            txtpass.Clear();
        }

        private void usericon_Click(object sender, EventArgs e)
        {
            userpanel usp = new userpanel();
            usp.Show();
            this.Hide();
        }

        private void lbluser_Click(object sender, EventArgs e)
        {
            userpanel usp = new userpanel();
            usp.Show();
            this.Hide();
        }

        private void closeicon_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}