using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_Tracker
{
    public class ServiceGroupBuilder
    {
        

        public List<GroupsClass> groupsListBuilder()
        {
            List<GroupsClass> groupsList = new List<GroupsClass>();

            GroupsClass group1 = new GroupsClass();
            group1.name = "CS101";

            GroupsClass group2 = new GroupsClass();
            group2.name = "ENG102";

            groupsList.Add(group1);
            groupsList.Add(group2);
            return groupsList;
        }

    }
}
