partial class Form1
{
    private System.ComponentModel.IContainer components = null;

    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
        this.components = new System.ComponentModel.Container();
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(800, 450);
        this.Text = "Seans Takip Uygulaması";

        // Film adı için label
        Label lblFilmAdi = new Label();
        lblFilmAdi.Location = new System.Drawing.Point(20, 20);
        lblFilmAdi.Size = new System.Drawing.Size(100, 23);
        lblFilmAdi.Text = "Film Adı:";
        this.Controls.Add(lblFilmAdi);

        // Film adı için textBox
        TextBox txtFilmAdi = new TextBox();
        txtFilmAdi.Location = new System.Drawing.Point(130, 20);
        txtFilmAdi.Size = new System.Drawing.Size(150, 23);
        this.Controls.Add(txtFilmAdi);

        // Film ekleme butonu
        Button btnFilmEkle = new Button();
        btnFilmEkle.Location = new System.Drawing.Point(300, 20);
        btnFilmEkle.Size = new System.Drawing.Size(100, 23);
        btnFilmEkle.Text = "Film Ekle";
        btnFilmEkle.Click += new System.EventHandler(this.btnFilmEkle_Click);
        this.Controls.Add(btnFilmEkle);

        // Salon adı için label
        Label lblSalonAdi = new Label();
        lblSalonAdi.Location = new System.Drawing.Point(20, 60);
        lblSalonAdi.Size = new System.Drawing.Size(100, 23);
        lblSalonAdi.Text = "Salon Adı:";
        this.Controls.Add(lblSalonAdi);

        // Salon adı için textBox
        TextBox txtSalonAdi = new TextBox();
        txtSalonAdi.Location = new System.Drawing.Point(130, 60);
        txtSalonAdi.Size = new System.Drawing.Size(150, 23);
        this.Controls.Add(txtSalonAdi);

        // Salon koltuk kapasitesi için label
        Label lblKoltukKapasitesi = new Label();
        lblKoltukKapasitesi.Location = new System.Drawing.Point(20, 100);
        lblKoltukKapasitesi.Size = new System.Drawing.Size(110, 23);
        lblKoltukKapasitesi.Text = "Koltuk Kapasitesi:";
        this.Controls.Add(lblKoltukKapasitesi);

        // Salon koltuk kapasitesi için textBox
        TextBox txtKoltukKapasitesi = new TextBox();
        txtKoltukKapasitesi.Location = new System.Drawing.Point(130, 100);
        txtKoltukKapasitesi.Size = new System.Drawing.Size(150, 23);
        this.Controls.Add(txtKoltukKapasitesi);

        // Salon ekleme butonu
        Button btnSalonEkle = new Button();
        btnSalonEkle.Location = new System.Drawing.Point(300, 60);
        btnSalonEkle.Size = new System.Drawing.Size(100, 23);
        btnSalonEkle.Text = "Salon Ekle";
        btnSalonEkle.Click += new System.EventHandler(this.btnSalonEkle_Click);
        this.Controls.Add(btnSalonEkle);

        // Seansları gösteren DataGridView
        DataGridView dataGridViewSeanslar = new DataGridView();
        dataGridViewSeanslar.Location = new System.Drawing.Point(20, 140);
        dataGridViewSeanslar.Size = new System.Drawing.Size(760, 300);
        this.Controls.Add(dataGridViewSeanslar);
    }
}
