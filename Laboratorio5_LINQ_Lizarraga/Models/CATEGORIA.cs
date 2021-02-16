namespace Laboratorio5_LINQ_Lizarraga.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using System.Linq;

    [Table("CATEGORIA")]
    public partial class CATEGORIA
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CATEGORIA()
        {
            PRODUCTO = new HashSet<PRODUCTO>();
        }

        [Key]
        public int IDCATEGORIA { get; set; }

        [StringLength(20)]
        public string NOMBRE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PRODUCTO> PRODUCTO { get; set; }


        /************************** METODOS *************************/
        public List<CATEGORIA> Listar() // retorna objetos
        {
            var categorias = new List<CATEGORIA>();

            try
            {
                /******ORIGEN DE DATOS*******/
                using (var db = new ModeloVentas())
                {
                    //Sentencia LINQ
                    categorias = db.CATEGORIA.ToList();
                }
                /***************************/
            }
            catch (Exception e)
            {
                throw;
            }

            return categorias;
        }

        
        public List<CATEGORIA> ConsultaWhere() // retorna objetos
        {
            var categorias = new List<CATEGORIA>();

            try
            {
                /******ORIGEN DE DATOS*******/
                using (var db = new ModeloVentas())
                {
                    //Sentencia LINQ
                    categorias = db.CATEGORIA                        
                        .Where(x => x.NOMBRE.StartsWith("T"))
                        .ToList();
                }
                /***************************/
            }
            catch (Exception e)
            {
                throw;
            }

            return categorias;
        }
    }
}
