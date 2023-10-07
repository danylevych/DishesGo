using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using ComponentFactory.Krypton.Toolkit;
using DishesGo.src.dbClasses;

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
                string login = loginLoginPlateText.Text;
                string password = passwordLoginPlateText.Text;

                string sqlQuery = "SELECT * FROM Users WHERE user_password = @password AND (nickname = @login OR email = @login);";

                using (SqlCommand command = new SqlCommand(sqlQuery, SQLConection.Instance))
                {
                    command.Parameters.AddWithValue("@password", password);
                    command.Parameters.AddWithValue("@login", login);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {

                        if (reader.HasRows)
                        {
                            // TODO: open form.
                        }
                        else
                        {
                            MessageBox.Show("На жаль, такого користувача не знайдено.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
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

            if (nicnameText.Text == "Введіть своє нікнейм" && nicnameText.Text != "")
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
                string firstName = nameText.Text;
                string lastName = lastnameText.Text;
                string email = emailText.Text;
                string nickname = nicnameText.Text;
                string userPassword = passwordText.Text;

                string sqlQuery = "INSERT INTO YourTableName (first_name, last_name, email, nickname, user_password)" +
                    " VALUES (@firstName, @lastName, @email, @nickname, @userPassword);";

                using (SqlCommand command = new SqlCommand(sqlQuery, SQLConection.Instance))
                {
                    command.Parameters.AddWithValue("@firstName", firstName);
                    command.Parameters.AddWithValue("@lastName", lastName);
                    command.Parameters.AddWithValue("@email", email);
                    command.Parameters.AddWithValue("@nickname", nickname);
                    command.Parameters.AddWithValue("@userPassword", userPassword);


                    if (command.ExecuteNonQuery() > 0)
                    {

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
