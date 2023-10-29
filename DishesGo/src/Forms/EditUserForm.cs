using ComponentFactory.Krypton.Toolkit;
using DishesGo.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DishesGo.src.Forms
{
    public partial class EditUserForm : KryptonForm
    {
        private Users user;

        // Flags for the save button.
        private bool isPhotoChanged = false;      // +
        private bool isNicknameChanged = false;   // +
        private bool isEmailChanged = false;      // +
        private bool isFirstNameChanged = false;  //
        private bool isLastNameChanged = false;   //
        private bool isPasswordChanged = false;   //


        public EditUserForm(Users user)
        {
            this.user = user;
            InitializeComponent();

            // Initalization of form components.
            if(user != null ) 
            {
                // Set photo.
                if(user.user_photo == null)
                {
                    userPhoto.Image = Properties.Resources.withoutPhoto;
                }
                else
                {
                    using (MemoryStream ms = new MemoryStream(user.user_photo))
                    {
                        userPhoto.Image = Image.FromStream(ms);
                    }
                }

                // Nickname and email.
                nickname.Text = user.nickname;
                email.Text = user.email;

                // First and last name.
                name.Text = user.first_name;
                lastName.Text = user.last_name;
            }
        }

        private void backButtonImg_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void editUserImg_Click(object sender, EventArgs e)
        {
            // Open dialog window where user can choose image.
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Файли зображень|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        userPhoto.Image = new System.Drawing.Bitmap(openFileDialog.FileName);
                        isPhotoChanged = true; // User change the photo.
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Помилка завантаження фото: " + ex.Message, "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void canslePhoto_Click(object sender, EventArgs e)
        {
            // Discard user changing.
            using (MemoryStream ms = new MemoryStream(user.user_photo))
            {
                userPhoto.Image = Image.FromStream(ms);
                isPhotoChanged = false;
            }
        }



        private void editNickEmail_Click(object sender, EventArgs e)
        {
            // Set enable as true, now user can edit the info.
            nickEmailGroupBox.Enabled = true;
        }

        private void cancleNickEmail_Click(object sender, EventArgs e)
        {
            // Set enable as false, and discard all changes.
            nickEmailGroupBox.Enabled = false;

            nickname.Text = user.nickname;
            email.Text = user.email;
            
            isNicknameChanged = false;
            isEmailChanged = false;
        }

        private void nickname_TextChanged(object sender, EventArgs e)
        {
            KryptonTextBox textBox = (KryptonTextBox)sender;
            ValidateField(textBox, nicknameLabel, textBox.Text, user.nickname);
        }

        private void email_TextChanged(object sender, EventArgs e)
        {
            KryptonTextBox textBox = (KryptonTextBox)sender;
            ValidateField(textBox, emailLabel, textBox.Text, user.email);
        }

        private void ValidateField(KryptonTextBox textBox, Label label, string fieldValue, string userValue)
        {
            if (fieldValue.Trim() != "" && fieldValue.Trim() != userValue)
            {
                using (DishesGo_dbDataSet context = new DishesGo_dbDataSet())
                {
                    // if field exists in db.
                    var fieldExists = false;

                    if (textBox == nickname)
                    {
                        fieldExists = context.Users.FirstOrDefault(dbuser => dbuser.nickname == fieldValue.Trim()) != null;
                    }
                    else if (textBox == email)
                    {
                        fieldExists = context.Users.FirstOrDefault(dbuser => dbuser.email == fieldValue.Trim()) != null;
                    }

                    if (fieldExists)
                    {
                        label.ForeColor = Color.Red;
                    }
                    else
                    {
                        label.ForeColor = System.Drawing.SystemColors.ControlDark;
                    }
                }
            }
        }

        private void nickname_Leave(object sender, EventArgs e)
        {
            if (nickname.Text.Trim() != user.nickname)
            {
                using (DishesGo_dbDataSet context = new DishesGo_dbDataSet())
                {
                    // If nickname exists in db.
                    if (context.Users.FirstOrDefault(dbuser => dbuser.nickname == nickname.Text.Trim()) != null)
                    {
                        nicknameLabel.ForeColor = System.Drawing.SystemColors.ControlDark;
                        nickname.Text = user.nickname;
                    }
                    else
                    {
                        isNicknameChanged = true;   
                    }
                }
            }
            else if (nickname.Text.Trim() != "") // if user doesn't enter new nickname.
            {
                nicknameLabel.ForeColor = System.Drawing.SystemColors.ControlDark;
                nickname.Text = user.nickname;
            }
            else
            {
                nicknameLabel.ForeColor = System.Drawing.SystemColors.ControlDark;
            }
        }

        private void email_Leave(object sender, EventArgs e)
        {
            if (email.Text.Trim() != user.email)
            {
                using (DishesGo_dbDataSet context = new DishesGo_dbDataSet())
                {
                    // If email exists in db.
                    if (context.Users.FirstOrDefault(dbuser => dbuser.email == email.Text.Trim()) != null)
                    {
                        emailLabel.ForeColor = System.Drawing.SystemColors.ControlDark;
                        email.Text = user.email;
                    }
                    else
                    {
                        isEmailChanged = true;
                    }
                }
            }
            else if (email.Text.Trim() != "") // if user doesn't enter new email.
            {
                email.ForeColor = System.Drawing.SystemColors.ControlDark;
                email.Text = user.email;
            }
            else
            {
                emailLabel.ForeColor = System.Drawing.SystemColors.ControlDark;
            }
        }



        private void editNames_Click(object sender, EventArgs e)
        {
            // Set enable as true, now user can edit info.
            namesGroupBox.Enabled = true;
        }

        private void cancleNames_Click(object sender, EventArgs e)
        {
            // Set enable in state false and discard all chnges.
            namesGroupBox.Enabled = false;
            
            name.Text = user.first_name;
            lastName.Text = user.last_name;

            isFirstNameChanged = false;
            isLastNameChanged = false;
        }

        private void firstName_Leave(object sender, EventArgs e)
        {
            if (name.Text.Trim() == "")
            {
                name.Text = user.first_name;
            }
            else if (name.Text.Trim() != user.first_name)
            {
                isFirstNameChanged = true;
            }
        }

        private void lastName_Leave(object sender, EventArgs e)
        {
            if (lastName.Text.Trim() == "")
            {
                lastName.Text = user.last_name;
            }
            else if (lastName.Text.Trim() != user.last_name)
            {
                isLastNameChanged = true;
            }
        }



        private void editPassword_Click(object sender, EventArgs e)
        {
            // Set enable in true, now user can change password.
            passwordsGroupBox.Enabled = true;
        }

        private void canclePassword_Click(object sender, EventArgs e)
        {
            // Set enable in state false and discard all chnges.
            passwordsGroupBox.Enabled = false;
            
            // Set previous values.
            oldPassword.Text = "старий пароль";
            newPassword.Text = "новий пароль";
            comfirmPassword.Text = "пароль іще раз";

            // Disable showing the text as password text
            oldPassword.UseSystemPasswordChar = false;
            newPassword.UseSystemPasswordChar = false;
            comfirmPassword.UseSystemPasswordChar = false;

            // Disable access ability to old and comfirm variable.
            newPassword.Enabled = false;
            comfirmPassword.Enabled = false;
        }

        private void oldPassword_Enter(object sender, EventArgs e)
        {
            if (oldPassword.Text == "старий пароль")
            {
                oldPassword.Text = "";
                oldPassword.UseSystemPasswordChar = true; // Set the password character for user input.
            }
        }

        private void oldPassword_Leave(object sender, EventArgs e)
        {
            if (oldPassword.Text == "")
            {
                oldPassword.Text = "старий пароль";
                oldPassword.UseSystemPasswordChar = false; // Visualise as text.
            }
        }

        private void oldPassword_TextChanged(object sender, EventArgs e)
        {
            if(oldPassword.Text != "" &&  oldPassword.Text != "старий пароль" && oldPassword.Text.Trim() != user.user_password)
            {
                oldPassword.StateCommon.Content.Color1 = Color.Red;

                // Disallow user to the next action.
                newPassword.Enabled = false;
                comfirmPassword.Enabled = false;

                // Set previous values.
                newPassword.Text = "новий пароль";
                comfirmPassword.Text = "пароль ще раз";
            }
            else if (oldPassword.Text != "" && oldPassword.Text != "старий пароль") // User entered password, that equal previous.
            {
                oldPassword.StateCommon.Content.Color1 = Color.Black;

                // Allow usere to make changes.
                newPassword.Enabled = true;
                comfirmPassword.Enabled = true;
            }
            else
            {
                oldPassword.StateCommon.Content.Color1 = Color.Black;
            }
        }

        private void newPassword_Enter(object sender, EventArgs e)
        {
            if (newPassword.Text == "новий пароль")
            {
                newPassword.Text = "";
                newPassword.UseSystemPasswordChar = true; // Set the password character for user input.
            }
        }

        private void newPassword_Leave(object sender, EventArgs e)
        {
            if (newPassword.Text == "")
            {
                newPassword.Text = "новий пароль";
                newPassword.UseSystemPasswordChar = false; // Visualise as text.
            }
        }

        private void comfirmPassword_Enter(object sender, EventArgs e)
        {
            if (comfirmPassword.Text == "пароль ще раз")
            {
                comfirmPassword.Text = "";
                comfirmPassword.UseSystemPasswordChar = true; // Set the password character for user input.
            }
        }

        private void comfirmPassword_Leave(object sender, EventArgs e)
        {
            if (comfirmPassword.Text == "")
            {
                comfirmPassword.Text = "пароль ще раз";
                comfirmPassword.StateCommon.Content.Color1 = Color.Black;
                comfirmPassword.UseSystemPasswordChar = false; // Visualise as text.
            }
            else if (comfirmPassword.Text.Trim() != newPassword.Text.Trim() && comfirmPassword.Text.Trim() != "пароль ще раз")
            {
                comfirmPassword.StateCommon.Content.Color1 = Color.Black;
                canclePassword_Click(sender, e); // Discard user actions.
            }
        }

        private void comfirmPassword_TextChanged(object sender, EventArgs e)
        {
            if (comfirmPassword.Text != "" && comfirmPassword.Text != "пароль ще раз" && comfirmPassword.Text.Trim() != newPassword.Text.Trim())
            {
                comfirmPassword.StateCommon.Content.Color1 = Color.Red;
            }
            else
            {
                comfirmPassword.StateCommon.Content.Color1 = Color.Black;
            }
        }
    }
}
