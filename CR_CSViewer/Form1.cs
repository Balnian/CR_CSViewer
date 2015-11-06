using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CR_CSViewer
{
    public partial class Form1 : Form
    {
        private String DialoguesPath = "";
        private String QuetesPath = "";
        private List<String[]> Dialogues = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {

        }

        private void ouvrirFichierDialoguesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog OFDial = new OpenFileDialog();
            OFDial.Filter = "CSV (.csv)|*.csv";
            OFDial.FilterIndex = 1;
            if(OFDial.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                if(OFDial.CheckFileExists)
                {
                    DialoguesPath = OFDial.FileName;
                    List<String[]> temp = new List<string[]>();
                    using(TextFieldParser  parser = new TextFieldParser(OFDial.FileName))
                    {
                        parser.TextFieldType = FieldType.Delimited;
                        parser.SetDelimiters(",");
                        
                        while(!parser.EndOfData)
                        {
                            temp.Add(parser.ReadFields());
                        }
                    }

                    Dialogues = temp;
                    FillDialogues();

                    //String[] file = File.ReadAllLines(OFDial.FileName);
                    //String[,] Data;
                    
                    //foreach(String ligne in file)
                    //{
                    //    temp.Add(ligne.Split())

                    //}
                    
                }
            }
             
        }

        private void FillDialogues()
        {
            if(Dialogues!=null)
            {
                LV_Dialogues.Columns.Clear();
                foreach(String col in Dialogues.First())
                {
                    LV_Dialogues.Columns.Add(col);
                }
                LV_Dialogues.Items.Clear();
                foreach(String[] row in Dialogues)
                {
                    if(row != Dialogues.First() )
                    {
                        if(!String.IsNullOrWhiteSpace(TSTB_Recherche.Text))
                        {
                            foreach(String str in row)
                            {
                                if(str.Contains(TSTB_Recherche.Text))
                                {
                                    LV_Dialogues.Items.Add(new ListViewItem(row,0));
                                    break;
                                }
                            }
                        }
                        else
                            LV_Dialogues.Items.Add(new ListViewItem(row,0));

                    }
                }
            }


            
        }

        private void TSTB_Recherche_Click(object sender, EventArgs e)
        {
            
        }

        private void TSTB_Recherche_TextChanged(object sender, EventArgs e)
        {
            FillDialogues();
        }
    }
}
