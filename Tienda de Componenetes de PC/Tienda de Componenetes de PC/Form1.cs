using MySql.Data.MySqlClient;

namespace Tienda_de_Componenetes_de_PC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        MySqlConnection conex = new MySqlConnection("Server=(local);DataBase=BD_Sistema;UId=admintien;Pwd=123abc");

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                conex.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btn_ingresar_Click(object sender, EventArgs e)
        {
            String usuario = txt_usuario.Text;
            String contrasena = txt_contrasena.Text;
            try
            {
                MySqlCommand cmd = new MySqlCommand("Select * From Usuario Where usuario='"+ usuario +"' and contrasena ='"+ contrasena +"'",conex);
                MySqlDataReader dr = cmd.ExecuteReader();
                if(dr.Read())
                {
                    MessageBox.Show("Bienvenido " + dr.GetValue(1));
                }
                else
                {
                    MessageBox.Show("USUARIO NO VALIDO");
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            string nombre, contraseña;
            nombre = txt_usuario.Text;
            contraseña = txt_contrasena.Text;
        }


    }
}