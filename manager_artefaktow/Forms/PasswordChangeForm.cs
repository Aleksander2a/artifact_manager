using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using manager_artefaktow.BusinessLogic;
using manager_artefaktow.Data;
using manager_artefaktow.Data.Models;

namespace manager_artefaktow.Forms
{
    public partial class PasswordChangeForm : Form
    {
        public PasswordChangeForm()
        {
            InitializeComponent();
        }

        private void Menu_button_Click(object sender, EventArgs e)
        {
            this.FindForm().Hide();
            Form userHomeForm = new UserHomePageForm();
            userHomeForm.ShowDialog();
        }

        private void Register_button_Click(object sender, EventArgs e)
        {
            if (CurrentPass_textBox.Text.Trim().Length == 0 || NewPass_textBox.Text.Trim().Length == 0 || ConfirmNewPass_Password_textBox.Text.Trim().Length == 0)
            {
                MessageBox.Show("Invalid input");
                return;
            }
            if (LoggingIn.UserPasswordIsCorrect(LoggedUser.UserName, CurrentPass_textBox.Text)) 
            {
                if (NewPass_textBox.Text == ConfirmNewPass_Password_textBox.Text)
                {
                    DialogResult dr = MessageBox.Show("Are you sure to save Changes", "Message", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
                   
                    if (dr != DialogResult.Yes)
                    {
                        MessageBox.Show("No changes made");
                        return;
                    }
                    UserManagement.ChangeUserPassword(LoggedUser.UserName, NewPass_textBox.Text);
                    MessageBox.Show("Password changed successfully");
                    return;
                }
                else
                {
                    MessageBox.Show("New password and password confirmation are not the same");
                    return;
                }
            }
            else
            {
                MessageBox.Show("Current password is does not match the actual password");
                return;
            }
        }
    }
}
