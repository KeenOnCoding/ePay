using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TestTask.Data.Models
{
    public class Tag
    {
        #region Constructor

        public Tag()
        {
        }

        #endregion Constructor

        #region Properties

        [Key]
        [Required]
        public int Id { get; set; }

        [Required]
        public string UserId { get; set; }

        [Required]
        public string Name { get; set; }

        #endregion Properties

        #region Lazy-Load Properties

        /// <summary>
        /// The quiz author: it will be loaded
        /// on first use thanks to the EF Lazy-Loading feature.
        /// </summary>
        [ForeignKey("UserId")]
        public virtual User User { get; set; }

        #endregion Lazy-Load Properties
    }
}