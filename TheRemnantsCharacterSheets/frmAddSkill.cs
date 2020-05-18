using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheRemnantsCharacterSheets
{
    public partial class frmAddSkill : Form
    {
        public frmAddSkill()
        {
            InitializeComponent();
            UpdateSkillList();
        }

        public void UpdateSkillList()
        {
            if (Character.Skills.Count == 0) lblSkillsAdded.Text = "Nie dodano jeszcze żadnych umiejętności!";
            else
            {
                lblSkillsAdded.Text = "";
                foreach (Skill skill in Character.Skills)
                {
                    lblSkillsAdded.Text += skill.Name + " - " + skill.Description + " (" + skill.Priority + ")";
                    lblSkillsAdded.Text += Environment.NewLine;
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Skill aSkill = new Skill();

            aSkill.Name = txtName.Text;
            aSkill.Description = txtDescription.Text;
            aSkill.Priority = Convert.ToInt32(txtPriority.Text);

            Character.Skills.Add(aSkill);

            txtName.Clear();
            txtDescription.Clear();
            txtPriority.Clear();

            UpdateSkillList();
        }

        private void btnFinish_Click(object sender, EventArgs e)
        {
            frmAddEquipment allEquipment = new frmAddEquipment();
            allEquipment.Show();
            this.Hide();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Character.Skills = new List<Skill>();
            UpdateSkillList();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
