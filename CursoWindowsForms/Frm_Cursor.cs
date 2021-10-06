using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CursoWindowsForms
{
    public partial class Frm_Cursor : Form
    {
        public Frm_Cursor()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            for (int i = 0; i <= 10; i++)
            {
                System.Threading.Thread.Sleep(1000);
            }
            this.Cursor = Cursors.Default;
        }
    }
}
