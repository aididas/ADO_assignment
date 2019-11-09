namespace Adoassignment
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
            this.btnAddBigTeam = new System.Windows.Forms.Button();
            this.b = new System.Windows.Forms.Button();
            this.btnAddMember = new System.Windows.Forms.Button();
            this.btnRemoveM = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.listMembers = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAddMember = new System.Windows.Forms.TextBox();
            this.txtBuyer = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.listRoundInfo = new System.Windows.Forms.ListBox();
            this.listBalanceInfo = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAddBigTeam
            // 
            this.btnAddBigTeam.Location = new System.Drawing.Point(6, 24);
            this.btnAddBigTeam.Name = "btnAddBigTeam";
            this.btnAddBigTeam.Size = new System.Drawing.Size(76, 91);
            this.btnAddBigTeam.TabIndex = 0;
            this.btnAddBigTeam.Text = "Add default team";
            this.btnAddBigTeam.UseVisualStyleBackColor = true;
            this.btnAddBigTeam.Click += new System.EventHandler(this.BtnAddBigTeam_Click);
            // 
            // b
            // 
            this.b.Location = new System.Drawing.Point(0, 180);
            this.b.Name = "b";
            this.b.Size = new System.Drawing.Size(82, 90);
            this.b.TabIndex = 1;
            this.b.Text = "Remove selected team member";
            this.b.UseVisualStyleBackColor = true;
            // 
            // btnAddMember
            // 
            this.btnAddMember.Location = new System.Drawing.Point(88, 183);
            this.btnAddMember.Name = "btnAddMember";
            this.btnAddMember.Size = new System.Drawing.Size(66, 84);
            this.btnAddMember.TabIndex = 2;
            this.btnAddMember.Text = "Add team member";
            this.btnAddMember.UseVisualStyleBackColor = true;
            this.btnAddMember.Click += new System.EventHandler(this.BtnAddMember_Click);
            // 
            // btnRemoveM
            // 
            this.btnRemoveM.Location = new System.Drawing.Point(160, 180);
            this.btnRemoveM.Name = "btnRemoveM";
            this.btnRemoveM.Size = new System.Drawing.Size(77, 86);
            this.btnRemoveM.TabIndex = 3;
            this.btnRemoveM.Text = "Remove team member";
            this.btnRemoveM.UseVisualStyleBackColor = true;
            this.btnRemoveM.Click += new System.EventHandler(this.BtnRemoveM_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(274, 25);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(51, 60);
            this.button5.TabIndex = 4;
            this.button5.Text = "button5";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(274, 95);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(51, 62);
            this.button6.TabIndex = 5;
            this.button6.Text = "button6";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(475, 75);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(45, 82);
            this.button7.TabIndex = 6;
            this.button7.Text = "Buy a round!";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // listMembers
            // 
            this.listMembers.FormattingEnabled = true;
            this.listMembers.Location = new System.Drawing.Point(106, 24);
            this.listMembers.Name = "listMembers";
            this.listMembers.Size = new System.Drawing.Size(104, 121);
            this.listMembers.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtAddMember);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.b);
            this.groupBox1.Controls.Add(this.btnAddMember);
            this.groupBox1.Controls.Add(this.btnRemoveM);
            this.groupBox1.Controls.Add(this.listMembers);
            this.groupBox1.Controls.Add(this.btnAddBigTeam);
            this.groupBox1.Location = new System.Drawing.Point(12, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(256, 347);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Team members";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 299);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Team member";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(287, 275);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Round buyer";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(287, 299);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Round price";
            // 
            // txtAddMember
            // 
            this.txtAddMember.Location = new System.Drawing.Point(106, 296);
            this.txtAddMember.Name = "txtAddMember";
            this.txtAddMember.Size = new System.Drawing.Size(100, 20);
            this.txtAddMember.TabIndex = 5;
            // 
            // txtBuyer
            // 
            this.txtBuyer.Location = new System.Drawing.Point(358, 273);
            this.txtBuyer.Name = "txtBuyer";
            this.txtBuyer.Size = new System.Drawing.Size(100, 20);
            this.txtBuyer.TabIndex = 11;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(358, 304);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(100, 20);
            this.txtPrice.TabIndex = 12;
            // 
            // listRoundInfo
            // 
            this.listRoundInfo.FormattingEnabled = true;
            this.listRoundInfo.Location = new System.Drawing.Point(328, 25);
            this.listRoundInfo.Name = "listRoundInfo";
            this.listRoundInfo.Size = new System.Drawing.Size(128, 134);
            this.listRoundInfo.TabIndex = 13;
            // 
            // listBalanceInfo
            // 
            this.listBalanceInfo.FormattingEnabled = true;
            this.listBalanceInfo.Location = new System.Drawing.Point(526, 27);
            this.listBalanceInfo.Name = "listBalanceInfo";
            this.listBalanceInfo.Size = new System.Drawing.Size(174, 225);
            this.listBalanceInfo.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBalanceInfo);
            this.Controls.Add(this.listRoundInfo);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtBuyer);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddBigTeam;
        private System.Windows.Forms.Button b;
        private System.Windows.Forms.Button btnAddMember;
        private System.Windows.Forms.Button btnRemoveM;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.ListBox listMembers;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtAddMember;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBuyer;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.ListBox listRoundInfo;
        private System.Windows.Forms.ListBox listBalanceInfo;
    }
}

