using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;


namespace Task_Tracker
{
    public class GroupsClass
    {

        public string name { get; set; }
        public Color colour { get; set; }
        public bool autoArchive { get; set; }
        public DateTime archiveDate { get; set; }
        public List<TasksClass> taskList;

        public override string ToString()
        {
            return name;
        }

    }
} 
