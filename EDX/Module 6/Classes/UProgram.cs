using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_6.Classes
{
    class UProgram
    {
        //Contructors
        public UProgram()
        {

        }
        public UProgram(string name ,  string departmenthead)
        {
            this.ProgramName = name;
            this.DepartmentHead = departmenthead;
        }

        //Member variables
        private string programname;
        private string departmenthead;
        private Degree degree;

        //public propeties 
        public string ProgramName { get { return programname; } set { programname = value; } }
        public string DepartmentHead { get { return departmenthead;  } set { departmenthead = value; } }
        public Degree Degree { get { return degree; } set { degree = value; } }
    }
}
