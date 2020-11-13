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

        string audioLibraryLocation = "";

        string []sf_Name = null;





        public frm_main()
        {
            InitializeComponent();
        }

        private void frm_main_Load(object sender, EventArgs e)
        {
            lbl_debug.Text = "User Word: " + debugone +" \tBest Match: " + debugtwo;

            if (Directory.Exists(Environment.CurrentDirectory + "\\data"))
            {



            }
      else
            {
                //missing data directory,  recreate  it
                Directory.CreateDirectory(Environment.CurrentDirectory + "\\data");
                Directory.CreateDirectory(Environment.CurrentDirectory + "\\data\\master");
                Directory.CreateDirectory(Environment.CurrentDirectory + "\\data\\audio");
            }


            if (Directory.Exists(Environment.CurrentDirectory + "\\data\\master"))
            {
                if (File.Exists(Environment.CurrentDirectory+"\\data\\master\\settings.conf"))
                {
                    //default settings are ok

                }
                else
                {
                    using (var tw = new StreamWriter(Environment.CurrentDirectory+"\\data\\master\\settings.conf", true))
                    {
                        tw.WriteLine(Environment.CurrentDirectory+ "\\data\\audio\\MaxxSteele");
                    }
                }

            }

            string[] Settings = File.ReadAllLines(Environment.CurrentDirectory + "\\data\\master\\settings.conf");
            //settings 0 is the audio directory
            audioLibraryLocation = Settings[0];

            var allFiles = Directory.GetFiles(Settings[0], "*.wav", SearchOption.AllDirectories);
            sf_Name = allFiles;
           if (allFiles.Length==0)
            {
                txt_search.Enabled = false;
                btn_play.Enabled = false;
            }
           else
            {
                txt_search.Enabled = true;
                btn_play.Enabled = true;
            }


        }








        string debugone;
        string debugtwo;
        int priorSpace = 0; //it will always be at 0
        double stringdif;
        double highestDif = 0;
        int difIndex = 0;
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            stringdif = 0;
            highestDif = 0;
            difIndex = 0;
            //we want to construct sentences based on spaces
            if (txt_search.Text!="")
            {
              
                if (txt_search.Text.Substring(txt_search.Text.Length - 1, 1) == " ")
                {
                    lbl_search.Text = "Active search start: " + priorSpace;
                    priorSpace = txt_search.Text.Length;
               //     rtx_term_search.Text = "";

                }
                else
                {


 

                    lbl_search.Text = "Active search start: " + priorSpace;


                    lst_select.Items.Clear();
                   // rtx_term_search.Text = "";
                    for (int i = 0; i < sf_Name.Length; i++)
                    {
                        int lastele = sf_Name[i].Split('\\').Length;
                        if (priorSpace< txt_search.Text.Length) //avoid being at the very end or beginign
                        {
                            string extension = System.IO.Path.GetExtension(sf_Name[i].Split('\\')[lastele - 1]);
                            string result = sf_Name[i].Split('\\')[lastele - 1].Substring(0, sf_Name[i].Split('\\')[lastele - 1].Length - extension.Length);
                            if (result.Contains(txt_search.Text.Substring(priorSpace)))
                            {
                                //   rtx_term_search.Text = rtx_term_search.Text + sf_Name[i].Split('\\')[lastele - 1] + Environment.NewLine;

                                lst_select.Items.Add(result);

                                //put in our autoselect for closest matching word
                                for (int z=0;z<lst_select.Items.Count;z++)
                                {

                                      debugone = txt_search.Text.Substring(priorSpace);
                                      debugtwo= lst_select.Items[z].ToString();
                                   
                                    stringdif = StringCompare((debugtwo), debugone);
                                    // stringdif =(StringCompare(txt_search.Text.Substring(priorSpace), lst_select.Items[z].ToString()));
                                    if (stringdif>highestDif)
                                    {
                                        highestDif = stringdif;
                                        difIndex = z;
                                    }
                                    lbl_debug.Text = "DebugOne: " + debugone + "   DebugTwo: " + debugtwo  + "A VALU"+stringdif;
                                }

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


                    if (lst_select.Items.Count>0)
                    {
                        
                        //11-11-20 old method was to use the index, but that is extra steps. trying the selected item method
                         lst_select.SelectedIndex = difIndex;
                        lbl_debug.Text = "User Word: " + debugone + " \tBest Match: " + lst_select.SelectedItem.ToString();
                        //     lst_select.SelectedItem = debugtwo;
                    }
                    


                }

             

          


            }
            else
            {
                lst_select.Items.Clear();
            }
            lbl_stringDiff.Text = "Diference" + highestDif;

        }
        //11-10-20
        //https://stackoverflow.com/questions/16840503/how-to-compare-2-strings-and-find-the-difference-in-percentage
        static double StringCompare(string a, string b)
        {
            if (a == b) //Same string, no iteration needed.
                return 100;
            if ((a.Length == 0) || (b.Length == 0)) //One is empty, second is not
            {
                return 0;
            }
            double maxLen = a.Length > b.Length ? a.Length : b.Length;
            int minLen = a.Length < b.Length ? a.Length : b.Length;
            int sameCharAtIndex = 0;
            int blarg = b.Length-1;// - 3;
            bool superBreak = false;
            for (int i = 0; i < minLen; i++) //Compare char by char
            {
                for (int q= 0; q<minLen;q++)
                {
                    if (a[q] == b[i])
                    {
                        if (q>0)
                        {
                            if (a[q] != a[q - 1]) //words like hello have two l's back to back which messes with the difference counter to go over 100. this prevents that from happening
                            {
                                sameCharAtIndex++;
                                break;
                            }
                        }
                        else
                        {
                            sameCharAtIndex++;
                            break;
                        }
                      
                     
                     
                     
                     }
                    else
                    {
                        if (q >= minLen)
                        {
                          //  sameCharAtIndex = 0;
                        }
                    }


                }
                if (a[i] == b[i])
                {
                  //  sameCharAtIndex++;
                }
            }
            return sameCharAtIndex / maxLen * 100;
        }

        private void txt_search_Enter(object sender, EventArgs e)
        {
            rtx_term_search.Text = "";
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //11-9-20
            //https://stackoverflow.com/questions/11624298/how-to-use-openfiledialog-to-select-a-folder
            using (var fbd = new FolderBrowserDialog())
            {
                fbd.SelectedPath = Environment.CurrentDirectory;
                DialogResult result = fbd.ShowDialog();
                 
                if (result == DialogResult.OK && !string.IsNullOrEmpty(fbd.SelectedPath))
                {

                    audioLibraryLocation = fbd.SelectedPath;
                    var allFiles = Directory.GetFiles(fbd.SelectedPath, "*.wav", SearchOption.AllDirectories);
                    sf_Name = allFiles;

                    System.Windows.Forms.MessageBox.Show("Total audio files found (.wav): " + allFiles.Length.ToString(), "Message");
                }
            }
        }

        private SoundPlayer Player = new SoundPlayer();

        private void loadSoundAsync(string audioLoc)
        {
            // Note: You may need to change the location specified based on
            // the location of the sound to be played.
            this.Player.SoundLocation = audioLoc;
            this.Player.LoadAsync();
        }

        private void Player_LoadCompleted(
            object sender,
            System.ComponentModel.AsyncCompletedEventArgs e)
        {
            if (this.Player.IsLoadCompleted)
            {
                this.Player.PlaySync();
            }
        }

        private void btn_play_Click(object sender, EventArgs e)
        {
            //   rtx_stagement.Text = lst_select.Items[lst_select.SelectedIndex].ToString();
            //  SoundPlayer simpleSound = new SoundPlayer(audioLibraryLocation+"\\" + lst_select.Items[lst_select.SelectedIndex].ToString()+".wav");
            // simpleSound.Play();
            txt_search.Text = txt_search.Text.Trim();
            string[] spaceSplit1 = txt_search.Text.Split(' ');
            bool allExist = true;
            for (int i = 0; i < spaceSplit1.Length; i++)
            {
               
             if (!File.Exists(audioLibraryLocation + "\\" + spaceSplit1[i] + ".wav"))
                    {
                    allExist = false;
                    lbl_status.Text = "Status: NOK";
                }
            }

            if (allExist==true)
            {
                worker.RunWorkerAsync();
                btn_play.Enabled = false;
                lbl_status.Text = "Status: OK";
            }
            txt_search.SelectionStart = txt_search.Text.Length;








        }



 

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void txt_search_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Space)
            {

                if ( lst_select.Items.Count>0)
                {
                  //  lst_select.SelectedIndex = 0;



                    string[] breaker = txt_search.Text.Split(' ');
                    string recon = null;
                    for (int i = 0; i < breaker.Length - 1; i++)
                    {
                        recon = recon + breaker[i] + " ";
                    }
                    txt_search.Text = recon + lst_select.Items[lst_select.SelectedIndex].ToString();
                    txt_search.SelectionStart = txt_search.Text.Length;
                }
             
            }
            else
            {
                lst_select.ClearSelected();
            }
        }
      


        private void worker_DoWork_1(object sender, DoWorkEventArgs e)
        {
          
               // txt_search.Text = txt_search.Text.Trim();
            string[] spaceSplit1 = txt_search.Text.Split(' ');
            string progress = "";
           
           
           

        
            for (int i = 0; i < spaceSplit1.Length; i++)
            {
                progress = "";
                loadSoundAsync(audioLibraryLocation + "\\" + spaceSplit1[i] + ".wav"); //lst_select.Items[lst_select.SelectedIndex].ToString() 
                for (int z=0;z<spaceSplit1[i].Length;z++)
                {
                    progress = progress + ".";
                }
              
                 
              
             
                this.Player.PlaySync();
            }
          
        }

        private void rtx_stagement_TextChanged(object sender, EventArgs e)
        {

        }
      
        private void worker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
        
        }

        private void worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            btn_play.Enabled = true;
          
        }
    }
}
