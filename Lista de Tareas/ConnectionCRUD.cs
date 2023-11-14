using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lista_de_Tareas
{
    internal class ConnectionCRUD
    {
        SqlConnection conexion = new SqlConnection("server = DESKTOP-0CQAL6E; database=Homework; integrated security=true");


        public void CreateHomework(Homework homework)
        {
            if (homework == null)
            {
                MessageBox.Show("ha ocurrido un error de guardado");
                return;
            }

            if (string.IsNullOrWhiteSpace(homework.title) || string.IsNullOrWhiteSpace(homework.description))
            {
                MessageBox.Show("Complete todos los campos para crear contacto");
                return;
            }

            conexion.Open();
            string code = "INSERT INTO homeworks(title, description,status) VALUES " +
                "(@title, @description,@status)";

            SqlCommand cmd = new SqlCommand(code, conexion);

            cmd.Parameters.AddWithValue("@title", homework.title);
            cmd.Parameters.AddWithValue("@description", homework.description);
            cmd.Parameters.AddWithValue("@status", homework.status.ToString());


            cmd.ExecuteNonQuery();
            MessageBox.Show("Los datos han sido enviados correctamente");
            conexion.Close();
        }

        public List<Homework> GetHomework()
        {
            conexion.Open();
            List<Homework> homeworks = new List<Homework>();
            string code = "Select * from homeworks";
            SqlCommand cmd = new SqlCommand(code, conexion);
            SqlDataReader registro = cmd.ExecuteReader();

            while (registro.Read())
            {
                Homework homework = new Homework(
                    registro["ID"].ToString(), 
                    registro["title"].ToString(), 
                    registro["description"].ToString(),
                    bool.Parse(registro["status"].ToString())
                    );
                
                homeworks.Add(homework);
            }

            conexion.Close();
            return homeworks;
        }

        public void UpdateHomework(Homework homework)
        {

            if (homework == null)
            {
                MessageBox.Show("ha ocurrido un error de guardado");
                return;
            }

            if (string.IsNullOrWhiteSpace(homework.title) || string.IsNullOrWhiteSpace(homework.title))
            {
                MessageBox.Show("Complete todos los campos para crear tarea");
                return;
            }

            conexion.Open();


            DialogResult result = MessageBox.Show("¿Estás seguro de Guardar los cambios de esta tarea?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                string code = "UPDATE homeworks SET " + "title = @title, " + "description = @description, " + "status = @status " + "WHERE ID = @ID";

                SqlCommand cmd = new SqlCommand(code, conexion);
                cmd.Parameters.AddWithValue("@title", homework.title);
                cmd.Parameters.AddWithValue("@description", homework.description);
                cmd.Parameters.AddWithValue("@ID", homework.ID);
                cmd.Parameters.AddWithValue("@status", homework.status.ToString());
                Console.WriteLine(homework.status.ToString());
                cmd.ExecuteNonQuery();

                MessageBox.Show("Los datos han sido actualizados correctamente");
            }

            conexion.Close();
        }

        public void DeleteHomework(int id)
        {
            conexion.Open();

            DialogResult result = MessageBox.Show("¿Estás seguro de que deseas eliminar esta tarea?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                string code = "DELETE FROM homeworks WHERE ID = @ID";

                SqlCommand cmd = new SqlCommand(code, conexion);
                cmd.Parameters.AddWithValue("@ID", id);
                cmd.ExecuteNonQuery();

                MessageBox.Show("El contacto han sido eliminado correctamente");
            }

          
            conexion.Close();
        }


    }
}
