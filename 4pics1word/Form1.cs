namespace _4pics1word
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String given = "J";
            button1.Enabled = false;
            if (textBox1.Text == String.Empty)
            {
                textBox1.Text = given;
            } else if (textBox2.Text == String.Empty)
            {
                textBox2.Text = given;
            } else if (textBox3.Text == String.Empty)
            {
                textBox3.Text = given;
            } else if (textBox4.Text == String.Empty)
            {
                textBox4.Text = given;
                if (textBox1.Text + textBox2.Text + textBox3.Text + textBox4.Text == "STAR")
                {
                    MessageBox.Show("Correct and you got it right!", "Correct!", MessageBoxButtons.OK);
		            // Resets the game.
		            textBox1.Text = textBox2.Text = textBox3.Text = textBox4.Text = "";
                    button1.Enabled = button2.Enabled = button3.Enabled = button4.Enabled = button5.Enabled = button6.Enabled = button7.Enabled = button8.Enabled = button9.Enabled = button10.Enabled = button11.Enabled = button12.Enabled = true;
                } else
                {
                    MessageBox.Show("Incorrect Letters, Resetting...", "Incorrect!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox1.Text = textBox2.Text = textBox3.Text = textBox4.Text = "";
                    button1.Enabled = button2.Enabled = button3.Enabled = button4.Enabled = button5.Enabled = button6.Enabled = button7.Enabled = button8.Enabled = button9.Enabled = button10.Enabled = button11.Enabled = button12.Enabled = true;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String given = "E";
            button2.Enabled = false;
            if (textBox1.Text == String.Empty)
            {
                textBox1.Text = given;
            }
            else if (textBox2.Text == String.Empty)
            {
                textBox2.Text = given;
            }
            else if (textBox3.Text == String.Empty)
            {
                textBox3.Text = given;
            }
            else if (textBox4.Text == String.Empty)
            {
                textBox4.Text = given;
                if (textBox1.Text + textBox2.Text + textBox3.Text + textBox4.Text == "STAR")
                {
                    MessageBox.Show("Correct and you got it right!", "Correct!", MessageBoxButtons.OK);
                    // Resets the game.
                    textBox1.Text = textBox2.Text = textBox3.Text = textBox4.Text = "";
                    button1.Enabled = button2.Enabled = button3.Enabled = button4.Enabled = button5.Enabled = button6.Enabled = button7.Enabled = button8.Enabled = button9.Enabled = button10.Enabled = button11.Enabled = button12.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Incorrect Letters, Resetting...", "Incorrect!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox1.Text = textBox2.Text = textBox3.Text = textBox4.Text = "";
                    button1.Enabled = button2.Enabled = button3.Enabled = button4.Enabled = button5.Enabled = button6.Enabled = button7.Enabled = button8.Enabled = button9.Enabled = button10.Enabled = button11.Enabled = button12.Enabled = true;
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            String given = "A";
            button3.Enabled = false;
            if (textBox1.Text == String.Empty)
            {
                textBox1.Text = given;
            }
            else if (textBox2.Text == String.Empty)
            {
                textBox2.Text = given;
            }
            else if (textBox3.Text == String.Empty)
            {
                textBox3.Text = given;
            }
            else if (textBox4.Text == String.Empty)
            {
                textBox4.Text = given;
                if (textBox1.Text + textBox2.Text + textBox3.Text + textBox4.Text == "STAR")
                {
                    MessageBox.Show("Correct and you got it right!", "Correct!", MessageBoxButtons.OK);
                    // Resets the game.
                    textBox1.Text = textBox2.Text = textBox3.Text = textBox4.Text = "";
                    button1.Enabled = button2.Enabled = button3.Enabled = button4.Enabled = button5.Enabled = button6.Enabled = button7.Enabled = button8.Enabled = button9.Enabled = button10.Enabled = button11.Enabled = button12.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Incorrect Letters, Resetting...", "Incorrect!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox1.Text = textBox2.Text = textBox3.Text = textBox4.Text = "";
                    button1.Enabled = button2.Enabled = button3.Enabled = button4.Enabled = button5.Enabled = button6.Enabled = button7.Enabled = button8.Enabled = button9.Enabled = button10.Enabled = button11.Enabled = button12.Enabled = true;
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            String given = "O";
            button4.Enabled = false;
            if (textBox1.Text == String.Empty)
            {
                textBox1.Text = given;
            }
            else if (textBox2.Text == String.Empty)
            {
                textBox2.Text = given;
            }
            else if (textBox3.Text == String.Empty)
            {
                textBox3.Text = given;
            }
            else if (textBox4.Text == String.Empty)
            {
                textBox4.Text = given;
                if (textBox1.Text + textBox2.Text + textBox3.Text + textBox4.Text == "STAR")
                {
                    MessageBox.Show("Correct and you got it right!", "Correct!", MessageBoxButtons.OK);
                    // Resets the game.
                    textBox1.Text = textBox2.Text = textBox3.Text = textBox4.Text = "";
                    button1.Enabled = button2.Enabled = button3.Enabled = button4.Enabled = button5.Enabled = button6.Enabled = button7.Enabled = button8.Enabled = button9.Enabled = button10.Enabled = button11.Enabled = button12.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Incorrect Letters, Resetting...", "Incorrect!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox1.Text = textBox2.Text = textBox3.Text = textBox4.Text = "";
                    button1.Enabled = button2.Enabled = button3.Enabled = button4.Enabled = button5.Enabled = button6.Enabled = button7.Enabled = button8.Enabled = button9.Enabled = button10.Enabled = button11.Enabled = button12.Enabled = true;
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            String given = "T";
            button5.Enabled = false;
            if (textBox1.Text == String.Empty)
            {
                textBox1.Text = given;
            }
            else if (textBox2.Text == String.Empty)
            {
                textBox2.Text = given;
            }
            else if (textBox3.Text == String.Empty)
            {
                textBox3.Text = given;
            }
            else if (textBox4.Text == String.Empty)
            {
                textBox4.Text = given;
                if (textBox1.Text + textBox2.Text + textBox3.Text + textBox4.Text == "STAR")
                {
                    MessageBox.Show("Correct and you got it right!", "Correct!", MessageBoxButtons.OK);
                    // Resets the game.
                    textBox1.Text = textBox2.Text = textBox3.Text = textBox4.Text = "";
                    button1.Enabled = button2.Enabled = button3.Enabled = button4.Enabled = button5.Enabled = button6.Enabled = button7.Enabled = button8.Enabled = button9.Enabled = button10.Enabled = button11.Enabled = button12.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Incorrect Letters, Resetting...", "Incorrect!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox1.Text = textBox2.Text = textBox3.Text = textBox4.Text = "";
                    button1.Enabled = button2.Enabled = button3.Enabled = button4.Enabled = button5.Enabled = button6.Enabled = button7.Enabled = button8.Enabled = button9.Enabled = button10.Enabled = button11.Enabled = button12.Enabled = true;
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            String given = "C";
            button6.Enabled = false;
            if (textBox1.Text == String.Empty)
            {
                textBox1.Text = given;
            }
            else if (textBox2.Text == String.Empty)
            {
                textBox2.Text = given;
            }
            else if (textBox3.Text == String.Empty)
            {
                textBox3.Text = given;
            }
            else if (textBox4.Text == String.Empty)
            {
                textBox4.Text = given;
                if (textBox1.Text + textBox2.Text + textBox3.Text + textBox4.Text == "STAR")
                {
                    MessageBox.Show("Correct and you got it right!", "Correct!", MessageBoxButtons.OK);
                    // Resets the game.
                    textBox1.Text = textBox2.Text = textBox3.Text = textBox4.Text = "";
                    button1.Enabled = button2.Enabled = button3.Enabled = button4.Enabled = button5.Enabled = button6.Enabled = button7.Enabled = button8.Enabled = button9.Enabled = button10.Enabled = button11.Enabled = button12.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Incorrect Letters, Resetting...", "Incorrect!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox1.Text = textBox2.Text = textBox3.Text = textBox4.Text = "";
                    button1.Enabled = button2.Enabled = button3.Enabled = button4.Enabled = button5.Enabled = button6.Enabled = button7.Enabled = button8.Enabled = button9.Enabled = button10.Enabled = button11.Enabled = button12.Enabled = true;
                }
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            String given = "P";
            button7.Enabled = false;
            if (textBox1.Text == String.Empty)
            {
                textBox1.Text = given;
            }
            else if (textBox2.Text == String.Empty)
            {
                textBox2.Text = given;
            }
            else if (textBox3.Text == String.Empty)
            {
                textBox3.Text = given;
            }
            else if (textBox4.Text == String.Empty)
            {
                textBox4.Text = given;
                if (textBox1.Text + textBox2.Text + textBox3.Text + textBox4.Text == "STAR")
                {
                    MessageBox.Show("Correct and you got it right!", "Correct!", MessageBoxButtons.OK);
                    // Resets the game.
                    textBox1.Text = textBox2.Text = textBox3.Text = textBox4.Text = "";
                    button1.Enabled = button2.Enabled = button3.Enabled = button4.Enabled = button5.Enabled = button6.Enabled = button7.Enabled = button8.Enabled = button9.Enabled = button10.Enabled = button11.Enabled = button12.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Incorrect Letters, Resetting...", "Incorrect!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox1.Text = textBox2.Text = textBox3.Text = textBox4.Text = "";
                    button1.Enabled = button2.Enabled = button3.Enabled = button4.Enabled = button5.Enabled = button6.Enabled = button7.Enabled = button8.Enabled = button9.Enabled = button10.Enabled = button11.Enabled = button12.Enabled = true;
                }
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            String given = "H";
            button8.Enabled = false;
            if (textBox1.Text == String.Empty)
            {
                textBox1.Text = given;
            }
            else if (textBox2.Text == String.Empty)
            {
                textBox2.Text = given;
            }
            else if (textBox3.Text == String.Empty)
            {
                textBox3.Text = given;
            }
            else if (textBox4.Text == String.Empty)
            {
                textBox4.Text = given;
                if (textBox1.Text + textBox2.Text + textBox3.Text + textBox4.Text == "STAR")
                {
                    MessageBox.Show("Correct and you got it right!", "Correct!", MessageBoxButtons.OK);
                    // Resets the game.
                    textBox1.Text = textBox2.Text = textBox3.Text = textBox4.Text = "";
                    button1.Enabled = button2.Enabled = button3.Enabled = button4.Enabled = button5.Enabled = button6.Enabled = button7.Enabled = button8.Enabled = button9.Enabled = button10.Enabled = button11.Enabled = button12.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Incorrect Letters, Resetting...", "Incorrect!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox1.Text = textBox2.Text = textBox3.Text = textBox4.Text = "";
                    button1.Enabled = button2.Enabled = button3.Enabled = button4.Enabled = button5.Enabled = button6.Enabled = button7.Enabled = button8.Enabled = button9.Enabled = button10.Enabled = button11.Enabled = button12.Enabled = true;
                }
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            String given = "L";
            button9.Enabled = false;
            if (textBox1.Text == String.Empty)
            {
                textBox1.Text = given;
            }
            else if (textBox2.Text == String.Empty)
            {
                textBox2.Text = given;
            }
            else if (textBox3.Text == String.Empty)
            {
                textBox3.Text = given;
            }
            else if (textBox4.Text == String.Empty)
            {
                textBox4.Text = given;
                if (textBox1.Text + textBox2.Text + textBox3.Text + textBox4.Text == "STAR")
                {
                    MessageBox.Show("Correct and you got it right!", "Correct!", MessageBoxButtons.OK);
                    // Resets the game.
                    textBox1.Text = textBox2.Text = textBox3.Text = textBox4.Text = "";
                    button1.Enabled = button2.Enabled = button3.Enabled = button4.Enabled = button5.Enabled = button6.Enabled = button7.Enabled = button8.Enabled = button9.Enabled = button10.Enabled = button11.Enabled = button12.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Incorrect Letters, Resetting...", "Incorrect!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox1.Text = textBox2.Text = textBox3.Text = textBox4.Text = "";
                    button1.Enabled = button2.Enabled = button3.Enabled = button4.Enabled = button5.Enabled = button6.Enabled = button7.Enabled = button8.Enabled = button9.Enabled = button10.Enabled = button11.Enabled = button12.Enabled = true;
                }
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            String given = "S";
            button10.Enabled = false;
            if (textBox1.Text == String.Empty)
            {
                textBox1.Text = given;
            }
            else if (textBox2.Text == String.Empty)
            {
                textBox2.Text = given;
            }
            else if (textBox3.Text == String.Empty)
            {
                textBox3.Text = given;
            }
            else if (textBox4.Text == String.Empty)
            {
                textBox4.Text = given;
                if (textBox1.Text + textBox2.Text + textBox3.Text + textBox4.Text == "STAR")
                {
                    MessageBox.Show("Correct and you got it right!", "Correct!", MessageBoxButtons.OK);
                    // Resets the game.
                    textBox1.Text = textBox2.Text = textBox3.Text = textBox4.Text = "";
                    button1.Enabled = button2.Enabled = button3.Enabled = button4.Enabled = button5.Enabled = button6.Enabled = button7.Enabled = button8.Enabled = button9.Enabled = button10.Enabled = button11.Enabled = button12.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Incorrect Letters, Resetting...", "Incorrect!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox1.Text = textBox2.Text = textBox3.Text = textBox4.Text = "";
                    button1.Enabled = button2.Enabled = button3.Enabled = button4.Enabled = button5.Enabled = button6.Enabled = button7.Enabled = button8.Enabled = button9.Enabled = button10.Enabled = button11.Enabled = button12.Enabled = true;
                }
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            String given = "R";
            button11.Enabled = false;
            if (textBox1.Text == String.Empty)
            {
                textBox1.Text = given;
            }
            else if (textBox2.Text == String.Empty)
            {
                textBox2.Text = given;
            }
            else if (textBox3.Text == String.Empty)
            {
                textBox3.Text = given;
            }
            else if (textBox4.Text == String.Empty)
            {
                textBox4.Text = given;
                if (textBox1.Text + textBox2.Text + textBox3.Text + textBox4.Text == "STAR")
                {
                    MessageBox.Show("Correct and you got it right!", "Correct!", MessageBoxButtons.OK);
                    // Resets the game.
                    textBox1.Text = textBox2.Text = textBox3.Text = textBox4.Text = "";
                    button1.Enabled = button2.Enabled = button3.Enabled = button4.Enabled = button5.Enabled = button6.Enabled = button7.Enabled = button8.Enabled = button9.Enabled = button10.Enabled = button11.Enabled = button12.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Incorrect Letters, Resetting...", "Incorrect!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox1.Text = textBox2.Text = textBox3.Text = textBox4.Text = "";
                    button1.Enabled = button2.Enabled = button3.Enabled = button4.Enabled = button5.Enabled = button6.Enabled = button7.Enabled = button8.Enabled = button9.Enabled = button10.Enabled = button11.Enabled = button12.Enabled = true;
                }
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            String given = "I";
            button12.Enabled = false;
            if (textBox1.Text == String.Empty)
            {
                textBox1.Text = given;
            }
            else if (textBox2.Text == String.Empty)
            {
                textBox2.Text = given;
            }
            else if (textBox3.Text == String.Empty)
            {
                textBox3.Text = given;
            }
            else if (textBox4.Text == String.Empty)
            {
                textBox4.Text = given;
                if (textBox1.Text + textBox2.Text + textBox3.Text + textBox4.Text == "STAR")
                {
                    MessageBox.Show("Correct and you got it right!", "Correct!", MessageBoxButtons.OK);
                    // Resets the game.
                    textBox1.Text = textBox2.Text = textBox3.Text = textBox4.Text = "";
                    button1.Enabled = button2.Enabled = button3.Enabled = button4.Enabled = button5.Enabled = button6.Enabled = button7.Enabled = button8.Enabled = button9.Enabled = button10.Enabled = button11.Enabled = button12.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Incorrect Letters, Resetting...", "Incorrect!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox1.Text = textBox2.Text = textBox3.Text = textBox4.Text = "";
                    button1.Enabled = button2.Enabled = button3.Enabled = button4.Enabled = button5.Enabled = button6.Enabled = button7.Enabled = button8.Enabled = button9.Enabled = button10.Enabled = button11.Enabled = button12.Enabled = true;
                }
            }
        }

        // Kakatamad mag copy-paste.
        void ClearInText(String s) {
            switch (s)
            {
                case "J":
                    button1.Enabled = true;
                    break;
                case "E":
                    button2.Enabled = true;
                    break;
                case "A":
                    button3.Enabled = true;
                    break;
                case "O":
                    button4.Enabled = true;
                    break;
                case "T":
                    button5.Enabled = true;
                    break;
                case "C":
                    button6.Enabled = true;
                    break;
                case "P":
                    button7.Enabled = true;
                    break;
                case "H":
                    button8.Enabled = true;
                    break;
                case "L":
                    button9.Enabled = true;
                    break;
                case "S":
                    button10.Enabled = true;
                    break;
                case "R":
                    button11.Enabled = true;
                    break;
                case "I":
                    button12.Enabled = true;
                    break;
            }
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            ClearInText(textBox1.Text);
            textBox1.Text = "";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            ClearInText(textBox2.Text);
            textBox2.Text = "";
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_Click(object sender, EventArgs e)
        {
            ClearInText(textBox3.Text);
            textBox3.Text = "";
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_Click(object sender, EventArgs e)
        {
            ClearInText(textBox4.Text);
            textBox4.Text = "";
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}