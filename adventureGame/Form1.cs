using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Media;
//

namespace adventureGame
{
    public partial class gameBackground : Form
    {


        //Music input
        SoundPlayer beginmusicplayer = new SoundPlayer(Properties.Resources.begin_music);
        SoundPlayer wizardline1 = new SoundPlayer(Properties.Resources.Wizard_line_1);
        SoundPlayer wizardline2 = new SoundPlayer(Properties.Resources.Wizard_line_2);
        SoundPlayer Damsel = new SoundPlayer(Properties.Resources.Damsel);
        SoundPlayer AngryElf = new SoundPlayer(Properties.Resources.AngryElf);
        //integers 
        int page = 1;

        public gameBackground()
        {
            
            InitializeComponent();

            //Hide
            welcomeLabel.Visible = false;
            wizardImageBox.Visible = false;
            gameText.Visible = false;
            nextFormButton.Visible = false;
            option1.Visible = false;
            option2.Visible = false;
            slimeImage.Visible = false;
            fightImage.Visible = false;
            angryElfImage.Visible = false;
            damselImage.Visible = false;

        }
        private void beginButton_Click(object sender, EventArgs e)
        {
            beginmusicplayer.Play();

            //welcome message
            welcomeLabel.Visible = true;
            welcomeLabel.Text = $"AN EDEN POWER PRODUCTION";

            //Stop music
            Refresh();
            Thread.Sleep(2000);

            //disable labels 
            iconBox.Visible = false;
            welcomeLabel.Visible = false;
            beginButton.Visible = false;

            //Show images
            wizardImageBox.Visible = true;
            gameText.Visible = true;
            nextFormButton.Visible = true;

            //music
            beginmusicplayer.Play();
        }

        private void nextFormButton_Click(object sender, EventArgs e)
        {
            //Disable Images
            wizardImageBox.Visible = false;
            nextFormButton.Visible = false;

            //Enable Images
            option1.Visible = true;
            option2.Visible = true;

            //Text Display
            gameText.Text = "Are you ready to begin young Wizard?";



        }

        private void option2_Click(object sender, EventArgs e)
        {
            if (page == 1) { page = 99; }
            else if (page == 4) { page = 5; }
            else if (page == 5) { page = 99; }
            else if (page == 6) { page = 8; }
            else if (page == 8) { page = 1; }
            else if (page == 5) { page = 1; }
            else if (page == 11) { page = 14; }

            DisplayPage();

        }

