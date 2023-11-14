using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_de_Tareas
{
    public class Homework
    {
        public string ID { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public bool status { get; set; }

        public Homework()
        {
            ID = "";
            this.title = "";
            this.description = "";
            status = false;
        }

        public Homework(string id, string title, string description, bool status)
        {
            ID = id;
            this.title = title;
            this.description = description;
            this.status = status;
        }

        public Homework(string id, string title, string description)
        {
            ID = id;
            this.title = title;
            this.description = description;
            this.status = status;
        }

        public Homework(string title, string description)
        {
            ID = "";
            this.title = title;
            this.description = description;
            status = false;
        }

    }
}
