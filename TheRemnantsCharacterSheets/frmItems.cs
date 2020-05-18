using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Xceed.Document.NET;
using Xceed.Words.NET;

namespace TheRemnantsCharacterSheets
{
    public partial class frmItems : Form
    {
        public frmItems()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Character.Oasis = Convert.ToInt32(txtOasis.Text);
            Character.ItemCount += Character.Oasis > 0 ? 1 : 0;
            Character.Monster = Convert.ToInt32(txtMonster.Text);
            Character.ItemCount += Character.Monster > 0 ? 1 : 0;
            Character.Doritos = Convert.ToInt32(txtDoritos.Text);
            Character.ItemCount += Character.Doritos > 0 ? 1 : 0;
            Character.Coke = Convert.ToInt32(txtCoke.Text);
            Character.ItemCount += Character.Coke > 0 ? 1 : 0;
            Character.ColaOriginal = Convert.ToInt32(txtCokeOriginal.Text);
            Character.ItemCount += Character.ColaOriginal > 0 ? 1 : 0;
            Character.Crawford = Convert.ToInt32(txtCrawford.Text);
            Character.ItemCount += Character.Crawford > 0 ? 1 : 0;
            Character.HotDog = Convert.ToInt32(txtHotDog.Text);
            Character.ItemCount += Character.HotDog > 0 ? 1 : 0;
            Character.Brownie = Convert.ToInt32(txtBrownie.Text);
            Character.ItemCount += Character.Brownie > 0 ? 1 : 0;
            Character.WhitePotion = Convert.ToInt32(txtWhitePotion.Text);
            Character.ItemCount += Character.WhitePotion > 0 ? 1 : 0;
            Character.YellowPotion = Convert.ToInt32(txtYellowPotion.Text);
            Character.ItemCount += Character.YellowPotion > 0 ? 1 : 0;
            Character.Maltesers = Convert.ToInt32(txtMaltesers.Text);
            Character.ItemCount += Character.Maltesers > 0 ? 1 : 0;
            Character.RedPotion = Convert.ToInt32(txtRedPotion.Text);
            Character.ItemCount += Character.RedPotion > 0 ? 1 : 0;
            Character.GreenPotion = Convert.ToInt32(txtGreenPotion.Text);
            Character.ItemCount += Character.GreenPotion > 0 ? 1 : 0;
            Character.MauvePotion = Convert.ToInt32(txtMauvePotion.Text);
            Character.ItemCount += Character.MauvePotion > 0 ? 1 : 0;
            Character.DairyMilk = Convert.ToInt32(txtDairyMilk.Text);
            Character.ItemCount += Character.DairyMilk > 0 ? 1 : 0;
            Character.Gfuel = Convert.ToInt32(txtGfuel.Text);
            Character.ItemCount += Character.Gfuel > 0 ? 1 : 0;
            Character.Coffee = Convert.ToInt32(txtKawa.Text);
            Character.ItemCount += Character.Coffee > 0 ? 1 : 0;
            Character.Dobrowianka = Convert.ToInt32(txtDobrowianka.Text);
            Character.ItemCount += Character.Dobrowianka > 0 ? 1 : 0;
            Character.MtnDew = Convert.ToInt32(txtMtnDew.Text);
            Character.ItemCount += Character.MtnDew > 0 ? 1 : 0;
            Character.DrPepper = Convert.ToInt32(txtDrPepper.Text);
            Character.ItemCount += Character.DrPepper > 0 ? 1 : 0;
            Character.HoolaHoops = Convert.ToInt32(txtHopaHoops.Text);
            Character.ItemCount += Character.HoolaHoops > 0 ? 1 : 0;
            Character.BarrCreamSoda = Convert.ToInt32(txtCreamSoda.Text);
            Character.ItemCount += Character.BarrCreamSoda > 0 ? 1 : 0;
            Character.StrSeed = Convert.ToInt32(txtStrSeed.Text);
            Character.ItemCount += Character.StrSeed > 0 ? 1 : 0;
            Character.AgiSeed = Convert.ToInt32(txtAgiSeed.Text);
            Character.ItemCount += Character.AgiSeed > 0 ? 1 : 0;
            Character.AppSeed = Convert.ToInt32(txtAppSeed.Text);
            Character.ItemCount += Character.AppSeed > 0 ? 1 : 0;
            Character.ResSeed = Convert.ToInt32(txtDefSeed.Text);
            Character.ItemCount += Character.ResSeed > 0 ? 1 : 0;
            Character.SpdSeed = Convert.ToInt32(txtSpdSeed.Text);
            Character.ItemCount += Character.SpdSeed > 0 ? 1 : 0;
            Character.HpSeed = Convert.ToInt32(txtHPSeed.Text);
            Character.ItemCount += Character.HpSeed > 0 ? 1 : 0;

            frmGenerate finalStep = new frmGenerate();
            finalStep.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
