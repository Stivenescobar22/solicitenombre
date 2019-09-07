using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace solicite_nombre
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Btnok_Click(object sender, EventArgs e)
        {
            
            const string tletra = "MS Gothic";
            

            Font fo = txtnombre.Font;

            
            lblstilo.Font = new Font(tletra, emSize:24, style: FontStyle.Bold);
            lblstilo.ForeColor = Color.Red;
    
            lblstilo.Text = txtnombre.Text;
            lblstilo.Visible = true;
        }
    }
}
