namespace Bank
{
    partial class EditClientForm
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
            this.search = new System.Windows.Forms.Button();
            this.searchCNP = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.firstName = new System.Windows.Forms.TextBox();
            this.CNP = new System.Windows.Forms.TextBox();
            this.ICN = new System.Windows.Forms.TextBox();
            this.address = new System.Windows.Forms.TextBox();
            this.lastName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.sdfg = new System.Windows.Forms.Label();
            this.vns = new System.Windows.Forms.Label();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // search
            // 
            this.search.Location = new System.Drawing.Point(50, 86);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(75, 23);
            this.search.TabIndex = 1;
            this.search.Text = "Search";
            this.search.UseVisualStyleBackColor = true;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // searchCNP
            // 
            this.searchCNP.Location = new System.Drawing.Point(50, 60);
            this.searchCNP.Name = "searchCNP";
            this.searchCNP.Size = new System.Drawing.Size(100, 20);
            this.searchCNP.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "CNP";
            // 
            // firstName
            // 
            this.firstName.Location = new System.Drawing.Point(246, 114);
            this.firstName.Name = "firstName";
            this.firstName.Size = new System.Drawing.Size(123, 20);
            this.firstName.TabIndex = 4;
            // 
            // CNP
            // 
            this.CNP.Location = new System.Drawing.Point(246, 88);
            this.CNP.Name = "CNP";
            this.CNP.Size = new System.Drawing.Size(123, 20);
            this.CNP.TabIndex = 3;
            // 
            // ICN
            // 
            this.ICN.Location = new System.Drawing.Point(246, 60);
            this.ICN.Name = "ICN";
            this.ICN.Size = new System.Drawing.Size(123, 20);
            this.ICN.TabIndex = 2;
            // 
            // address
            // 
            this.address.Location = new System.Drawing.Point(246, 166);
            this.address.Multiline = true;
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(123, 46);
            this.address.TabIndex = 6;
            // 
            // lastName
            // 
            this.lastName.Location = new System.Drawing.Point(246, 140);
            this.lastName.Name = "lastName";
            this.lastName.Size = new System.Drawing.Size(123, 20);
            this.lastName.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(183, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "First Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(183, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Last Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(195, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Address";
            // 
            // sdfg
            // 
            this.sdfg.AutoSize = true;
            this.sdfg.Location = new System.Drawing.Point(211, 91);
            this.sdfg.Name = "sdfg";
            this.sdfg.Size = new System.Drawing.Size(29, 13);
            this.sdfg.TabIndex = 12;
            this.sdfg.Text = "CNP";
            // 
            // vns
            // 
            this.vns.AutoSize = true;
            this.vns.Location = new System.Drawing.Point(215, 69);
            this.vns.Name = "vns";
            this.vns.Size = new System.Drawing.Size(25, 13);
            this.vns.TabIndex = 13;
            this.vns.Text = "ICN";
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(186, 233);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 7;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(294, 233);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonDelete.TabIndex = 8;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // EditClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 277);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.vns);
            this.Controls.Add(this.sdfg);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lastName);
            this.Controls.Add(this.address);
            this.Controls.Add(this.ICN);
            this.Controls.Add(this.CNP);
            this.Controls.Add(this.firstName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.searchCNP);
            this.Controls.Add(this.search);
            this.Name = "EditClient";
            this.Text = "EditClient";
            this.Load += new System.EventHandler(this.EditClient_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button search;
        private System.Windows.Forms.TextBox searchCNP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox firstName;
        private System.Windows.Forms.TextBox CNP;
        private System.Windows.Forms.TextBox ICN;
        private System.Windows.Forms.TextBox address;
        private System.Windows.Forms.TextBox lastName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label sdfg;
        private System.Windows.Forms.Label vns;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonDelete;
    }
}