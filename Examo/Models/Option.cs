namespace Examo.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class Option
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Option()
        {
            StudentAnswers = new HashSet<StudentAnswer>();
        }

        [Column(TypeName = "numeric")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal Id { get; set; }

        [StringLength(1050)]
        public string QuestionOption { get; set; }

        public bool? IsImage { get; set; }

        public bool? IsCorrect { get; set; }

        [Column(TypeName = "numeric")]
        public decimal QuestionId { get; set; }

        public Guid PublicId { get; set; }

        public virtual Question Question { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<StudentAnswer> StudentAnswers { get; set; }
    }
}
