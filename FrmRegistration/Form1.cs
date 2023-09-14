namespace FrmRegistration
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            FrmConfirm frmConfirm = new FrmConfirm();
            try
            {
                
                StudentInfoClass.Program = cbprogram.SelectedItem.ToString();
                StudentInfoClass.FirstName = fn.Text.ToString();
                StudentInfoClass.LastName = ln.Text.ToString();
                StudentInfoClass.MiddleName = mn.Text.ToString();
                StudentInfoClass.Address = ad.Text.ToString();
                StudentInfoClass.Age = Convert.ToInt64(a.Text);
                StudentInfoClass.ContactNo = Convert.ToInt64(cn.Text);
                StudentInfoClass.StudentNo = Convert.ToInt64(sn.Text);
                frmConfirm.ShowDialog();
                // button1.DialogResult = DialogResult.OK;
                frmConfirm.DialogResult = DialogResult.OK;
            } catch
            {
                MessageBox.Show("Please fill all the boxes.");
            }
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }
    }
}