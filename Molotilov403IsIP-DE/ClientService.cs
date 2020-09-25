using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Molotilov403IsIP_DE
{
    public partial class ClientService : Form
    {
        public ClientService()
        {
            InitializeComponent();
        }

        private void clientServiceBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.clientServiceBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.molotilov403DEDataSet);

        }

        private void clientServiceBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.clientServiceBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.molotilov403DEDataSet);

        }

        private void clientServiceBindingNavigatorSaveItem_Click_2(object sender, EventArgs e)
        {
            this.Validate();
            this.clientServiceBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.molotilov403DEDataSet);

        }

        private void ClientService_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "molotilov403DEDataSet.ClientService". При необходимости она может быть перемещена или удалена.
            this.clientServiceTableAdapter.Fill(this.molotilov403DEDataSet.ClientService);

        }
    }
}
