using HotelZafiro.Models;
using Microsoft.EntityFrameworkCore;

namespace HotelZafiro.DatosDB
{
    public class HotelContext : DbContext
    {
        //CREAMOS LAS TABLAS
        public DbSet<PersonaModel> Persona { get; set; }
        public DbSet<ProductoModel> Producto { get; set; }
        public DbSet<ProductoModel> Habitacion { get; set; }
        public DbSet<TipoPersonaModel> Tipo { get; set; }

        //CREAMOS UN CONSTRUCTOR
        public HotelContext(DbContextOptions<HotelContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //SEMBRAMOS DATOS DE PERSONA 

            var PersonaModel = new PersonaModel();
            PersonaModel.Id = Guid.NewGuid().ToString();
            PersonaModel.Nombre = "Johan";
            PersonaModel.Apellido = "Hidrobo";
            PersonaModel.Correo = "diegohidrobo11@gmail.com";
            PersonaModel.Clave = "123";
            PersonaModel.FechaCreacion = "29/06/2023";
            modelBuilder.Entity<PersonaModel>().HasData(PersonaModel);


            //SEMBRAMOS DATOS DEL PRODUCTO

            var listaProducto = new List<ProductoModel>()
            {
                new ProductoModel
                {
                   Id = Guid.NewGuid().ToString(),
                   Nombre = "Agua",
                   Detalle = "250ml",
                   Precio = 5,
                   Cantidad = 20,
                   Estado = "True"
                },

                new ProductoModel
                {
                   Id = Guid.NewGuid().ToString(),
                   Nombre = "Cigarrillos",
                   Detalle = "Lark",
                   Precio = 0.50,
                   Cantidad = 75,
                   Estado = "True"
                },

            };
            //sembaramos datos de la habitacion
            var listaHabitacion = new List<HabitacionModel>()
            {
                new HabitacionModel
                {
                   Id = Guid.NewGuid().ToString(),
                  
                   Detalle = "solo para uno",
                   categoria = "Individual",
                   precio = 50,
                   
                   
                },

                new HabitacionModel
                {
                  Id = Guid.NewGuid().ToString(),

                   Detalle = "para dos",
                   categoria = "doble",
                   precio = 100,
                },

                new HabitacionModel
                {
                  Id = Guid.NewGuid().ToString(),

                   Detalle = "Habitacion Grande",
                   categoria = "Matrimonial",
                   precio = 150,
                },


            };

            modelBuilder.Entity<ProductoModel>().HasData(listaProducto);
            modelBuilder.Entity<HabitacionModel>().HasData(listaHabitacion);

            //SEMBRAMOS DATOS
            var listaPersonas=CargarTipoPersonas(PersonaModel);

            modelBuilder.Entity<TipoPersonaModel>().HasData(listaPersonas);

        }

        private static List<TipoPersonaModel> CargarTipoPersonas(PersonaModel PersonaModel)
        {
            return new List<TipoPersonaModel>()
            {
                new TipoPersonaModel
                {
                    Id = Guid.NewGuid().ToString(),
                    Descripcion = "administrador",
                    FechaCreacion = "22/06/2023",
                    PersonaId = PersonaModel.Id,
                },
                new TipoPersonaModel
                {
                    Id = Guid.NewGuid().ToString(),
                    Descripcion = "empleado",
                    FechaCreacion = "22/06/2023",
                    PersonaId = PersonaModel.Id,
                }

            };
        }
    }
} 


