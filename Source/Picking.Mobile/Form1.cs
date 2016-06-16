using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.ServiceModel;

namespace Picking.Mobile
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            BasicHttpBinding binding = new BasicHttpBinding();
            EndpointAddress ea = new EndpointAddress("http://dred-msi/PickingService/PickingService.svc");
            //PickingService.PickingSlip ps2 = new Picking.Mobile.PickingService.PickingSlip();
            //PickingService.PickingService ps = new Picking.Mobile.PickingService.PickingService();
            //var ps1 = ps.GetPickingSlip("sadfsadf");
        }
    }
}