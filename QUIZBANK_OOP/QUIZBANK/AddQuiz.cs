using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QUIZBANK
{
    public partial class AddQuiz : Form
    {
        public AddQuiz()
        {
            InitializeComponent();
        }
        public void loadform(object Form)
        {
            if (this.addPanel.Controls.Count > 0)
                this.addPanel.Controls.RemoveAt(0);
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.addPanel.Controls.Add(f);
            this.addPanel.Tag = f;
            f.Show();
        }
        private void btnMultipleChoice_Click(object sender, EventArgs e)
        {
            loadform(new MultipleChoice());
            addPanel.Hide();
        }

        private void btnIdentification_Click(object sender, EventArgs e)
        {
            loadform(new Identificationcs());
            this.Hide();
        }
    }
}
