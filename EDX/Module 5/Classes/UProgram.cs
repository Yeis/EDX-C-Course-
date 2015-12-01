using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_5.Classes
{
    class UProgram
    {
        //Contructors
        public UProgram()
        {

        }
        public UProgram(string name ,  string departmenthead)
        {
            this.PeogramName = name;
            this.DepartmentHead = departmenthead;
        }

        //Member variables
        private string programname;
        private string departmenthead;

        //public propeties 
        public string PeogramName { get { return programname; } set { programname = value; } }
        public string DepartmentHead { get { return departmenthead;  } set { DepartmentHead = value; } }
    }
}
