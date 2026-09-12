using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _14projectpizza
{
    public partial class Form1 : Form
    {
        
          


       
        public Form1()
        {
            InitializeComponent();
        }
        void UpdateOrderSummary()
        {
            UpdateSize();
            UpdateToppings();
            UpdateCrust();
            UpdateWhereToEat();
            UpdateTotalPrice();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
           
            UpdateOrderSummary();
        }
        float GetSelectedSizePrice()
        {
            if (rbsmall.Checked)
                return Convert.ToSingle(rbsmall.Tag);
            else if (rbmeduim.Checked)
                return Convert.ToSingle(rbmeduim.Tag);
            else
                return Convert.ToSingle(rblarge.Tag);

        }
        float CalculateToppingsPrice()
        {
            float ToppingsTotalPrice = 0;

            if (chkextrachess.Checked)
            {
                ToppingsTotalPrice += Convert.ToSingle(chkextrachess.Tag);
            }


            if (chkonion.Checked)
            {
                ToppingsTotalPrice += Convert.ToSingle(chkonion.Tag);
            }

            if (chkmushroms.Checked)
            {
                ToppingsTotalPrice += Convert.ToSingle(chkmushroms.Tag);
            }

            if (chkolives.Checked)
            {
                ToppingsTotalPrice += Convert.ToSingle(chkolives.Tag);
            }

            if (chktomaoes.Checked)
            {
                ToppingsTotalPrice += Convert.ToSingle(chktomaoes.Tag);
            }

            if (chkgreenpeppers.Checked)
            {
                ToppingsTotalPrice += Convert.ToSingle(chkgreenpeppers.Tag);
            }



            return ToppingsTotalPrice;

        }
        float GetSelectedCrutPrice()
        {
            if (rbthincrust.Checked)
                return Convert.ToSingle(rbthincrust.Tag);
            else 
                return Convert.ToSingle(rbtinkcrust.Tag);
        }
        float CalculateTotalPrice()
        {
            return GetSelectedSizePrice() + CalculateToppingsPrice() + GetSelectedCrutPrice();
        }
        void UpdateTotalPrice()
        {
            lbltotalprice.Text = "$" + CalculateTotalPrice().ToString();
        }
        void UpdateSize()
        {
            UpdateTotalPrice();
            if (rbsmall.Checked)
            {
                lblsize.Text = "small";
                return;
            }
            if (rbmeduim.Checked)
            {
                lblsize.Text = "medium";
                return;
            }
            if (rblarge.Checked)
            {
                lblsize.Text = "large";
                return;
            }
        }

        private void rbsmall_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSize();
        }

        private void rbmeduim_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSize();
        }

        private void rblarge_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSize();
        }
        void UpdateCrust()
        {
            UpdateTotalPrice();
            if (rbthincrust.Checked)
                lblcrusttype.Text = "thin crust";
            if (rbtinkcrust.Checked)
                lblcrusttype.Text = "tink crust";
        }
        private void rbthincrust_CheckedChanged(object sender, EventArgs e)
        {
            UpdateCrust();
        }

        private void rbtinkcrust_CheckedChanged(object sender, EventArgs e)
        {
            UpdateCrust();
        }
        void UpdateToppings()
        {
            UpdateTotalPrice();
            string s = "";
            if (chkextrachess.Checked)
                s = "extra chess";
            if (chkmushroms.Checked)
                s += ", mushroms";
            if (chktomaoes.Checked)
                s += ", tomatoes";
            if (chkonion.Checked)
                s += ", onion";
            if (chkolives.Checked)
                s += ", olives";
            if (chkgreenpeppers.Checked)
                s += ", green pepers";
            if(s.StartsWith(","))
            {
                s=s.Substring(1, s.Length - 1).Trim();
            }
            if (s == "")
                s = "no toppings";

            lbltoppings.Text = s;

        }
        private void chkextrachess_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void chkonion_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void chkmushroms_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void chkolives_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void chktomaoes_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void chkgreenpeppers_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }
        void UpdateWhereToEat()
        {
            UpdateTotalPrice();
            if (rbeatin.Checked)
                lblwheretoeat.Text = "eat in";
            else
                lblwheretoeat.Text = "eat out";
        }
        private void rbeatin_CheckedChanged(object sender, EventArgs e)
        {
            UpdateWhereToEat();
        }

        private void rbeatout_CheckedChanged(object sender, EventArgs e)
        {
            UpdateWhereToEat();
        }
        void ResetForm()
        {
            //reset Groups
            gbcrusttype.Enabled = true;
            gbsize.Enabled = true;
            gbtoppings.Enabled = true;
            gbwheretoeat.Enabled = true;

            rbmeduim.Checked= true;
            chkextrachess.Checked= false;
            chkgreenpeppers.Checked= false;
            chkmushroms.Checked= false;
            chkolives.Checked= false;
            chkonion.Checked= false;
            chktomaoes.Checked= false;

            rbthincrust.Checked= true;
            rbeatin.Checked= true;
            btnorderpizza.Enabled= true;
        }
        private void btnreset_Click(object sender, EventArgs e)
        {
            ResetForm();
        }

        private void btnorderpizza_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("are u sure","confirm oreder", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {

                MessageBox.Show("Order Placed Successfully", "Success",
                       MessageBoxButtons.OK, MessageBoxIcon.Information);

                btnorderpizza.Enabled = false;
                gbsize.Enabled = false;
                gbtoppings.Enabled = false;
               gbcrusttype.Enabled = false;
                gbwheretoeat.Enabled = false;

            }
            else

                MessageBox.Show("Update your order", "Update",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
    }
    }

