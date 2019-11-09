using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Adoassignment
{
    public partial class Form1 : Form
    {
        BindingList<Member> memberStart = new BindingList<Member>();

        BindingList<Member> memberRound = new BindingList<Member>();
        BindingList<Member> memberPay = new BindingList<Member>();

        public Form1()
        {
            InitializeComponent();
            
        }

        private void BtnAddBigTeam_Click(object sender, EventArgs e)
        {
            memberStart.Add(new Member("Steve"));
            memberStart.Add(new Member("David"));
            memberStart.Add(new Member("John"));

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listMembers.DataSource = memberStart;
            listMembers.DisplayMember = "name";
            boxBuyer.DataSource = memberStart;
            

            listRoundInfo.DataSource = memberRound;
            listRoundInfo.DisplayMember = "name";


        }

        private void BtnAddMember_Click(object sender, EventArgs e)
        {
            if (txtAddMember != null) //wtf 
            {
                Member toAdd = new Member(txtAddMember.Text);
                memberStart.Add(toAdd);
                listMembers.Items.Add(toAdd.name);
            }
            else
                MessageBox.Show("Enter team members name");
        }

        private void BtnRemoveM_Click(object sender, EventArgs e)
        {
            string toRemove = txtAddMember.Text;
            for(int i = memberStart.Count - 1; i >= 0; i--) //foreach(Member m in memberStart)
            {
                //if(m.name == toRemove && m.balance == 0)
                //{
                   // memberStart.Remove(m);
                //}
            }
        }

        private void BtnAddMemberToRound_Click(object sender, EventArgs e)
        {
            var selectedMember = listMembers.SelectedItem as Member;

            if (selectedMember == null)
                MessageBox.Show("Please, select a team member first");
            else
            {
                if(!memberRound.Contains(selectedMember))
                    memberRound.Add(selectedMember);

            }

        }

        private void BtnRemoveMemberFromRound_Click(object sender, EventArgs e)
        {
            var selectedMember = listRoundInfo.SelectedItem as Member;
            memberRound.Remove(selectedMember);
        }

        private void BtnBuyRound_Click(object sender, EventArgs e)
        {
            if (txtBuyer != null && txtPrice != null)
            {
                for (int i = memberStart.Count - 1; i >= 0; i--)
                {
                    memberPay[i] = memberStart[i];
                    if (memberPay[i].name == txtBuyer.Text)
                    {
                        memberPay[i].balance += double.Parse(txtPrice.Text);
                    }
                    foreach (Member m in memberRound)
                    {
                        if (m.name == memberPay[i].name)
                        {
                            memberPay[i].balance -= double.Parse(txtPrice.Text) / memberRound.Count;
                            break;
                        }
                    }

                }
            }
            else
                MessageBox.Show("Fill in the round buyer info");
            

        }
    }
}
