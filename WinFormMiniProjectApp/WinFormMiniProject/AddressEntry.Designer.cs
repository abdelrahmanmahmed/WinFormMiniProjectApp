
namespace WinFormMiniProject
{
    partial class AddressEntry
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
            this.cityText = new System.Windows.Forms.TextBox();
            this.streetAddressText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.stateText = new System.Windows.Forms.TextBox();
            this.zipCodeText = new System.Windows.Forms.TextBox();
            this.saveAddressEntry = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cityText
            // 
            this.cityText.Location = new System.Drawing.Point(207, 127);
            this.cityText.Name = "cityText";
            this.cityText.Size = new System.Drawing.Size(208, 35);
            this.cityText.TabIndex = 2;
            // 
            // streetAddressText
            // 
            this.streetAddressText.Location = new System.Drawing.Point(207, 74);
            this.streetAddressText.Name = "streetAddressText";
            this.streetAddressText.Size = new System.Drawing.Size(208, 35);
            this.streetAddressText.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(148, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 29);
            this.label2.TabIndex = 9;
            this.label2.Text = "City";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 29);
            this.label1.TabIndex = 8;
            this.label1.Text = "Street Address";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(133, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 29);
            this.label3.TabIndex = 8;
            this.label3.Text = "State";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(89, 244);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 29);
            this.label4.TabIndex = 9;
            this.label4.Text = "Zip Code";
            // 
            // stateText
            // 
            this.stateText.Location = new System.Drawing.Point(207, 188);
            this.stateText.Name = "stateText";
            this.stateText.Size = new System.Drawing.Size(208, 35);
            this.stateText.TabIndex = 3;
            // 
            // zipCodeText
            // 
            this.zipCodeText.Location = new System.Drawing.Point(207, 241);
            this.zipCodeText.Name = "zipCodeText";
            this.zipCodeText.Size = new System.Drawing.Size(208, 35);
            this.zipCodeText.TabIndex = 4;
            // 
            // saveAddressEntry
            // 
            this.saveAddressEntry.Location = new System.Drawing.Point(186, 299);
            this.saveAddressEntry.Name = "saveAddressEntry";
            this.saveAddressEntry.Size = new System.Drawing.Size(76, 40);
            this.saveAddressEntry.TabIndex = 5;
            this.saveAddressEntry.Text = "Save";
            this.saveAddressEntry.UseVisualStyleBackColor = true;
            this.saveAddressEntry.Click += new System.EventHandler(this.saveAddressEntry_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(133, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(162, 29);
            this.label5.TabIndex = 10;
            this.label5.Text = "Address Entry";
            // 
            // AddressEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(468, 351);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.saveAddressEntry);
            this.Controls.Add(this.zipCodeText);
            this.Controls.Add(this.stateText);
            this.Controls.Add(this.cityText);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.streetAddressText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(7);
            this.Name = "AddressEntry";
            this.Text = "Address Entry Form by Abdo Ahmed";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox cityText;
        private System.Windows.Forms.TextBox streetAddressText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox stateText;
        private System.Windows.Forms.TextBox zipCodeText;
        private System.Windows.Forms.Button saveAddressEntry;
        private System.Windows.Forms.Label label5;
    }
}