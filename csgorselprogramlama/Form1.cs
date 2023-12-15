using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Windows.Forms;

namespace csgorselprogramlama
{
    public partial class Form1 : Form
    {
        private List<Toplanti> toplantilar = new List<Toplanti>();
        private string dosyaAdi = "toplanti_verileri.json";

        public Form1()
        {
            InitializeComponent();

            // Olaylarý tanýmla
            toplanti_olusturan_kisi.TextChanged += toplanti_olusturan_kisi_TextChanged;
            toplanti_olusturan_aciklama.TextChanged += toplanti_olusturan_aciklama_TextChanged;
            toplanti_katilan_isim.TextChanged += toplanti_katilan_isim_TextChanged;
            toplanti_olusturan_takvim.DateChanged += toplanti_olusturan_takvim_DateChanged;
            toplanti_katilan_takvim.DateChanged += toplanti_katilan_takvim_DateChanged;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            Load += Form1_Load;

            // DataGridView sütunlarýný tanýmla
            dataGridView1.Columns.Add("Kod", "Toplanti Kodu");
            dataGridView1.Columns.Add("Uye", "Üye");
            dataGridView1.Columns.Add("Aciklama", "Açýklama");
            dataGridView1.Columns.Add("OlusturmaTarihi", "Oluþturma Tarihi");
            dataGridView1.Columns.Add("KatilmaTarihi", "Katýlma Tarihi");

            // Daha önce kaydedilmiþ verileri yükle
            VerileriYukle();
        }

        private void toplanti_olusturan_kisi_TextChanged(object sender, EventArgs e)
        {

        }

        private void toplanti_olusturan_aciklama_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void toplanti_katilan_isim_TextChanged(object sender, EventArgs e)
        {

        }
        private void toplanti_katilan_kod_TextChanged(object sender, EventArgs e)
        {

        }
        private void toplanti_olusturan_takvim_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void toplanti_katilan_takvim_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            /*if (e.RowIndex >= 0 && e.ColumnIndex == dataGridView1.Columns["Sil"].Index)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                string toplantiKodu = row.Cells["Kod"].Value.ToString();

                DialogResult result = MessageBox.Show("Seçili toplantýyý silmek istediðinizden emin misiniz?", "Toplantý Silme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    // Seçili toplantýyý sil
                    ToplantiSil(toplantiKodu);

                    // Verileri kaydet
                    VerileriKaydet();
                }
            }
            */
        }

