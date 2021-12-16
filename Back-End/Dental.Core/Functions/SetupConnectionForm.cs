using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace Dental.Core.Functions
{
    public partial class SetupConnectionForm : DevExpress.XtraEditors.XtraForm
    {
        SqlConnectionStringBuilder connectionStringBuilder = new SqlConnectionStringBuilder();
        public bool Kaydedildi = false;
        public SetupConnectionForm()
        {
            InitializeComponent();
        }
        private void BaglantiCumleOlustur()
        {
            connectionStringBuilder.InitialCatalog = "master";
            connectionStringBuilder.DataSource = txtServer.Text;
            if (chkWindow.Checked)
            {
                connectionStringBuilder.IntegratedSecurity = true;
            }
            else
            {
                connectionStringBuilder.UserID = txtUser.Text;
                connectionStringBuilder.Password = txtPassword.Text;
                connectionStringBuilder.IntegratedSecurity = false;
            }



        }
        private void chkSql_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSql.Checked)
            {
                txtUser.Enabled = true;
                txtPassword.Enabled = true;
            }
            else
            {
                txtUser.Enabled = false;
                txtPassword.Enabled = false;
            }
        }

        private void btnBaglantiTest_Click(object sender, EventArgs e)
        {
            BaglantiCumleOlustur();
            if (ConnectionStringInfo.Check(connectionStringBuilder.ConnectionString))
            {
                MessageBox.Show("Bağlantınız Başarılı");
            }
            else
            {
                MessageBox.Show("Bağlantınız Başarısız.");
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            BaglantiCumleOlustur();
            if (ConnectionStringInfo.Check(connectionStringBuilder.ConnectionString))
            {
                connectionStringBuilder.InitialCatalog = "DbDental";
                ConnectionStringInfo.Set(connectionStringBuilder.ConnectionString);
                Close();
            }
            else
            {
                MessageBox.Show("Bağlantınız Başarısız.");
            }
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}