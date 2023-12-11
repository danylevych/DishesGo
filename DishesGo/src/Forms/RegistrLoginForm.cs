using ComponentFactory.Krypton.Toolkit;
using DishesGo.Data;
using DishesGo.src.tools;
using DishesGo.src.Tools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace DishesGo
{
    public partial class RegistrLoginForm : KryptonForm
    {
        private class UserCashInfo
        {
            public string Email { get; set; }
            public string NickName { get; set; }
        }

        private List<UserCashInfo> users;


        public RegistrLoginForm()
        {
            InitializeComponent();

            using (DishesGo_dbEntities context = new DishesGo_dbEntities())
            {
                users = context.Users.Select(u => new UserCashInfo { Email = u.email, NickName = u.nickname }).Take(2).ToList();
            }
        }

        private void OpenPanelButton_Click(object sender, EventArgs e)
        {
            KryptonButton caller = ((KryptonButton)sender);

            if (caller.Name == loginButton.Name)
            {
                if (registrPanel.Visible)
                {
                    registrPanel.Visible = false;
                }
                loginPanel.Visible = true;
            }
            else if (caller.Name == signinButton.Name)
            {
                if (loginPanel.Visible)
                {
                    loginPanel.Visible = false;
                }
                registrPanel.Visible = true;
            }
        }


        #region Registration
        private void emailText_Enter(object sender, EventArgs e)
        {
            // User select the text label.
            if (emailText.Text == "Введіть свій e-mail")
            {
                emailText.Text = "";
            }
            emailNotValid.Visible = false;
        }

        private void emailText_Leave(object sender, EventArgs e)
        {
            // User leave the label.
            if (emailText.Text == "")
            {
                emailText.Text = "Введіть свій e-mail";
            }
        }

       
        private void lastnameText_Enter(object sender, EventArgs e)
        {
            // User leave the label.
            if (lastnameText.Text == "Введіть своє прізвище")
            {
                lastnameText.Text = "";
            }
            lastNameNotValid.Visible = false;
        }

        private void lastnameText_Leave(object sender, EventArgs e)
        {
            // User leave the label.
            if (lastnameText.Text == "")
            {
                lastnameText.Text = "Введіть своє прізвище";
            }
        }


        private void nameText_Enter(object sender, EventArgs e)
        {
            // User leave the label.
            if (nameText.Text == "Введіть своє ім'я")
            {
                nameText.Text = "";
            }
            nameNotValid.Visible = false;
        }

        private void nameText_Leave(object sender, EventArgs e)
        {
            // User leave the label.
            if (nameText.Text == "")
            {
                nameText.Text = "Введіть своє ім'я";
            }
        }


        private void nicnameText_Enter(object sender, EventArgs e)
        {
            // User leave the label.
            if (nicnameText.Text == "Введіть нікнейм")
            {
                nicnameText.Text = "";
            }
            nicknameNotValid.Visible = false;
        }

        private void nicnameText_Leave(object sender, EventArgs e)
        {
            // User leave the label.
            if (nicnameText.Text == "")
            {
                nicnameText.Text = "Введіть нікнейм";
            }
        }


        private void passwordText_Enter(object sender, EventArgs e)
        {
            // User leave the label.
            if (passwordText.Text == "Введіть пароль")
            {
                passwordText.Text = "";
            }
            passwordNotValid.Visible = false;
        }

        private void passwordText_Leave(object sender, EventArgs e)
        {
            // User leave the label.
            if (passwordText.Text == "")
            {
                passwordText.Text = "Введіть пароль";
            }
        }

        private void passwordText_TextChanged(object sender, EventArgs e)
        {
            string password = passwordText.Text.Trim();
            
            // We look if user entered password.
            if (password != string.Empty && password != "Введіть пароль")
            {
                comfirmPassText.Enabled = true;
            }
            else
            {
                comfirmPassText.Enabled = false;
            }
        }

        private void comfirmPassText_Enter(object sender, EventArgs e)
        {
            // User leave the label.
            if (comfirmPassText.Text == "Введіть пароль іще раз")
            {
                comfirmPassText.Text = "";
            }
        }

        private void comfirmPassText_Leave(object sender, EventArgs e)
        {
            // User leave the label.
            if (comfirmPassText.Text == "")
            {
                comfirmPassText.Text = "Введіть пароль іще раз";
            }
        }

        private void comfirmPassText_TextChanged(object sender, EventArgs e)
        {
            if (passwordText.Text != "Введіть пароль" && comfirmPassText.Text != "Введіть пароль іще раз")
            {
                if (passwordText.Text != comfirmPassText.Text)
                {
                    comfirmPassLabel.ForeColor = Color.Red;
                }
                else
                {
                    comfirmPassLabel.ForeColor = Color.Black;
                }
            }
        }

        private void signinRegPlateButton_Click(object sender, EventArgs e)
        {
            emailNotValid.Visible = false;
            lastNameNotValid.Visible = false;
            nameNotValid.Visible = false;
            nicknameNotValid.Visible = false;
            passwordNotValid.Visible = false;

            bool addToTable = true;

            string firstName = nameText.Text.Trim();
            string lastName = lastnameText.Text.Trim();
            string email = emailText.Text.Trim();
            string nickname = nicnameText.Text.Trim();
            string userPassword = passwordText.Text.Trim();

            // User does not input the email.
            if (email == "Введіть свій e-mail" || email == "")
            {
                emailNotValid.Text = "e-mail не може бути пустим";
                emailNotValid.Visible = true;

                addToTable = false;
            }

            // Check if user's email is valide.
            if (!EmailValidator.IsValidEmail(email))
            {
                emailNotValid.Text = "e-mail має неправильний формат";
                emailNotValid.Visible = true;

                addToTable = false;
            }

            using (DishesGo_dbEntities db = new DishesGo_dbEntities())
            {
                // Email exists in db.
                if (db.Users.Any(user => user.email == email))
                {
                    emailNotValid.Text = "Такий e-mail уже існує";
                    emailNotValid.Visible = true;
                    addToTable = false;
                }

                // Nickname exists in db.
                if (db.Users.Any(user => user.nickname == nickname))
                {
                    nicknameNotValid.Text = "Користувач із таким nickname уже існує.";
                    nicknameNotValid.Visible = true;
                    addToTable = false;
                }
            }

            // Last name is empty.
            if (lastName == "Введіть своє прізвище" || lastName == "")
            {
                lastNameNotValid.Text = "Прізвище не може бути пустим";
                lastNameNotValid.Visible = true; 
                addToTable = false;
            }

            // First name is empty.
            if (firstName == "Введіть своє ім'я" || firstName == "")
            {
                nameNotValid.Text = "Ім'я  не може бути пустим";
                nameNotValid.Visible = true;
                addToTable = false;
            }

            // Nickname is empty.
            if (nickname == "Введіть нікнейм" || nickname == "")
            {
                nicknameNotValid.Text = "Нікнейм  не може бути пустим";
                nicknameNotValid.Visible = true;
                addToTable = false;
            }

            // Password is empty.
            if (userPassword == "Введіть пароль" || userPassword == "")
            {
                passwordNotValid.Text = "Пароль не може бути пустим";
                passwordNotValid.Visible = true;
                addToTable = false;
            }

            if (!comfirmPassText.Enabled)
            {
                comfirmPassLabel.ForeColor = Color.Red;
                addToTable = false;
            }

            if (comfirmPassText.Text.Trim() != userPassword)
            {
                comfirmPassLabel.ForeColor = Color.Red;
                addToTable = false;
            }

            if (addToTable)
            {
                Users user = new Users()
                {
                    first_name = firstName,
                    last_name = lastName,
                    email = email,
                    nickname = nickname,
                    user_password = userPassword
                };

                using (DishesGo_dbEntities db = new DishesGo_dbEntities())
                {
                    db.Users.Add(user);

                    if (db.SaveChanges() > 0)
                    {
                        JsonUserData userData = new JsonUserData()
                        {
                            email = email,
                            nickname = nickname,
                            isLogined = true
                        };

                        File.WriteAllText(configs.userDataPath, JsonConvert.SerializeObject(userData, Formatting.Indented));

                        Application.Restart();
                    }
                    else
                    {
                        MessageBox.Show("Щось пішло не так.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        #endregion Registration

        #region Login
        private void loginLoginPlateText_Enter(object sender, EventArgs e)
        {
            if (loginLoginPlateText.Text == "Введіть логін")
            {
                loginLoginPlateText.Text = "";
            }
        }

        private void loginLoginPlateText_Leave(object sender, EventArgs e)
        {
            if (loginLoginPlateText.Text == "")
            {
                loginLoginPlateText.Text = "Введіть логін";
            }
        }

        private void loginLoginPlateText_TextChanged(object sender, EventArgs e)
        {
            string login = loginLoginPlateText.Text.Trim();
            if (login != "" && login != "Введіть логін")
            {
                using (DishesGo_dbEntities context = new DishesGo_dbEntities())
                {
                    var matchingUsers = context.Users
                                               .Where(u => u.email == login || u.nickname == login)
                                               .ToList();

                    if (matchingUsers.Any())
                    {
                        loginLoginPlateLabel.ForeColor = Color.Black;
                        passwordLoginPlateText.Enabled = true; // User can enter the password.
                    }
                    else
                    {
                        loginLoginPlateLabel.ForeColor = Color.Red;
                        passwordLoginPlateText.Enabled = false; // User cannot enter the password.
                    }
                }
            }
            else
            {
                loginLoginPlateLabel.ForeColor = Color.Black;
            }
        }

        private void passwordLoginPlateText_Enter(object sender, EventArgs e)
        {
            if (passwordLoginPlateText.Text == "Введіть пароль")
            {
                passwordLoginPlateText.Text = "";
            }
        }

        private void passwordLoginPlateText_Leave(object sender, EventArgs e)
        {
            if (passwordLoginPlateText.Text == "")
            {
                passwordLoginPlateText.Text = "Введіть пароль";
            }
        }

        private void passwordLoginPlateText_TextChanged(object sender, EventArgs e)
        {
            string login = loginLoginPlateText.Text.Trim();
            string password = passwordLoginPlateText.Text.Trim();

            using (DishesGo_dbEntities context = new DishesGo_dbEntities())
            {
                var user = context.Users.FirstOrDefault(u => u.email == login || u.nickname == login);

                if (user != null && PasswordHasher.VerifyPassword(password, user.user_password)) // The user with the login exists.
                {
                    loginLoginPlateButton.Visible = true;
                }
                else // We do not have the user in db.
                {
                    loginLoginPlateButton.Visible = false;
                }
            }
        }

        // The user try to enter.
        private void loginLoginPlateButton_Click(object sender, EventArgs e)
        {
            string login = loginLoginPlateText.Text.Trim();
            string password = passwordLoginPlateText.Text.Trim();

            using (DishesGo_dbEntities context = new DishesGo_dbEntities())
            {
                // We do not check if current user is null, because if it is that we would not have been here.
                Users currentUser = context.Users.FirstOrDefault(user => user.email == login || user.nickname == login);
                JsonUserData userData = new JsonUserData()
                {
                    email = currentUser.email,
                    nickname = currentUser.nickname,
                    isLogined = true
                };

                File.WriteAllText(configs.userDataPath, JsonConvert.SerializeObject(userData, Formatting.Indented));

                Application.Restart();
            }
        }
        #endregion Login
    }
}
