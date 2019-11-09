using System;
using System.Collections.Generic;
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
        public struct Member
        {
            public String name;
            public double balance;
        }
        public Form1()
        {
            InitializeComponent();
        }

        
        List<Member> memberStart = new List<Member>();
        List<Member> memberRound = new List<Member>();
        List<Member> memberPay = new List<Member>();

       

        private void BtnAddBigTeam_Click(object sender, EventArgs e)
        {
            foreach(Member m in memberStart)
            {
                listMembers.Items.Add(m.name);
            }
     
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for(int i=0; i< 10; i++)
            {               
                Member what = new Member();
                what.name = i.ToString();
                what.balance = 0;
                memberStart.Add(what);
            }
        }

        private void BtnAddMember_Click(object sender, EventArgs e)
        {
            if (txtAddMember != null) //wtf 
            {
                Member toAdd = new Member();
                toAdd.name = txtAddMember.Text;
                toAdd.balance = 0;
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
                if(memberStart[i].name == toRemove && memberStart[i].balance == 0)
                {
                    memberStart.RemoveAt(i);
                    listMembers.Items.RemoveAt(i);
                }
            }
        }

        private void B_Click(object sender, EventArgs e)
        {
            listMembers.Items.RemoveAt(listMembers.SelectedIndex);
        }
    }
}
