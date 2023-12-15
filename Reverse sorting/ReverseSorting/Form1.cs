using System;
using System.Collections;
using System.Windows.Forms;

namespace Simplification
{
    public partial class Form1 : Form
    {
        private int amount;
        private TextBox[] numberTextBoxes;

        public Form1()
        {
            InitializeComponent();
            InitializeNumberTextBoxes();
        }

        private void InitializeNumberTextBoxes()
        {
            numberTextBoxes = new TextBox[] { nmb1, nmb2, nmb3, nmb4, nmb5, nmb6, nmb7, nmb8, nmb9 };
        }

        private void Txtbox1_TextChanged(object sender, EventArgs e)
        {
            if (Int32.TryParse(txtbox_amount.Text, out amount))
            {
                chkbox1.Checked = amount >= 2 && amount <= 9;
                lbl_msg.Visible = !chkbox1.Checked;
                lbl_msg.Text = chkbox1.Checked ? string.Empty : "Add number from 2 to 10";
                UpdateNumberTextBoxesVisibility();
            }
            else
            {
                lbl_msg.Visible = true;
                lbl_msg.Text = "Text box is empty";
            }
        }

        private void UpdateNumberTextBoxesVisibility()
        {
            for (int i = 0; i < numberTextBoxes.Length; i++)
            {
                numberTextBoxes[i].Visible = i < amount;
            }
        }

        private void Chkbox1_CheckedChanged(object sender, EventArgs e)
        {
            lbl_txt.Visible = chkbox1.Checked;
        }

        private void Btn_add_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < amount; i++)
            {
                if (int.TryParse(numberTextBoxes[i].Text, out int value))
                {
                    listbox.Items.Add(value);
                }
            }
        }

        private void Btn_cln_Click(object sender, EventArgs e)
        {
            listbox.Items.Clear();
            foreach (var textBox in numberTextBoxes)
            {
                textBox.Clear();
            }
        }
    }
}
