using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;

namespace SampleTextEditiorL4DC
{
    public partial class frmDocument : Form
    {
        textfileDSTableAdapters.FilesTableAdapter fdb = new textfileDSTableAdapters.FilesTableAdapter();
        textfileDSTableAdapters.File_DetailTableAdapter ddb = new textfileDSTableAdapters.File_DetailTableAdapter();
        int noofTags = 1;
        public frmDocument()
        {
            InitializeComponent();
        }
        private RichTextBox NewRichTextBox()
        {
            RichTextBox rtb = null;
            TabPage tp = tabdisplay.SelectedTab;
            if (tp !=null)
            {
                rtb = tp.Controls[0] as RichTextBox;
            }
            return rtb;
        }
        private void mnuexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void mnuundo_Click(object sender, EventArgs e)
        {
            NewRichTextBox().Undo();
        }

        private void mnuredo_Click(object sender, EventArgs e)
        {
            NewRichTextBox().Redo();

        }

        private void mnucopy_Click(object sender, EventArgs e)
        {
            NewRichTextBox().Copy();
        }

        private void mnucut_Click(object sender, EventArgs e)
        {
            NewRichTextBox().Cut();

        }

        private void mnuPaste_Click(object sender, EventArgs e)
        {
            NewRichTextBox().Paste();
        }

        private void frmDocument_Load(object sender, EventArgs e)
        {
            lblfind.Visible = false;
            lblreplace.Visible = false;
            txtfind.Visible = false;
            txtreplace.Visible = false;
            btnfind.Visible = false;
            btnreplace.Visible = false;
            chboAutogenerate.Visible = false;

            this.Text = frmloginForm.username;
            RichTextBox rt = new RichTextBox();
            TabPage newpage = new TabPage("Untitled" + noofTags);
            tabdisplay.TabPages.Add(newpage);
            tabdisplay.SelectTab(noofTags - 1);
            tabdisplay.SelectedTab.Controls.Add(rt);
            rt.AcceptsTab = true;
            rt.Dock = DockStyle.Fill;
            rt.BackColor = Color.White;
            rt.ForeColor = Color.Black;
            rt.Multiline = true;
            rt.Font = new Font(this.Font.FontFamily, this.FontHeight + 1, FontStyle.Regular);
            richTextBox1.Hide();
            foreach (FontFamily font in FontFamily .Families )
            {
                CBOfONTSTYLE.Items.Add(font.Name.ToString());
            }
        }

        private void tabdisplay_DrawItem(object sender, DrawItemEventArgs e)
        {

        }

        private void mnunew_Click(object sender, EventArgs e)
        {
            try
            {
                richTextBox1.Hide();
                RichTextBox rt = new RichTextBox();
                noofTags = noofTags + 1;
                TabPage newpage = new TabPage("Untitled" + noofTags);
                tabdisplay.TabPages.Add(newpage);
                tabdisplay.SelectTab(noofTags - 1);
                tabdisplay.SelectedTab.Controls.Add(rt);
                rt.AcceptsTab = true;
                rt.Dock = DockStyle.Fill;
                rt.BackColor = Color.White;
                rt.ForeColor = Color.Black;
                rt.Multiline = true;
                rt.Font = new Font(this.Font.FontFamily, this.FontHeight + 1, FontStyle.Regular);
            }
            catch (ArgumentOutOfRangeException ex)
            {

                MessageBox.Show("Null Page", "", MessageBoxButtons .OK ,MessageBoxIcon .Error );
                this.Hide();
                frmDocument ff = new frmDocument();
                ff.ShowDialog();
            }
        }

        private void mnufile_Click(object sender, EventArgs e)
        {

        }

