using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jsondotnet_newtonsoft
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void addFriendBtn_Click(object sender, EventArgs e)
        {
            string friendName = friendNameTxt.Text;
            FriendsLstbox.Items.Add(friendName);
        }

        private void createJsonBtn_Click(object sender, EventArgs e)
        {
            person returnPerson = new person();

            returnPerson.firstName = firstNameTxt.Text;
            returnPerson.lastName = lastNameTxt.Text;
            returnPerson.contact.Add("phone", phoneTxt.Text);
            returnPerson.contact.Add("email", emailTxt.Text);
            returnPerson.contact.Add("instant messenger", "abhilash456a");

            foreach(string friend in FriendsLstbox.Items)
            {
                returnPerson.Friends.Add(friend);
            }

            string newJson = Newtonsoft.Json.JsonConvert.SerializeObject(returnPerson);

            jsonTxt.Text = newJson;
        }

        private void decodeJsonBtn_Click(object sender, EventArgs e)
        {
            string json = jsonTxt.Text;
            person abhilash = new person();

            Newtonsoft.Json.JsonConvert.PopulateObject(json, abhilash);

            firstNameTxt.Text = abhilash.firstName;
            lastNameTxt.Text = abhilash.lastName;
            emailTxt.Text = abhilash.contact["email"];
            phoneTxt.Text = abhilash.contact["phone"];

            foreach(string friend in abhilash.Friends)
            {
                FriendsLstbox.Items.Add(friend);
            }
        }
    }
}
