using System;
using System.Windows.Forms;
using System.Linq;
using Microsoft.EntityFrameworkCore;

public partial class Form1 : Form
{
    private AppDbContext dbContext = new AppDbContext();

    public Form1()
    {
        InitializeComponent();
        InitializeComboBoxesAndDateTimePicker();
        LoadSeanslar();
    }

    private void btnFilmEkle_Click(object sender, EventArgs e)
    {
        var film = new Film { Ad = txtFilmAdi.Text };
        dbContext.Filmler.Add(film);
        dbContext.SaveChanges();
        MessageBox.Show("Film eklendi.");
    }

    private void btnSalonEkle_Click(object sender, EventArgs e)
    {
        if (int.TryParse(txtKoltukKapasitesi.Text, out int koltukKapasitesi))
        {
            var salon = new Salon { Ad = txtSalonAdi.Text, KoltukKapasitesi = koltukKapasitesi };
            dbContext.Salonlar.Add(salon);
            dbContext.SaveChanges();
            MessageBox.Show("Salon eklendi.");
        }
        else
        {
            MessageBox.Show("Lütfen geçerli bir koltuk kapasitesi girin.");
        }
    }

    private void btnSeansEkle_Click(object sender, EventArgs e)
    {
        int filmId = (int)cmbFilmler.SelectedValue;
        int salonId = (int)cmbSalonlar.SelectedValue;
        DateTime tarihSaat = dateTimePickerSeans.Value;

        var seans = new Seans
        {
            FilmId = filmId,
            SalonId = salonId,
            TarihSaat = tarihSaat
        };

        dbContext.Seanslar.Add(seans);
        dbContext.SaveChanges();
        MessageBox.Show("Seans başarıyla eklendi.");
        LoadSeanslar();
    }

    private void LoadSeanslar()
    {
        dataGridViewSeanslar.DataSource = dbContext.Seanslar
            .Include(s => s.Film)
            .Include(s => s.Salon)
            .Select(s => new {
                SeansId = s.SeansId,
                FilmAdi = s.Film.Ad,
                SalonAdi = s.Salon.Ad,
                s.TarihSaat
            }).ToList();
    }

    private void InitializeComboBoxesAndDateTimePicker()
    {
        cmbFilmler.DataSource = dbContext.Filmler.ToList();
        cmbFilmler.DisplayMember = "Ad";
        cmbFilmler.ValueMember = "FilmId";

        cmbSalonlar.DataSource = dbContext.Salonlar.ToList();
        cmbSalonlar.DisplayMember = "Ad";
        cmbSalonlar.ValueMember = "SalonId";

        dateTimePickerSeans.Value = DateTime.Now;
    }

    private void Form1_Load(object sender, EventArgs e)
    {
        InitializeComboBoxesAndDateTimePicker();
        LoadSeanslar();
    }
}
