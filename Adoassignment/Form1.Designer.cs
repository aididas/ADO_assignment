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
            this.button7 = new System.Windows.Forms.Button();
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
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAddBigTeam
            // 
            this.btnAddBigTeam.Location = new System.Drawing.Point(11, 37);
            this.btnAddBigTeam.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnAddBigTeam.Name = "btnAddBigTeam";
            this.btnAddBigTeam.Size = new System.Drawing.Size(101, 112);
            this.btnAddBigTeam.TabIndex = 0;
            this.btnAddBigTeam.Text = "Add default team";
            this.btnAddBigTeam.UseVisualStyleBackColor = true;
            this.btnAddBigTeam.Click += new System.EventHandler(this.BtnAddBigTeam_Click);
            // 
            // b
            // 
            this.b.Location = new System.Drawing.Point(0, 273);
            this.b.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.b.Name = "b";
            this.b.Size = new System.Drawing.Size(109, 111);
            this.b.TabIndex = 1;
            this.b.Text = "Remove selected team member";
            this.b.UseVisualStyleBackColor = true;
            // 
            // btnAddMember
            // 
            this.btnAddMember.Location = new System.Drawing.Point(156, 277);
            this.btnAddMember.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnAddMember.Name = "btnAddMember";
            this.btnAddMember.Size = new System.Drawing.Size(88, 103);
            this.btnAddMember.TabIndex = 2;
            this.btnAddMember.Text = "Add team member";
            this.btnAddMember.UseVisualStyleBackColor = true;
            this.btnAddMember.Click += new System.EventHandler(this.BtnAddMember_Click);
            // 
            // btnRemoveM
            // 
            this.btnRemoveM.Location = new System.Drawing.Point(284, 273);
            this.btnRemoveM.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnRemoveM.Name = "btnRemoveM";
            this.btnRemoveM.Size = new System.Drawing.Size(103, 106);
            this.btnRemoveM.TabIndex = 3;
            this.btnRemoveM.Text = "Remove team member";
            this.btnRemoveM.UseVisualStyleBackColor = true;
            this.btnRemoveM.Click += new System.EventHandler(this.BtnRemoveM_Click);
            // 
            // btnAddMemberToRound
            // 
            this.btnAddMemberToRound.Location = new System.Drawing.Point(487, 38);
            this.btnAddMemberToRound.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnAddMemberToRound.Name = "btnAddMemberToRound";
            this.btnAddMemberToRound.Size = new System.Drawing.Size(37, 74);
            this.btnAddMemberToRound.TabIndex = 4;
            this.btnAddMemberToRound.Text = ">>";
            this.btnAddMemberToRound.UseVisualStyleBackColor = true;
            this.btnAddMemberToRound.Click += new System.EventHandler(this.BtnAddMemberToRound_Click);
            // 
            // btnBuyRound
            // 
            this.btnBuyRound.Location = new System.Drawing.Point(633, 92);
            this.btnBuyRound.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBuyRound.Name = "btnBuyRound";
            this.btnBuyRound.Size = new System.Drawing.Size(60, 101);
            this.btnBuyRound.TabIndex = 6;
            this.btnBuyRound.Text = "Buy a round!";
            this.btnBuyRound.UseVisualStyleBackColor = true;
            this.btnBuyRound.Click += new System.EventHandler(this.BtnBuyRound_Click);
            // 
            // btnRemoveMemberFromRound
            // 
            this.btnRemoveMemberFromRound.Location = new System.Drawing.Point(487, 144);
            this.btnRemoveMemberFromRound.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnRemoveMemberFromRound.Name = "btnRemoveMemberFromRound";
            this.btnRemoveMemberFromRound.Size = new System.Drawing.Size(49, 94);
            this.btnRemoveMemberFromRound.TabIndex = 5;
            this.btnRemoveMemberFromRound.Text = "<<";
            this.btnRemoveMemberFromRound.UseVisualStyleBackColor = true;
            this.btnRemoveMemberFromRound.Click += new System.EventHandler(this.BtnRemoveMemberFromRound_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(844, 113);
            this.button7.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(80, 124);
            this.button7.TabIndex = 6;
            this.button7.Text = "Buy a round!";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // listMembers
            // 
            this.listMembers.FormattingEnabled = true;
            this.listMembers.ItemHeight = 16;
            this.listMembers.Location = new System.Drawing.Point(188, 37);
            this.listMembers.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.listMembers.Name = "listMembers";
            this.listMembers.Size = new System.Drawing.Size(137, 148);
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
            this.groupBox1.Location = new System.Drawing.Point(21, 5);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.groupBox1.Size = new System.Drawing.Size(455, 526);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Team members";
            // 
            // txtAddMember
            // 
            this.txtAddMember.Location = new System.Drawing.Point(121, 424);
            this.txtAddMember.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtAddMember.Name = "txtAddMember";
            this.txtAddMember.Size = new System.Drawing.Size(132, 22);
            this.txtAddMember.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 427);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Team member";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(484, 323);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Round buyer";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(489, 373);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Round price";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(583, 373);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(132, 22);
            this.txtPrice.TabIndex = 12;
            // 
            // listRoundInfo
            // 
            this.listRoundInfo.FormattingEnabled = true;
            this.listRoundInfo.ItemHeight = 16;
            this.listRoundInfo.Location = new System.Drawing.Point(547, 34);
            this.listRoundInfo.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.listRoundInfo.Name = "listRoundInfo";
            this.listRoundInfo.Size = new System.Drawing.Size(196, 164);
            this.listRoundInfo.TabIndex = 13;
            // 
            // listBalanceInfo
            // 
            this.listBalanceInfo.FormattingEnabled = true;
            this.listBalanceInfo.ItemHeight = 16;
            this.listBalanceInfo.Location = new System.Drawing.Point(935, 41);
            this.listBalanceInfo.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.listBalanceInfo.Name = "listBalanceInfo";
            this.listBalanceInfo.Size = new System.Drawing.Size(231, 276);
            this.listBalanceInfo.TabIndex = 14;
            // 
            // boxBuyer
            // 
            this.boxBuyer.FormattingEnabled = true;
            this.boxBuyer.Location = new System.Drawing.Point(583, 320);
            this.boxBuyer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.boxBuyer.Name = "boxBuyer";
            this.boxBuyer.Size = new System.Drawing.Size(160, 24);
            this.boxBuyer.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.boxBuyer);
            this.Controls.Add(this.listBalanceInfo);
            this.Controls.Add(this.listRoundInfo);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnBuyRound);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.btnRemoveMemberFromRound);
            this.Controls.Add(this.btnAddMemberToRound);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
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
        private System.Windows.Forms.Button button7;
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
    }
}

