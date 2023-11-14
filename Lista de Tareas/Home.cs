using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace Lista_de_Tareas
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
            RefreshHomeworkList();

            ResetButtons();
        }
        ConnectionCRUD connectionCRUD = new ConnectionCRUD();

        public void RefreshHomeworkList()
        {
            homeworkCheckedList.Items.Clear();

            List<Homework> homeworks = connectionCRUD.GetHomework();

            foreach (Homework homework in homeworks)
            {
                // Cambia el color del texto del item antes de agregarlo al listBox
                string itemText = homework.title;
                if (homework.status)
                {
                    itemText = string.Format("La tarea ----"+ itemText + "----- ha sido verificada");
                    homeworkCheckedList.Items.Add(itemText);
                }
                else
                {
                    itemText = string.Format("La tarea ----"+ itemText + "----- esta pendiente");
                    homeworkCheckedList.Items.Add(itemText);
                }
            }
        }

        public void ResetButtons()
        {
            int i = homeworkCheckedList.SelectedIndex;

            if (i >= 0)
                {
                    btnAdd.Enabled = false;
                    btnCancel.Enabled = true;
                    btnDelete.Enabled = true;
                    btnVerified.Enabled = true;
                    btnOptions.Enabled = true;
                    btnShow.Enabled = true;
                }else
                {
                    btnAdd.Enabled = true;
                    btnCancel.Enabled = false;
                    btnDelete.Enabled = false;
                    btnVerified.Enabled = false;
                    btnOptions.Enabled = true;
                    btnShow.Enabled = false;
                }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            Create create = new Create(this);
            create.Show();
        }

        private void homeworksListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            ResetButtons();

        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            Update update = new Update(this);
            List<Homework> homeworks = connectionCRUD.GetHomework();



            update.ShowDataHomework(homeworks[homeworkCheckedList.SelectedIndex]);
            update.Show();
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            List<Homework> homeworks = connectionCRUD.GetHomework();

                
            string id = homeworks[homeworkCheckedList.SelectedIndex].ID;
            connectionCRUD.DeleteHomework(int.Parse(id));
            RefreshHomeworkList();
            ResetButtons();

                    
        }

        private void homeworkCheckedList_SelectedIndexChanged(object sender, EventArgs e)
        {
            ResetButtons();

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            homeworkCheckedList.SelectedIndex = -1;
        }

        private void homeworkCheckedList_DrawItem(object sender, DrawItemEventArgs e)
        {
            // Get the homework item that is being drawn.
            Homework homework = connectionCRUD.GetHomework()[e.Index];

            // Set the color of the text brush based on the status of the homework.
            Brush textBrush = (homework.status) ? Brushes.Red : Brushes.Blue;

            // Draw the text of the listBox item.
            e.Graphics.DrawString(homework.title, e.Font, textBrush, e.Bounds, StringFormat.GenericDefault);
        }

        private void btnOptions_Click(object sender, EventArgs e)
        {
            optionsPanel.Visible = true;
        }

        private void btnOptionSave_Click(object sender, EventArgs e)
        {

            optionsPanel.Visible = false;

        }

        private void cfWhite_CheckedChanged(object sender, EventArgs e)
        {
            homeworkCheckedList.BackColor = Color.White;

        }

        private void cfBlack_CheckedChanged(object sender, EventArgs e)
        {
            homeworkCheckedList.BackColor = Color.Black;

        }

        private void cfBlue_CheckedChanged(object sender, EventArgs e)
        {
            homeworkCheckedList.BackColor = Color.Blue;

        }

        private void btnOptionClose_Click(object sender, EventArgs e)
        {
            homeworkCheckedList.BackColor = Color.LightGray;
            homeworkCheckedList.Font = new Font("Cooper Black", 9.75f);
            homeworkCheckedList.ForeColor = Color.Black;
            optionsPanel.Visible =false;
        }

        private void etLucida_CheckedChanged(object sender, EventArgs e)
        {
            homeworkCheckedList.Font = new Font("Lucida Fax", 9.75f);

        }

        private void etImpact_CheckedChanged(object sender, EventArgs e)
        {
            homeworkCheckedList.Font = new Font("Impact", 9.75f);

        }

        private void etCooper_CheckedChanged(object sender, EventArgs e)
        {
            homeworkCheckedList.Font = new Font("Cooper Black", 9.75f);

        }

        private void ctWhite_CheckedChanged(object sender, EventArgs e)
        {
            homeworkCheckedList.ForeColor = Color.White;

        }

        private void CtBlack_CheckedChanged(object sender, EventArgs e)
        {
            homeworkCheckedList.ForeColor = Color.Black;

        }

        private void btnVerified_Click(object sender, EventArgs e)
        {
            Update update = new Update(this);
            List<Homework> homeworks = connectionCRUD.GetHomework();
            int index = homeworkCheckedList.SelectedIndex;

            if(index >= 0 && homeworks[index].status != true)
            {
                homeworks[index].status = true;
                connectionCRUD.UpdateHomework(homeworks[index]);
                RefreshHomeworkList();
                ResetButtons();
                homeworkCheckedList.SelectedIndex = -1;
            }else if(homeworks[index].status == true)
            {
                MessageBox.Show("Ya esta tarea ha sido realizada");
            }

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            optionsPanel.Visible = false;
            homeworkCheckedList.BackColor = Color.LightGray;
            homeworkCheckedList.Font = new Font("Cooper Black", 9.75f);
            homeworkCheckedList.ForeColor = Color.Black;
            optionsPanel.Visible = false;
        }
    }
}
