using System.ComponentModel;

namespace CarsDealer.Models
{
    public class Car
    {
        [DisplayName("Numer")]
        public int Id { get; set; }

        [DisplayName("Marka")]
        public string Make { get; set; }

        [DisplayName("Model")]
        public string Model { get; set; }

        [DisplayName("Rok Produkcji")]
        public int Year { get; set; }

        [DisplayName("Kilometry")]
        public string Mileage { get; set; }

        [DisplayName("Pojemność silnika")]
        public string EngineSize { get; set; }

        [DisplayName("Rodzaj Paliwa")]
        public string FuelType { get; set; }

        [DisplayName("Moc silnika")]
        public string Power { get; set; }

        [DisplayName("Opis")]
        public string Description { get; set; }

        [DisplayName("Cena PLN")]
        public decimal Price { get; set; }

        [DisplayName("Zdjęcie")]
        public string PhotoUrl { get; set; }

        [DisplayName("Mini Zdjęcie")]
        public string MiniPhotoUrl { get; set; }

        [DisplayName("Czy jest u Dealera?")]
        public bool Dealer { get; set; }

        [DisplayName("Typ Pojazdu")]
        public CarType CarType { get; set; }

        [DisplayName("Id Typu Pojazdu")]
        public int CarTypeId { get; set; }
    }
}
