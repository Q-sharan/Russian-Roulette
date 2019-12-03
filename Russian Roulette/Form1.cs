using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace Russian_Roulette
{
    public partial class Form1 : Form
    {
        private SoundPlayer _soundPlayer;
        int count = 1;
        
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Btnshoot_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int nums = rnd.Next(1, 6);

            //LOOP FOR FIRING BULLET TILL HAVING CHANCES
            for (int i = nums; i <= nums; i++)
            {


                if (i < 3)
                {
                    _soundPlayer = new SoundPlayer("Gun+Shot2.wav");
                    _soundPlayer.Play();
                    chamberspinpic.Visible = false;
                    gunfirepic.Visible = true;
                    gunfirepic.Enabled = true;
                    missfirepic.Visible = false;
                    openchamberpic.Visible = false;
                    btnshoot.Enabled = false;
                    btnload.Enabled = false;
                    btnplay.Enabled = true;
                    string message = "You Survived";
                    string title = "Hot Hands";
                    MessageBox.Show(message, title);
                    break;

                }



                else if (i >= 3)
                {

                    for(int j = 1; j < 2; j++)
                    {

                        btnshoot.Enabled = false;
                        btnload.Enabled = false;
                        btnplay.Enabled = true;
                        btnsecondfire.Enabled = false;

                    }
                    _soundPlayer = new SoundPlayer("empty-bullet-shell-fall-02.wav");
                    _soundPlayer.Play();
                    gunfirepic.Visible = false;
                    btnshoot.Enabled = false;
                    missfirepic.Visible = true;
                    btnload.Enabled = false;
                    btnsecondfire.Enabled = true;




                }
                //FOR STOPING THE PLAYER TO FINISH AFTER ENDING CHANCES
                

                    if (count == 2 )

                {
                        btnplay.Enabled = true;
                        btnsecondfire.Enabled = false;
                        string message = "Game over";
                        string title = "Hot Hands";
                        MessageBox.Show(message, title);
                       
                        break;

                    }
                

               

               

                }

          


        }

        private void Btnload_Click_1(object sender, EventArgs e)
        {
            chamberspinpic.Enabled = true;
            chamberspinpic.Visible = true;
            openchamberpic.Visible = false;
            gunfirepic.Visible = false;
            missfirepic.Visible = false;
            openchamberpic.Visible = false;
            btnshoot.Enabled = true;
        }

        private void Btnplay_Click(object sender, EventArgs e)
        {
            btnload.Enabled = true;
            btnplay.Enabled = false;
        }

        private void Btnsecondfire_Click(object sender, EventArgs e)
        {
            btnsecondfire.Enabled = false;
            btnload.Enabled = true;
            btnplay.Enabled = false;
            openchamberpic.Visible = true;
            gunfirepic.Visible = false;
            missfirepic.Visible = false;
            chamberspinpic.Visible = false;

        }

        private void openchamberpic_Click(object sender, EventArgs e)
        {

        }

        private void missfirepic_Click(object sender, EventArgs e)
        {

        }
    }
        }
