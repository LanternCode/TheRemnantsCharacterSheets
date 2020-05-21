using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Xceed.Document.NET;
using Xceed.Words.NET;

namespace TheRemnantsCharacterSheets
{
    public partial class frmGenerate : Form
    {
        public frmGenerate()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        /// <summary>
        /// Resize the image to the specified width and height.
        /// </summary>
        /// <param name="image">The image to resize.</param>
        /// <param name="width">The width to resize to.</param>
        /// <param name="height">The height to resize to.</param>
        /// <returns>The resized image.</returns>
        public static Bitmap ResizeImage(System.Drawing.Image image, int width, int height)
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

        private void btnGenerate_Click(object sender, EventArgs e)
        {

            //Path to save the sheet
            string fileName = @"D:\GeneratedDocs\" + Character.Name.Replace(' ', '_') + ".docx"; 

            //Create Title  
            string title = Character.Name;

            //Formatting Title  
            Formatting titleFormat = new Formatting();
            titleFormat.FontFamily = new Xceed.Document.NET.Font("Calibri Light");
            titleFormat.Size = 28D;
            titleFormat.FontColor = System.Drawing.Color.Black;

            //Create Subtitle
            string subtitle = Character.Title + ", " + Character.Rank + " '" + Character.Group + "'" + Environment.NewLine + Environment.NewLine + Environment.NewLine;

            //Formatting Subtitle
            Formatting textParagraphFormat = new Formatting();
            textParagraphFormat.FontFamily = new Xceed.Document.NET.Font("Calibri");
            textParagraphFormat.Size = 11D;
            textParagraphFormat.FontColor = ColorTranslator.FromHtml("#5A5A5A");

            //Create word document
            var doc = DocX.Create(fileName);

            //Insert title
            Paragraph paragraphTitle = doc.InsertParagraph(title, false, titleFormat);
            paragraphTitle.Alignment = Alignment.center;

            //Insert subtitle
            Paragraph paragraphSubTitle = doc.InsertParagraph(subtitle, false, textParagraphFormat);
            paragraphSubTitle.Alignment = Alignment.center;

            //Create Table with 11 rows and 3 columns.
            Table t = doc.AddTable(11, 3);
            t.Alignment = Alignment.center;
            Border tableBorder = new Border(Xceed.Document.NET.BorderStyle.Tcbs_none, 0, 0, Color.Black);
            t.SetBorder(TableBorderType.Bottom, tableBorder);
            t.SetBorder(TableBorderType.InsideH, tableBorder);
            t.SetBorder(TableBorderType.InsideV, tableBorder);
            t.SetBorder(TableBorderType.Left, tableBorder);
            t.SetBorder(TableBorderType.Right, tableBorder);
            t.SetBorder(TableBorderType.Top, tableBorder);
            t.SetWidths(new float[] { 180f, 135, 135f });

            //Add image:
            Xceed.Document.NET.Image img = doc.AddImage(Character.imageName);
            Picture p = img.CreatePicture(230, 150);
            t.MergeCellsInColumn(0, 0, 10);
            t.Rows[0].Cells[0].Paragraphs.First().AppendPicture(p);
            File.Delete(Character.imageName);

            //Add statistics:
            t.Rows[0].Cells[1].Paragraphs.First().Append("Poziom: " + Character.Level).SpacingAfter(7d);
            t.Rows[1].Cells[1].Paragraphs.First().Append("Klasa: " + Character.Class).SpacingAfter(7d);
            t.Rows[2].Cells[1].Paragraphs.First().Append("Punkty Życia: " + Character.HP).SpacingAfter(7d);
            t.Rows[3].Cells[1].Paragraphs.First().Append("Zwinność: " + Character.Agility).SpacingAfter(7d);
            t.Rows[4].Cells[1].Paragraphs.First().Append("Szybkość: " + Character.Speed).SpacingAfter(7d);
            t.Rows[5].Cells[1].Paragraphs.First().Append("Wygląd: " + Character.Appearance).SpacingAfter(7d);
            t.Rows[6].Cells[1].Paragraphs.First().Append("Wprawa: " + Character.Dexterity).SpacingAfter(7d);
            t.Rows[7].Cells[1].Paragraphs.First().Append("Unik: " + Character.Dodge).SpacingAfter(7d);
            t.Rows[8].Cells[1].Paragraphs.First().Append("Siła: " + Character.Strength).SpacingAfter(7d);
            t.Rows[9].Cells[1].Paragraphs.First().Append("Atak Bazowy: " + Character.BaseAttack).SpacingAfter(7d);
            t.Rows[10].Cells[1].Paragraphs.First().Append("Rezystancja: " + Character.Resistance).SpacingAfter(7d);

            //Add talents:
            Int32 Index = 0;
            for (int i = 0; i < 12; ++i)
            {
                switch (i)
                {
                    case 0:
                        {
                            if (Character.TacticAnalysis > 0)
                            {
                                t.Rows[Index].Cells[2].Paragraphs.First().Append("Analiza Taktyczna: " + new String('*', Character.TacticAnalysis));
                                Index++;
                            }
                            break;
                        }
                    case 1:
                        {
                            if (Character.Tactics > 0)
                            {
                                t.Rows[Index].Cells[2].Paragraphs.First().Append("Taktyka: " + new String('*', Character.Tactics));
                                Index++;
                            }
                            break;
                        }
                    case 2:
                        {
                            if (Character.Knowledge > 0)
                            {
                                t.Rows[Index].Cells[2].Paragraphs.First().Append("Wiedza: " + new String('*', Character.Knowledge));
                                Index++;
                            }
                            break;
                        }
                    case 3:
                        {
                            if (Character.MeleeRange > 0)
                            {
                                t.Rows[Index].Cells[2].Paragraphs.First().Append("Walka Bezp.: " + new String('*', Character.MeleeRange));
                                Index++;
                            }
                            break;
                        }
                    case 4:
                        {
                            if (Character.ShortRange > 0)
                            {
                                t.Rows[Index].Cells[2].Paragraphs.First().Append("Walka Krótka: " + new String('*', Character.ShortRange));
                                Index++;
                            }
                            break;
                        }
                    case 5:
                        {
                            if (Character.Sorcery > 0)
                            {
                                t.Rows[Index].Cells[2].Paragraphs.First().Append("Czarnoksięstwo: " + new String('*', Character.Sorcery));
                                Index++;
                            }
                            break;
                        }
                    case 6:
                        {
                            if (Character.Faith > 0)
                            {
                                t.Rows[Index].Cells[2].Paragraphs.First().Append("Wiara: " + new String('*', Character.Faith));
                                Index++;
                            }
                            break;
                        }
                    case 7:
                        {
                            if (Character.Symbolics > 0)
                            {
                                t.Rows[Index].Cells[2].Paragraphs.First().Append("Symbolika: " + new String('*', Character.Symbolics));
                                Index++;
                            }
                            break;
                        }
                    case 8:
                        {
                            if (Character.PassiveIncome > 0)
                            {
                                t.Rows[Index].Cells[2].Paragraphs.First().Append("Pasywny Przychód: " + new String('*', Character.PassiveIncome));
                                Index++;
                            }
                            break;
                        }
                    case 9:
                        {
                            if (Character.WeaponMastery > 0)
                            {
                                t.Rows[Index].Cells[2].Paragraphs.First().Append("Mistrzostwo Bronii: " + new String('*', Character.WeaponMastery));
                                Index++;
                            }
                            break;
                        }
                    case 10:
                        {
                            if (Character.SpellMastery > 0)
                            {
                                t.Rows[Index].Cells[2].Paragraphs.First().Append("Mistrzostwo Magii: " + new String('*', Character.SpellMastery));
                                Index++;
                            }
                            break;
                        }
                    case 11:
                        {
                            if (Character.RavenAgility > 0)
                            {
                                t.Rows[Index].Cells[2].Paragraphs.First().Append("Krucza Zwinność: " + new String('*', Character.RavenAgility));
                                Index++;
                            }
                            break;
                        }
                }
            }

            //Insert the table
            doc.InsertTable(t);

            doc.InsertParagraph(Environment.NewLine);

            //Create Table with 3 columns and enough rows to hold all skills, equipment and items 
            Int32 rowsRequired = Character.Equipment.Count > Character.Skills.Count ? (Character.Equipment.Count > Character.ItemCount ? Character.Equipment.Count : Character.ItemCount) : (Character.Skills.Count > Character.ItemCount ? Character.Skills.Count : Character.ItemCount);
            rowsRequired = rowsRequired < 2 ? 2 : rowsRequired;
            Table tableBottom = doc.AddTable(rowsRequired + 1, 3); //first row is a header row
            tableBottom.Alignment = Alignment.center;
            Border tableBottomBorder = new Border(Xceed.Document.NET.BorderStyle.Tcbs_none, 0, 0, Color.Black);
            tableBottom.SetBorder(TableBorderType.Bottom, tableBottomBorder);
            tableBottom.SetBorder(TableBorderType.InsideH, tableBottomBorder);
            tableBottom.SetBorder(TableBorderType.InsideV, tableBottomBorder);
            tableBottom.SetBorder(TableBorderType.Left, tableBottomBorder);
            tableBottom.SetBorder(TableBorderType.Right, tableBottomBorder);
            tableBottom.SetBorder(TableBorderType.Top, tableBottomBorder);
            tableBottom.SetWidths(new float[] { 150f, 150, 150f });

            //Merge cells in the columns
            tableBottom.MergeCellsInColumn(0, 1, rowsRequired);
            tableBottom.MergeCellsInColumn(1, 1, rowsRequired);
            tableBottom.MergeCellsInColumn(2, 1, rowsRequired);

            //Create Headers For The Bottom Table
            string skillsHeader = "Umiejętności" + Environment.NewLine;
            string equipmentHeader = "Ekwipunek" + Environment.NewLine;
            string itemsHeader = "Przedmioty" + Environment.NewLine;

            //Formatting The Headers
            Formatting bottomTableHeaderFormat = new Formatting();
            bottomTableHeaderFormat.FontFamily = new Xceed.Document.NET.Font("Calibri");
            bottomTableHeaderFormat.Size = 14D;
            bottomTableHeaderFormat.FontColor = Color.Black;
            bottomTableHeaderFormat.UnderlineColor = Color.Black;

            //Insert the headers
            tableBottom.Rows[0].Cells[0].InsertParagraph(skillsHeader, false, bottomTableHeaderFormat).Bold();
            tableBottom.Rows[0].Cells[1].InsertParagraph(equipmentHeader, false, bottomTableHeaderFormat).Bold();
            tableBottom.Rows[0].Cells[2].InsertParagraph(itemsHeader, false, bottomTableHeaderFormat).Bold();

            //List all skills
            foreach (Skill skill in Character.Skills)
            {
                String line = "- " + skill.Name + (skill.Description.Length > 0 ? " - " : "") + skill.Description + " (" + skill.Priority + ")" + Environment.NewLine;
                tableBottom.Rows[1].Cells[0].Paragraphs.First().Append(line);
                Index++;
            }

            //List all equipment
            foreach (Equipment item in Character.Equipment)
            {
                String line = "- " + Equipment.listBuffs(item);
                tableBottom.Rows[1].Cells[1].Paragraphs.First().Append(line);
                Index++;
            }

            //List all items

            if (Character.Cash > 0) { tableBottom.Rows[1].Cells[2].Paragraphs.First().Append("- " + Character.Cash + " zł" + Environment.NewLine); }
            if (Character.Oasis > 0) { tableBottom.Rows[1].Cells[2].Paragraphs.First().Append("- Oasis: " + Character.Oasis + Environment.NewLine); }
            if (Character.Monster > 0) { tableBottom.Rows[1].Cells[2].Paragraphs.First().Append("- Monster: " + Character.Monster + Environment.NewLine); }
            if (Character.Doritos > 0) { tableBottom.Rows[1].Cells[2].Paragraphs.First().Append("- Doritos: " + Character.Doritos + Environment.NewLine); }
            if (Character.Coke > 0) { tableBottom.Rows[1].Cells[2].Paragraphs.First().Append("- Coke: " + Character.Coke + Environment.NewLine); }
            if (Character.ColaOriginal > 0) { tableBottom.Rows[1].Cells[2].Paragraphs.First().Append("- Cola Original: " + Character.ColaOriginal + Environment.NewLine); }
            if (Character.Crawford > 0) { tableBottom.Rows[1].Cells[2].Paragraphs.First().Append("- Crawford & Tilley: " + Character.Crawford + Environment.NewLine); }
            if (Character.HotDog > 0) { tableBottom.Rows[1].Cells[2].Paragraphs.First().Append("- HotDog: " + Character.HotDog + Environment.NewLine); }
            if (Character.Brownie > 0) { tableBottom.Rows[1].Cells[2].Paragraphs.First().Append("- Brownie: " + Character.Brownie + Environment.NewLine); }
            if (Character.WhitePotion > 0) { tableBottom.Rows[1].Cells[2].Paragraphs.First().Append("- White Potion: " + Character.WhitePotion + Environment.NewLine); }
            if (Character.YellowPotion > 0) { tableBottom.Rows[1].Cells[2].Paragraphs.First().Append("- Yellow Potion: " + Character.YellowPotion + Environment.NewLine); }
            if (Character.Maltesers > 0) { tableBottom.Rows[1].Cells[2].Paragraphs.First().Append("- Maltesers: " + Character.Maltesers + Environment.NewLine); }
            if (Character.RedPotion > 0) { tableBottom.Rows[1].Cells[2].Paragraphs.First().Append("- Red Potion: " + Character.RedPotion + Environment.NewLine); }
            if (Character.GreenPotion > 0) { tableBottom.Rows[1].Cells[2].Paragraphs.First().Append("- Green Potion: " + Character.GreenPotion + Environment.NewLine); }
            if (Character.MauvePotion > 0) { tableBottom.Rows[1].Cells[2].Paragraphs.First().Append("- Mauve Potion: " + Character.MauvePotion + Environment.NewLine); }
            if (Character.DairyMilk > 0) { tableBottom.Rows[1].Cells[2].Paragraphs.First().Append("- Dairy Milk: " + Character.DairyMilk + Environment.NewLine); }
            if (Character.Gfuel > 0) { tableBottom.Rows[1].Cells[2].Paragraphs.First().Append("- GFuel: " + Character.Gfuel + Environment.NewLine); }
            if (Character.Coffee > 0) { tableBottom.Rows[1].Cells[2].Paragraphs.First().Append("- Coffee: " + Character.Coffee + Environment.NewLine); }
            if (Character.Dobrowianka > 0) { tableBottom.Rows[1].Cells[2].Paragraphs.First().Append("- Dobrowianka: " + Character.Dobrowianka + Environment.NewLine); }
            if (Character.MtnDew > 0) { tableBottom.Rows[1].Cells[2].Paragraphs.First().Append("- Mtn Dew: " + Character.MtnDew + Environment.NewLine); }
            if (Character.DrPepper > 0) { tableBottom.Rows[1].Cells[2].Paragraphs.First().Append("- Dr Pepper: " + Character.DrPepper + Environment.NewLine); }
            if (Character.HoolaHoops > 0) { tableBottom.Rows[1].Cells[2].Paragraphs.First().Append("- Hoola Hoops: " + Character.HoolaHoops + Environment.NewLine); }
            if (Character.BarrCreamSoda > 0) { tableBottom.Rows[1].Cells[2].Paragraphs.First().Append("- Barr's Cream Soda: " + Character.BarrCreamSoda + Environment.NewLine); }
            if (Character.StrSeed > 0) { tableBottom.Rows[1].Cells[2].Paragraphs.First().Append("- Strength Seed: " + Character.StrSeed + Environment.NewLine); }
            if (Character.AgiSeed > 0) { tableBottom.Rows[1].Cells[2].Paragraphs.First().Append("- Agility Seed: " + Character.AgiSeed + Environment.NewLine); }
            if (Character.AppSeed > 0) { tableBottom.Rows[1].Cells[2].Paragraphs.First().Append("- Appearance Seed: " + Character.AppSeed + Environment.NewLine); }
            if (Character.ResSeed > 0) { tableBottom.Rows[1].Cells[2].Paragraphs.First().Append("- Resilience Seed: " + Character.ResSeed + Environment.NewLine); }
            if (Character.SpdSeed > 0) { tableBottom.Rows[1].Cells[2].Paragraphs.First().Append("- Speed Seed: " + Character.SpdSeed + Environment.NewLine); }
            if (Character.HpSeed > 0) { tableBottom.Rows[1].Cells[2].Paragraphs.First().Append("- Health Seed: " + Character.HpSeed + Environment.NewLine); }

            //Insert the table
            doc.InsertTable(tableBottom);

            //Save the document to its final form
            doc.Save();

            //Generate and open the document
            Process.Start("WINWORD.EXE", fileName);
        }
    }
}
