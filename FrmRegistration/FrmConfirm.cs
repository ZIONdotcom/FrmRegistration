using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static FrmRegistration.StudentInfoClass;

namespace FrmRegistration
{
    public partial class FrmConfirm : Form
    {
        private DelegateText DelProgram, DelLastName, DelFirstName, DelMiddleName, DelAddress;
        private DelegateNumber DelNumAge, DelContactNum, DelStudno;

        public FrmConfirm()
        {
            InitializeComponent();
            DelProgram = new DelegateText(StudentInfoClass.GetProgram);
            DelLastName = new DelegateText(StudentInfoClass.GetLastNmae);
            DelFirstName = new DelegateText(StudentInfoClass.GetFirstName);
            DelMiddleName = new DelegateText(StudentInfoClass.GetMiddleName);
            DelAddress = new DelegateText(StudentInfoClass.GetAddress);

            DelNumAge = new DelegateNumber(StudentInfoClass.GetAge);
            DelContactNum = new DelegateNumber(StudentInfoClass.GetContactNo);
            DelStudno = new DelegateNumber(StudentInfoClass.GetStudentNo);


        }

        private void FrmConfirm_Load(object sender, EventArgs e)
        {
            fn.Text = DelFirstName(StudentInfoClass.FirstName);
            ln.Text = DelLastName(StudentInfoClass.LastName);
            mn.Text = DelMiddleName(StudentInfoClass.MiddleName);
            prog.Text = DelProgram(StudentInfoClass.Program);
            ad.Text = DelAddress(StudentInfoClass.Address);

            a.Text = DelNumAge(StudentInfoClass.Age).ToString();
            cn.Text = DelContactNum(StudentInfoClass.ContactNo).ToString();
            sn.Text = DelStudno(StudentInfoClass.StudentNo).ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();

        }

        private void FrmConfirm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.DialogResult= DialogResult.OK;
        }
    }
}
