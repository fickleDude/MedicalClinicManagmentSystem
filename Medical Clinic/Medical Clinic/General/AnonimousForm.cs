using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Medical_Clinic.General
{
    public partial class AnonimousForm : Form
    {
        private Connection connection;
        public AnonimousForm(Connection connection)
        {
            InitializeComponent();
            this.connection = connection;
        }
    }
}
