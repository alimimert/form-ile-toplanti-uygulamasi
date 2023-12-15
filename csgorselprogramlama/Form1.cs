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

            // Olaylar� tan�mla
            toplanti_olusturan_kisi.TextChanged += toplanti_olusturan_kisi_TextChanged;
            toplanti_olusturan_aciklama.TextChanged += toplanti_olusturan_aciklama_TextChanged;
            toplanti_katilan_isim.TextChanged += toplanti_katilan_isim_TextChanged;
            toplanti_olusturan_takvim.DateChanged += toplanti_olusturan_takvim_DateChanged;
            toplanti_katilan_takvim.DateChanged += toplanti_katilan_takvim_DateChanged;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            Load += Form1_Load;

            // DataGridView s�tunlar�n� tan�mla
            dataGridView1.Columns.Add("Kod", "Toplanti Kodu");
            dataGridView1.Columns.Add("Uye", "�ye");
            dataGridView1.Columns.Add("Aciklama", "A��klama");
            dataGridView1.Columns.Add("OlusturmaTarihi", "Olu�turma Tarihi");
            dataGridView1.Columns.Add("KatilmaTarihi", "Kat�lma Tarihi");

            // Daha �nce kaydedilmi� verileri y�kle
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

                DialogResult result = MessageBox.Show("Se�ili toplant�y� silmek istedi�inizden emin misiniz?", "Toplant� Silme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    // Se�ili toplant�y� sil
                    ToplantiSil(toplantiKodu);

                    // Verileri kaydet
                    VerileriKaydet();
                }
            }
            */
        }

        private void toplanti_olustur_Click(object sender, EventArgs e)
        {
            // Kod olu�tur
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

            // DataGridView'e olu�turan �yeyi ekliyoruz
            dataGridView1.Rows.Add(toplantiKodu, $"Olu�turan ({olusturanKisi})", aciklama, olusturmaTarihi.ToString("dd/MM/yyyy"), ""); // Bo� kat�lma tarihi ekliyoruz

            // Verileri kaydet
            VerileriKaydet();

            // Olu�turulan toplant� kodunu g�ster
            MessageBox.Show($"Toplant� Kodunuz: {toplantiKodu}", "Toplant� Olu�turma", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

                // DataGridView'e kat�lan �yeyi ekliyoruz
                dataGridView1.Rows.Add(toplantiKodu, $"Kat�lan ({katilanIsim})", hedefToplanti.Aciklama, hedefToplanti.OlusturmaTarihi.ToString("dd/MM/yyyy"), katilmaTarihi.ToString("dd/MM/yyyy"));

                // Verileri kaydet
                VerileriKaydet();
            }
            else
            {
                MessageBox.Show("B�yle bir toplant� bulunamad�!");
            }
        }
        private string RandomKodOlustur()
        {
            // Rastgele 3 haneli bir kod olu�tur
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

                if (uyeTipi.StartsWith("Olu�turan"))
                {
                    // Olu�turan ise, sadece ilgili toplant�y� sil
                    Toplanti silinecekToplanti = toplantilar.Find(t => t.Kod == toplantiKodu);
                    if (silinecekToplanti != null)
                    {
                        toplantilar.Remove(silinecekToplanti);
                    }
                }
                else if (uyeTipi.StartsWith("Kat�lan"))
                {
                    // Kat�lan ise, sadece ilgili Katilan'� sil
                    string tarih = selectedRow.Cells["KatilmaTarihi"].Value.ToString();
                    Toplanti silinecekToplanti = toplantilar.Find(t => t.Kod == toplantiKodu);

                    if (silinecekToplanti != null)
                    {
                        // Kat�lan verisini silme, sadece se�ili sat�r� kald�r
                        silinecekToplanti.Katilanlar.RemoveAll(k => k.KatilmaTarihi.ToString("dd/MM/yyyy") == tarih);
                    }
                }

                // DataGridView'den se�ili sat�r� kald�r
                dataGridView1.Rows.Remove(selectedRow);

                // Verileri kaydet
                VerileriKaydet();
            }
            else
            {
                MessageBox.Show("L�tfen silmek istedi�iniz toplant�y� se�in.", "Toplant� Silme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        private void VerileriKaydet()
        {
            // JSON format�nda verileri dosyaya kaydet
            string jsonVeriler = JsonSerializer.Serialize(toplantilar);
            File.WriteAllText(dosyaAdi, jsonVeriler);
        }

        private void VerileriYukle()
        {
            // Daha �nce kaydedilmi� verileri y�kle
            if (File.Exists(dosyaAdi))
            {
                string jsonVeriler = File.ReadAllText(dosyaAdi);
                toplantilar = JsonSerializer.Deserialize<List<Toplanti>>(jsonVeriler);

                // DataGridView'i g�ncelle
                dataGridView1.Rows.Clear();

                foreach (Toplanti toplanti in toplantilar)
                {
                    // Olu�turan �yeyi ekle
                    dataGridView1.Rows.Add(toplanti.Kod, $"Olu�turan ({toplanti.OlusturanKisi})", toplanti.Aciklama, toplanti.OlusturmaTarihi.ToString("dd/MM/yyyy"), "");

                    // Kat�lan �yeleri ekle
                    foreach (Katilan katilan in toplanti.Katilanlar)
                    {
                        dataGridView1.Rows.Add(toplanti.Kod, $"Kat�lan ({katilan.Isim})", toplanti.Aciklama, toplanti.OlusturmaTarihi.ToString("dd/MM/yyyy"), katilan.KatilmaTarihi.ToString("dd/MM/yyyy"));
                    }
                }
            }
        }

        private void silButton_Click_1(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Se�ili toplant�y� silmek istedi�inizden emin misiniz?", "Toplant� Silme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                // Se�ili toplant�y� sil
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