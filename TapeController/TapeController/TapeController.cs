using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TapeController
{
    public partial class TapeController : Form
    {
        private string data_Route;
        private TapeArchive tape_Archive;
        private static string FILES_AVAILABLE = "\\filesAvailable.txt";

        public TapeController(string data_Route)
        {
            InitializeComponent();
            this.data_Route = data_Route;
            tape_Archive = new TapeArchive(data_Route);

            /*initialize list(comboBox1) of files available*/
            Object[] files_Available = tape_Archive.element_Separator(FILES_AVAILABLE);
            if (files_Available != null)
                filesAvailable.Items.AddRange(files_Available);
            else
                filesAvailable.Items.Add("NULL");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*update list(comboBox1) of files available*/
            filesAvailable.Items.Clear();
            Object[] files_Available = tape_Archive.element_Separator(FILES_AVAILABLE);
            if (files_Available != null)
                filesAvailable.Items.AddRange(files_Available);
            else
                filesAvailable.Items.Add("NULL");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            { 
                string answer = tape_Archive.controller("\\FilesAvailable\\" +filesAvailable.SelectedItem.ToString());
                richTextBox1.Text = answer;
            }
            catch
            {
                richTextBox1.Text = "Unselected option";
            }
        }

        private void TapeController_Load(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
