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

            Character.Oasis = int.TryParse(txtOasis.Text, out _) ? Convert.ToInt32(txtOasis.Text) : 0;
            Character.ItemCount += Character.Oasis > 0 ? 1 : 0;
            Character.Monster = int.TryParse(txtMonster.Text, out _) ? Convert.ToInt32(txtMonster.Text) : 0;
            Character.ItemCount += Character.Monster > 0 ? 1 : 0;
            Character.Doritos = int.TryParse(txtDoritos.Text, out _) ? Convert.ToInt32(txtDoritos.Text) : 0;
            Character.ItemCount += Character.Doritos > 0 ? 1 : 0;
            Character.Coke = int.TryParse(txtCoke.Text, out _) ? Convert.ToInt32(txtCoke.Text) : 0;
            Character.ItemCount += Character.Coke > 0 ? 1 : 0;
            Character.ColaOriginal = int.TryParse(txtCokeOriginal.Text, out _) ? Convert.ToInt32(txtCokeOriginal.Text) : 0;
            Character.ItemCount += Character.ColaOriginal > 0 ? 1 : 0;
            Character.Crawford = int.TryParse(txtCrawford.Text, out _) ? Convert.ToInt32(txtCrawford.Text) : 0;
            Character.ItemCount += Character.Crawford > 0 ? 1 : 0;
            Character.HotDog = int.TryParse(txtHotDog.Text, out _) ? Convert.ToInt32(txtHotDog.Text) : 0;
            Character.ItemCount += Character.HotDog > 0 ? 1 : 0;
            Character.Brownie = int.TryParse(txtBrownie.Text, out _) ? Convert.ToInt32(txtBrownie.Text) : 0;
            Character.ItemCount += Character.Brownie > 0 ? 1 : 0;
            Character.WhitePotion = int.TryParse(txtWhitePotion.Text, out _) ? Convert.ToInt32(txtWhitePotion.Text) : 0;
            Character.ItemCount += Character.WhitePotion > 0 ? 1 : 0;
            Character.YellowPotion = int.TryParse(txtYellowPotion.Text, out _) ? Convert.ToInt32(txtYellowPotion.Text) : 0;
            Character.ItemCount += Character.YellowPotion > 0 ? 1 : 0;
            Character.Maltesers = int.TryParse(txtMaltesers.Text, out _) ? Convert.ToInt32(txtMaltesers.Text) : 0;
            Character.ItemCount += Character.Maltesers > 0 ? 1 : 0;
            Character.RedPotion = int.TryParse(txtRedPotion.Text, out _) ? Convert.ToInt32(txtRedPotion.Text) : 0;
            Character.ItemCount += Character.RedPotion > 0 ? 1 : 0;
            Character.GreenPotion = int.TryParse(txtGreenPotion.Text, out _) ? Convert.ToInt32(txtGreenPotion.Text) : 0;
            Character.ItemCount += Character.GreenPotion > 0 ? 1 : 0;
            Character.MauvePotion = int.TryParse(txtMauvePotion.Text, out _) ? Convert.ToInt32(txtMauvePotion.Text) : 0;
            Character.ItemCount += Character.MauvePotion > 0 ? 1 : 0;
            Character.DairyMilk = int.TryParse(txtDairyMilk.Text, out _) ? Convert.ToInt32(txtDairyMilk.Text) : 0;
            Character.ItemCount += Character.DairyMilk > 0 ? 1 : 0;
            Character.Gfuel = int.TryParse(txtGfuel.Text, out _) ? Convert.ToInt32(txtGfuel.Text) : 0;
            Character.ItemCount += Character.Gfuel > 0 ? 1 : 0;
            Character.Coffee = int.TryParse(txtKawa.Text, out _) ? Convert.ToInt32(txtKawa.Text) : 0;
            Character.ItemCount += Character.Coffee > 0 ? 1 : 0;
            Character.Dobrowianka = int.TryParse(txtDobrowianka.Text, out _) ? Convert.ToInt32(txtDobrowianka.Text) : 0;
            Character.ItemCount += Character.Dobrowianka > 0 ? 1 : 0;
            Character.MtnDew = int.TryParse(txtMtnDew.Text, out _) ? Convert.ToInt32(txtMtnDew.Text) : 0;
            Character.ItemCount += Character.MtnDew > 0 ? 1 : 0;
            Character.DrPepper = int.TryParse(txtDrPepper.Text, out _) ? Convert.ToInt32(txtDrPepper.Text) : 0;
            Character.ItemCount += Character.DrPepper > 0 ? 1 : 0;
            Character.HoolaHoops = int.TryParse(txtHoolaHoops.Text, out _) ? Convert.ToInt32(txtHoolaHoops.Text) : 0;
            Character.ItemCount += Character.HoolaHoops > 0 ? 1 : 0;
            Character.BarrCreamSoda = int.TryParse(txtCreamSoda.Text, out _) ? Convert.ToInt32(txtCreamSoda.Text) : 0;
            Character.ItemCount += Character.BarrCreamSoda > 0 ? 1 : 0;
            Character.StrSeed = int.TryParse(txtStrSeed.Text, out _) ? Convert.ToInt32(txtStrSeed.Text) : 0;
            Character.ItemCount += Character.StrSeed > 0 ? 1 : 0;
            Character.AgiSeed = int.TryParse(txtAgiSeed.Text, out _) ? Convert.ToInt32(txtAgiSeed.Text) : 0;
            Character.ItemCount += Character.AgiSeed > 0 ? 1 : 0;
            Character.AppSeed = int.TryParse(txtAppSeed.Text, out _) ? Convert.ToInt32(txtAppSeed.Text) : 0;
            Character.ItemCount += Character.AppSeed > 0 ? 1 : 0;
            Character.ResSeed = int.TryParse(txtDefSeed.Text, out _) ? Convert.ToInt32(txtDefSeed.Text) : 0;
            Character.ItemCount += Character.ResSeed > 0 ? 1 : 0;
            Character.SpdSeed = int.TryParse(txtSpdSeed.Text, out _) ? Convert.ToInt32(txtSpdSeed.Text) : 0;
            Character.ItemCount += Character.SpdSeed > 0 ? 1 : 0;
            Character.HpSeed = int.TryParse(txtHPSeed.Text, out _) ? Convert.ToInt32(txtHPSeed.Text) : 0;
            Character.ItemCount += Character.HpSeed > 0 ? 1 : 0;
            Character.Cash = int.TryParse(txtPLN.Text, out _) ? Convert.ToInt32(txtPLN.Text) : 0;
            Character.ItemCount += Character.Cash > 0 ? 1 : 0;

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