        private void toplanti_olustur_Click(object sender, EventArgs e)
        {
            // Kod oluþtur
            string toplantiKodu = RandomKodOlustur();
            string olusturanKisi = toplanti_olusturan_kisi.Text;
            string aciklama = toplanti_olusturan_aciklama.Text;
            DateTime olusturmaTarihi = toplanti_olusturan_takvim.SelectionStart;

            Toplanti yeniToplanti = new Toplanti
            {
                Kod = toplantiKodu,
                OlusturanKisi = olusturanKisi,
                Aciklama = aciklama,
                OlusturmaTarihi = olusturmaTarihi
            };

            toplantilar.Add(yeniToplanti);

            // DataGridView'e oluþturan üyeyi ekliyoruz
            dataGridView1.Rows.Add(toplantiKodu, $"Oluþturan ({olusturanKisi})", aciklama, olusturmaTarihi.ToString("dd/MM/yyyy"), ""); // Boþ katýlma tarihi ekliyoruz

            // Verileri kaydet
            VerileriKaydet();

            // Oluþturulan toplantý kodunu göster
            MessageBox.Show($"Toplantý Kodunuz: {toplantiKodu}", "Toplantý Oluþturma", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void toplantiya_katil_Click(object sender, EventArgs e)
        {
            string toplantiKodu = toplanti_katilan_kod.Text;
            string katilanIsim = toplanti_katilan_isim.Text;
            DateTime katilmaTarihi = toplanti_katilan_takvim.SelectionStart;

            Toplanti hedefToplanti = toplantilar.Find(t => t.Kod == toplantiKodu);

            if (hedefToplanti != null)
            {
                hedefToplanti.Katilanlar.Add(new Katilan
                {
                    Isim = katilanIsim,
                    KatilmaTarihi = katilmaTarihi
                });

                // DataGridView'e katýlan üyeyi ekliyoruz
                dataGridView1.Rows.Add(toplantiKodu, $"Katýlan ({katilanIsim})", hedefToplanti.Aciklama, hedefToplanti.OlusturmaTarihi.ToString("dd/MM/yyyy"), katilmaTarihi.ToString("dd/MM/yyyy"));

                // Verileri kaydet
                VerileriKaydet();
            }
            else
            {
                MessageBox.Show("Böyle bir toplantý bulunamadý!");
            }
        }
        private string RandomKodOlustur()
        {
            // Rastgele 3 haneli bir kod oluþtur
            Random random = new Random();
            int rastgeleKod = random.Next(100, 1000);
            return rastgeleKod.ToString();
        }

        private void ToplantiSil()
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                string toplantiKodu = selectedRow.Cells["Kod"].Value.ToString();
                string uyeTipi = selectedRow.Cells["Uye"].Value.ToString();

                if (uyeTipi.StartsWith("Oluþturan"))
                {
                    // Oluþturan ise, sadece ilgili toplantýyý sil
                    Toplanti silinecekToplanti = toplantilar.Find(t => t.Kod == toplantiKodu);
                    if (silinecekToplanti != null)
                    {
                        toplantilar.Remove(silinecekToplanti);
                    }
                }
                else if (uyeTipi.StartsWith("Katýlan"))
                {
                    // Katýlan ise, sadece ilgili Katilan'ý sil
                    string tarih = selectedRow.Cells["KatilmaTarihi"].Value.ToString();
                    Toplanti silinecekToplanti = toplantilar.Find(t => t.Kod == toplantiKodu);

                    if (silinecekToplanti != null)
                    {
                        // Katýlan verisini silme, sadece seçili satýrý kaldýr
                        silinecekToplanti.Katilanlar.RemoveAll(k => k.KatilmaTarihi.ToString("dd/MM/yyyy") == tarih);
                    }
                }

                // DataGridView'den seçili satýrý kaldýr
                dataGridView1.Rows.Remove(selectedRow);

                // Verileri kaydet
                VerileriKaydet();
            }
            else
            {
                MessageBox.Show("Lütfen silmek istediðiniz toplantýyý seçin.", "Toplantý Silme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        private void VerileriKaydet()
        {
            // JSON formatýnda verileri dosyaya kaydet
            string jsonVeriler = JsonSerializer.Serialize(toplantilar);
            File.WriteAllText(dosyaAdi, jsonVeriler);
        }

        private void VerileriYukle()
        {
            // Daha önce kaydedilmiþ verileri yükle
            if (File.Exists(dosyaAdi))
            {
                string jsonVeriler = File.ReadAllText(dosyaAdi);
                toplantilar = JsonSerializer.Deserialize<List<Toplanti>>(jsonVeriler);

                // DataGridView'i güncelle
                dataGridView1.Rows.Clear();

                foreach (Toplanti toplanti in toplantilar)
                {
                    // Oluþturan üyeyi ekle
                    dataGridView1.Rows.Add(toplanti.Kod, $"Oluþturan ({toplanti.OlusturanKisi})", toplanti.Aciklama, toplanti.OlusturmaTarihi.ToString("dd/MM/yyyy"), "");

                    // Katýlan üyeleri ekle
                    foreach (Katilan katilan in toplanti.Katilanlar)
                    {
                        dataGridView1.Rows.Add(toplanti.Kod, $"Katýlan ({katilan.Isim})", toplanti.Aciklama, toplanti.OlusturmaTarihi.ToString("dd/MM/yyyy"), katilan.KatilmaTarihi.ToString("dd/MM/yyyy"));
                    }
                }
            }
        }

        private void silButton_Click_1(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Seçili toplantýyý silmek istediðinizden emin misiniz?", "Toplantý Silme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                // Seçili toplantýyý sil
                ToplantiSil();

                // Verileri kaydet
                VerileriKaydet();
            }
        }


    }

    public class Toplanti
    {
        public string Kod { get; set; }
        public string OlusturanKisi { get; set; }
        public string Aciklama { get; set; }
        public DateTime OlusturmaTarihi { get; set; }
        public List<Katilan> Katilanlar { get; set; } = new List<Katilan>();
    }

    public class Katilan
    {
        public string Isim { get; set; }
        public DateTime KatilmaTarihi { get; set; }
    }
}