using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BufferMaker
{
    public partial class BufferMaker : Form
    {
        string root;
        private static string TAPE = "\\TapeController\\TapeController\\Data";
        private static string DISK = "\\DiskController\\DiskController\\Data";

        public BufferMaker(string route)
        {
            InitializeComponent();
            controllerOption.Items.Add("Tape"); controllerOption.Items.Add("Disk");
            actionOption.Items.Add("Create"); actionOption.Items.Add("Read"); actionOption.Items.Add("Modify"); actionOption.Items.Add("Delete");
            this.root = route;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void createBuffer_Click(object sender, EventArgs e)
        {
            bool valid = true;
            string print_Error = "";
            string save = "";
            char action = '0';

            if (controllerOption.SelectedItem != null)
            {
                if (controllerOption.SelectedItem.ToString() == "Tape") save = TAPE;
                else save = DISK;
            }
            else
            {
                valid = false;
                print_Error = "Select a controller.";
            }

            
            if (actionOption.SelectedItem != null)
            {
                switch (actionOption.SelectedItem.ToString())
                {
                    case "Modify":
                        action = 'M';
                        break;
                    case "Create":
                        action = 'C';
                        break;
                    case "Delete":
                        action = 'D';
                        break;
                    default: //Read
                        action = 'R';
                        break;
                }
            }
            else
            {
                valid = false;
                print_Error = print_Error + " Select a action.";
            }


            if (textRoute.TextLength == 0)
            {
                valid = false;
                print_Error = print_Error + " Direction/Route Empty.";
            }
            if (textFileName.TextLength == 0)
            {
                valid = false;
                print_Error = print_Error + " File Name empty.";
            }
            if (textContent.TextLength == 0)
            {
                valid = false;
                print_Error = print_Error + " Content empty.";
            }

            if (valid)
            {
                Archive archive = new Archive();
                bool confirmation = archive.create_Buffer(root + save, action, textRoute.Text, textFileName.Text, textContent.Text);
                if (confirmation) textContent.Text = "Archive " + textFileName.Text + " created";
                else textContent.Text = "Archive " + textFileName.Text + " not created, the 'File Name' is exists";
            }
            else textContent.Text = print_Error;
        }
    }
}
