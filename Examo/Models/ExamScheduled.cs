namespace Examo.Models
{
    using System;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("ExamScheduled")]
    public class ExamScheduled
    {
        [Column(TypeName = "numeric")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal Id { get; set; }

        [Column(TypeName = "numeric")]
        public decimal QuestionSetId { get; set; }

        public DateTime ScheduledDateTime { get; set; }

        public int? QuestionValue { get; set; }

        public double? NegativeValue { get; set; }

        public Guid? PublicId { get; set; }

        public virtual QuestionSet QuestionSet { get; set; }
    }
}
