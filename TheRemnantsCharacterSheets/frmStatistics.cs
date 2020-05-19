using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheRemnantsCharacterSheets
{
    public partial class frmStatistics : Form
    {
        public frmStatistics()
        {
            InitializeComponent();
            this.btnPicture.Click += new System.EventHandler(this.btnPicture_Click);
        }

        private void button1_Click(object sender, EventArgs e)
        {

            //name and title
            Character.Name = txtName.Text.Length > 0 ? txtName.Text : "Mateusz Krzesiński";//"Mitch Jones";
            Character.Title = txtTitle.Text.Length > 0 ? txtTitle.Text : "Legenda Streamingu";
            Character.Group = txtGroup.Text.Length > 0 ? txtGroup.Text : "Twitch.TV";
            Character.Rank = txtRank.Text.Length > 0 ? txtRank.Text : "Szefu";

            //stats
            int value;
            Character.Level = txtLevel.Text.Length > 0 ? (int.TryParse(txtLevel.Text, out value) ? Convert.ToInt32(txtLevel.Text) : 0) : 1;
            Character.Class = txtClass.Text.Length > 0 ? txtClass.Text : "Livestreamer";
            Character.HP = txtHP.Text.Length > 0 ? (int.TryParse(txtHP.Text, out value) ? Convert.ToInt32(txtHP.Text) : 0) : 100;
            Character.Agility = txtAgi.Text.Length > 0 ? (int.TryParse(txtAgi.Text, out value) ? Convert.ToInt32(txtAgi.Text) : 0) : 90;
            Character.Speed = txtSpd.Text.Length > 0 ? (int.TryParse(txtSpd.Text, out value) ? Convert.ToInt32(txtSpd.Text) : 0) : 85;
            Character.Appearance = txtApp.Text.Length > 0 ? (int.TryParse(txtApp.Text, out value) ? Convert.ToInt32(txtApp.Text) : 0) : 90;
            Character.Dexterity = txtDex.Text.Length > 0 ? (int.TryParse(txtDex.Text, out value) ? Convert.ToInt32(txtDex.Text) : 0) : 80;
            Character.Dodge = txtDodge.Text.Length > 0 ? (int.TryParse(txtDodge.Text, out value) ? Convert.ToInt32(txtDodge.Text) : 0) : 75;
            Character.Strength = txtStr.Text.Length > 0 ? (int.TryParse(txtStr.Text, out value) ? Convert.ToInt32(txtStr.Text) : 0) : 75;
            Character.BaseAttack = txtAtt.Text.Length > 0 ? (int.TryParse(txtAtt.Text, out value) ? Convert.ToInt32(txtAtt.Text) : 0) : 15;
            Character.Resistance = txtRes.Text.Length > 0 ? (int.TryParse(txtRes.Text, out value) ? Convert.ToInt32(txtRes.Text) : 0) : 8;


            frmTalents formTalents = new frmTalents();
            formTalents.Show();
            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnPicture_Click(object sender, EventArgs e)
        {
            OpenFileDialog opFile = new OpenFileDialog();
            opFile.Title = "Wybierz zdjęcie dla swojej postaci!";
            opFile.Filter = "jpg files (*.jpg)|*.jpg|All files (*.*)|*.*";

            string appPath = Path.GetDirectoryName(Application.ExecutablePath);// + @"\ProImages\"; // <---
            if (Directory.Exists(appPath) == false)                                              // <---
            {                                                                                    // <---
                Directory.CreateDirectory(appPath);                                              // <---
            }                                                                                    // <---

            if (opFile.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string iName = opFile.SafeFileName;   // <---
                    string filepath = opFile.FileName;    // <---
                    Bitmap toResize = new Bitmap(opFile.OpenFile());
                    imgCharacter.Image = ResizeImage(toResize, 162, 293);
                    File.Copy(filepath, appPath + iName); // <---
                }
                catch (Exception exp)
                {
                    MessageBox.Show("Musisz wybrać zdjęcie, kod błędu: " + exp.Message);
                }
            }
            else
            {
                opFile.Dispose();
            }
        }

        /// <summary>
        /// Resize the image to the specified width and height.
        /// </summary>
        /// <param name="image">The image to resize.</param>
        /// <param name="width">The width to resize to.</param>
        /// <param name="height">The height to resize to.</param>
        /// <returns>The resized image.</returns>
        public static Bitmap ResizeImage(Image image, int width, int height)
        {
            var destRect = new Rectangle(0, 0, width, height);
            var destImage = new Bitmap(width, height);

            destImage.SetResolution(image.HorizontalResolution, image.VerticalResolution);

            using (var graphics = Graphics.FromImage(destImage))
            {
                graphics.CompositingMode = CompositingMode.SourceCopy;
                graphics.CompositingQuality = CompositingQuality.HighQuality;
                graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
                graphics.SmoothingMode = SmoothingMode.HighQuality;
                graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;

                using (var wrapMode = new ImageAttributes())
                {
                    wrapMode.SetWrapMode(WrapMode.TileFlipXY);
                    graphics.DrawImage(image, destRect, 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, wrapMode);
                }
            }

            return destImage;
        }

    }
}
