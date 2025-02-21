using System.Drawing;

namespace Library_Management_System
{
    partial class AddStudent
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        // Declare UI elements at the class level
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtContact;
        private System.Windows.Forms.TextBox txtEnrollment;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtSex;
        private System.Windows.Forms.TextBox txtNIC;
        private System.Windows.Forms.TextBox txtAddress;

        // Declare missing labels to fix errors
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelContact;
        private System.Windows.Forms.Label labelEnrollment;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelSex;
        private System.Windows.Forms.Label labelNIC;
        private System.Windows.Forms.Label labelAddress;

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddStudent));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtContact = new System.Windows.Forms.TextBox();
            this.txtEnrollment = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtSex = new System.Windows.Forms.TextBox();
            this.txtNIC = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();

            // Initialize Labels
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelContact = new System.Windows.Forms.Label();
            this.labelEnrollment = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelSex = new System.Windows.Forms.Label();
            this.labelNIC = new System.Windows.Forms.Label();
            this.labelAddress = new System.Windows.Forms.Label();

            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();

            // panel1 - Header
            this.panel1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1158, 150);
            this.panel1.TabIndex = 0;

            // label1 - Title
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(500, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Add Student";

            // pictureBox1 - Header Icon
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(520, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 80);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;

            // pictureBox2 - Side Image
            this.pictureBox2.Image =  Image.FromFile("C:\\Users\\MasterG\\Downloads\\Library-Management-System\\Library-Management-System\\addStudent.jpg");
            this.pictureBox2.Location = new System.Drawing.Point(20, 200);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(350, 300);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;

            // panel2 - Form Fields
            this.panel2.BackColor = System.Drawing.Color.LightGray;
            this.panel2.Controls.Add(this.btnExit);
            this.panel2.Controls.Add(this.btnSave);
            this.panel2.Controls.Add(this.btnRefresh);
            this.panel2.Controls.Add(this.txtEmail);
            this.panel2.Controls.Add(this.txtContact);
            this.panel2.Controls.Add(this.txtEnrollment);
            this.panel2.Controls.Add(this.txtName);
            this.panel2.Controls.Add(this.txtSex);
            this.panel2.Controls.Add(this.txtNIC);
            this.panel2.Controls.Add(this.txtAddress);
            this.panel2.Controls.Add(this.labelEmail);
            this.panel2.Controls.Add(this.labelContact);
            this.panel2.Controls.Add(this.labelEnrollment);
            this.panel2.Controls.Add(this.labelName);
            this.panel2.Controls.Add(this.labelSex);
            this.panel2.Controls.Add(this.labelNIC);
            this.panel2.Controls.Add(this.labelAddress);
            this.panel2.Location = new System.Drawing.Point(400, 160);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(720, 550);
            this.panel2.TabIndex = 2;

            // Textbox and Label Layout Adjustments
            int labelWidth = 100;
            int labelHeight = 30;
            int textboxWidth = 200;
            int gap = 30;

            // Name Label and TextBox
            this.labelName.Text = "Name:";
            this.labelName.Location = new System.Drawing.Point(50, 30);
            this.labelName.Size = new System.Drawing.Size(labelWidth, labelHeight);
            this.txtName.Location = new System.Drawing.Point(200, 30);
            this.txtName.Size = new System.Drawing.Size(textboxWidth, 30);

            // Sex Label and TextBox
            this.labelSex.Text = "Sex:";
            this.labelSex.Location = new System.Drawing.Point(50, 70);
            this.labelSex.Size = new System.Drawing.Size(labelWidth, labelHeight);
            this.txtSex.Location = new System.Drawing.Point(200, 70);
            this.txtSex.Size = new System.Drawing.Size(textboxWidth, 30);

            // NIC Label and TextBox
            this.labelNIC.Text = "NIC:";
            this.labelNIC.Location = new System.Drawing.Point(50, 110);
            this.labelNIC.Size = new System.Drawing.Size(labelWidth, labelHeight);
            this.txtNIC.Location = new System.Drawing.Point(200, 110);
            this.txtNIC.Size = new System.Drawing.Size(textboxWidth, 30);

            

            // Enrollment Label and TextBox
            this.labelEnrollment.Text = "User Number:";
            this.labelEnrollment.Location = new System.Drawing.Point(50, 190);
            this.labelEnrollment.Size = new System.Drawing.Size(labelWidth, labelHeight);
            this.txtEnrollment.Location = new System.Drawing.Point(200, 190);
            this.txtEnrollment.Size = new System.Drawing.Size(textboxWidth, 30);

            // Contact Label and TextBox
            this.labelContact.Text = "Contact:";
            this.labelContact.Location = new System.Drawing.Point(50, 230);
            this.labelContact.Size = new System.Drawing.Size(labelWidth, labelHeight);
            this.txtContact.Location = new System.Drawing.Point(200, 230);
            this.txtContact.Size = new System.Drawing.Size(textboxWidth, 30);

            // Email Label and TextBox
            this.labelEmail.Text = "Email:";
            this.labelEmail.Location = new System.Drawing.Point(50, 270);
            this.labelEmail.Size = new System.Drawing.Size(labelWidth, labelHeight);
            this.txtEmail.Location = new System.Drawing.Point(200, 270);
            this.txtEmail.Size = new System.Drawing.Size(textboxWidth, 30);

            // Address Label and TextBox
            this.labelAddress.Text = "Address:";
            this.labelAddress.Location = new System.Drawing.Point(50, 310);
            this.labelAddress.Size = new System.Drawing.Size(labelWidth, labelHeight);
            this.txtAddress.Location = new System.Drawing.Point(200, 310);
            this.txtAddress.Size = new System.Drawing.Size(textboxWidth, 30);

            // Button Layout
            this.btnSave.Text = "Save";
            this.btnSave.Location = new System.Drawing.Point(50, 380);
            this.btnSave.Size = new System.Drawing.Size(100, 40);

            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.Location = new System.Drawing.Point(200, 380);
            this.btnRefresh.Size = new System.Drawing.Size(100, 40);

            this.btnExit.Text = "Exit";
            this.btnExit.Location = new System.Drawing.Point(350, 380);
            this.btnExit.Size = new System.Drawing.Size(100, 40);

            // Form Properties
            this.ClientSize = new System.Drawing.Size(1158, 750);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.panel1);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Student";

            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion
    }
}
