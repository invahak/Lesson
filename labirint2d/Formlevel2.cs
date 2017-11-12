using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace labirint2d
{
    public partial class Formlevel2 : Form
    {
        public Formlevel2()
        {
            InitializeComponent();
        }

        private void start_game()
        {
            Point point;
            point = label_start.Location;
            point.Offset(label_start.Width / 2, label_start.Height / 2);
            Cursor.Position = PointToScreen (point);
            Sound.Play_start();
            label_key.Visible = true;
            label_door.Visible = true;
        }
        //Если задел стенки
        private void finish_game()
        {
            Sound.Play_fail();
            DialogResult dr = MessageBox.Show("Ебать ты лох! Ещё разок или засал?", "Оскорбление",
                MessageBoxButtons.YesNo);
            if (dr == System.Windows.Forms.DialogResult.Yes)
                start_game();
            else
                DialogResult = System.Windows.Forms.DialogResult.Abort;
        }

        private void Formlevel2_Shown(object sender, EventArgs e)
        {
            start_game();
        }

        private void label8_MouseEnter(object sender, EventArgs e)
        {
            finish_game();
        }

        private void label_key_MouseEnter(object sender, EventArgs e)
        {
            label_key.Visible = false;
            Sound.Play_key();
            
        }

        private void label_door_MouseEnter(object sender, EventArgs e)
        {
            if (label_key.Visible)
            {
                finish_game();
            }
            else
            {
                label_door.Visible = false;
                Sound.Play_key();
            }
        }

        private void label_finish_MouseEnter(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.OK;
        }
    }
}
