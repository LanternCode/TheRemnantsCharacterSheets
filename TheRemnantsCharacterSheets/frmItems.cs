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
            Character.Monster = Convert.ToInt32(txtMonster.Text);
            Character.Doritos = Convert.ToInt32(txtDoritos.Text);
            Character.Coke = Convert.ToInt32(txtCoke.Text);
            Character.ColaOriginal = Convert.ToInt32(txtCokeOriginal.Text);
            Character.Crawford = Convert.ToInt32(txtCrawford.Text);
            Character.HotDog = Convert.ToInt32(txtHotDog.Text);
            Character.Brownie = Convert.ToInt32(txtBrownie.Text);
            Character.WhitePotion = Convert.ToInt32(txtWhitePotion.Text);
            Character.YellowPotion = Convert.ToInt32(txtYellowPotion.Text);
            Character.Maltesers = Convert.ToInt32(txtMaltesers.Text);
            Character.RedPotion = Convert.ToInt32(txtRedPotion.Text);
            Character.GreenPotion = Convert.ToInt32(txtGreenPotion.Text);
            Character.MauvePotion = Convert.ToInt32(txtMauvePotion.Text);
            Character.DairyMilk = Convert.ToInt32(txtDairyMilk.Text);
            Character.Gfuel = Convert.ToInt32(txtGfuel.Text);
            Character.Coffee = Convert.ToInt32(txtKawa.Text);
            Character.Dobrowianka = Convert.ToInt32(txtDobrowianka.Text);
            Character.MtnDew = Convert.ToInt32(txtMtnDew.Text);
            Character.DrPepper = Convert.ToInt32(txtDrPepper.Text);
            Character.HoolaHoops = Convert.ToInt32(txtHopaHoops.Text);
            Character.BarrCreamSoda = Convert.ToInt32(txtCreamSoda.Text);
            Character.StrSeed = Convert.ToInt32(txtStrSeed.Text);
            Character.AgiSeed = Convert.ToInt32(txtAgiSeed.Text);
            Character.AppSeed = Convert.ToInt32(txtAppSeed.Text);
            Character.ResSeed = Convert.ToInt32(txtDefSeed.Text);
            Character.SpdSeed = Convert.ToInt32(txtSpdSeed.Text);
            Character.HpSeed = Convert.ToInt32(txtHPSeed.Text);

            //GENERATE THE SHEET

            //Path to save the sheet
            string fileName = @"D:\GeneratedDocs\sheet.docx";

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

            //Formatting Title  
            //titleFormat.UnderlineColor = System.Drawing.Color.Gray;
            //titleFormat.Italic = true;
            //textParagraphFormat.Spacing = 2;

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

            //Add image:
            Xceed.Document.NET.Image img = doc.AddImage(@"D:\wamp64\www\TheRemnantsCharacterSheets\TheRemnantsCharacterSheets\mitchjones.jpg");
            Picture p = img.CreatePicture(200, 100);
            t.MergeCellsInColumn(0, 0, 10);
            t.Rows[0].Cells[0].Paragraphs.First().AppendPicture(p);

            //Add statistics:
            t.Rows[0].Cells[1].Paragraphs.First().Append("Poziom: " + Character.Level);
            t.Rows[1].Cells[1].Paragraphs.First().Append("Klasa: " + Character.Class);
            t.Rows[2].Cells[1].Paragraphs.First().Append("Punkty Życia: " + Character.HP);
            t.Rows[3].Cells[1].Paragraphs.First().Append("Zwinność: " + Character.Agility);
            t.Rows[4].Cells[1].Paragraphs.First().Append("Szybkość: " + Character.Speed);
            t.Rows[5].Cells[1].Paragraphs.First().Append("Wygląd: " + Character.Appearance);
            t.Rows[6].Cells[1].Paragraphs.First().Append("Wprawa: " + Character.Dexterity);
            t.Rows[7].Cells[1].Paragraphs.First().Append("Unik: " + Character.Dodge);
            t.Rows[8].Cells[1].Paragraphs.First().Append("Siła: " + Character.Strength);
            t.Rows[9].Cells[1].Paragraphs.First().Append("Atak Bazowy: " + Character.BaseAttack);
            t.Rows[10].Cells[1].Paragraphs.First().Append("Rezystancja: " + Character.Resistance);

            //Add talents:
            Int32 Index = 0;
            for(int i = 0; i < 12; ++i)
            {
                switch (i)
                {
                    case 0:
                    {
                        if(Character.TacticAnalysis > 0)
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
            doc.InsertTable(t);
            //Hyperlink  
            //Hyperlink url = doc.AddHyperlink("Google Web Site", new Uri("http://www.google.com"));
            //Paragraph p1 = doc.InsertParagraph();
            //p1.AppendLine("Please check ").Bold().AppendHyperlink(url);
            doc.Save();

            Process.Start("WINWORD.EXE", fileName);
        }
    }
}
