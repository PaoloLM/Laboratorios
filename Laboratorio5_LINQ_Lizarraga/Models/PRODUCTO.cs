namespace Laboratorio5_LINQ_Lizarraga.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using System.Linq;

    [Table("PRODUCTO")]
    public partial class PRODUCTO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PRODUCTO()
        {
            DETALLE_PEDIDO = new HashSet<DETALLE_PEDIDO>();
        }

        [Key]
        public int IDPRODUCTO { get; set; }

        public int IDCATEGORIA { get; set; }

        [Required]
        [StringLength(20)]
        public string NOMBRE { get; set; }

        [StringLength(50)]
        public string DESCRIPCION { get; set; }

        public int PRECIO { get; set; }

        public int STOCK { get; set; }

        [Required]
        [StringLength(1)]
        public string PORTADA { get; set; }

        public int IMPORTANCIA { get; set; }

        [StringLength(50)]
        public string IMAGEN { get; set; }

        public virtual CATEGORIA CATEGORIA { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DETALLE_PEDIDO> DETALLE_PEDIDO { get; set; }


        /************************** METODOS *************************/
        public List<PRODUCTO> Listar() // retorna objetos
        {
            var productos = new List<PRODUCTO>();

            try
            {
                /******ORIGEN DE DATOS*******/
                using (var db = new ModeloVentas())
                {
                    //Sentencia LINQ
                    productos = db.PRODUCTO
                                    .Include("CATEGORIA")
                                    .ToList();
                }
                /***************************/
            }
            catch (Exception e)
            {
                throw;
            }

            return productos;
        }


        public List<PRODUCTO> ConsultaWhere() // retorna objetos
        {
            var productos = new List<PRODUCTO>();

            try
            {
                /******ORIGEN DE DATOS*******/
                using (var db = new ModeloVentas())
                {
                    //Sentencia LINQ
                    productos = db.PRODUCTO                                    
                                    .Where(x => x.NOMBRE.StartsWith("m"))
                                    .ToList();
                }
                /***************************/
            }
            catch (Exception e)
            {
                throw;
            }

            return productos;
        }

        public List<PRODUCTO> ConsultaWhere2() // retorna objetos
        {
            var productos = new List<PRODUCTO>();

            try
            {
                /******ORIGEN DE DATOS*******/
                using (var db = new ModeloVentas())
                {
                    //Sentencia LINQ
                    productos = db.PRODUCTO
                                    .Include("CATEGORIA")
                                    .Where(x => x.NOMBRE.Contains("m") && x.PRECIO <= 600)
                                    .ToList();
                }
                /***************************/
            }
            catch (Exception e)
            {
                throw;
            }

            return productos;
        }

        public List<PRODUCTO> BuscarProductoPorCategoria(string buscar) // retorna objetos
        {
            var productos = new List<PRODUCTO>();

            try
            {
                /******ORIGEN DE DATOS*******/
                using (var db = new ModeloVentas())
                {
                    //Sentencia LINQ
                    productos = db.PRODUCTO
                                    .Include("CATEGORIA")
                                    .Where(x => x.NOMBRE.Contains(buscar) 
                                            || x.CATEGORIA.NOMBRE.Contains(buscar))                                    
                                    .ToList();
                }
                /***************************/
            }
            catch (Exception e)
            {
                throw;
            }

            return productos;
        }

        public List<PRODUCTO> Ordenado() // retorna objetos
        {
            var productos = new List<PRODUCTO>();
            string txtresultado = "";

            try
            {
                /******ORIGEN DE DATOS*******/
                using (var db = new ModeloVentas())
                {
                    //Sentencia LINQ
                    productos = db.PRODUCTO
                                    .Include("CATEGORIA")
                                    .OrderByDescending(x => x.NOMBRE)
                                    .ToList();
                }
                /***************************/
            }
            catch (Exception e)
            {
                throw;
            }

            return productos;
        }
    }
}
