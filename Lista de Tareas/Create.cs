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
    public partial class Create : Form
    {
        private Home home;

        public Create(Home home)
        {
            InitializeComponent();
            this.home = home;
        }

        ConnectionCRUD connectionCRUD = new ConnectionCRUD();


        private void button1_Click(object sender, EventArgs e)
        {
            
            Homework homework = new Homework(
                titleBox.Text, 
                descriptionBox.Text
                );

            connectionCRUD.CreateHomework(homework);
            home.RefreshHomeworkList();
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
