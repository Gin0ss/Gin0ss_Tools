using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vector_Maths_Tool
{
    public partial class Vector_Shapes : Component
    {
        public Vector_Shapes()
        {
            InitializeComponent();
        }

        public Vector_Shapes(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
    }
}
