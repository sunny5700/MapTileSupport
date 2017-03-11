﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdministrativeDivisionSupport.Models
{
    class City
    {
        private int index;

        public int Index
        {
            get { return index; }
            set { index = value; }
        }

        private int code;

        public int Code
        {
            get { return code; }
            set { code = value; }
        }

        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private List<County> countyCollection;

        public List<County> CountyCollection
        {
            get { return countyCollection; }
            set { countyCollection = value; }
        }
    }
}
