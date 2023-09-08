using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace login
{
    public partial class Login : Component
    {
        public Login()
        {
            InitializeComponent();
        }

        public Login(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
    }
}
