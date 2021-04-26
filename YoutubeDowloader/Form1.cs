using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;//...
using VideoLibrary;//...
using MediaToolkit;//...
using System.Net;//...

namespace YoutubeDowloader
{
    public partial class Form1 : Form
    {
        public Form1()
        {

            InitializeComponent();
        }


        bool FormatDurum = true;


        private async void btn_Dowland_Click(object sender, EventArgs e)
        {

            //await
            using (FolderBrowserDialog fdb = new FolderBrowserDialog() { Description = "Lütfen İndirmek istediğiniz Klasörü Seçiniz" })
            {
                if (fdb.ShowDialog() == DialogResult.OK)
                {
                    pictureBox2.Visible = true;
                    lbl_durum.Visible = true;
                    lbl_header.Visible = true;
                    BaslıkGetir();

                    var youtube = YouTube.Default;
                    var video = await youtube.GetVideoAsync(txt_Url.Text);
                    File.WriteAllBytes(fdb.SelectedPath + @"\" + video.FullName, await video.GetBytesAsync());

                    var InputFıle = new MediaToolkit.Model.MediaFile { Filename = fdb.SelectedPath + @"\" + video.FullName };
                    var OutputFıle = new MediaToolkit.Model.MediaFile { Filename = $"{fdb.SelectedPath + @"\" + video.FullName}.mp3" };

                    using (var enging = new Engine())
                    {
                        enging.GetMetadata(InputFıle);
                        enging.Convert(InputFıle, OutputFıle);
                    }

                    if (FormatDurum == true)
                    {
                        File.Delete(fdb.SelectedPath + @"\" + video.FullName);
                    }
                    else
                    {
                        File.Delete($"{fdb.SelectedPath + @"\" + video.FullName}.mp3");
                    }

                    lbl_header.Visible = false;
                    lbl_durum.Visible = false;
                    pictureBox2.Visible = false;
                }
                else
                {
                    MessageBox.Show("Lütfen Bir Dosya Yolunu Seçin", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }

        }

        public void BaslıkGetir()
        {

            WebRequest istek = HttpWebRequest.Create(txt_Url.Text);
            WebResponse yanıt;
            yanıt = istek.GetResponse();
            StreamReader bilgiler = new StreamReader(yanıt.GetResponseStream());
            string gelen = bilgiler.ReadToEnd();
            int baslangıc = gelen.IndexOf("<title>") + 7;
            int bitis = gelen.Substring(baslangıc).IndexOf("</title>");
            string gelenbilgiler = gelen.Substring(baslangıc, bitis);
            lbl_header.Text = (gelenbilgiler);

        }

        private void Btn_Close_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Uygulamayı Beğendiyseniz \n Bunun Gibi Ücretsiz Uygulamaları  Youtube Yada İnstagram Hesabımızı Takip Ederek İndirebilirsiniz -YouTube/Angry Eye- -İnstagram/AngryEyeDesigns-","Uygulamamızı Beğendinizmi",MessageBoxButtons.OK);
            Application.Exit();
        }

        private void btn_Alt_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void radioButtonMp4_CheckedChanged(object sender, EventArgs e)
        {
            FormatDurum = false;
        }

        private void radioButtonMp3_CheckedChanged(object sender, EventArgs e)
        {
            FormatDurum = true;
        }

        private void btn_Youtube_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.youtube.com/channel/UCF9-MdUUG7V9ulI96PVolVA?view_as=subscriber");
        }

        private void btn_instagram_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.instagram.com/angry.eye.designs/");
        }
    }
}
