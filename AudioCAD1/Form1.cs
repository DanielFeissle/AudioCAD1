using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Threading;
using System.Collections;
using System.Media;

namespace AudioCAD1
{
    public partial class frm_main : Form
    {



        string []sf_Name = null;





        public frm_main()
        {
            InitializeComponent();
        }

        private void frm_main_Load(object sender, EventArgs e)
        {
           var  allFiles = Directory.GetFiles(Environment.CurrentDirectory, "*.wav", SearchOption.AllDirectories);

            sf_Name = allFiles;

        }










        int priorSpace = 0; //it will always be at 0


        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //we want to construct sentences based on spaces
            if (txt_search.Text!="")
            {
              
                if (txt_search.Text.Substring(txt_search.Text.Length - 1, 1) == " ")
                {
                    lbl_search.Text = "SPACE"+priorSpace;
                    priorSpace = txt_search.Text.Length;
               //     rtx_term_search.Text = "";

                }
                else
                {


 

                    lbl_search.Text = "SEARCH"+priorSpace;


                    lst_select.Items.Clear();
                   // rtx_term_search.Text = "";
                    for (int i = 0; i < sf_Name.Length; i++)
                    {
                        int lastele = sf_Name[i].Split('\\').Length;
                        if (priorSpace< txt_search.Text.Length) //avoid being at the very end or beginign
                        {
                            if (sf_Name[i].Split('\\')[lastele - 1].Contains(txt_search.Text.Substring(priorSpace)))
                            {
                             //   rtx_term_search.Text = rtx_term_search.Text + sf_Name[i].Split('\\')[lastele - 1] + Environment.NewLine;
                                lst_select.Items.Add(sf_Name[i].Split('\\')[lastele - 1]);
                            }
                        }
                        else //backspace detected
                        {
                            for (int z=txt_search.Text.Length-1;z>0;z--)
                            {
                                //get the space furthest back and reset
                                string haha = txt_search.Text.Substring(z,1);
                                if (haha==" ")
                                {
                                    priorSpace = z+1;
                                    i = 0; // research
                                    break;
                                }
                                else if (!txt_search.Text.Contains(" "))
                                {
                                    //no spaces exist
                                    priorSpace =0;
                                    i = 0; // research
                                    break;
                                }
                                else if (txt_search.Text.Substring(z,1)!="")
                                {
                                    //no spaces exist
                                 //   priorSpace = 0;
                                 //   i = 0; // research
                                 //   break;
                                }
                            }
                        }

                    }






                }


                //put in our autoselect for closest matching word
          


            }
            else
            {
                lst_select.Items.Clear();
            }
              

        }

        private void txt_search_Enter(object sender, EventArgs e)
        {
            rtx_term_search.Text = "";
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void btn_play_Click(object sender, EventArgs e)
        {
            rtx_stagement.Text = lst_select.Items[lst_select.SelectedIndex].ToString();
            SoundPlayer simpleSound = new SoundPlayer("data\\audio\\MaxxSteele\\" + lst_select.Items[lst_select.SelectedIndex].ToString());
            simpleSound.Play();
        }
    }
}
