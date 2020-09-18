namespace admEstudianteSeguro.Models
{
    using System.Data.Entity;
    public class DataContext : DbContext
    {
        public DataContext() : base("DefaultConnection")
        {

        }

        public System.Data.Entity.DbSet<admEstudianteSeguro.Models.Student> Students { get; set; }
    }
}