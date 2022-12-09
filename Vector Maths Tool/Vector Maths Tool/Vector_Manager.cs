using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vector_Maths_Tool
{
    public partial class Vector_Manager : Component
    {
        public Vector_Manager()
        {
            InitializeComponent();
        }

        public Vector_Manager(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
    }
}
