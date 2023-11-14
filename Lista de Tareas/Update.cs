using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lista_de_Tareas
{
    public partial class Update : Form
    {
        private Home home;
        int idHomework;
        ConnectionCRUD connectionCRUD = new ConnectionCRUD();

        public Update(Home home)
        {
            InitializeComponent();
            this.home = home;
        }



        public void ShowDataHomework(Homework homework1)
        {

            titleBox.Text = homework1.title;
            descriptionBox.Text = homework1.description;
            idHomework = int.Parse(homework1.ID);
            statusBox.Checked = homework1.status;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Homework homework = new Homework(
                idHomework.ToString(),
                titleBox.Text,
                descriptionBox.Text,
                statusBox.Checked
                );

            connectionCRUD.UpdateHomework(homework);
            home.RefreshHomeworkList();
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
