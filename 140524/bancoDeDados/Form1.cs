using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlServerCe;
using System.IO;

namespace bancoDeDados
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ConectarBD_Click(object sender, EventArgs e)
        {
            string pathBD = Application.StartupPath + @"\BancoSQLCe.sdf"; //Retorna a pasta
            string strConnection = @"DataSource = " + pathBD + "; PassWord = '123'";
            SqlCeEngine bd = new SqlCeEngine(strConnection);

            if (! File.Exists(pathBD)) // caso não exista o bd criar
            {
                bd.CreateDatabase();
            }
            bd.Dispose(); //Liberar os recursos

            SqlCeConnection conexao = new SqlCeConnection(strConnection);
            //Fazer a conexão com o banco de dados 
            //conexaõ.ConnectionString = strConnection; 

            try
            {
                conexao.Open(); //Abrir a conexão 
                MessageBox.Show("Conexão estabelecida!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao estabelecer conexão" + ex);
            }
            finally
            {
                conexao.Close(); //Fechar a conexão 
            }
        }
    }
}
