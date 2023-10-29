using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using DishesGo.Data;
using DishesGo.src;
using System.IO;
using DishesGo.src.tools;
using Newtonsoft.Json;

namespace DishesGo
{
    public partial class RegistrLoginForm : KryptonForm
    {
        public RegistrLoginForm()
        {
            InitializeComponent();
        }

        private void emailText_Enter(object sender, EventArgs e)
        {
            // User select the text label.
            if (emailText.Text == "Введіть свій e-mail")
            {
                emailText.Text = "";
            }
        }

        private void emailText_Leave(object sender, EventArgs e)
        {
            // User leave the label.
            if (emailText.Text == "")
            {
                emailText.Text = "Введіть свій e-mail";
            }
        }

        // TODO: check if e-mail has already exist in db.
        private void emailText_TextChanged(object sender, EventArgs e)
        {

        }


        private void lastnameText_Enter(object sender, EventArgs e)
        {
            // User leave the label.
            if (lastnameText.Text == "Введіть своє прізвище")
            {
                lastnameText.Text = "";
            }
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
        }

        private void nicnameText_Leave(object sender, EventArgs e)
        {
            // User leave the label.
            if (nicnameText.Text == "")
            {
                nicnameText.Text = "Введіть нікнейм";
            }
        }

        // TODO: chech if nikname has already exist in db.
        private void nicnameText_TextChanged(object sender, EventArgs e)
        {

        }


        private void passwordText_Enter(object sender, EventArgs e)
        {
            // User leave the label.
            if (passwordText.Text == "Введіть пароль")
            {
                passwordText.Text = "";
            }
        }

        private void passwordText_Leave(object sender, EventArgs e)
        {
            // User leave the label.
            if (passwordText.Text == "")
            {
                passwordText.Text = "Введіть пароль";
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
                    comfirmPassLabel.BackColor = Color.White;
                }
                else
                {
                    comfirmPassLabel.ForeColor = System.Drawing.Color.Black;
                    comfirmPassLabel.BackColor = Color.White;
                }
            }
        }


        private void MainFormButton_Click(object sender, EventArgs e)
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

        // The user try to enter.
        private void loginLoginPlateButton_Click(object sender, EventArgs e)
        {
            if (loginLoginPlateButton.Text != "Введіть логін" && loginLoginPlateButton.Text != "" &&
                passwordLoginPlateLabel.Text != "Введіть пароль" && passwordLoginPlateLabel.Text != "")
            {
                string login = loginLoginPlateText.Text.Trim();
                string password = passwordLoginPlateText.Text.Trim();

                using (DishesGo_dbEntities db = new DishesGo_dbEntities())
                {
                    /*bool isEmail = db.Users.Any(user => user.email == login);
                    bool isNickname = db.Users.Any(user => user.nickname == login);*/

                    Users currentUser = db.Users.FirstOrDefault(user => user.email == login || user.nickname == login);
                    if (currentUser != null)
                    {
                        if (db.Users.Any(user => user.user_password == password && (user.nickname == login || user.email == login)))
                        {
                            JsonUserData userData = new JsonUserData()
                            {
                                email = currentUser.email,
                                nickname = currentUser.nickname,
                                isLogined = true
                            };

                            File.WriteAllText(configs.userDataPath, JsonConvert.SerializeObject(userData, Formatting.Indented));

                            MainForm mainForm = new MainForm(currentUser);
                            mainForm.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Ви ввели направильний пароль.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Ви ввели направильний логін.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }


        private void signinRegPlateButton_Click(object sender, EventArgs e)
        {
            bool addToTable = true;

            if (emailText.Text == "Введіть свій e-mail" && emailText.Text == "")
            {
                MessageBox.Show("Поле - Пошта не може бути пустим.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                addToTable = false;
            }

            using (DishesGo_dbEntities db = new DishesGo_dbEntities())
            {
                if (db.Users.Any(user => user.email == emailText.Text.Trim()))
                {
                    MessageBox.Show("Користувач із таким email уже існує.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    addToTable = false;
                }

                if (db.Users.Any(user => user.nickname == nicnameText.Text.Trim()))
                {
                    MessageBox.Show("Користувач із таким nickname уже існує.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    addToTable = false;
                }
            }

            if (lastnameText.Text == "Введіть своє прізвище" && lastnameLabel.Text != "")
            {
                MessageBox.Show("Поле - Прізвище не може бути пустим.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                addToTable = false;
            }

            if (nameText.Text == "Введіть своє ім'я" && nameText.Text != "")
            {
                MessageBox.Show("Поле - Ім'я не може бути пустим.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                addToTable = false;
            }

            if (nicnameText.Text == "Введіть нікнейм" && nicnameText.Text != "")
            {
                MessageBox.Show("Поле - Нікнейм не може бути пустим.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                addToTable = false;
            }

            if (passwordText.Text == "Введіть пароль" && passwordText.Text != "")
            {
                MessageBox.Show("Поле - Пароль не може бути пустим.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                addToTable = false;
            }

            if (passwordText.Text != comfirmPassText.Text)
            {
                MessageBox.Show("Паролі не відповідають одне одному.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                addToTable = false;
            }

            if (addToTable)
            {
                string firstName = nameText.Text.Trim();
                string lastName = lastnameText.Text.Trim();
                string email = emailText.Text.Trim();
                string nickname = nicnameText.Text.Trim();
                string userPassword = passwordText.Text.Trim();

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

                        MainForm mainForm = new MainForm(user);
                        mainForm.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Щось пішло не так.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }


    }
}
