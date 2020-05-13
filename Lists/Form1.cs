using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lists
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 1; i < 20; i++)
            {
                listBoxL.Items.Add(string.Format("Opcja {0}", i));
                listBoxR.Items.Add(string.Format("Opcja {0}", (char)(i + (int)'A')) );
            }

            listBoxL.SelectionMode = SelectionMode.MultiExtended;
            listBoxR.SelectionMode = SelectionMode.MultiExtended;
        }

        private void ToTheRight(object sender, EventArgs e)
        {
            do
            {
                listBoxR.Items.Add(listBoxL.SelectedItem);
                listBoxL.Items.Remove(listBoxL.SelectedItem);

            } while (listBoxL.SelectedIndices.Count > 0);

        }

        private void ToTheLeft(object sender, EventArgs e)
        {
            do
            {
                listBoxL.Items.Add(listBoxR.SelectedItem);
                listBoxR.Items.Remove(listBoxR.SelectedItem);

            } while (listBoxR.SelectedIndices.Count > 0);


        }
    }




}
