using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeduShop.Model.Model
{
    [Table("MenuGroups")]
    public class MenuGroup
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]//ID tu tang
        public int ID { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        //Quan he voi tu khoa ngoai tai bang Menu
        public virtual IEnumerable<Menu> Menus { get; set; }
    }
}