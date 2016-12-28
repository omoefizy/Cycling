using Calendar.NET;
using System;
using System.IO;
using System.Windows.Forms;

namespace Cycling
{
   
    public partial class Calendar : Form
    {
        string djeasy;
        string[] files;
        public Calendar()
        {
            InitializeComponent();
            files = Directory.GetFiles(@"C:\Users\OMOBO\Documents\LEEDS BU Year 3\SEM 2\ASEB\ASDBdata-20160805T031015Z\ASDBdata\August2012DataForCalandar");
        }
        public void Mydate()
        {
            listView1.Clear();
            foreach (string file in files)
            {
                if (monthCalendar1.SelectionRange.Start.ToShortDateString() == File.GetCreationTime(file).ToShortDateString())
                {
                    var newfile = new ListViewItem(Path.GetFileName(file));
                    listView1.Items.Add(newfile);
                }
            }
        }
        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            Mydate();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            djeasy = listView1.SelectedItems[0].Text;
            DialogResult = DialogResult.OK;
        }
        public string OSI
        {
            get {
                return 
                djeasy;
                }
        }
    }

}
   
