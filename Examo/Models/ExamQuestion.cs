namespace Examo.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("ExamQuestion")]
    public class ExamQuestion
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ExamQuestion()
        {
            StudentAnswers = new HashSet<StudentAnswer>();
        }

        [Column(TypeName = "numeric")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal Id { get; set; }

        [Column(TypeName = "numeric")]
        public decimal QuestionId { get; set; }

        public Guid PublicId { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? QuestionSetId { get; set; }

        public virtual Question Question { get; set; }

        public virtual QuestionSet QuestionSet { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<StudentAnswer> StudentAnswers { get; set; }
    }
}
