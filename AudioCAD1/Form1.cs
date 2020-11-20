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
using System.Text.RegularExpressions;

namespace AudioCAD1
{
    public partial class frm_main : Form
    {
        const string progBar = "*";
        const string errorBar = "E";
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




        private void txtSuggest()
        {
            string[] curWords = txt_search.Text.Split(' ');
            int ba = txt_search.SelectionStart-1;
            int whereAreWe = 0;
            for (int pu=0;pu<txt_search.Text.Length;pu++)
            {
                
                if (txt_search.Text.Substring(pu,1)==" ")
                {
                    whereAreWe++;
                }
                if (pu == ba)
                {
                    //the array position is in the var above
                    break;
                }
            }
            if (ba<0)
            {
                whereAreWe = 0;
            }






            lbl_search.Text = "Active array: " + whereAreWe;


            lst_select.Items.Clear();
            // rtx_term_search.Text = "";
            for (int i = 0; i < sf_Name.Length; i++)
            {
                int lastele = sf_Name[i].Split('\\').Length;
              //  if (priorSpace < txt_search.SelectionStart) //avoid being at the very end or beginign
                {
                    string extension = System.IO.Path.GetExtension(sf_Name[i].Split('\\')[lastele - 1]);
                    string result = sf_Name[i].Split('\\')[lastele - 1].Substring(0, sf_Name[i].Split('\\')[lastele - 1].Length - extension.Length);

 
                    if (curWords[whereAreWe]!="")
                    {

                    
                    if (result.Contains(curWords[whereAreWe]))
                    {






                        //   rtx_term_search.Text = rtx_term_search.Text + sf_Name[i].Split('\\')[lastele - 1] + Environment.NewLine;

                        lst_select.Items.Add(result);

                        //put in our autoselect for closest matching word
                        for (int z = 0; z < lst_select.Items.Count; z++)
                        {

                            debugone = curWords[whereAreWe].Substring(priorSpace);
                            debugtwo = lst_select.Items[z].ToString();

                            stringdif = StringCompare((debugtwo), debugone);
                            // stringdif =(StringCompare(txt_search.Text.Substring(priorSpace), lst_select.Items[z].ToString()));
                            if (stringdif > highestDif)
                            {
                                highestDif = stringdif;
                                difIndex = z;
                            }
                            lbl_debug.Text = "DebugOne: " + debugone + "   DebugTwo: " + debugtwo + "A VALU" + stringdif;
                        }
                    }
                    }
                }
            }

            if (lst_select.Items.Count > 0)
            {

                //11-11-20 old method was to use the index, but that is extra steps. trying the selected item method
                lst_select.SelectedIndex = difIndex;
                lbl_debug.Text = "User Word: " + debugone + " \tBest Match: " + lst_select.SelectedItem.ToString();
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


                txtSuggest();
             

          


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
            tmr_progressPlayer.Enabled = true;
            txt_progress.Text = "";
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
                    highlightNOK();
                    break;
                }
            }

            if (allExist==true)
            {
                worker.RunWorkerAsync();
                btn_play.Enabled = false;
                lbl_status.Text = "Status: OK";
            }
            txt_search.SelectionStart = txt_search.Text.Length;



            lst_select.Items.Clear();




        }


