using ITMO2022.CSharp.Forms.Lab04.Ex3.Person;
using System.Text;

namespace ITMO2022.CSharp.Forms.Lab04.Ex2.EditPerson
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<Person> pers = new List<Person>();

        private void button1_Click(object sender, EventArgs e)
        {
            Person p = new Person();

            EditPersonForm editForm = new EditPersonForm(p);
            pers.Add(p);

            personsListView.VirtualListSize = pers.Count;
            personsListView.Invalidate();

            if (editForm.ShowDialog() != DialogResult.OK)
                return;
            ListViewItem newItem = personsListView.Items.Add(editForm.FirstName);
            newItem.SubItems.Add(editForm.LastName);
            newItem.SubItems.Add(editForm.Age.ToString());
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (personsListView.SelectedIndices.Count == 0)
                return;

            Person p = pers[personsListView.SelectedIndices[0]];

            EditPersonForm editForm = new EditPersonForm(p);
            if (editForm.ShowDialog() == DialogResult.OK)
            {
                personsListView.Invalidate();
            }
        }

        private void personsListView_RetrieveVirtualItem(object sender, RetrieveVirtualItemEventArgs e)
        {
            if (e.ItemIndex >= 0 && e.ItemIndex < pers.Count)
            {
                e.Item = new ListViewItem(pers[e.ItemIndex].FirstName);
                e.Item.SubItems.Add(pers[e.ItemIndex].LastName);
                e.Item.SubItems.Add(pers[e.ItemIndex].Age.ToString());
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            foreach (Person item in pers)
            {
                sb.Append("���������: \n" + item.ToString());
            }
            richTextBox1.Text = sb.ToString();
        }
    }
}