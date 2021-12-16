using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Dental.Business.Workers;

namespace Dental.Form.Patient
{
    public partial class PatientForm : DevExpress.XtraEditors.XtraForm
    {
        private DentalWorker worker = new DentalWorker();
        public PatientForm()
        {
            InitializeComponent();
            //Listele();
        }

        void Listele()
        {
         worker.UserService.Load(null);
         gridControlPatient.DataSource = worker.UserService.BindingList();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}