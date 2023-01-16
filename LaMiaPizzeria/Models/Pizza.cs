using System.ComponentModel.DataAnnotations.Schema;

namespace LaMiaPizzeria.Models
{
    public class Pizza
    {

        public int Id { get; set;}
        [Column(TypeName = "varchar(30)")]
        public string Name { get; set;}
        [Column(TypeName = "varchar(200)")]
        public string Description { get; set;}
        [Column(TypeName = "varchar(300)")]
        public string Picture { get; set;}
        public double Price { get; set;}

        public Pizza()
        {

        }

        public Pizza(int id, string name, string description, string picture, double price)
        {
            Id = id;
            Name = name;
            Description = description;
            Picture = picture;
            Price = price;
        }

      
    }
}
