using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bistro_Shelves
{
    public partial class History : Form
    {
        public History()
        {
            InitializeComponent();
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            Form1.show();
            this.Close();
        }

        private void inventoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btrecordcounts form2 = new btrecordcounts();
            btrecordcounts.show();
            this.Close();

        }

        private void parToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Par form3 = new Par();
            Par.show();
            this.Close();
        }

        private void historyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            History form4 = new History();
            History.show();
            this.Close();

        }

        private static void show()
        {
            throw new NotImplementedException();
        }
    }
    }
}
