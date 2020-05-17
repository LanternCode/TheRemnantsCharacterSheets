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
            t.SetWidths(new float[] { 180f, 135, 135f });

            //Add image:
            Xceed.Document.NET.Image img = doc.AddImage(@"D:\wamp64\www\TheRemnantsCharacterSheets\TheRemnantsCharacterSheets\mitchjones.jpg");
            Picture p = img.CreatePicture(230, 150);
            t.MergeCellsInColumn(0, 0, 10);
            t.Rows[0].Cells[0].Paragraphs.First().AppendPicture(p);

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

            //Insert the table
            doc.InsertTable(t);

            //Create Table with 3 columns and enough rows to hold all skills, equipment and items 
            Int32 rowsRequired = Character.Equipment.Count > Character.Skills.Count ? (Character.Equipment.Count > Character.ItemCount ? Character.Equipment.Count : Character.ItemCount) : (Character.Skills.Count > Character.ItemCount ? Character.Skills.Count : Character.ItemCount);
            Table tableBottom = doc.AddTable(rowsRequired, 3);
            tableBottom.Alignment = Alignment.center;
            Border tableBottomBorder = new Border(Xceed.Document.NET.BorderStyle.Tcbs_none, 0, 0, Color.Black);
            tableBottom.SetBorder(TableBorderType.Bottom, tableBottomBorder);
            tableBottom.SetBorder(TableBorderType.InsideH, tableBottomBorder);
            tableBottom.SetBorder(TableBorderType.InsideV, tableBottomBorder);
            tableBottom.SetBorder(TableBorderType.Left, tableBottomBorder);
            tableBottom.SetBorder(TableBorderType.Right, tableBottomBorder);
            tableBottom.SetBorder(TableBorderType.Top, tableBottomBorder);
            tableBottom.SetWidths(new float[] { 150f, 150, 150f });

            //List all skills
            Index = 0;
            foreach(Skill skill in Character.Skills)
            {
                String line = skill.Name + (skill.Description.Length > 0 ? " - " : "") + skill.Description + " (" + skill.Priority + ")";
                tableBottom.Rows[Index].Cells[0].Paragraphs.First().Append(line);
                Index++;
            }

            //List all equipment
            Index = 0;
            foreach(Equipment item in Character.Equipment)
            {
                String line = item.Name + "(" + ")";
                tableBottom.Rows[Index].Cells[1].Paragraphs.First().Append(line);
                Index++;
            }

            //List all items
            Index = 0;
            
                if(Character.Oasis > 0)
                {
                    tableBottom.Rows[Index].Cells[2].Paragraphs.First().Append("Oasis: " + Character.Oasis);
                    Index++;
                }

                if(Character.Monster > 0){tableBottom.Rows[Index].Cells[2].Paragraphs.First().Append("Monster: " + Character.Monster);Index++;}
                if(Character.Doritos > 0){tableBottom.Rows[Index].Cells[2].Paragraphs.First().Append("Doritos: " + Character.Doritos);Index++;}
                if(Character.Coke > 0){tableBottom.Rows[Index].Cells[2].Paragraphs.First().Append("Coke: " + Character.Coke);Index++;}
                if(Character.ColaOriginal > 0){tableBottom.Rows[Index].Cells[2].Paragraphs.First().Append("Cola Original: " + Character.ColaOriginal);Index++;}
                if(Character.Crawford > 0){tableBottom.Rows[Index].Cells[2].Paragraphs.First().Append("Crawford & Tilley: " + Character.Crawford);Index++;}
                if(Character.HotDog > 0){tableBottom.Rows[Index].Cells[2].Paragraphs.First().Append("HotDog: " + Character.HotDog);Index++;}
                if(Character.Brownie > 0){tableBottom.Rows[Index].Cells[2].Paragraphs.First().Append("Brownie: " + Character.Brownie);Index++;}
                if(Character.WhitePotion > 0){tableBottom.Rows[Index].Cells[2].Paragraphs.First().Append("White Potion: " + Character.WhitePotion);Index++;}
                if(Character.YellowPotion > 0){tableBottom.Rows[Index].Cells[2].Paragraphs.First().Append("Yellow Potion: " + Character.YellowPotion);Index++;}
                if(Character.Maltesers > 0){tableBottom.Rows[Index].Cells[2].Paragraphs.First().Append("Maltesers: " + Character.Maltesers);Index++;}
                if(Character.RedPotion > 0){tableBottom.Rows[Index].Cells[2].Paragraphs.First().Append("Red Potion: " + Character.RedPotion);Index++;}
                if(Character.GreenPotion > 0){tableBottom.Rows[Index].Cells[2].Paragraphs.First().Append("Green Potion: " + Character.GreenPotion);Index++;}
                if(Character.MauvePotion > 0){tableBottom.Rows[Index].Cells[2].Paragraphs.First().Append("Mauve Potion: " + Character.MauvePotion);Index++;}
                if(Character.DairyMilk > 0){tableBottom.Rows[Index].Cells[2].Paragraphs.First().Append("Dairy Milk: " + Character.DairyMilk);Index++;}
                if(Character.Gfuel > 0){tableBottom.Rows[Index].Cells[2].Paragraphs.First().Append("GFuel: " + Character.Gfuel);Index++;}
                if(Character.Coffee > 0){tableBottom.Rows[Index].Cells[2].Paragraphs.First().Append("Coffee: " + Character.Coffee);Index++;}
                if(Character.Dobrowianka > 0){tableBottom.Rows[Index].Cells[2].Paragraphs.First().Append("Dobrowianka: " + Character.Dobrowianka);Index++;}
                if(Character.MtnDew > 0){tableBottom.Rows[Index].Cells[2].Paragraphs.First().Append("Mtn Dew: " + Character.MtnDew);Index++;}
                if(Character.DrPepper > 0){tableBottom.Rows[Index].Cells[2].Paragraphs.First().Append("Dr Pepper: " + Character.DrPepper);Index++;}
                if(Character.HoolaHoops > 0){tableBottom.Rows[Index].Cells[2].Paragraphs.First().Append("Hoola Hoops: " + Character.HoolaHoops);Index++;}
                if(Character.BarrCreamSoda > 0){tableBottom.Rows[Index].Cells[2].Paragraphs.First().Append("Barr's Cream Soda: " + Character.BarrCreamSoda);Index++;}
                if(Character.StrSeed > 0){tableBottom.Rows[Index].Cells[2].Paragraphs.First().Append("Strength Seed: " + Character.StrSeed);Index++;}
                if(Character.AgiSeed > 0){tableBottom.Rows[Index].Cells[2].Paragraphs.First().Append("Agility Seed: " + Character.AgiSeed);Index++;}
                if(Character.AppSeed > 0){tableBottom.Rows[Index].Cells[2].Paragraphs.First().Append("Appearance Seed: " + Character.AppSeed);Index++;}
                if(Character.ResSeed > 0){tableBottom.Rows[Index].Cells[2].Paragraphs.First().Append("Resilience Seed: " + Character.ResSeed);Index++;}
                if(Character.SpdSeed > 0){tableBottom.Rows[Index].Cells[2].Paragraphs.First().Append("Speed Seed: " + Character.SpdSeed);Index++;}
                if(Character.HpSeed > 0){tableBottom.Rows[Index].Cells[2].Paragraphs.First().Append("Health Seed: " + Character.HpSeed);Index++;}


            //Hyperlink  
            //Hyperlink url = doc.AddHyperlink("Google Web Site", new Uri("http://www.google.com"));
            //Paragraph p1 = doc.InsertParagraph();
            //p1.AppendLine("Please check ").Bold().AppendHyperlink(url);
            doc.Save();

            Process.Start("WINWORD.EXE", fileName);
        }
    }
}
