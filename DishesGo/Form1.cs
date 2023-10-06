using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;

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
            if(passwordText.Text != "Введіть пароль" && comfirmPassText.Text != "Введіть пароль іще раз")
            {
                if(passwordText.Text != comfirmPassText.Text) 
                {
                    comfirmPassLabel.BackColor = Color.Red;
                }
                else
                {
                    comfirmPassLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(235)))), ((int)(((byte)(148)))));
                }
            }
        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            registrPanel.Visible = true;
        }
    }
}
