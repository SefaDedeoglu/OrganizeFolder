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

namespace indirilenlerKlasörü
{
    public partial class uygulamaForm : Form
    {
        //@author Sefa DEDEOĞLU
        public uygulamaForm()
        {
            InitializeComponent();
            lblPath.Text = "";
        }
        

        private void btnDosyaYol_Click(object sender, EventArgs e)
        {

            FolderBrowserDialog file = new FolderBrowserDialog();
            List<string> liste = new List<string>();
            DialogResult result = file.ShowDialog();
            string dizin = file.SelectedPath;
            

            if (result == DialogResult.OK)
            {
                update(dizin);
            }
        }
        void update(string dizin)
        {
            lblPath.Text = "";
            dosyalar.Clear();
            dosyalar.View = View.Details;
            dosyalar.GridLines = true;
            dosyalar.Columns.Add("Klasörler", 200);
            dosyalar.FullRowSelect = true;

            files.Clear();
            files.View = View.Details;
            files.GridLines = true;
            files.Columns.Add("Dosya Adı", 200);
            files.Columns.Add("Dosya Uzantısı", 200);
            files.FullRowSelect = true;

            lblPath.Text = dizin;

            string[] dizindekiKlasorler = Directory.GetDirectories(dizin);
            string[] dizindekiDosyalar = Directory.GetFiles(dizin);


            foreach (string i in dizindekiKlasorler)
            {
                string filename = Path.GetFileName(i);
                dosyalar.Items.Add(filename);

            }
            foreach (string i in dizindekiDosyalar)
            {
                string dosyaAdi = Path.GetFileNameWithoutExtension(i);
                string extension = Path.GetExtension(i);
                string[] veri = { dosyaAdi, extension };
                files.Items.Add(new ListViewItem(veri));
            }
        }
        void pdf()
        {
            for (int i = 0; i < files.Items.Count; i++)
            {
                if (files.Items[i].SubItems[1].Text.Equals(".pdf"))
                {
                    Random rnd = new Random();
                    int a = rnd.Next(0, 5555);
                    File.Move(lblPath.Text+"/"+files.Items[i].SubItems[0].Text+ files.Items[i].SubItems[1].Text, lblPath.Text + "/Dosya Düzenleyici/Pdf/"+files.Items[i].SubItems[0].Text+" sc"+a.ToString()+ files.Items[i].SubItems[1].Text);
                }
            }
        }

        void exe()
        {
            for (int i = 0; i < files.Items.Count; i++)
            {
                if (files.Items[i].SubItems[1].Text.Equals(".exe"))
                {
                    Random rnd = new Random();
                    int a = rnd.Next(0, 5555);
                    File.Move(lblPath.Text + "/" + files.Items[i].SubItems[0].Text + files.Items[i].SubItems[1].Text, lblPath.Text + "/Dosya Düzenleyici/Uygulamalar/" + files.Items[i].SubItems[0].Text + " sc" + a.ToString() + files.Items[i].SubItems[1].Text);
                }
            }
        }
        void videos()
        {
            for (int i = 0; i < files.Items.Count; i++)
            {
                string extension = files.Items[i].SubItems[1].Text;
                if (extension.Equals(".webm")|| extension.Equals(".mkv") || extension.Equals(".flv") || extension.Equals(".vob") || extension.Equals(".mng") || extension.Equals(".avi") || extension.Equals(".wmv") || extension.Equals(".mov") || extension.Equals(".mp4") || extension.Equals(".m4v") || extension.Equals(".svi"))
                {
                    Random rnd = new Random();
                    int a = rnd.Next(0, 5555);
                    File.Move(lblPath.Text + "/" + files.Items[i].SubItems[0].Text + files.Items[i].SubItems[1].Text, lblPath.Text + "/Dosya Düzenleyici/Videolar/" + files.Items[i].SubItems[0].Text + " sc" + a.ToString() + files.Items[i].SubItems[1].Text);
                }
            }
        }
        void music()
        {
            for (int i = 0; i < files.Items.Count; i++)
            {
                string extension = files.Items[i].SubItems[1].Text;
                if (extension.Equals(".mp3"))
                {
                    Random rnd = new Random();
                    int a = rnd.Next(0, 5555);
                    File.Move(lblPath.Text + "/" + files.Items[i].SubItems[0].Text + files.Items[i].SubItems[1].Text, lblPath.Text + "/Dosya Düzenleyici/Müzikler/" + files.Items[i].SubItems[0].Text + " sc" + a.ToString() + files.Items[i].SubItems[1].Text);
                }
            }
        }
        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            if (lblPath.Text != "") {
                string path = lblPath.Text;
                Directory.CreateDirectory(path + "/Dosya Düzenleyici");
                Directory.CreateDirectory(path + "/Dosya Düzenleyici/Pdf");
                Directory.CreateDirectory(path + "/Dosya Düzenleyici/Uygulamalar");
                Directory.CreateDirectory(path + "/Dosya Düzenleyici/Videolar");
                Directory.CreateDirectory(path + "/Dosya Düzenleyici/Müzikler");
                pdf();
                exe();
                videos();
                music();
                update(path);
            }
            
        }
    }
}
