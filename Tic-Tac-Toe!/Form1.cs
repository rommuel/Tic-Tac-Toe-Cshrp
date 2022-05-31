namespace Tic_Tac_Toe_
{
    public partial class Form1 : Form
    {
        int flip = 0;
        public Form1()
        {
            InitializeComponent();
            Xpicb1.Visible = false;
            Opicb1.Visible = false;
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
            
        }

        private void Helpbtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Two Players: Player 1 marks as X, and Player 2 marks as O.");
            MessageBox.Show("The Players take turns in filling boxes with their marks (Xs or Os)");
            MessageBox.Show("The first player to form a straight mark line of three win. Good Luck!");
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
    }
}