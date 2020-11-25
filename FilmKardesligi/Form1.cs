using FilmKardesligi.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FilmKardesligi
{
    public partial class Form1 : Form
    {
        FilmKardesligiContext db = new FilmKardesligiContext();
        Film duzenlenen = null;
        public Form1()
        {
            InitializeComponent();
            FilmleriListele();
            TurleriListele();
        }

        private void TurleriListele()
        {
            clbTur.DataSource = db.Turler.OrderBy(x => x.TurAd).ToList();
            clbTur.DisplayMember = "TurAd";
        }

        private void FilmleriListele()
        {
            lstFilmler.DataSource = db.Filmler
                .OrderByDescending(x => x.Puan)
                .ThenBy(x => x.FilmAd)
                .ToList();
        }

        private void tsmiTurler_Click(object sender, EventArgs e)
        {
            TurlerForm frmTurler = new TurlerForm(db);
            frmTurler.DegisiklikYapildi += FrmTurler_DegisiklikYapildi;
            frmTurler.ShowDialog();
        }

        private void FrmTurler_DegisiklikYapildi(object sender, EventArgs e)
        {
            TurleriListele();
            FilmleriListele();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            string filmAd = txtFilmAd.Text.Trim();
            int puan = Convert.ToInt32(gboPuan
                            .Controls.OfType<RadioButton>()
                            .FirstOrDefault(x => x.Checked)
                            .Tag
                        );
            List<Tur> seciliTurler = clbTur.CheckedItems.OfType<Tur>().ToList();

            if (filmAd == "")
            {
                MessageBox.Show("Film adı girmediniz!");
                return;
            }

            if (clbTur.CheckedItems.Count == 0)
            {
                MessageBox.Show("Film için en az bir tür seçmelisiniz!");
                return;
            }

            if (duzenlenen == null)
            {
                #region Film Ekle
                Film film = new Film()
                {
                    FilmAd = filmAd,
                    Puan = puan,
                    Turler = seciliTurler
                };

                //film.Turler = new List<Tur>();
                //foreach (var item in clbTur.CheckedItems)
                //    film.Turler.Add((Tur)item);

                db.Filmler.Add(film);
                #endregion
            }
            else
            {
                #region Film Düzenle
                duzenlenen.FilmAd = filmAd;
                duzenlenen.Puan = puan;
                duzenlenen.Turler = seciliTurler;
                #endregion
            }

            db.SaveChanges();
            FormuResetle();
            FilmleriListele();
        }

        private void FormuTemizle()
        {
            txtFilmAd.Clear();
            clbTur.ClearSelected();
            for (int i = 0; i < clbTur.Items.Count; i++)
            {
                clbTur.SetItemChecked(i, false);
            }
            rbPuan3.Checked = true;
        }

        private void FormuResetle()
        {
            FormuTemizle();
            duzenlenen = null;
            btnIptal.Hide();
            btnEkle.Text = "EKLE";
            lstFilmler.Enabled = btnDuzenle.Enabled = btnSil.Enabled = true;
            txtFilmAd.Focus();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            int sid = lstFilmler.SelectedIndex;
            if (sid < 0)
            {
                MessageBox.Show("Silmek için bir öğe seçmelisiniz.");
                return;
            }

            Film film = (Film)lstFilmler.SelectedItem;

            db.Filmler.Remove(film);
            db.SaveChanges();
            FilmleriListele();
            lstFilmler.SelectedIndex = sid < lstFilmler.Items.Count
                                        ? sid
                                        : lstFilmler.Items.Count - 1;
        }

        
        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            int sid = lstFilmler.SelectedIndex;
            if (sid < 0)
            {
                MessageBox.Show("Düzenlemek için bir öğe seçmelisiniz.");
                return;
            }

            FormuTemizle();

            // DÜZENLEME MODUNA GEÇ
            duzenlenen = (Film)lstFilmler.SelectedItem;
            txtFilmAd.Text = duzenlenen.FilmAd;
            // checkboxları seçtir
            for (int i = 0; i < clbTur.Items.Count; i++)
            {
                Tur tur = (Tur)clbTur.Items[i];

                if (duzenlenen.Turler.Any(x => x.Id == tur.Id))
                {
                    clbTur.SetItemChecked(i, true);
                }
            }
            // dereceyi seçtir
            gboPuan.Controls.OfType<RadioButton>()
                .FirstOrDefault(x => (string)x.Tag == duzenlenen.Puan.ToString())
                .Checked = true;
            btnIptal.Show();
            btnEkle.Text = "KAYDET";
            lstFilmler.Enabled = btnDuzenle.Enabled = btnSil.Enabled = false;
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            FormuResetle();
        }
    }
}