        private void option1_Click(object sender, EventArgs e)
        {
            if (page == 1) { page = 4; }
            else if (page == 4) { page = 6; }
            else if (page == 6) { page = 7; }
            else if (page == 7) { page = 10; }
            else if (page == 10) { page = 11; }
            else if (page == 11) { page = 1; }
           

            DisplayPage();


        }
        public void DisplayPage()
        {
            switch (page)
            {
                case 1:
                    beginmusicplayer.Play();
                    //welcome message
                    welcomeLabel.Visible = true;
                    welcomeLabel.Text = $"AN EDEN POWER PRODUCTION";

                    //Stop music
                    Refresh();
                    Thread.Sleep(2000);

                    //disable labels 
                    iconBox.Visible = false;
                    welcomeLabel.Visible = false;
                    beginButton.Visible = false;
                    fightImage.Visible = false;
                    option1.Visible = false;
                    option2.Visible = false;
                    gameText.Visible = false;

                    //Show images
                    wizardImageBox.Visible = true;
                    gameText.Visible = true;
                    nextFormButton.Visible = true;

                    //music
                    beginmusicplayer.Play();
                    break;
                case 4:
                    //coordinates 
                    //wizardImageBox.Scale = (366, 234);

                    //Disable Labels
                    option1.Visible = false;
                    option2.Visible = false;

                    //Show Images
                    slimeImage.Visible = false;
                    wizardImageBox.Visible = true;

                    // Text and chacater sound output
                    gameText.Text = "The Wizard sets off on his journey when suddenly...";
                    Refresh();
                    Thread.Sleep(2000);
                    wizardline1.Play();
                    gameText.Text = "Wizard:";
                    gameText.Text += $"\nGAH!A SLIME";
                    slimeImage.Visible = true;

                    //Move to next page
                    Refresh();
                    Thread.Sleep(2000);
                    wizardline1.Stop();
                    wizardImageBox.Visible = false;
                    slimeImage.Visible = false;
                    gameText.Text = "Will you fight the slime?";
                    Refresh();
                    Thread.Sleep(1000);
                    option1.Visible = true;
                    option2.Visible = true;

                    break;
                case 5:
                    gameText.Text = "You couldn't escape and you died :(";
                    fightImage.Visible = true;
                    Refresh();
                    Thread.Sleep(2000);
                    gameText.Text = "Would you like to play again?";
                    option2.Visible = true;
                    option1.Visible = true;
                    break;
                case 6:
                    //Show Image
                    fightImage.Visible = true;

                    //disable images
                    option1.Visible = false;
                    option2.Visible = false;

                    //text output
                    gameText.Text = "he faces the slime head on as he begins to chant a magic spell";
                    Refresh();
                    Thread.Sleep(2000);
                    wizardline2.Play();
                    gameText.Text = "Wizard";
                    gameText.Text += "\nLet's do this!";
                    wizardline2.Stop();
                    gameText.Text = "Sparks fly from his hands as he strikes the slime";
                    Refresh();
                    Thread.Sleep(2000);
                    gameText.Text = "The slime disintegrates in an instant and the wizard is able to continue on his journey";

                    //next form
                    Refresh();
                    Thread.Sleep(3000);
                    fightImage.Visible = false;
                    wizardImageBox.Visible = true;
                    gameText.Text = "As you continue on with your journey you come to a fork in the road!!";
                    Refresh();
                    Thread.Sleep(1000);
                    option1.Visible = true;
                    option2.Visible = true;
                    option1.Text = "RIGHT";
                    option2.Text = "LEFT";

                    break;
                case 7:
                    // disable options
                    option1.Visible = false;
                    option2.Visible = false;

                    gameText.Text = "You find a damsel...OH NO! It seems shes in distress";
                    Refresh();
                    Thread.Sleep(2000);

                    // Show Characters
                    angryElfImage.Visible = true;
                    damselImage.Visible = true;

                    Refresh();
                    Thread.Sleep(2000);

                    // character sounds
                    Damsel.Play();
                    gameText.Text = "Damsel:";
                    gameText.Text += $"\nHELP, HEEE- !!";
                    Refresh();
                    Thread.Sleep(2000);

                    AngryElf.Play();
                    gameText.Text = "Angry Elf:";
                    gameText.Text += $"\nShut it LADY!!";
                    Refresh();
                    Thread.Sleep(2000);
                    gameText.Text = "Will you help her?";
                    option2.Visible = true;
                    option1.Visible = true;
                    option1.Text = "Yes";
                    option2.Text = "No";
                    break;
                case 8:
                    gameText.Text = "Oh no!...You got eaten by giant spiders :(";
                    Refresh();
                    Thread.Sleep(2000);
                    gameText.Text = "Play again...?";
                    Refresh();
                    Thread.Sleep(2000);
                    option1.Visible = true;
                    option2.Visible = true;
                    break;

                case 9:
                    //disable buttons
                    option2.Visible = false;
                    option1.Visible = false;
                    gameText.Text = "You trip over a bigroot while trying to get away and you die";
                    Refresh();
                    Thread.Sleep(2000);
                    gameText.Text = "Play again...?";
                    Refresh();
                    Thread.Sleep(2000);
                    option1.Visible = true;
                    option2.Visible = true;
                    break;

                case 10:
                    //disable characters
                    angryElfImage.Visible = false;

                    //disable buttons
                    option1.Visible = false;
                    option2.Visible = false;
                    gameText.Text = "You saved her!! She comes in close...";
                    Refresh();
                    Thread.Sleep(2000);
                    gameText.Text = "Do you kiss her?";
                    Refresh();
                    Thread.Sleep(2000);
                    option1.Visible = true;
                    option2.Visible = true;
                    break;

                case 11:
                    option1.Visible = false;
                    option2.Visible = false;

                    gameText.Text = "You both fall madly in love and continue on you great adventure to become an all powerful wizard.";
                    Refresh();
                    Thread.Sleep(3000);

                    gameText.Text += $"THANKS FOR PLAYING MY GAME :) \n Thanks too: Kay Broda, Ali Doupe, Soaphie Hoffman, Mr.Osborne, Eric Evans, Ella Ruby, and Violet ShipWay, and Ewan Siebert!!!";
                    Refresh();
                    Thread.Sleep(2000);
                    gameText.Text = "Play again...?";
                    Refresh();
                    Thread.Sleep(2000);
                    option1.Visible = true;
                    option2.Visible = true;
                    break;

                case 12:
                    gameText.Text = "she leaves you forever and you live with the mistake for the rest of your life :C ";
                    Refresh();
                    Thread.Sleep(2000);
                    gameText.Text = "Play again...?";
                    Refresh();
                    Thread.Sleep(2000);
                    option1.Visible = true;
                    option2.Visible = true;
                    break;

                case 13:
                    gameText.Text = "you overcome the great temptation of love and move forward on your adventure you become a great powerful wizard !!";
                    break;

                case 99:
                    //Text Display
                    gameText.Text = "Thanks for playing";
                    //Closing Form
                    Refresh();
                    Thread.Sleep(1000);
                    this.Close();
                    break;
                default:
                    break;

               
                  
            }
        }

      
    }
}
