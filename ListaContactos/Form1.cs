using ListaContactos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListaContactos
{
    public partial class Form1 : Form
    {

		private DataTable addressTable;
		public string pageAction;
		public string deleted;
		public string reLoad;
		public string DataFileName
        {
            get
            {
                string folder;
                folder = Environment.CurrentDirectory;
                return folder + "\\AdressBook.xml";
            }

        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
			// load the address using a shared method on SerializableData...
			txtSearchByName.Focus();
			ClearFields();
			SetEditState(false);
			LoadAddressGrid();
			LoadCurrentItem();
		}

		private void LoadCurrentItem()
		{
			if (grdAddress.CurrentRowIndex == -1)       // Is there any row selected now?
			{
				btnEdit.Enabled = false;
				btnDelete.Enabled = false;
				return;
			}

			int Id = int.Parse(grdAddress[grdAddress.CurrentRowIndex, 0].ToString());

			AddressData addressdata = AddressDataManager.GetAddressData(Id);
			if (addressdata == null)
			{
				MessageBox.Show("No se puede recibir información.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			txtName.Text = addressdata.Name;
			txtAddress.Text = addressdata.Address;
			txtPhone.Text = addressdata.Phone;
			txtFatherName.Text = addressdata.Father;
			dtDOB.Value = addressdata.DOB;
			txtQualification.Text = addressdata.Quali;
			txtNationality.Text = addressdata.Nationality;
			txtDesignation.Text = addressdata.Desig;
			txtMailId.Text = addressdata.Email;
			txtOtherDetails.Text = addressdata.Remarks;
		}

		private void LoadAddressGrid()
		{
			string criteria = "Name like '%" + txtSearchByName.Text + "%' AND status <> " + (int)eStatus.Deleted;
			addressTable = AddressDataManager.GetAddressess(criteria);
			grdAddress.DataSource = addressTable;
		}

		public void LoadAddresses()
		{
			if (grdAddress.CurrentRowIndex <= -1)
				return;

			int Id = int.Parse(grdAddress[grdAddress.CurrentRowIndex, 0].ToString());

			AddressData frm = AddressDataManager.GetAddressData(Id);

			if (frm == null)
			{
				MessageBox.Show("No se puede recibir información. " + Id, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			txtName.Text = frm.Name;
			txtAddress.Text = frm.Address;
			txtPhone.Text = frm.Phone;
			txtFatherName.Text = frm.Father;
			dtDOB.Value = frm.DOB;
			txtQualification.Text = frm.Quali;
			txtNationality.Text = frm.Nationality;
			txtDesignation.Text = frm.Desig;
			txtMailId.Text = frm.Email;
			txtOtherDetails.Text = frm.Remarks;
		}

		private void SetEditState(bool edit)
		{
			btnAdd.Enabled = !edit;
			btnEdit.Enabled = !edit;
			btnQuit.Enabled = !edit;
			btnDelete.Enabled = !edit;

			grdAddress.Enabled = !edit;

			btnCancel.Enabled = edit;
			btnSave.Enabled = edit;

			txtName.ReadOnly = !edit;
			txtAddress.ReadOnly = !edit;
			txtPhone.ReadOnly = !edit;
			txtFatherName.ReadOnly = !edit;
			txtQualification.ReadOnly = !edit;
			txtNationality.ReadOnly = !edit;
			txtDesignation.ReadOnly = !edit;
			txtMailId.ReadOnly = !edit;
			txtOtherDetails.ReadOnly = !edit;

			dtDOB.Enabled = edit;
		}

		private void ClearFields()
		{
			txtName.Text = String.Empty;
			txtAddress.Text = String.Empty;
			txtPhone.Text = String.Empty;
			txtFatherName.Text = String.Empty;
			dtDOB.Value = DateTime.Today;
			txtQualification.Text = String.Empty;
			txtNationality.Text = String.Empty;
			txtDesignation.Text = String.Empty;
			txtMailId.Text = String.Empty;
			txtOtherDetails.Text = String.Empty;
		}

		

		private void grdAddress_CurrentCellChanged(object sender, System.EventArgs e)
		{
			grdAddress.Select(grdAddress.CurrentRowIndex);
			LoadCurrentItem();
			SetEditState(false);
		}

		private void btnCancel_Click(object sender, System.EventArgs e)
		{
			LoadCurrentItem();

			SetEditState(false);
		}

		private void btnAdd_Click(object sender, System.EventArgs e)
		{
			pageAction = "ADD";
			ClearFields();
			SetEditState(true);
			txtName.Focus();
		}

		private void btnEdit_Click(object sender, System.EventArgs e)
		{
			pageAction = "EDIT";

			LoadCurrentItem();
			txtName.Focus();
			SetEditState(true);
		}

		private void btnDelete_Click(object sender, System.EventArgs e)
		{
			if (grdAddress.CurrentRowIndex <= -1)
			{
				return;
			}

			int Id = int.Parse(grdAddress[grdAddress.CurrentRowIndex, 0].ToString());
			AddressData st = AddressDataManager.GetAddressData(Id);

			if (st == null)
			{
				return;
			}

			if (MessageBox.Show("آیا برای حذف مطمئن هستید ؟", "AddressBook", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.OK)
			{
				st.Status = eStatus.Deleted;
				AddressDataManager.UpdateAddressData(st);
			}
			else
			{
				return;
			}

			LoadAddressGrid();

			txtSearchByName.Focus();

			SetEditState(false);

			ClearFields();

			LoadCurrentItem();
		}

		private void btnSave_Click(object sender, System.EventArgs e)
		{
			if (txtName.Text.Trim() == String.Empty)
			{
				MessageBox.Show("Por favor, introduzca su nombre y apellido.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				txtName.Focus();
				return;
			}

			AddressData addressdata;

			if (pageAction == "ADD")
			{
				addressdata = new AddressData();
				int id = IdManager.GetNextID("AddressData", "RecId");
				addressdata.RecId = id;
			}
			else
			{

				int id = int.Parse(grdAddress[grdAddress.CurrentRowIndex, 0].ToString());
				addressdata = AddressDataManager.GetAddressData(id);
			}

			addressdata.Name = txtName.Text;
			addressdata.Address = txtAddress.Text;
			addressdata.Phone = txtPhone.Text;
			addressdata.Father = txtFatherName.Text;
			addressdata.DOB = dtDOB.Value;
			addressdata.Quali = txtQualification.Text;
			addressdata.Nationality = txtNationality.Text;
			addressdata.Desig = txtDesignation.Text;
			addressdata.Email = txtMailId.Text;
			addressdata.Remarks = txtOtherDetails.Text;

			if (pageAction == "ADD")
			{
				int id = IdManager.GetNextID("AddressData", "RecId");
				addressdata.RecId = id;
				AddressDataManager.CreateAddressData(addressdata);
			}
			else
			{
				AddressDataManager.UpdateAddressData(addressdata);
			}

			LoadAddressGrid();

			MessageBox.Show("تغییرات با موفقیت ذخیره گردید", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);


			SetEditState(false);
		}

		private void BtnClose_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}

		private void btnQuit_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			//frmAbout frm = new frmAbout();
			//frm.ShowDialog();

		}

		private void grpControls_Enter(object sender, EventArgs e)
		{

		}

        private void txtSearchByName_TextChanged(object sender, EventArgs e)
        {
			LoadAddressGrid();
			LoadCurrentItem();
		}
    }
}
