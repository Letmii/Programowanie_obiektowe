using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }
    }

    public class UsersContext : DbContext
    {
        public DbSet<UserLogin> UserLogins { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
        public DbSet<Film> Films { get; set; }
        public DbSet<Place> Places { get; set; }
    }

    public class UserLogin
    {
        [Key]
        public long Id { get; set; }
        [Required()]
        public string UserName { get; set; }
        [Required()]
        public string Password { get; set; }
        [Required()]
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public int PhoneNumber { get; set; }
        
    }

    public class Reservation
    {
        [Key]
        public long ReservationId { get; set; }
        public long Id { get; set; }
        [ForeignKey("Id")]
        public string ReservationDate { get; set; }
        public UserLogin UserLogin { get; set; }

    }

    public class Film
    {
        [Key]
        public long FilmId { get; set; }
        public long Id { get; set; }
        public string Title { get; set; }
        public string Genre { get; set; }
        public string Director { get; set; }

    }

    public class Place
    {
        [Key]
        public long PlaceId { get; set; }
        public string Cinema { get; set; }
    }
    
}