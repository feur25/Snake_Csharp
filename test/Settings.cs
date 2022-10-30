using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string getFoward = Forward.Text;
            string getDown = Down.Text;
            string getRight = Right.Text;
            string getLeft = Left.Text;
            string getSpace = Space.Text;
            if (String.IsNullOrWhiteSpace(getFoward) || String.IsNullOrWhiteSpace(getDown) || String.IsNullOrWhiteSpace(getRight) || String.IsNullOrWhiteSpace(getLeft)|| String.IsNullOrWhiteSpace(getSpace))
            {
                MessageBox.Show("Attention vérifier que tous les champ on était rentrer. ");
                return;
            }
            command NewControls = new command(getFoward, getDown, getRight, getLeft, getSpace);
        }
    }
}
