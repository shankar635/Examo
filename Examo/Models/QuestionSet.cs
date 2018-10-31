namespace Examo.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("QuestionSet")]
    public class QuestionSet
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public QuestionSet()
        {
            ExamQuestions = new HashSet<ExamQuestion>();
            ExamScheduleds = new HashSet<ExamScheduled>();
        }

        [Column(TypeName = "numeric")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal Id { get; set; }

        [Required]
        [StringLength(250)]
        public string QuestionSetName { get; set; }

        public int SubjectTypeId { get; set; }

        public int ExamTypeId { get; set; }

        [StringLength(50)]
        public string QuestionSetKey { get; set; }

        public string Description { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ExamQuestion> ExamQuestions { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ExamScheduled> ExamScheduleds { get; set; }

        public virtual ExamType ExamType { get; set; }

        public virtual Subject Subject { get; set; }
    }
}
