using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MenuTest.Classes;

namespace MenuTest
{
    public partial class HomeScreen : Form
    {
        public HomeScreen()
        {
            InitializeComponent();
            Page1.Visible = true;
        }
       

        private void create_Click(object sender, EventArgs e)
        {
            
            Player Player1 = new Player(newPlayer.Text);
            confirm.Visible = true;
            confirm.Text = confirm.Text+" "+Player1.name+"!";
            newPlayer.Visible = false;
            create.Visible = false;
            label2.Visible = false;
            Start.Visible = true;
            
            
        }

        private void Start_Click(object sender, EventArgs e)
        {

        }

        private void newPlayer_TextChanged(object sender, EventArgs e)
        {

        }
        private void newPlayer_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                create.PerformClick();
            }
        }
    }
}
