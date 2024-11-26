namespace DemoWindowsForms
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void obnOk_Click(object sender, EventArgs e)
		{
			string name = txtName.Text;

			DateTime date = dateTimePicker1.Value.Date;

			double age = Math.Floor((DateTime.Now.Subtract(date).TotalDays / 365));

			lblInfo.Text = $@"Your name is {name} and you are {age} years old";



		}

		private void button1_Click(object sender, EventArgs e)
		{
			Form2 form2 = new Form2();
			form2.ShowDialog();

		}
	}
}
