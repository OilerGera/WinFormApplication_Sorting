using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Collections;

namespace simplification
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();
        }

        int amount;                                                                                                        // Variable amount 
        int var1;
        int var2;
        int var3;
        int var4;                                                                                                  // Declaration of variables from 2 to 9
        int var5;
        int var6;
        int var7;
        int var8;
        int var9;



        public void Txtbox1_TextChanged(object sender, EventArgs e)                                      // How much number will be sorted? 
        {
        if (Int32.TryParse(txtbox_amount.Text, out amount))
            {
                if (amount >= 2 && amount <= 9)                                                // Constraint, possible to sort only from 2 to 9 digits
                {
                    chkbox1.Checked = true;
                    lbl_msg.Visible = false;
                }
                else
                {
                    chkbox1.Checked = false;
                    lbl_msg.Visible = true;
                    lbl_msg.Text = "Add number from 2 to 10";
                }
            }
            try                                                                              // Visibility of number boxes 
            {
                if (txtbox_amount.Text.Length == 0)
                {
                    nmb1.Visible = false;
                    nmb2.Visible = false;
                    nmb3.Visible = false;
                    nmb4.Visible = false;
                    nmb5.Visible = false;
                    nmb6.Visible = false;
                    nmb7.Visible = false;
                    nmb8.Visible = false;
                    nmb9.Visible = false;

                }
                if (amount == 1)
                {
                    nmb1.Visible = false;
                    nmb2.Visible = false;
                    nmb3.Visible = false;
                    nmb4.Visible = false;
                    nmb5.Visible = false;
                    nmb6.Visible = false;
                    nmb7.Visible = false;
                    nmb8.Visible = false;
                    nmb9.Visible = false;
                }
                if (amount == 2)
                {
                    nmb1.Visible = true;
                    nmb2.Visible = true;
                    nmb3.Visible = false;
                    nmb4.Visible = false;
                    nmb5.Visible = false;
                    nmb6.Visible = false;
                    nmb7.Visible = false;
                    nmb8.Visible = false;
                    nmb9.Visible = false;
                }
                if (amount == 3)
                {
                    nmb1.Visible = true;
                    nmb2.Visible = true;
                    nmb3.Visible = true;
                    nmb4.Visible = false;
                    nmb5.Visible = false;
                    nmb6.Visible = false;
                    nmb7.Visible = false;
                    nmb8.Visible = false;
                    nmb9.Visible = false;
                }
                if (amount == 4)
                {
                    nmb1.Visible = true;
                    nmb2.Visible = true;
                    nmb3.Visible = true;
                    nmb4.Visible = true;
                    nmb5.Visible = false;
                    nmb6.Visible = false;
                    nmb7.Visible = false;
                    nmb8.Visible = false;
                    nmb9.Visible = false;
                }
                if (amount == 5)
                {
                    nmb1.Visible = true;
                    nmb2.Visible = true;
                    nmb3.Visible = true;
                    nmb4.Visible = true;
                    nmb5.Visible = true;
                    nmb6.Visible = false;
                    nmb7.Visible = false;
                    nmb8.Visible = false;
                    nmb9.Visible = false;
                }
                if (amount == 6)
                {
                    nmb1.Visible = true;
                    nmb2.Visible = true;
                    nmb3.Visible = true;
                    nmb4.Visible = true;
                    nmb5.Visible = true;
                    nmb6.Visible = true;
                    nmb7.Visible = false;
                    nmb8.Visible = false;
                    nmb9.Visible = false;
                }
                if (amount == 7)
                {
                    nmb1.Visible = true;
                    nmb2.Visible = true;
                    nmb3.Visible = true;
                    nmb4.Visible = true;
                    nmb5.Visible = true;
                    nmb6.Visible = true;
                    nmb7.Visible = true;
                    nmb8.Visible = false;
                    nmb9.Visible = false;
                }
                if (amount == 8)
                {
                    nmb1.Visible = true;
                    nmb2.Visible = true;
                    nmb3.Visible = true;
                    nmb4.Visible = true;
                    nmb5.Visible = true;
                    nmb6.Visible = true;
                    nmb7.Visible = true;
                    nmb8.Visible = true;
                    nmb9.Visible = false;
                }
                if (amount == 9)
                {
                    nmb1.Visible = true;
                    nmb2.Visible = true;
                    nmb3.Visible = true;
                    nmb4.Visible = true;
                    nmb5.Visible = true;
                    nmb6.Visible = true;
                    nmb7.Visible = true;
                    nmb8.Visible = true;
                    nmb9.Visible = true;
                }
            }
            catch
            {
                lbl_msg.Text = "Text box is empty";
            }
        }

        public void Chkbox1_CheckedChanged(object sender, EventArgs e)                           // Visibility of checkkbox
        {                                                                                    // check if digits from 2 to 10
                                                                                            // shows error 'lbl_txt' if variable wrong 
            if (chkbox1.Checked) 
            {
                lbl_txt.Visible = true;
            }
            else
            {
                lbl_txt.Visible = false;
            }
        }



        private void Sorting_Click(object sender, EventArgs e)                               // Sorting bult-in function
        {
            ArrayList Sorting = new ArrayList();

            foreach (var vars in listbox.Items)
            {
                Sorting.Add(vars);
            }

            Sorting.Sort(new Sorting.ReverseSort());                                     //call class ReverseSort for reverse sorting

            listbox.Items.Clear();                                                    

            foreach (var vars in Sorting)
            {
                listbox.Items.Add(vars);
            }

        }
        private void Btn_add_Click(object sender, EventArgs e)                             // If click to button 'add'
        {
            if (amount == 1)
            {
                return;
            }                                                       // if one digit - nothing
            if (amount == 2)
            {
                if (Int32.TryParse(nmb1.Text, out var1))
                {
                    listbox.Items.Add(var1);
                }
                if (Int32.TryParse(nmb2.Text, out var2))
                {
                    listbox.Items.Add(var2);
                }
            }                                                      // if two digits
            if (amount == 3)
            {
                if (Int32.TryParse(nmb1.Text, out var1))
                {
                    listbox.Items.Add(var1);
                }
                if (Int32.TryParse(nmb2.Text, out var2))
                {
                    listbox.Items.Add(var2);
                }
                if (Int32.TryParse(nmb3.Text, out var3))
                {
                    listbox.Items.Add(var3);
                }



            /*
            if (amount == 5)
            {
                if (Int32.TryParse(nmb1.Text, out var1))
                {
                    listbox.Items.Add(var1);
                }
                if (Int32.TryParse(nmb2.Text, out var2))
                {
                    listbox.Items.Add(var2);
                }
                if (Int32.TryParse(nmb3.Text, out var3))
                {
                    listbox.Items.Add(var3);
                }
                if (Int32.TryParse(nmb4.Text, out var4))
                {
                    listbox.Items.Add(var4);
                }
                if (Int32.TryParse(nmb5.Text, out var5))
                {
                    listbox.Items.Add(var5);
                }
            }
            
            if (amount == 6)
            {
                if (Int32.TryParse(nmb1.Text, out var1))
                {
                    listbox.Items.Add(var1);
                }
                if (Int32.TryParse(nmb2.Text, out var2))
                {
                    listbox.Items.Add(var2);
                }
                if (Int32.TryParse(nmb3.Text, out var3))
                {
                    listbox.Items.Add(var3);
                }
                if (Int32.TryParse(nmb4.Text, out var4))
                {
                    listbox.Items.Add(var4);
                }
                if (Int32.TryParse(nmb5.Text, out var5))
                {
                    listbox.Items.Add(var5);
                }
                if (Int32.TryParse(nmb6.Text, out var6))
                {
                    listbox.Items.Add(var6);
                }
            }

            if (amount == 7)
                if (Int32.TryParse(nmb1.Text, out var1))
                {
                    listbox.Items.Add(var1);
                }
                if (Int32.TryParse(nmb2.Text, out var2))
                {
                    listbox.Items.Add(var2);
                }
                if (Int32.TryParse(nmb3.Text, out var3))
                {
                    listbox.Items.Add(var3);
                }
                if (Int32.TryParse(nmb4.Text, out var4))
                {
                    listbox.Items.Add(var4);
                }
                if (Int32.TryParse(nmb5.Text, out var5))
                {
                    listbox.Items.Add(var5);
                }
                if (Int32.TryParse(nmb6.Text, out var6))
                {
                    listbox.Items.Add(var6);
                }
                if (Int32.TryParse(nmb7.Text, out var7))
                {
                    listbox.Items.Add(var7);
                }*/
            }                                                     // if three digits
            if (amount == 4)
            {
                if (int.TryParse(nmb1.Text, out var1))
                {
                    listbox.Items.Add(var1);
                }
                if (int.TryParse(nmb2.Text, out var2))
                {
                    listbox.Items.Add(var2);
                }
                if (int.TryParse(nmb3.Text, out var3))
                {
                    listbox.Items.Add(var3);
                }
                if (int.TryParse(nmb4.Text, out var4))
                {
                    listbox.Items.Add(var4);
                }
            }                                                    // if four digits
            if (amount == 5)
            {
                if (int.TryParse(nmb1.Text, out var1))
                {
                    listbox.Items.Add(var1);
                }
                if (int.TryParse(nmb2.Text, out var2))
                {
                    listbox.Items.Add(var2);
                }
                if (int.TryParse(nmb3.Text, out var3))
                {
                    listbox.Items.Add(var3);
                }
                if (int.TryParse(nmb4.Text, out var4))
                {
                    listbox.Items.Add(var4);
                }
                if (int.TryParse(nmb5.Text, out var5))
                {
                    listbox.Items.Add(var5);
                }
            }                                                   // if five digits
            if (amount == 6)
            {
                if (int.TryParse(nmb1.Text, out var1))
                {
                    listbox.Items.Add(var1);
                }
                if (int.TryParse(nmb2.Text, out var2))
                {
                    listbox.Items.Add(var2);
                }
                if (int.TryParse(nmb3.Text, out var3))
                {
                    listbox.Items.Add(var3);
                }
                if (int.TryParse(nmb4.Text, out var4))
                {
                    listbox.Items.Add(var4);
                }
                if (int.TryParse(nmb5.Text, out var5))
                {
                    listbox.Items.Add(var5);
                }
                if (int.TryParse(nmb6.Text, out var6))
                {
                    listbox.Items.Add(var6);
                }
            }                                                  // if six digits
            if (amount == 7)
            {
                if (int.TryParse(nmb1.Text, out var1))
                {
                    listbox.Items.Add(var1);
                }
                if (int.TryParse(nmb2.Text, out var2))
                {
                    listbox.Items.Add(var2);
                }
                if (int.TryParse(nmb3.Text, out var3))
                {
                    listbox.Items.Add(var3);
                }
                if (int.TryParse(nmb4.Text, out var4))
                {
                    listbox.Items.Add(var4);
                }
                if (int.TryParse(nmb5.Text, out var5))
                {
                    listbox.Items.Add(var5);
                }
                if (int.TryParse(nmb6.Text, out var6))
                {
                    listbox.Items.Add(var6);
                }
                if (int.TryParse(nmb7.Text, out var7))
                {
                    listbox.Items.Add(var7);
                }
            }                                                 // if seven digits
            if (amount == 8)
            {
                if (int.TryParse(nmb1.Text, out var1))
                {
                    listbox.Items.Add(var1);
                }
                if (int.TryParse(nmb2.Text, out var2))
                {
                    listbox.Items.Add(var2);
                }
                if (int.TryParse(nmb3.Text, out var3))
                {
                    listbox.Items.Add(var3);
                }
                if (int.TryParse(nmb4.Text, out var4))
                {
                    listbox.Items.Add(var4);
                }
                if (int.TryParse(nmb5.Text, out var5))
                {
                    listbox.Items.Add(var5);
                }
                if (int.TryParse(nmb6.Text, out var6))
                {
                    listbox.Items.Add(var6);
                }
                if (int.TryParse(nmb7.Text, out var7))
                {
                    listbox.Items.Add(var7);
                }
                if (int.TryParse(nmb8.Text, out var8))
                {
                    listbox.Items.Add(var8);
                }
            }                                                // if eight digits
            if (amount == 9)
            {
                if (int.TryParse(nmb1.Text, out var1))
                {
                    listbox.Items.Add(var1);
                }
                if (int.TryParse(nmb2.Text, out var2))
                {
                    listbox.Items.Add(var2);
                }
                if (int.TryParse(nmb3.Text, out var3))
                {
                    listbox.Items.Add(var3);
                }
                if (int.TryParse(nmb4.Text, out var4))
                {
                    listbox.Items.Add(var4);
                }
                if (int.TryParse(nmb5.Text, out var5))
                {
                    listbox.Items.Add(var5);
                }
                if (int.TryParse(nmb6.Text, out var6))
                {
                    listbox.Items.Add(var6);
                }
                if (int.TryParse(nmb7.Text, out var7))
                {
                    listbox.Items.Add(var7);
                }
                if (int.TryParse(nmb8.Text, out var8))
                {
                    listbox.Items.Add(var8);
                }
                if (int.TryParse(nmb9.Text, out var9))
                {
                    listbox.Items.Add(var9);
                }
            }                                               // if nine digits - maximum

        }
        private void Btn_cln_Click(object sender, EventArgs e)                           // Clean all variables and listbox
        {
            listbox.Items.Clear();
            nmb1.Clear();
            nmb2.Clear();
            nmb3.Clear();
            nmb4.Clear();
            nmb5.Clear();
            nmb6.Clear();
            nmb7.Clear();
            nmb8.Clear();
            nmb9.Clear();
        }
    }

}