        private void mnuclose_Click(object sender, EventArgs e)
        {
            try
            {
                 MessageBox.Show("Are you sure, you want to close this file?", "Close", MessageBoxButtons.OK, MessageBoxIcon.Information);
            TabPage ct = tabdisplay .SelectedTab ;
            tabdisplay .TabPages .Remove(ct);
            }
            catch (ArgumentNullException ex)
            {

                MessageBox.Show(ex.Message);
                MessageBox.Show("Null out of Range", "Close all", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            

        }

        private void mnuopen_Click(object sender, EventArgs e)
        {
            Stream mystream;
            OpenFileDialog open = new OpenFileDialog();
            RichTextBox rtb = new RichTextBox();
            if (open .ShowDialog () == System.Windows.Forms.DialogResult .OK )
            {
                if ((mystream = open.OpenFile()) != null )
                {
                    string firstname = open.FileName;
                    string filetext = File.ReadAllText(firstname);
                    NewRichTextBox().Text = filetext;
                    tabdisplay.SelectedTab.Text = Path.GetFileName(ofdopen.FileName);
                }
            }
        }

        private void mnusave_Click(object sender, EventArgs e)
        {
            if (File.Exists (tabdisplay .SelectedTab .Text))
            {
                StreamWriter sw = new StreamWriter(tabdisplay.SelectedTab.Text);
                sw.WriteLine(tabdisplay.SelectedTab.Text);
                sw.Close();
            }
            else
            {
                sfd.Title = "Save file Page..";
                sfd.Filter = ".txt|*.txt|.docx|*.docx";
                sfd.ShowDialog();
                String filename;
                String filelocation;
                filename = sfd.Title;
                sfd.InitialDirectory = Directory.GetCurrentDirectory();
                filelocation = sfd.InitialDirectory;
                StreamWriter sw = new StreamWriter(filename);
                sw.Write(NewRichTextBox().Text);
                sw.Close();
                tabdisplay.SelectedTab.Text = filename;
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            string pattern = "";
            string[] keywords =
            {
                "bool","int","string","class","public","foreach","private","void","new"
            };
            foreach (var item in keywords)
            {
                pattern += item + "|";
            }
            Regex R = new Regex(pattern);
            int index = richTextBox1.SelectionStart;
            foreach (Match m in R.Matches(richTextBox1 .Text ))
            {
                richTextBox1 .Select ( m.Index, m.Value.Length);
                richTextBox1 .SelectionColor =Color .Blue ;
                richTextBox1 .SelectionStart = index;

            }
            richTextBox1.SelectionColor = Color .Black ;
        }

        private void cToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Show();
            RichTextBox rt = new RichTextBox();
            tabdisplay.SelectedTab.Controls.Add(rt);
            rt.AcceptsTab = true;
            rt.Dock = DockStyle.Fill;
            rt.BackColor = Color.White;
            rt.ForeColor = Color.Black;
            rt.Multiline = true;
            rt.Font = new Font(this.Font.FontFamily, this.FontHeight + 1, FontStyle.Regular);
            chboAutogenerate.Visible = true;
        }

        private void findAndReplaceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lblfind.Visible = true;
            lblreplace.Visible = true;
            txtfind.Visible = true;
            txtreplace.Visible = true;
            btnfind.Visible = true;
            btnreplace.Visible = true;
        }

        private void richTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            String s = e.KeyChar.ToString();
            int ss = richTextBox1.SelectionStart;
            if (chboAutogenerate.Checked == true)
            {
                switch (s)
                {
                    case "(": richTextBox1.Text = richTextBox1.Text.Insert(ss, "()");
                        e.Handled = true;
                        richTextBox1.SelectionStart = ss + 1;
                        break;

                    case "{":
                        String st = "{}";
                        richTextBox1.Text = richTextBox1.Text.Insert(ss, st);
                        e.Handled = true;
                        richTextBox1.SelectionStart = ss + st.Length - 1;
                        conkey = true;
                        break;

                    case "[":
                        String tt = "[]";
                        richTextBox1.Text = richTextBox1.Text.Insert(ss, tt);
                        e.Handled = true;
                        richTextBox1.SelectionStart = ss + tt.Length - 1;
                        conkey = true;
                        break;

                    case "<": richTextBox1.Text = richTextBox1.Text.Insert(ss, "<>");
                        e.Handled = true;
                        richTextBox1.SelectionStart = ss + 1;
                        break;

                    case "\"": richTextBox1.Text = richTextBox1.Text.Insert(ss, "\"\"");
                        e.Handled = true;
                        richTextBox1.SelectionStart = ss + 1;
                        break;

                    case "'": richTextBox1.Text = richTextBox1.Text.Insert(ss, "''");
                        e.Handled = true;
                        richTextBox1.SelectionStart = ss + 1;
                        break;
                }
            }
        }

        public bool conkey { get; set; }

        private void btnfind_Click(object sender, EventArgs e)
        {
            clsfindtextsearch cs = new clsfindtextsearch();
            int s = cs.startData;
            int end = richTextBox1.Text.LastIndexOf(txtfind.Text);
            richTextBox1.SelectAll();
            richTextBox1.SelectionBackColor = Color.White;
            if (txtfind .Text =="")
            {
                MessageBox.Show("Please enter to find data"); 
            }
            else if (richTextBox1 .Text =="")
            {
                MessageBox.Show("Null data in Richtextbox"); 
            }
            else
            {
                while (s <= end)
                {
                    richTextBox1.Find(txtfind.Text, s, richTextBox1.TextLength, RichTextBoxFinds.MatchCase);
                    richTextBox1.SelectionBackColor = Color.Yellow;
                    s = richTextBox1.Text.IndexOf(txtfind.Text, s) + 1;

                }
            }
        }

        private void btnreplace_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectAll();
            richTextBox1.SelectionBackColor = Color.Yellow;
            try
            {
                string find = txtfind.Text.Trim();
                string replace = txtreplace.Text.Trim();    
                if ( replace == "")
                {
                    MessageBox.Show("Please enter Replace data");
                }
                else if (find == "")
                {
                    MessageBox.Show("Please enter find data");
                }
                else
                {
                    string newtext = richTextBox1.Text.Replace(find, replace);
                    richTextBox1.Text = newtext;
                }
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {

        }

        private void cbofontstyle_Click(object sender, EventArgs e)
        {

        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {
            try
            {
                richTextBox1.Font = new Font(CBOfONTSTYLE.Text, richTextBox1.Font.Size);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CBOfONTSTYLE_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void cbofontsize_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                richTextBox1.Font = new Font(CBOfONTSTYLE.Font.FontFamily, float.Parse(cbofontsize.SelectedItem.ToString()));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void newToolStripButton_Click(object sender, EventArgs e)
        {

        }
                }
            }

