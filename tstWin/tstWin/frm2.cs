using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyCollections;
namespace tstWin
{
    public partial class frm2 : Form
    {
        public frm2()
        {
            InitializeComponent();
        }

        private MyCollections.ListWithChangedEvent List;

        public MyCollections.ListWithChangedEvent oList {

            set
                { List = value;

                List.Changed += new ChangedEventHandler(ListChanged);
            }

        }

        private void ListChanged(object sender, EventArgs e)
        {
            Console.WriteLine("This is called when the event fires.");
        }

        public void Detach()
        {
            // Detach the event and delete the list
            List.Changed -= new ChangedEventHandler(ListChanged);
            List = null;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
