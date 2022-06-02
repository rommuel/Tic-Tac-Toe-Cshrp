namespace Tic_Tac_Toe_
{
    public partial class Form1 : Form
    {
        int flip = 0;
        public Form1()
        {
            InitializeComponent();
            //Row 1 Buttons
            Xpicb1.Visible = false;
            Opicb1.Visible = false;
            Xpicb2.Visible = false;
            Opicb2.Visible = false;
            Xpicb3.Visible = false;
            Opicb3.Visible = false;

            //Row 2 Buttons
            Xpicb4.Visible = false;
            Opicb4.Visible = false;
            Xpicb5.Visible = false;
            Opicb5.Visible = false;
            Xpicb6.Visible = false;
            Opicb6.Visible = false;

            //Row 3 Buttons
            Xpicb7.Visible = false;
            Opicb7.Visible = false;
            Xpicb8.Visible = false;
            Opicb8.Visible = false;
            Xpicb9.Visible = false;
            Opicb9.Visible = false;
        }

        
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            b3.Enabled = false;
            b3.Visible = false;
            flip = flip + 1;

            if (flip % 2 == 0)
            {
                // Show O visibly
                Opicb3.Visible = true;

            }
            else
            {
                // Show X visibly
                Xpicb3.Visible = true;
            }
            // Win determiner for O (block 3)
            if (Opicb3.Visible)
            {
                // Determine Win for O pattern with last O in block 3.

                // O O L
                // - - -
                // - - -
                if (Opicb2.Visible)
                {
                    if (Opicb1.Visible)
                    {
                        MessageBox.Show("Player O wins!");
                        Application.Restart();
                        Environment.Exit(0);
                    }
                }
                // - - L
                // - O -
                // O - -
                if (Opicb5.Visible)
                {
                    if (Opicb7.Visible)
                    {
                        MessageBox.Show("Player O wins!");
                        Application.Restart();
                        Environment.Exit(0);
                    }
                }
                // - - L
                // - - O
                // - - O
                if (Opicb6.Visible)
                {
                    if (Opicb9.Visible)
                    {
                        MessageBox.Show("Player O wins!");
                        Application.Restart();
                        Environment.Exit(0);
                    }
                }
            }
        }

        private void b1_Click(object sender, EventArgs e)
        {
            b1.Enabled = false;
            b1.Visible = false;
            flip = flip + 1;

            if (flip % 2 == 0)
            {
                // Show O visibly
                Opicb1.Visible = true;

            }
            else
            {
                // Show X visibly
                Xpicb1.Visible = true;
            }
            // Win determiner for O (block 1)
            if (Opicb1.Visible)
            {
                // Determine Win for O pattern with last O in block 1.

                // L O O
                // - - -
                // - - -
                if (Opicb2.Visible)
                {
                    if (Opicb3.Visible)
                    {
                        MessageBox.Show("Player O wins!");
                        Application.Restart();
                        Environment.Exit(0);
                    }
                }
                // L - -
                // - O -
                // - - O
                if (Opicb5.Visible)
                {
                    if (Opicb9.Visible)
                    {
                        MessageBox.Show("Player O wins!");
                        Application.Restart();
                        Environment.Exit(0);
                    }
                }
                // L - -
                // O - -
                // O - -
                if (Opicb4.Visible)
                {
                    if (Opicb7.Visible)
                    {
                        MessageBox.Show("Player O wins!");
                        Application.Restart();
                        Environment.Exit(0);
                    }
                }
            }
        }

        private void Helpbtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Two Players: Player 1 marks as X, and Player 2 marks as O.");
            MessageBox.Show("The Players take turns in filling boxes with their marks (Xs or Os). Player X is the first turn.");
            MessageBox.Show("The first player to form a straight mark line of three wins. Good Luck!");
        }

        private void Xpicb1_Click(object sender, EventArgs e)
        {
            // Render X image as invisible initially
            //Xpicb1.Visible = false;

        }

        private void Opicb1_Click(object sender, EventArgs e)
        {
            // Render O image as invisible initially
            //Opicb1.Visible = false;
        }

        private void b2_Click(object sender, EventArgs e)
        {
            b2.Enabled = false;
            b2.Visible = false;
            flip = flip + 1;

            if (flip % 2 == 0)
            {
                // Show O visibly
                Opicb2.Visible = true;

            }
            else
            {
                // Show X visibly
                Xpicb2.Visible = true;
            }
            // Win determiner for O (block 2)
            if (Opicb2.Visible)
            {
                // Determine Win for O pattern with last O in block 2.

                // O L O
                // - - -
                // - - -
                if (Opicb1.Visible)
                {
                    if (Opicb3.Visible)
                    {
                        MessageBox.Show("Player O wins!");
                        Application.Restart();
                        Environment.Exit(0);
                    }
                }
                // - L -
                // - O -
                // - O -
                if (Opicb5.Visible)
                {
                    if (Opicb8.Visible)
                    {
                        MessageBox.Show("Player O wins!");
                        Application.Restart();
                        Environment.Exit(0);
                    }
                }
            }
        }

        private void b4_Click(object sender, EventArgs e)
        {
            b4.Enabled = false;
            b4.Visible = false;
            flip = flip + 1;

            if (flip % 2 == 0)
            {
                // Show O visibly
                Opicb4.Visible = true;

            }
            else
            {
                // Show X visibly
                Xpicb4.Visible = true;
            }
            // Win determiner for O (block 4)
            if (Opicb4.Visible)
            {
                // Determine Win for O pattern with last O in block 2.

                // O - -
                // L - -
                // O - -
                if (Opicb1.Visible)
                {
                    if (Opicb7.Visible)
                    {
                        MessageBox.Show("Player O wins!");
                        Application.Restart();
                        Environment.Exit(0);
                    }
                }
                // - - -
                // L O O
                // - - -
                if (Opicb5.Visible)
                {
                    if (Opicb6.Visible)
                    {
                        MessageBox.Show("Player O wins!");
                        Application.Restart();
                        Environment.Exit(0);
                    }
                }
            }

        }

        private void b5_Click(object sender, EventArgs e)
        {
            b5.Enabled = false;
            b5.Visible = false;
            flip = flip + 1;

            if (flip % 2 == 0)
            {
                // Show O visibly
                Opicb5.Visible = true;

            }
            else
            {
                // Show X visibly
                Xpicb5.Visible = true;
            }
        }

        private void b6_Click(object sender, EventArgs e)
        {
            b6.Enabled = false;
            b6.Visible = false;
            flip = flip + 1;

            if (flip % 2 == 0)
            {
                // Show O visibly
                Opicb6.Visible = true;

            }
            else
            {
                // Show X visibly
                Xpicb6.Visible = true;
            }
        }

        private void b7_Click(object sender, EventArgs e)
        {
            b7.Enabled = false;
            b7.Visible = false;
            flip = flip + 1;

            if (flip % 2 == 0)
            {
                // Show O visibly
                Opicb7.Visible = true;

            }
            else
            {
                // Show X visibly
                Xpicb7.Visible = true;
            }
        }

        private void b8_Click(object sender, EventArgs e)
        {
            b8.Enabled = false;
            b8.Visible = false;
            flip = flip + 1;

            if (flip % 2 == 0)
            {
                // Show O visibly
                Opicb8.Visible = true;

            }
            else
            {
                // Show X visibly
                Xpicb8.Visible = true;
            }
        }

        private void b9_Click(object sender, EventArgs e)
        {
            b9.Enabled = false;
            b9.Visible = false;
            flip = flip + 1;

            if (flip % 2 == 0)
            {
                // Show O visibly
                Opicb9.Visible = true;

            }
            else
            {
                // Show X visibly
                Xpicb9.Visible = true;
            }
         
        }

        private void Opicb7_Click(object sender, EventArgs e)
        {

        }

        private void Restartbtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Game reset!");
            Application.Restart();
            Environment.Exit(0);
        }

        private void Xpicb2_Click(object sender, EventArgs e)
        {

        }
    }
}