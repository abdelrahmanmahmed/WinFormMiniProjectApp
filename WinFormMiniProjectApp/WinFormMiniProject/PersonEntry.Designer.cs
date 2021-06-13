
namespace WinFormMiniProject
{
    partial class PersonEntry
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.addressesList = new System.Windows.Forms.ListBox();
            this.firstNameText = new System.Windows.Forms.TextBox();
            this.lastNameText = new System.Windows.Forms.TextBox();
            this.addNewAddress = new System.Windows.Forms.Button();
            this.saveRecord = new System.Windows.Forms.Button();
            this.isActive = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Last Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(99, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "Active";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 29);
            this.label4.TabIndex = 3;
            this.label4.Text = "Addresses";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // addressesList
            // 
            this.addressesList.FormattingEnabled = true;
            this.addressesList.ItemHeight = 29;
            this.addressesList.Location = new System.Drawing.Point(50, 238);
            this.addressesList.Name = "addressesList";
            this.addressesList.Size = new System.Drawing.Size(340, 236);
            this.addressesList.TabIndex = 5;
            // 
            // firstNameText
            // 
            this.firstNameText.Location = new System.Drawing.Point(182, 36);
            this.firstNameText.Name = "firstNameText";
            this.firstNameText.Size = new System.Drawing.Size(208, 35);
            this.firstNameText.TabIndex = 6;
            // 
            // lastNameText
            // 
            this.lastNameText.Location = new System.Drawing.Point(182, 89);
            this.lastNameText.Name = "lastNameText";
            this.lastNameText.Size = new System.Drawing.Size(208, 35);
            this.lastNameText.TabIndex = 7;
            // 
            // addNewAddress
            // 
            this.addNewAddress.Location = new System.Drawing.Point(320, 196);
            this.addNewAddress.Name = "addNewAddress";
            this.addNewAddress.Size = new System.Drawing.Size(70, 36);
            this.addNewAddress.TabIndex = 8;
            this.addNewAddress.Text = "Add";
            this.addNewAddress.UseVisualStyleBackColor = true;
            this.addNewAddress.Click += new System.EventHandler(this.addNewAddress_Click);
            // 
            // saveRecord
            // 
            this.saveRecord.Location = new System.Drawing.Point(182, 507);
            this.saveRecord.Name = "saveRecord";
            this.saveRecord.Size = new System.Drawing.Size(78, 36);
            this.saveRecord.TabIndex = 9;
            this.saveRecord.Text = "Save";
            this.saveRecord.UseVisualStyleBackColor = true;
            this.saveRecord.Click += new System.EventHandler(this.saveRecord_Click);
            // 
            // isActive
            // 
            this.isActive.AutoSize = true;
            this.isActive.Location = new System.Drawing.Point(182, 156);
            this.isActive.Name = "isActive";
            this.isActive.Size = new System.Drawing.Size(15, 14);
            this.isActive.TabIndex = 4;
            this.isActive.UseVisualStyleBackColor = true;
            // 
            // PersonEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(462, 555);
            this.Controls.Add(this.saveRecord);
            this.Controls.Add(this.addNewAddress);
            this.Controls.Add(this.lastNameText);
            this.Controls.Add(this.firstNameText);
            this.Controls.Add(this.addressesList);
            this.Controls.Add(this.isActive);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(7);
            this.Name = "PersonEntry";
            this.Text = "Person Entry Form by Abdo Ahmed";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox addressesList;
        private System.Windows.Forms.TextBox firstNameText;
        private System.Windows.Forms.TextBox lastNameText;
        private System.Windows.Forms.Button addNewAddress;
        private System.Windows.Forms.Button saveRecord;
        private System.Windows.Forms.CheckBox isActive;
    }
}

