﻿
namespace Contactos
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lnkSendEmail = new System.Windows.Forms.LinkLabel();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.lblAddressNumber = new System.Windows.Forms.Label();
            this.Label11 = new System.Windows.Forms.Label();
            this.Label10 = new System.Windows.Forms.Label();
            this.Label9 = new System.Windows.Forms.Label();
            this.Label8 = new System.Windows.Forms.Label();
            this.Label7 = new System.Windows.Forms.Label();
            this.Label6 = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtCountry = new System.Windows.Forms.TextBox();
            this.txtPostalCode = new System.Windows.Forms.TextBox();
            this.txtRegion = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtAddress2 = new System.Windows.Forms.TextBox();
            this.txtAddress1 = new System.Windows.Forms.TextBox();
            this.txtCompanyName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // lnkSendEmail
            // 
            this.lnkSendEmail.AutoSize = true;
            this.lnkSendEmail.Location = new System.Drawing.Point(84, 339);
            this.lnkSendEmail.Name = "lnkSendEmail";
            this.lnkSendEmail.Size = new System.Drawing.Size(60, 13);
            this.lnkSendEmail.TabIndex = 84;
            this.lnkSendEmail.TabStop = true;
            this.lnkSendEmail.Text = "Send Email";
            this.lnkSendEmail.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkSendEmail_LinkClicked);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(227, 334);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 83;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(335, 334);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(75, 23);
            this.btnLoad.TabIndex = 82;
            this.btnLoad.Text = "&Load";
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // lblAddressNumber
            // 
            this.lblAddressNumber.AutoSize = true;
            this.lblAddressNumber.Location = new System.Drawing.Point(174, 27);
            this.lblAddressNumber.Name = "lblAddressNumber";
            this.lblAddressNumber.Size = new System.Drawing.Size(50, 13);
            this.lblAddressNumber.TabIndex = 81;
            this.lblAddressNumber.Text = "(Number)";
            // 
            // Label11
            // 
            this.Label11.AutoSize = true;
            this.Label11.Location = new System.Drawing.Point(84, 290);
            this.Label11.Name = "Label11";
            this.Label11.Size = new System.Drawing.Size(35, 13);
            this.Label11.TabIndex = 80;
            this.Label11.Text = "Email:";
            // 
            // Label10
            // 
            this.Label10.AutoSize = true;
            this.Label10.Location = new System.Drawing.Point(84, 264);
            this.Label10.Name = "Label10";
            this.Label10.Size = new System.Drawing.Size(30, 13);
            this.Label10.TabIndex = 79;
            this.Label10.Text = "Pais:";
            // 
            // Label9
            // 
            this.Label9.AutoSize = true;
            this.Label9.Location = new System.Drawing.Point(84, 238);
            this.Label9.Name = "Label9";
            this.Label9.Size = new System.Drawing.Size(75, 13);
            this.Label9.TabIndex = 78;
            this.Label9.Text = "Codigo Postal:";
            // 
            // Label8
            // 
            this.Label8.AutoSize = true;
            this.Label8.Location = new System.Drawing.Point(84, 212);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(44, 13);
            this.Label8.TabIndex = 77;
            this.Label8.Text = "Región:";
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.Location = new System.Drawing.Point(84, 186);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(43, 13);
            this.Label7.TabIndex = 76;
            this.Label7.Text = "Ciudad:";
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Location = new System.Drawing.Point(84, 160);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(64, 13);
            this.Label6.TabIndex = 75;
            this.Label6.Text = "Dirección 2:";
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Location = new System.Drawing.Point(84, 134);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(64, 13);
            this.Label5.TabIndex = 74;
            this.Label5.Text = "Dirección 1:";
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Location = new System.Drawing.Point(84, 108);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(57, 13);
            this.Label4.TabIndex = 73;
            this.Label4.Text = "Compania ";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(84, 82);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(47, 13);
            this.Label3.TabIndex = 72;
            this.Label3.Text = "Apellido:";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(84, 56);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(47, 13);
            this.Label2.TabIndex = 71;
            this.Label2.Text = "Nombre:";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(84, 27);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(53, 13);
            this.Label1.TabIndex = 70;
            this.Label1.Text = "Contacto:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(175, 290);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(257, 20);
            this.txtEmail.TabIndex = 69;
            // 
            // txtCountry
            // 
            this.txtCountry.Location = new System.Drawing.Point(175, 264);
            this.txtCountry.Name = "txtCountry";
            this.txtCountry.Size = new System.Drawing.Size(127, 20);
            this.txtCountry.TabIndex = 68;
            // 
            // txtPostalCode
            // 
            this.txtPostalCode.Location = new System.Drawing.Point(175, 238);
            this.txtPostalCode.Name = "txtPostalCode";
            this.txtPostalCode.Size = new System.Drawing.Size(127, 20);
            this.txtPostalCode.TabIndex = 67;
            // 
            // txtRegion
            // 
            this.txtRegion.Location = new System.Drawing.Point(175, 212);
            this.txtRegion.Name = "txtRegion";
            this.txtRegion.Size = new System.Drawing.Size(127, 20);
            this.txtRegion.TabIndex = 66;
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(175, 186);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(127, 20);
            this.txtCity.TabIndex = 65;
            // 
            // txtAddress2
            // 
            this.txtAddress2.Location = new System.Drawing.Point(175, 160);
            this.txtAddress2.Name = "txtAddress2";
            this.txtAddress2.Size = new System.Drawing.Size(257, 20);
            this.txtAddress2.TabIndex = 64;
            // 
            // txtAddress1
            // 
            this.txtAddress1.Location = new System.Drawing.Point(175, 134);
            this.txtAddress1.Name = "txtAddress1";
            this.txtAddress1.Size = new System.Drawing.Size(257, 20);
            this.txtAddress1.TabIndex = 63;
            // 
            // txtCompanyName
            // 
            this.txtCompanyName.Location = new System.Drawing.Point(175, 108);
            this.txtCompanyName.Name = "txtCompanyName";
            this.txtCompanyName.Size = new System.Drawing.Size(257, 20);
            this.txtCompanyName.TabIndex = 62;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(175, 82);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(257, 20);
            this.txtLastName.TabIndex = 61;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(175, 56);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(257, 20);
            this.txtFirstName.TabIndex = 60;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(70, 23);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(376, 305);
            this.panel1.TabIndex = 85;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 450);
            this.Controls.Add(this.lnkSendEmail);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.lblAddressNumber);
            this.Controls.Add(this.Label11);
            this.Controls.Add(this.Label10);
            this.Controls.Add(this.Label9);
            this.Controls.Add(this.Label8);
            this.Controls.Add(this.Label7);
            this.Controls.Add(this.Label6);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtCountry);
            this.Controls.Add(this.txtPostalCode);
            this.Controls.Add(this.txtRegion);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.txtAddress2);
            this.Controls.Add(this.txtAddress1);
            this.Controls.Add(this.txtCompanyName);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Contactos";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        internal System.Windows.Forms.LinkLabel lnkSendEmail;
        internal System.Windows.Forms.Button btnSave;
        internal System.Windows.Forms.Button btnLoad;
        internal System.Windows.Forms.Label lblAddressNumber;
        internal System.Windows.Forms.Label Label11;
        internal System.Windows.Forms.Label Label10;
        internal System.Windows.Forms.Label Label9;
        internal System.Windows.Forms.Label Label8;
        internal System.Windows.Forms.Label Label7;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.TextBox txtEmail;
        internal System.Windows.Forms.TextBox txtCountry;
        internal System.Windows.Forms.TextBox txtPostalCode;
        internal System.Windows.Forms.TextBox txtRegion;
        internal System.Windows.Forms.TextBox txtCity;
        internal System.Windows.Forms.TextBox txtAddress2;
        internal System.Windows.Forms.TextBox txtAddress1;
        internal System.Windows.Forms.TextBox txtCompanyName;
        internal System.Windows.Forms.TextBox txtLastName;
        internal System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Panel panel1;
    }
}