        private void highlightNOK()
        {
            //11-19-20
            //pretty much a copy paste but modified in ways
            string[] spaceSplit1 = txt_search.Text.Split(' ');
            progress = "";





            for (int i = 0; i < spaceSplit1.Length; i++)
            {
                progress = "";
          
              

                    for (int z = 0; z < spaceSplit1[i].Length; z++)
                {

                    if (!File.Exists(audioLibraryLocation + "\\" + spaceSplit1[i] + ".wav"))
                    {
                        if (i == spaceSplit1.Length - 1)
                        {
                            if (z != spaceSplit1[i].Length - 1)//for the last char in array, do nothing. while for everything else do everything
                            {
                                progress = progress + errorBar;
                            }
                        }
                        else
                        {
                            progress = progress + errorBar;
                        }
                    }
                    else
                    {
                        if (i == spaceSplit1.Length - 1)
                        {
                            if (z != spaceSplit1[i].Length - 1)//for the last char in array, do nothing. while for everything else do everything
                            {
                                progress = progress + progBar;
                            }
                        }
                        else
                        {
                            progress = progress + progBar;
                        }
                    }


                 

                }



                    if (i==spaceSplit1.Length-1) //11-19-20 hope this works first try- confirmed-this part makes sure the error/normal text are highlighted properly ok.
                {
                    if (!File.Exists(audioLibraryLocation + "\\" + spaceSplit1[i] + ".wav"))
                    {
                        txt_progress.Text = txt_progress.Text + progress + errorBar;
                    }
                    else
                    {
                        txt_progress.Text = txt_progress.Text + progress + progBar;
                    }
               }
                    else
                {
                    txt_progress.Text = txt_progress.Text + progress + progBar;
                }

              

             
            }

            progress = "";


        }
 

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void txt_search_KeyDown(object sender, KeyEventArgs e)
        {
            int cursorPos = txt_search.SelectionStart;
            if (e.KeyCode==Keys.Space || e.KeyCode==Keys.Enter)
            {

                if ( lst_select.Items.Count>0)
                {

                

                    string[] curWords = txt_search.Text.Split(' ');
                    int ba = txt_search.SelectionStart - 1;
                    int whereAreWe = 0;
                    for (int pu = 0; pu < txt_search.Text.Length; pu++)
                    {

                        if (txt_search.Text.Substring(pu, 1) == " ")
                        {
                            whereAreWe++;
                        }
                        if (pu == ba)
                        {
                            //the array position is in the var above
                            break;
                        }
                    }
                    int curPose =txt_search.SelectionStart;
                    if (ba < 0)
                    {
                        whereAreWe = 0;
                    }

                    curWords[whereAreWe]= lst_select.Items[lst_select.SelectedIndex].ToString();

                    //reconstruct the text box with complete words
                    int cursepos = 0;
                    int finalcursepos = 0;
                    txt_search.Text = null;
                    for (int i=0;i<curWords.Length;i++)
                    {
                        cursepos = cursepos + curWords[i].Length+1; //add one space (1) and the total words (THE LENGTH)
                        txt_search.Text = txt_search.Text  + curWords[i]+ " ";
                        if (i==whereAreWe)
                        {
                            finalcursepos = cursepos;
                            txt_search.SelectionStart = txt_search.Text.Length;
                        }
                    }


                    //11-18-20 something new everyday
                    //https://stackoverflow.com/questions/206717/how-do-i-replace-multiple-spaces-with-a-single-space-in-c?noredirect=1&lq=1
             
                    RegexOptions options = RegexOptions.None;
                    Regex regex = new Regex("[ ]{2,}", options);
                    txt_search.Text = regex.Replace(txt_search.Text, " ");
                    txt_search.SelectionStart = finalcursepos;

                if (e.KeyCode==Keys.Space)
                    {
                        //remove the last char
                        txt_search.Text=txt_search.Text.Remove(txt_search.Text.Length-1);
                        txt_search.SelectionStart = finalcursepos;
                    }
                    lst_select.Items.Clear();
                    /*
                    string[] breaker = txt_search.Text.Split(' ');
                    string recon = null;
                    for (int i = 0; i < breaker.Length - 1; i++)
                    {
                        recon = recon + breaker[i] + " ";
                    }
                    txt_search.Text = recon + lst_select.Items[lst_select.SelectedIndex].ToString();
                    txt_search.SelectionStart = txt_search.Text.Length;
                    */
                }
             
            }
            else if (e.KeyCode==Keys.Up)
            {
                if (txt_search.SelectionStart>0 )
                {
                    txt_search.SelectionStart = cursorPos + 1;
                    if (lst_select.SelectedIndex > 0)
                    {
                        lst_select.SelectedIndex = lst_select.SelectedIndex - 1;
                    }
                  

                }
             
            }
            else if (e.KeyCode==Keys.Down)
            {
                if (txt_search.SelectionStart > 0)
                {
                    txt_search.SelectionStart = cursorPos - 1;
                    if (lst_select.SelectedIndex < lst_select.Items.Count - 1)
                    {
                        lst_select.SelectedIndex = lst_select.SelectedIndex + 1;
                    }
                 
                }
            }
            else
            {
                lst_select.ClearSelected();
                if (txt_search.Text != "")
                {
                     txtSuggest();
                }
                else
                {
                    lst_select.Items.Clear();
                }


            }
        }


        string progress = "";
        private void worker_DoWork_1(object sender, DoWorkEventArgs e)
        {
          
               // txt_search.Text = txt_search.Text.Trim();
            string[] spaceSplit1 = txt_search.Text.Split(' ');
             progress = "";
           
           
           

        
            for (int i = 0; i < spaceSplit1.Length; i++)
            {
                progress = "";
                loadSoundAsync(audioLibraryLocation + "\\" + spaceSplit1[i] + ".wav"); //lst_select.Items[lst_select.SelectedIndex].ToString() 
                for (int z=0;z<spaceSplit1[i].Length;z++)
                {
                    if (i==spaceSplit1.Length-1)
                    {
                        if ( z!= spaceSplit1[i].Length-1)//for the last char in array, do nothing. while for everything else do everything
                        {
                            progress = progress + progBar;
                        }
                    }
                    else
                    {
                        progress = progress + progBar;
                    }
                    
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
            tmr_progressPlayer.Enabled = false;
            txt_progress.Text = "";
            txt_search.Focus();
        }

        private void lst_select_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lst_select_DoubleClick(object sender, EventArgs e)
        {

            string[] breaker = txt_search.Text.Split(' ');
            string recon = null;
            for (int i = 0; i < breaker.Length - 1; i++)
            {
                recon = recon + breaker[i] + " ";
            }
            txt_search.Text = recon + lst_select.Items[lst_select.SelectedIndex].ToString();
            txt_search.SelectionStart = txt_search.Text.Length;
            txt_search.Select();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tmr_progressPlayer_Tick(object sender, EventArgs e)
        {
            if (progress!="")
            {
                txt_progress.Text = txt_progress.Text + progress + progBar;
                txt_search.Focus();
                progress = "";
            }

        }
    }
}
