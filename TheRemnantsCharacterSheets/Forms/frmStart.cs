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
        }

        private void button1_Click(object sender, EventArgs e)
        {

            //name and title
            Character.Name = txtName.Text.Length > 0 ? txtName.Text : "Mateusz Krzesiński";
            Character.Title = txtTitle.Text.Length > 0 ? txtTitle.Text : "Legenda Streamingu";
            Character.Group = txtGroup.Text.Length > 0 ? txtGroup.Text : "Twitch.TV";
            Character.Rank = txtRank.Text.Length > 0 ? txtRank.Text : "Szefu";

            //stats
            Character.Level = txtLevel.Text.Length > 0 ? (int.TryParse(txtLevel.Text, out _) ? Convert.ToInt32(txtLevel.Text) : 0) : 1;
            Character.Class = lstClass.Text.Length > 0 ? lstClass.Text : "Livestreamer";
            Character.HP = txtHP.Text.Length > 0 ? (int.TryParse(txtHP.Text, out _) ? Convert.ToInt32(txtHP.Text) : 0) : 100;
            Character.Agility = txtAgi.Text.Length > 0 ? (int.TryParse(txtAgi.Text, out _) ? Convert.ToInt32(txtAgi.Text) : 0) : 90;
            Character.Speed = txtSpd.Text.Length > 0 ? (int.TryParse(txtSpd.Text, out _) ? Convert.ToInt32(txtSpd.Text) : 0) : 85;
            Character.Appearance = txtApp.Text.Length > 0 ? (int.TryParse(txtApp.Text, out _) ? Convert.ToInt32(txtApp.Text) : 0) : 90;
            Character.Dexterity = txtDex.Text.Length > 0 ? (int.TryParse(txtDex.Text, out _) ? Convert.ToInt32(txtDex.Text) : 0) : 80;
            Character.Dodge = txtDodge.Text.Length > 0 ? (int.TryParse(txtDodge.Text, out _) ? Convert.ToInt32(txtDodge.Text) : 0) : 75;
            Character.Strength = txtStr.Text.Length > 0 ? (int.TryParse(txtStr.Text, out _) ? Convert.ToInt32(txtStr.Text) : 0) : 75;
            Character.BaseAttack = txtAtt.Text.Length > 0 ? (int.TryParse(txtAtt.Text, out _) ? Convert.ToInt32(txtAtt.Text) : 0) : 15;

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

            string appPath = Path.GetDirectoryName(Application.ExecutablePath);
            if (Directory.Exists(appPath) == false)
            {
                Directory.CreateDirectory(appPath);
            }

            if (opFile.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    Character.imageName = opFile.SafeFileName;
                    Bitmap toResize = new Bitmap(opFile.OpenFile());

                    Image characterImage = ResizeImage(toResize, 200, 306);

                    imgCharacter.Image = characterImage;
                    string path = Path.Combine("Images", Character.imageName);
                    characterImage.Save(path);
                }
                catch
                {
                    MessageBox.Show("Musisz wybrać zdjęcie. Jeśli tak zrobiono a ten błąd dalej występuje, jest " +
                        "spora szansa że to zdjęcie zostało zapisane w złym formacie lub nie jest tym czym się " +
                        "wydaje. Pobierz je z innego źródła lub 'zapisz jako' w dowolnym programie graficznym " +
                        "typu Paint.", "Wystąpił Błąd");
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
