namespace Examo.Models
{
    using System;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("StudentAnswer")]
    public class StudentAnswer
    {
        [Column(TypeName = "numeric")]
        public decimal Id { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? StudentId { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? ExamQuestionId { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? OptionId { get; set; }

        public DateTime? MarkedDateTime { get; set; }

        public virtual ExamQuestion ExamQuestion { get; set; }

        public virtual Option Option { get; set; }

        public virtual Student Student { get; set; }
    }
}
