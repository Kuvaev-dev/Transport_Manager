using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TransportManager.Views.AirwayViews;

namespace TransportManager.Views.Main
{
    public partial class OperationsView : Form
    {
        public OperationsView()
        {
            InitializeComponent();
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            DeleteAirway deleteAirway = new DeleteAirway();
            deleteAirway.Show();
        }

        private void Search_Click(object sender, EventArgs e)
        {
            GetAirway getAirway = new GetAirway();
            getAirway.Show();
        }

        private void Insert_Click(object sender, EventArgs e)
        {
            InsertAirway insertAirway = new InsertAirway();
            insertAirway.Show();
        }

        private void Update_Click(object sender, EventArgs e)
        {
            UpdateAirway updateAirway = new UpdateAirway();
            updateAirway.Show();
        }
    }
}
