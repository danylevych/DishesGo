using ComponentFactory.Krypton.Toolkit;
using DishesGo.Data;
using DishesGo.src.Forms.ToolForms;
using DishesGo.src.tools;
using DishesGo.src.Tools;
using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Windows.Forms;

namespace DishesGo.src.Forms
{
    public partial class EditUserForm : KryptonForm
    {
        private readonly Users user;

        private bool isWrongNickOrEmail = false;
        private bool isPasswordChanged = false;


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

        private void saveChanging_Click(object sender, EventArgs e)
        {
            // For checking if all data saved.
            Func<KryptonGroupBox, bool> IsSaved = (element) => element.StateCommon.Border.Color1 != Color.Red &&
                                                               element.StateCommon.Border.Color1 != Color.Red;
            // User did not save all data.
            if (!IsSaved(namesGroupBox) || !IsSaved(passwordsGroupBox) || !IsSaved(nickEmailGroupBox) || applyPhoto.Visible)
            {
                MessageBox.Show("Ви не зберегли всі дані.", "Інформація", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            using (DishesGo_dbEntities context = new DishesGo_dbEntities())
            {
                Users findedUser = context.Users.FirstOrDefault(userdb => userdb.user_id == user.user_id);

                if (findedUser == null)
                {
                    return;
                }

                // Check if user made some changes.
                if (findedUser.email == user.email && findedUser.nickname == user.nickname &&
                    findedUser.first_name == user.first_name && findedUser.last_name == user.last_name &&
                    findedUser.user_password == user.user_password && 
                    (findedUser.user_photo == null? false : findedUser.user_photo.SequenceEqual(user.user_photo))) // Does the user photo not exixst or equal to previous?
                {
                    return;
                }


                findedUser.email = user.email;
                findedUser.nickname = user.nickname;
                findedUser.first_name = user.first_name;
                findedUser.last_name = user.last_name;
                findedUser.user_photo = user.user_photo;
                findedUser.user_password = findedUser.user_password == user.user_password? user.user_password : PasswordHasher.HashPassword(user.user_password);
                
                context.SaveChanges();
                

                MessageBox.Show("Ви успішно змінили дані профілю.", "Інформація", MessageBoxButtons.OK, MessageBoxIcon.Information);

                MainForm.Instance.Refresh(findedUser);
            }
        }



        #region Image redactor
        private void editUserImg_Click(object sender, EventArgs e)
        {
            // Open dialog window where user can choose image.
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Файли зображень|*.jpg;*.jpeg;*.png";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        Image image = new System.Drawing.Bitmap(openFileDialog.FileName);

                        CropingImageForm cropingImgForm = new CropingImageForm(image);
                        cropingImgForm.ShowDialog(this);
                        if (cropingImgForm.SelectedButton == Tools.ImageCropingFormButton.SAVE)
                        {
                            userPhoto.Image = new Bitmap(cropingImgForm.GetCroppedImage());
                            applyPhoto.Visible = true;
                        }
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
                applyPhoto.Visible = false;
            }
        }

        private void applyPhoto_Click(object sender, EventArgs e)
        {
            // Set photo.
            user.user_photo = ImageRedactor.ToByteArray(userPhoto.Image);

            applyPhoto.Visible = false; // User setted photo.
        }
        #endregion Image redactor

        #region Email and nickname
        private void editNickEmail_Click(object sender, EventArgs e)
        {
            // Set enable as true, now user can edit the info.
            nickEmailGroupBox.Enabled = true;
            //applyNickEmail.Visible = true;

            // Red means that user is making changing.
            nickEmailGroupBox.StateCommon.Border.Color1 = Color.Red;
            nickEmailGroupBox.StateCommon.Border.Color2 = Color.Red;
        }

        private void cancleNickEmail_Click(object sender, EventArgs e)
        {
            // Set enable as false, and discard all changes.
            nickEmailGroupBox.Enabled = false;

            nickname.Text = user.nickname;
            email.Text = user.email;

            applyNickEmail.Visible = false;

            nickEmailGroupBox.StateCommon.Border.Color1 = Color.White;
            nickEmailGroupBox.StateCommon.Border.Color2 = Color.White;
        }

        private void applyNickEmail_Click(object sender, EventArgs e)
        {
            // If user entered values that is incorect.
            if (isWrongNickOrEmail)
            {
                MessageBox.Show("На жаль, дані в полях 'Нікнейм' та 'e-mail' неправильні.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Set new values.
            user.email = email.Text.Trim();
            user.nickname = nickname.Text.Trim();

            nickEmailGroupBox.Enabled = false;
            applyNickEmail.Visible = false;

            nickEmailGroupBox.StateCommon.Border.Color1 = Color.White;
            nickEmailGroupBox.StateCommon.Border.Color2 = Color.White;

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
                using (DishesGo_dbEntities context = new DishesGo_dbEntities())
                {
                    // if field exists in db.
                    var fieldExists = false;

                    if (textBox.Tag.ToString() == "nickname")
                    {
                        fieldExists = context.Users.FirstOrDefault(dbuser => dbuser.nickname == fieldValue.Trim()) != null;
                    }
                    else if (textBox.Tag.ToString() == "email")
                    {
                        fieldExists = context.Users.FirstOrDefault(dbuser => dbuser.email == fieldValue.Trim()) != null;
                    }

                    if (fieldExists) // Show for user that his value exists.
                    {
                        textBox.StateCommon.Content.Color1 = Color.Red;
                        isWrongNickOrEmail = true;

                        applyNickEmail.Enabled = false;
                        applyNickEmail.Visible = false;
                    }
                    else
                    {
                        textBox.StateCommon.Content.Color1 = Color.Black;
                        isWrongNickOrEmail = false;

                        applyNickEmail.Enabled = true;
                        applyNickEmail.Visible = true;
                    }
                }
            }
            else
            {
                textBox.StateCommon.Content.Color1 = Color.Black;
                isWrongNickOrEmail = false;

                applyNickEmail.Enabled = false;
                applyNickEmail.Visible = false;
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
        #endregion Email and nickname

        #region Names
        private void editNames_Click(object sender, EventArgs e)
        {
            // Set enable as true, now user can edit info.
            namesGroupBox.Enabled = true;

            // Show the user he is able to make changings.
            namesGroupBox.StateCommon.Border.Color1 = Color.Red;
            namesGroupBox.StateCommon.Border.Color2 = Color.Red;
        }

        private void cancleNames_Click(object sender, EventArgs e)
        {
            // Set enable in state false and discard all chnges.
            namesGroupBox.Enabled = false;
            
            name.Text = user.first_name;
            lastName.Text = user.last_name;

            namesGroupBox.StateCommon.Border.Color1 = Color.White;
            namesGroupBox.StateCommon.Border.Color2 = Color.White;
        }

        private void applyNames_Click(object sender, EventArgs e)
        {
            // Set new values.
            user.first_name = name.Text.Trim();
            user.last_name = lastName.Text.Trim();

            namesGroupBox.Enabled = false;
            applyNames.Visible = false;

            namesGroupBox.StateCommon.Border.Color1 = Color.White;
            namesGroupBox.StateCommon.Border.Color2 = Color.White;
        }


        private void name_TextChanged(object sender, EventArgs e)
        {
            if (name.Text.Trim() != user.first_name)
            {
                applyNames.Visible = true;
            }
            else
            { 
                applyNames.Visible = false;
            }
        }

        private void lastName_TextChanged(object sender, EventArgs e)
        {
            if (lastName.Text.Trim() != user.last_name)
            {
                applyNames.Visible = true;
            }
            else
            {
                applyNames.Visible = false;
            }
        }

        private void firstName_Leave(object sender, EventArgs e)
        {
            if (name.Text.Trim() == "")
            {
                name.Text = user.first_name;
            }
        }

        private void lastName_Leave(object sender, EventArgs e)
        {
            if (lastName.Text.Trim() == "")
            {
                lastName.Text = user.last_name;
            }
        }
        #endregion Names

        #region Password
        #region Enter and leave methods for password
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
        #endregion Enter and leave methods for password

        private void editPassword_Click(object sender, EventArgs e)
        {
            // Set enable in true, now user can change password.
            isPasswordChanged = false;
            passwordsGroupBox.Enabled = true;
            passwordsGroupBox.StateCommon.Border.Color1 = Color.Red;
            passwordsGroupBox.StateCommon.Border.Color2 = Color.Red;
        }

        private void canclePassword_Click(object sender, EventArgs e)
        {
            // Set enable in state false and discard all chnges.
            passwordsGroupBox.Enabled = false;

            applyPassword.Visible = false;
            applyPassword.Enabled = false;

            // Set previous values.
            oldPassword.Text = "старий пароль";
            newPassword.Text = "новий пароль";
            comfirmPassword.Text = "пароль іще раз";
            comfirmPassword.StateCommon.Content.Color1 = Color.Black;

            // Disable showing the text as password text
            oldPassword.UseSystemPasswordChar = false;
            newPassword.UseSystemPasswordChar = false;
            comfirmPassword.UseSystemPasswordChar = false;

            // Disable access ability to old and comfirm variable.
            newPassword.Enabled = false;
            comfirmPassword.Enabled = false;

            isPasswordChanged = false;
            passwordsGroupBox.StateCommon.Border.Color1 = Color.White;
            passwordsGroupBox.StateCommon.Border.Color2 = Color.White;
        }

        private void applyPassword_Click(object sender, EventArgs e)
        {
            if (!isPasswordChanged) // Never happend
            {
                MessageBox.Show("Поля в групі 'Паролі' не збережені.", "Інформація", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            user.user_password = newPassword.Text.Trim();

            canclePassword_Click(this, e); // Set previous data.
            //passwordsGroupBox.Enabled = true; // Set flag that we have changed password.
            isPasswordChanged = true;
        }

        private void comfirmPassword_TextChanged(object sender, EventArgs e)
        {
            if (comfirmPassword.Text.Trim() == newPassword.Text.Trim()) // User comfirmed password.
            {
                comfirmPassword.StateCommon.Content.Color1 = Color.Black;
                isPasswordChanged = true;

                // Show and make allow apply button.
                applyPassword.Visible = true;
                applyPassword.Enabled = true;
            }
            else
            {
                comfirmPassword.StateCommon.Content.Color1 = Color.Red;
                isPasswordChanged = false;

                // If we have entered new password set the apply button in disable.
                applyPassword.Visible = false;
                applyPassword.Enabled = false;
            }
        }

        private void oldPassword_TextChanged(object sender, EventArgs e)
        {
            if (oldPassword.Text != "" && oldPassword.Text != "старий пароль" && 
                PasswordHasher.VerifyPassword(oldPassword.Text.Trim(), user.user_password)) // Chaeck if user pasvord is valid.
            {
                oldPassword.StateCommon.Content.Color1 = Color.Red;

                // Disallow user to the next action.
                newPassword.Enabled = false;
                comfirmPassword.Enabled = false;

                // Set previous values.
                newPassword.Text = "новий пароль";
                comfirmPassword.Text = "пароль ще раз";
                
                isPasswordChanged = false; // User entered invalid password.
                return;
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
                isPasswordChanged = false; // User did not enter password.
                return;
            }

            isPasswordChanged = true; // User enter new password.
        }
        #endregion Password
    }
}
