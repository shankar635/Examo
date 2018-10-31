namespace Examo.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("ExamType")]
    public class ExamType
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ExamType()
        {
            QuestionSets = new HashSet<QuestionSet>();
        }

        public int Id { get; set; }

        [Required]
        [StringLength(150)]
        public string ExamName { get; set; }

        public Guid GuidValue { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<QuestionSet> QuestionSets { get; set; }
    }
}
