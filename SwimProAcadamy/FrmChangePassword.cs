using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using SwimProAcadamy.DAL;

namespace SwimProAcadamy
{
    public partial class FrmChangePassword : Form
    {
        public FrmChangePassword()
        {
            InitializeComponent();
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            string currentPassword = txtCurrentPassword.Text;
            string newPassword = txtNewPassword.Text;

            if (string.IsNullOrWhiteSpace(currentPassword) || string.IsNullOrWhiteSpace(newPassword))
            {
                MessageBox.Show("Please complete all password fields.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (newPassword.Length < 6)
            {
                MessageBox.Show("The new password must contain at least 6 characters.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (newPassword != txtConfirmPassword.Text)
            {
                MessageBox.Show("The new password and confirmation do not match.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                UserDAL userDal = new UserDAL();
                if (UserSession.UserId == 0 || userDal.Login(UserSession.Username, currentPassword) == null)
                {
                    MessageBox.Show("The current password is incorrect.", "Change Password", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                userDal.ChangePassword(UserSession.UserId, newPassword);
                AuditLogDAL.Log("UPDATE", "Password", "Changed account password.");
                MessageBox.Show("Your password has been changed successfully.", "Change Password", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to change password. " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
