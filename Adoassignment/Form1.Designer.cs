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
            this.btnAddMemberToRound = new System.Windows.Forms.Button();
            this.btnBuyRound = new System.Windows.Forms.Button();
            this.btnRemoveMemberFromRound = new System.Windows.Forms.Button();
            this.listMembers = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtAddMember = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.listRoundInfo = new System.Windows.Forms.ListBox();
            this.listBalanceInfo = new System.Windows.Forms.ListBox();
            this.boxBuyer = new System.Windows.Forms.ComboBox();
            this.BtnBuyRound1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAddBigTeam
            // 
            this.btnAddBigTeam.Location = new System.Drawing.Point(8, 30);
            this.btnAddBigTeam.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddBigTeam.Name = "btnAddBigTeam";
            this.btnAddBigTeam.Size = new System.Drawing.Size(76, 91);
            this.btnAddBigTeam.TabIndex = 0;
            this.btnAddBigTeam.Text = "Add default team";
            this.btnAddBigTeam.UseVisualStyleBackColor = true;
            this.btnAddBigTeam.Click += new System.EventHandler(this.BtnAddBigTeam_Click);
            // 
            // b
            // 
            this.b.Location = new System.Drawing.Point(0, 222);
            this.b.Margin = new System.Windows.Forms.Padding(4);
            this.b.Name = "b";
            this.b.Size = new System.Drawing.Size(82, 90);
            this.b.TabIndex = 1;
            this.b.Text = "Remove selected team member";
            this.b.UseVisualStyleBackColor = true;
            // 
            // btnAddMember
            // 
            this.btnAddMember.Location = new System.Drawing.Point(117, 225);
            this.btnAddMember.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddMember.Name = "btnAddMember";
            this.btnAddMember.Size = new System.Drawing.Size(66, 84);
            this.btnAddMember.TabIndex = 2;
            this.btnAddMember.Text = "Add team member";
            this.btnAddMember.UseVisualStyleBackColor = true;
            this.btnAddMember.Click += new System.EventHandler(this.BtnAddMember_Click);
            // 
            // btnRemoveM
            // 
            this.btnRemoveM.Location = new System.Drawing.Point(213, 222);
            this.btnRemoveM.Margin = new System.Windows.Forms.Padding(4);
            this.btnRemoveM.Name = "btnRemoveM";
            this.btnRemoveM.Size = new System.Drawing.Size(77, 86);
            this.btnRemoveM.TabIndex = 3;
            this.btnRemoveM.Text = "Remove team member";
            this.btnRemoveM.UseVisualStyleBackColor = true;
            this.btnRemoveM.Click += new System.EventHandler(this.BtnRemoveM_Click);
            // 
            // btnAddMemberToRound
            // 
            this.btnAddMemberToRound.Location = new System.Drawing.Point(365, 31);
            this.btnAddMemberToRound.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddMemberToRound.Name = "btnAddMemberToRound";
            this.btnAddMemberToRound.Size = new System.Drawing.Size(28, 60);
            this.btnAddMemberToRound.TabIndex = 4;
            this.btnAddMemberToRound.Text = ">>";
            this.btnAddMemberToRound.UseVisualStyleBackColor = true;
            this.btnAddMemberToRound.Click += new System.EventHandler(this.BtnAddMemberToRound_Click);
            // 
            // btnBuyRound
            // 
            this.btnBuyRound.Location = new System.Drawing.Point(475, 75);
            this.btnBuyRound.Name = "btnBuyRound";
            this.btnBuyRound.Size = new System.Drawing.Size(45, 82);
            this.btnBuyRound.TabIndex = 6;
            this.btnBuyRound.Text = "Buy a round!";
            this.btnBuyRound.UseVisualStyleBackColor = true;
            // 
            // btnRemoveMemberFromRound
            // 
            this.btnRemoveMemberFromRound.Location = new System.Drawing.Point(365, 117);
            this.btnRemoveMemberFromRound.Margin = new System.Windows.Forms.Padding(4);
            this.btnRemoveMemberFromRound.Name = "btnRemoveMemberFromRound";
            this.btnRemoveMemberFromRound.Size = new System.Drawing.Size(37, 76);
            this.btnRemoveMemberFromRound.TabIndex = 5;
            this.btnRemoveMemberFromRound.Text = "<<";
            this.btnRemoveMemberFromRound.UseVisualStyleBackColor = true;
            this.btnRemoveMemberFromRound.Click += new System.EventHandler(this.BtnRemoveMemberFromRound_Click);
            // 
            // listMembers
            // 
            this.listMembers.FormattingEnabled = true;
            this.listMembers.Location = new System.Drawing.Point(141, 30);
            this.listMembers.Margin = new System.Windows.Forms.Padding(4);
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
            this.groupBox1.Location = new System.Drawing.Point(16, 4);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(341, 427);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Team members";
            // 
            // txtAddMember
            // 
            this.txtAddMember.Location = new System.Drawing.Point(91, 344);
            this.txtAddMember.Margin = new System.Windows.Forms.Padding(4);
            this.txtAddMember.Name = "txtAddMember";
            this.txtAddMember.Size = new System.Drawing.Size(100, 20);
            this.txtAddMember.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 347);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Team member";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(363, 262);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Round buyer";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(367, 303);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Round price";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(437, 303);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(4);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(100, 20);
            this.txtPrice.TabIndex = 12;
            // 
            // listRoundInfo
            // 
            this.listRoundInfo.FormattingEnabled = true;
            this.listRoundInfo.Location = new System.Drawing.Point(410, 28);
            this.listRoundInfo.Margin = new System.Windows.Forms.Padding(4);
            this.listRoundInfo.Name = "listRoundInfo";
            this.listRoundInfo.Size = new System.Drawing.Size(148, 134);
            this.listRoundInfo.TabIndex = 13;
            // 
            // listBalanceInfo
            // 
            this.listBalanceInfo.FormattingEnabled = true;
            this.listBalanceInfo.Location = new System.Drawing.Point(660, 28);
            this.listBalanceInfo.Margin = new System.Windows.Forms.Padding(4);
            this.listBalanceInfo.Name = "listBalanceInfo";
            this.listBalanceInfo.Size = new System.Drawing.Size(174, 225);
            this.listBalanceInfo.TabIndex = 14;
            // 
            // boxBuyer
            // 
            this.boxBuyer.FormattingEnabled = true;
            this.boxBuyer.Location = new System.Drawing.Point(437, 260);
            this.boxBuyer.Name = "boxBuyer";
            this.boxBuyer.Size = new System.Drawing.Size(121, 21);
            this.boxBuyer.TabIndex = 15;
            // 
            // BtnBuyRound1
            // 
            this.BtnBuyRound1.Location = new System.Drawing.Point(562, 214);
            this.BtnBuyRound1.Name = "BtnBuyRound1";
            this.BtnBuyRound1.Size = new System.Drawing.Size(75, 23);
            this.BtnBuyRound1.TabIndex = 16;
            this.BtnBuyRound1.Text = "button1";
            this.BtnBuyRound1.UseVisualStyleBackColor = true;
            this.BtnBuyRound1.Click += new System.EventHandler(this.BtnBuyRound1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnBuyRound1);
            this.Controls.Add(this.boxBuyer);
            this.Controls.Add(this.listBalanceInfo);
            this.Controls.Add(this.listRoundInfo);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnBuyRound);
            this.Controls.Add(this.btnRemoveMemberFromRound);
            this.Controls.Add(this.btnAddMemberToRound);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
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
        private System.Windows.Forms.Button btnAddMemberToRound;
        private System.Windows.Forms.Button btnBuyRound;
        private System.Windows.Forms.Button btnRemoveMemberFromRound;
        private System.Windows.Forms.ListBox listMembers;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtAddMember;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.ListBox listRoundInfo;
        private System.Windows.Forms.ListBox listBalanceInfo;
        private System.Windows.Forms.ComboBox boxBuyer;
        private System.Windows.Forms.Button BtnBuyRound1;
    }
}

