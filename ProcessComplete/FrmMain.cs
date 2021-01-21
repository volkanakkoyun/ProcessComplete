using System;
using System.Windows.Forms;

namespace ProcessComplete
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        Process p = null;

        private void FrmMain_Load(object sender, EventArgs e)
        {
            p = new Process();
            p.ProcessCompleted += ProcessComlete;
        }

        public static void ProcessComlete(object sender, EventArgs e)
        {
            MessageBox.Show("Process completed");
        }

        private void processComlete_Click(object sender, EventArgs e)
        {
            p.Run();
        }
    }
}
