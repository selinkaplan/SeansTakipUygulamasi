public class Seans
{
    public int SeansId { get; set; }
    public DateTime TarihSaat { get; set; }
    public int FilmId { get; set; }
    public Film Film { get; set; }
    public int SalonId { get; set; }
    public Salon Salon { get; set; }
}
