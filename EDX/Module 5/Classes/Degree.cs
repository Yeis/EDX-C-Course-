﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_5.Classes
{
    class Degree
    {
        //Contructor 
        public Degree()
        {

        }
        public Degree(string name , int credits)
        {
            this.DegreeName = name;
            this.Credits_Required = credits; 
        }
        //Member Variables
        private string degreename;
        private int credits_required;
        // Public Properties
        public int Credits_Required { get { return credits_required; } set { credits_required = value; } }
        public string DegreeName { get { return degreename; } set { degreename = value; } }

    }
}
