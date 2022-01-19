using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StringComparer
{
    public partial class StringComparer : Form
    {
        public StringComparer()
        {
            InitializeComponent();
        }

        private void txtStringX_TextChanged(object sender, EventArgs e)
        {
            ValidationResult checker = new ValidationResult();
            if(checker.ValidateUserInput(txtStringX.Text))
            {
                lblResult.Text = "String X is valid";
            } else
            {
                lblResult.Text = "String X is invalid: " + checker.Message;
            }
        }
    }
}
