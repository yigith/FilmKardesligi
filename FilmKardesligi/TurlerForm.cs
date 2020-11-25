using FilmKardesligi.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FilmKardesligi
{
    public partial class TurlerForm : Form
    {
        public event EventHandler DegisiklikYapildi;

        private readonly FilmKardesligiContext db;

        Tur duzenlenen = null;

        public TurlerForm(FilmKardesligiContext context)
        {
            db = context;
            InitializeComponent();
            TurleriListele();
        }

        private void TurleriListele()
        {
            lstTurler.DataSource = db.Turler.OrderBy(x => x.TurAd).ToList();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            string turAd = txtTurAd.Text.Trim();

            if (turAd == "")
            {
                MessageBox.Show("Tür adı girmediniz!");
                return;
            }

            if (duzenlenen == null)
            {
                db.Turler.Add(new Tur()
                {
                    TurAd = turAd
                });
            }
            else
            {
                duzenlenen.TurAd = turAd;
                FormuResetle();
            }
            db.SaveChanges();
            txtTurAd.Clear();
            TurleriListele();
            DegisiklikYapildiginda(EventArgs.Empty);
        }

        private void FormuResetle()
        {
            duzenlenen = null;
            txtTurAd.Clear();
            btnEkle.Text = "EKLE";
            txtTurAd.Width += 106;
            btnIptal.Hide();
            lstTurler.Enabled = btnDuzenle.Enabled = btnSil.Enabled = true;
        }

        protected virtual void DegisiklikYapildiginda(EventArgs args)
        {
            // if (DegisiklikYapildi != null)  DegisiklikYapildi(this, args); 
            DegisiklikYapildi?.Invoke(this, args);
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (lstTurler.SelectedIndex < 0)
            {
                MessageBox.Show("Silmek için önce bir öğe seçmelisiniz.");
                return;
            }

            Tur tur = (Tur)lstTurler.SelectedItem;

            if (tur.Filmler != null && tur.Filmler.Count > 0)
            {
                DialogResult dr = MessageBox.Show("Silmek istediğiniz türde filmler bulunmaktadır. Silme işlemine devam etmek istiyor musunuz?", "Tür Silme Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);

                if (dr != DialogResult.Yes)
                    return;
            }

            // db.Turler.Remove(tur);
            // verdiğim nesne veritabanında var, onu silineceklere ekle
            db.Entry(tur).State = EntityState.Deleted;
            db.SaveChanges();
            TurleriListele();
            DegisiklikYapildiginda(EventArgs.Empty);
        }

        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            if (lstTurler.SelectedIndex < 0)
            {
                MessageBox.Show("Düzenlemek için önce bir öğe seçmelisiniz.");
                return;
            }

            duzenlenen = (Tur)lstTurler.SelectedItem;

            // DÜZENLEME MODUNA GEÇ
            txtTurAd.Text = duzenlenen.TurAd;
            btnEkle.Text = "KAYDET";
            txtTurAd.Width -= 106;
            btnIptal.Show();
            lstTurler.Enabled = btnDuzenle.Enabled = btnSil.Enabled = false;
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            FormuResetle();
        }
    }
}
