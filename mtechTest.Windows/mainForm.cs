using System;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Linq;

namespace mtechTest.Windows
{
    public partial class mainForm : Form
    {
        EmployeeContext _context;
        bool newRecord;

        public mainForm()
        {
            InitializeComponent();
        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            SqlConnectionStringBuilder csb = new SqlConnectionStringBuilder();
            csb.DataSource = "(LocalDb)\\MSSQLLocalDB";
            csb.InitialCatalog = "mtechDB";
            csb.IntegratedSecurity = true;
            _context = new EmployeeContext();
            _context.Database.Connection.ConnectionString = csb.ConnectionString;
            if(!_context.Database.Exists())
            {
                _context.Database.Create();
            }
            _context.Database.Connection.Open();
            _context.Employees.Load();
            employeeBS.DataSource = _context.Employees.Local.ToBindingList();
            endModify();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void employeeBS_CurrentChanged(object sender, EventArgs e)
        {
           // loadCurrentData();
        }

        private void loadCurrentData()
        {
            Employee current = (employeeBS.Current as Employee);
            eID.Value = current.Id;
            eName.Text = current.Name;
            eLastName.Text = current.LastName;
            eRFC.Text = current.RFC;
            eBornDate.Value = newRecord ? DateTime.Now : current.BornDate;
            eStatus.SelectedIndex = (int)current.Status;
        }

        private void eStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void mainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            _context.SaveChanges();
            _context.Database.Connection.Close();
        }

        private void bSave_Click(object sender, EventArgs e)
        {try
            {
                if (_context.Employees.Count(x => x.Id != (int)eID.Value && x.RFC.ToUpper() == eRFC.Text.ToUpper()) ==0)
                {
                    if (ValidateRFC(eRFC.Text.ToUpper()))
                    {
                        Employee current = (employeeBS.Current as Employee);
                        current.Id = newRecord ? (int)eID.Value : current.Id;
                        current.Name = eName.Text;
                        current.LastName = eLastName.Text;
                        current.RFC = eRFC.Text.ToUpper();
                        current.BornDate = eBornDate.Value;
                        current.Status = (EmployeeStatus)eStatus.SelectedIndex;
                        employeeBS.ResetCurrentItem();
                        _context.SaveChanges();
                           
                        endModify();
                    }
                    else
                    {
                        throw new Exception("RFC has incorrect format!!");
                    }
                }
                else
                {
                    throw new Exception("RFC already exist in the database!!");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private bool ValidateRFC(string RFC)
        {
            if(RFC.Length == 13)
            {
                return true;
            }
            return false;
        }

        private void bCancel_Click(object sender, EventArgs e)
        {
            if (newRecord)
            {
                employeeBS.RemoveCurrent();
            }
            endModify();
        }

        private void bNew_Click(object sender, EventArgs e)
        {
            newRecord = true;
            employeeBS.AddNew();
            loadCurrentData();
            startModify();
        }

        private void bEdit_Click(object sender, EventArgs e)
        {
            newRecord = false;
            loadCurrentData();
            startModify();
        }

        private void endModify()
        {
            eID.Value = 0;
            eName.Text = String.Empty;
            eLastName.Text = String.Empty;
            eRFC.Text = String.Empty;
            eBornDate.Value = DateTime.Now;
            eStatus.SelectedIndex = 0;

            eID.Enabled = false;
            eName.Enabled = false;
            eLastName.Enabled = false;
            eRFC.Enabled = false;
            eBornDate.Enabled = false;
            eStatus.Enabled = false;

            bSave.Enabled = false;
            bCancel.Enabled = false;
            newRecord = false;

            bNew.Enabled = true;
            bEdit.Enabled = true;
            bDelete.Enabled = true;
            bFilter.Enabled =true;
            bClear.Enabled= true;
            filterName.Enabled = true;

            employeeDGView.Enabled = true;

            _context.SaveChanges();
            
        }

        private void startModify()
        {
            //eID.Enabled = newRecord;
            eID.Enabled = false;
            eName.Enabled = true;
            eLastName.Enabled = true;
            eRFC.Enabled = true;
            eBornDate.Enabled = true;
            eStatus.Enabled = true;

            bSave.Enabled = true;
            bCancel.Enabled = true;

            bNew.Enabled = false;
            bEdit.Enabled = false;
            bDelete.Enabled = false;
            bFilter.Enabled = false;
            bClear.Enabled = false;
            filterName.Enabled = false;

            employeeDGView.Enabled = false;
        }

        private void bDelete_Click(object sender, EventArgs e)
        {
            Employee current = (employeeBS.Current as Employee);
            if (!newRecord && MessageBox.Show($"This will delete employee {current.Id} {current.Name} {current.LastName}","Delete employee", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                employeeBS.RemoveCurrent();
            }
        }

        private void bFilter_Click(object sender, EventArgs e)
        {
            employeeBS.Filter = $"Name LIKE '{filterName.Text}'";
            employeeDGView.Update();
        }

        private void bClear_Click(object sender, EventArgs e)
        {
            employeeBS.RemoveFilter();
            filterName.Text = String.Empty;
        }
    }
}
