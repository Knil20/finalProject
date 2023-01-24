using System.Media;

namespace finalProject

{
    //Candy Clicker
    //Dominic Winter-Pacheco
    public partial class Form1 : Form
    {
       

        int points = 0;
        int clickValue = 0;
        int autoClicker = 0;
        int autoValue = 0;
        int bUpgrade = 1;
        int bUpgradeCost = 25;
        int mUpgrade = 10;
        int mUpgradeCost = 250;
        int lUpgrade = 100;
        int lUpgradeCost = 2500;
        int bAuto = 1;
        int bAutoCost = 5000;
        int mAuto = 10;
        int mAutoCost = 50000;
        int lAuto = 100;
        int lAutoCost = 1000000;

        SoundPlayer click = new SoundPlayer(Properties.Resources.click);
        public Form1()
        {
            InitializeComponent();
            //displaying text
            cpsLabel.Text = $"CPS = {clickValue + 1}";
            totalLabel.Text = $"Candy = {points + autoClicker}";
            basicUpgradeButton.Text = $"Cost = {bUpgradeCost}";
            mediumUpgradeButton.Text = $"Cost = {mUpgradeCost}";
            largeUpgradeButton.Text = $"Cost = {lUpgradeCost}";
            basicAutoButton.Text = $"Cost = {bAutoCost}";
            mediumAutoButton.Text = $"Cost = {mAutoCost}";
            largeAutoButton.Text = $"Cost = {lAutoCost}";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //adding points to counter
            points += clickValue;
            points++;

            //showing points too respective places
            totalLabel.Text = $"Candy = {points + autoClicker}";
            cpsLabel.Text = $"CPS = {clickValue + 1}";

            //play sound
            click.Play();
            
        }

        private void basicUpgradeButton_Click(object sender, EventArgs e)
        {
            
            if (points >= bUpgradeCost)
            {
                //pay for upgrade
                points = points - bUpgradeCost;

                //updating how much you earn per click
                clickValue += bUpgrade;
                cpsLabel.Text = $"CPS = {clickValue + 1}";

                //show how many points are left
                totalLabel.Text = $"Candy = {points}";

                //update upgrade cost for next purchase level
                bUpgradeCost = bUpgradeCost * 2;
                basicUpgradeButton.Text = $"Cost = {bUpgradeCost}";


            }
            else
            {

            }
            
        }

        private void mediumUpgradeButton_Click(object sender, EventArgs e)
        {
            
            
            if (points >= mUpgradeCost)
            {
                //pay for upgrade
                points = points - mUpgradeCost;

                //updating how much you earn per click
                clickValue += mUpgrade;
                cpsLabel.Text = $"CPS = {clickValue + 1}";

                //show how many points are left
                totalLabel.Text = $"Candy = {points}";
                
                //update upgrade cost for next purchase level
                mUpgradeCost = mUpgradeCost * 2;
                mediumUpgradeButton.Text = $"Cost = {mUpgradeCost}";
            }
            else
            {

            }
        }

        private void largeUpgradeButton_Click(object sender, EventArgs e)
        {
            
            if (points >= lUpgradeCost)
            {
                //pay for upgrade
                points = points - lUpgradeCost;

                //updating how much you earn per click
                clickValue += lUpgrade;
                cpsLabel.Text = $"CPS = {clickValue + 1}";

                //show how many points are left
                totalLabel.Text = $"Candy = {points}";

                //update upgrade cost for next purchase level
                lUpgradeCost = lUpgradeCost * 2;
                largeUpgradeButton.Text = $"Cost = {lUpgradeCost}";


            }
            else
            {

            }
            
        }

        private void basicAutoButton_Click(object sender, EventArgs e)
        {
            
           
            if (points >= bAutoCost)
            {
                //pay for auto upgrade
                points = points - bAutoCost;

                //update the amount earned per timer tick
                autoValue += bAuto;
                autoLabel.Text = $" Auto = {autoValue}";

                //show how many points are left
                totalLabel.Text = $"Candy = {points}";

                //update upgrade cost for next purchase level
                bAutoCost = bAutoCost * 2;
                basicAutoButton.Text = $"Cost = {bAutoCost}";
            }
            else
            {

            }
        }

        private void mediumAutoButton_Click(object sender, EventArgs e)
        {
            
            if (points >= mAutoCost)
            {
                //pay for auto upgrade
                points = points - mAutoCost;

                //update the amount earned per timer tick
                autoValue += mAuto;
                autoLabel.Text = $" Auto = {autoValue}";

                //show how many points are left
                totalLabel.Text = $"Candy = {points}";

                //update upgrade cost for next purchase level
                mAutoCost = mAutoCost * 2;
                mediumAutoButton.Text = $"Cost = {mAutoCost}";
            }
            else
            {

            }
        }

        private void largeAutoButton_Click(object sender, EventArgs e)
        {
            
            if (points >= lAutoCost)
            {
                //pay for auto upgrade
                points = points - lAutoCost;

                //update the amount earned per timer tick
                autoValue += lAuto;
                autoLabel.Text = $" Auto = {autoValue}";

                //show how many points are left
                totalLabel.Text = $"Candy = {points}";

                //update upgrade cost for next purchase level
                lAutoCost = lAutoCost * 2;
                largeAutoButton.Text = $"Cost = {lAutoCost}";
            }
            else
            {

            }
        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {
            //adding auto points to total points
            points += autoValue;

            //dislaying points
            totalLabel.Text = $"Candy = {points}";


            Refresh();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            //changes labels/buttons to show or not show
            titleLabel.Visible = false;
            startButton.Visible = false;

            cpsLabel.Visible = true;
            autoLabel.Visible = true;
            totalLabel.Visible = true;
            basicUpgradeButton.Visible = true;
            basicAutoButton.Visible = true;
            mediumUpgradeButton.Visible = true;
            mediumAutoButton.Visible = true;
            largeUpgradeButton.Visible = true;
            largeAutoButton.Visible = true;
            pictureBox1.Visible = true;
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            label6.Visible = true;
            label7.Visible = true;
            label8.Visible = true;
            resetButton.Visible = true;
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            //reseting values
            clickValue = 0;
            autoClicker = 0;
            autoValue = 0;
            bUpgrade = 1;
            bUpgradeCost = 25;
            mUpgrade = 10;
            mUpgradeCost = 250;
            lUpgrade = 100;
            lUpgradeCost = 2500;
            bAuto = 1;
            bAutoCost = 5000;
            mAuto = 10;
            mAutoCost = 50000;
            lAuto = 100;
            lAutoCost = 1000000;
            points = 0;

            //displaying text
            cpsLabel.Text = $"CPS = {clickValue + 1}";
            autoLabel.Text = $"CPS = {autoValue}";
            totalLabel.Text = $"Candy = {points + autoClicker}";
            basicUpgradeButton.Text = $"Cost = {bUpgradeCost}";
            mediumUpgradeButton.Text = $"Cost = {mUpgradeCost}";
            largeUpgradeButton.Text = $"Cost = {lUpgradeCost}";
            basicAutoButton.Text = $"Cost = {bAutoCost}";
            mediumAutoButton.Text = $"Cost = {mAutoCost}";
            largeAutoButton.Text = $"Cost = {lAutoCost}";
        }
    }
}