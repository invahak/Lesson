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
    public partial class Formlevel1 : Form
    {
        public Formlevel1()
        {
            InitializeComponent();
            start_game();
        }
        //при старте ставит курсур на кнопку Старт
        private void start_game()
        {
            Point point;
            point = label_start.Location;
            point.Offset(label_start.Width / 2, label_start.Height / 2);
            Cursor.Position = PointToScreen (point);
            Sound.Play_start();
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

        private void Formlevel1_Shown(object sender, EventArgs e)
        {
            start_game();
        }
        //Если курсор задел кнопку финал, сообщает что уровень пройден
        private void label_finish_MouseEnter(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.OK;
        }
        //если задел станку то обращаемся к функции finish_game
        private void label1_MouseEnter(object sender, EventArgs e)
        {
            finish_game();
        }
    }   
}
