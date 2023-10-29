using Newtonsoft.Json;

namespace AnketWinform
{
    public partial class Anket : Form
    {
        private List<string> jsonFileNames;

        public string jsonFileName { get; private set; }

        public class AnketData
        {
            public string Name { get; set; }
            public string Surname { get; set; }
            public string Email { get; set; }
            public string Phone { get; set; }
            public string Birth { get; set; }
        }
        public Anket()
        {
            InitializeComponent();
            jsonFileNames = new List<string>();
        }

        private void ListboxLbl_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void SurnameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void EmailTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void PhoneTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void BirthTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ElaveBtn_Click(object sender, EventArgs e)
        {
            string name = NameTextBox.Text;
            listBox.Items.Add(name);
        }

        private void DeyisBtn_Click(object sender, EventArgs e)
        {
            foreach (var item in listBox.Items)
            {
                string element = item.ToString();
            }
        }

        private void FileNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void LoadBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "JSON Files|*.json|All Files|*.*";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string fileName = openFileDialog.FileName;
                string fileContent = File.ReadAllText(fileName);

                var formData = JsonConvert.DeserializeObject(fileContent, typeof(AnketData)) as AnketData;
                NameTextBox.Text = formData.Name;
                SurnameTextBox.Text = formData.Surname;
                EmailTextBox.Text = formData.Email;
                PhoneTextBox.Text = formData.Phone;
                BirthTextBox.Text = formData.Birth;

                jsonFileName = fileName;
            }
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            string name = NameTextBox.Text;
            string surname = SurnameTextBox.Text;
            string email = EmailTextBox.Text;
            string phone = PhoneTextBox.Text;
            string birth = BirthTextBox.Text;

            var formData = new AnketData
            {
                Name = name,
                Surname = surname,
                Email = email,
                Phone = phone,
                Birth = birth
            };

            string json = JsonConvert.SerializeObject(formData);

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "JSON Files|*.json|All Files|*.*";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string fileName = saveFileDialog.FileName;
                File.WriteAllText(fileName, json);
                MessageBox.Show("Successfully saved.");

                jsonFileName = fileName;
            }
        }
    }
}