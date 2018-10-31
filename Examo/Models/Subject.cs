namespace Examo.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("Subject")]
    public sealed class Subject
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Subject()
        {
            QuestionSets = new HashSet<QuestionSet>();
        }

        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string SubjectName { get; set; }

        public Guid PublicId { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public ICollection<QuestionSet> QuestionSets { get; set; }
    }
}
