using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class ConsultaEditora : Form
    {
        public ConsultaEditora()
        {
            InitializeComponent();
        }

        private void btnConsulSair_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
