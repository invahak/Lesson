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
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }
        //при нажатие на кнопку начать игру, выполняеться функция Start_level1
        private void buttonStart_Click(object sender, EventArgs e)
        {
            Start_level1();
        }

        //Включает и выключает звук в игре
        private void checkBoxSound_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxSound.Checked)
            {
                Sound.sound_on();
                Sound.Play_key();
            }
            else
            {
                Sound.sound_off();
            }
        }
        // выходит из игры если нажать на кнопку выход
        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void Start_level1()
        {
            Formlevel1 level1 = new Formlevel1();
            level1.ShowDialog();
            DialogResult dr = level1.ShowDialog();
            if (dr == System.Windows.Forms.DialogResult.OK)
                Start_level2();
        }
        private void Start_level2()
        {
            Formlevel2 level2 = new Formlevel2();
            level2.ShowDialog();
            DialogResult dr = level2.ShowDialog();
            if (dr == System.Windows.Forms.DialogResult.OK)
            {
                start_win();
            }
        }
        private void start_win()
        {
            Sound.Play_finish();
            MessageBox.Show("Неееееееееееееет, ты победил меня", "Победа!");
        }

    }
        
}

