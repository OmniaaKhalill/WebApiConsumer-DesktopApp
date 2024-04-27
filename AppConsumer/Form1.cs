using static System.Net.WebRequestMethods;

namespace AppConsumer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {


            //post
            //client.PostAsJsonAsync("url",);
        }



        private void Depts_Data_Click(object sender, EventArgs e)
        {

            HttpClient client = new HttpClient();
            HttpResponseMessage res = client.GetAsync("https://localhost:7003/api/departments").Result;

            if (res.IsSuccessStatusCode)
            {
                var deptData = res.Content.ReadAsAsync<List<DeptData>>().Result;
                DGV_Department.DataSource = deptData;

            }
        }

        private async void add_std_Click(object sender, EventArgs e)
        {
            StudentData stdData = new StudentData
            {
                st_Fname = f_name.Text,
                st_Lname = L_name.Text,
                st_Age = int.Parse(std_age.Text),
                st_Address = std_address.Text
            };

            HttpClient client = new HttpClient();
            
                HttpResponseMessage response = await client.PostAsJsonAsync("https://localhost:7003/api/students", stdData);
                bool returnValue = await response.Content.ReadAsAsync<bool>();

                if (returnValue)
                {
                    MessageBox.Show("Student data sent successfully");
                }
                else
                {
                    MessageBox.Show("Failed to send student data. Status code: " + response.StatusCode);
                }
            
        }


    }
}
