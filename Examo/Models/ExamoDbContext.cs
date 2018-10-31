namespace Examo.Models
{
    using System.Data.Entity;

    public class ExamoDbContext : DbContext
    {
        public ExamoDbContext()
            : base("name=ExamoDbContext")
        {
        }

        public virtual DbSet<ExamQuestion> ExamQuestions { get; set; }
        public virtual DbSet<ExamScheduled> ExamScheduleds { get; set; }
        public virtual DbSet<ExamType> ExamTypes { get; set; }
        public virtual DbSet<Option> Options { get; set; }
        public virtual DbSet<Question> Questions { get; set; }
        public virtual DbSet<QuestionSet> QuestionSets { get; set; }
        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<StudentAnswer> StudentAnswers { get; set; }
        public virtual DbSet<Subject> Subjects { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ExamQuestion>()
                .Property(e => e.Id)
                .HasPrecision(18, 0);

            modelBuilder.Entity<ExamQuestion>()
                .Property(e => e.QuestionId)
                .HasPrecision(18, 0);

            modelBuilder.Entity<ExamQuestion>()
                .Property(e => e.QuestionSetId)
                .HasPrecision(18, 0);

            modelBuilder.Entity<ExamScheduled>()
                .Property(e => e.Id)
                .HasPrecision(18, 0);

            modelBuilder.Entity<ExamScheduled>()
                .Property(e => e.QuestionSetId)
                .HasPrecision(18, 0);

            modelBuilder.Entity<ExamType>()
                .HasMany(e => e.QuestionSets)
                .WithRequired(e => e.ExamType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Option>()
                .Property(e => e.Id)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Option>()
                .Property(e => e.QuestionId)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Question>()
                .Property(e => e.Id)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Question>()
                .HasMany(e => e.ExamQuestions)
                .WithRequired(e => e.Question)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Question>()
                .HasMany(e => e.Options)
                .WithRequired(e => e.Question)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<QuestionSet>()
                .Property(e => e.Id)
                .HasPrecision(18, 0);

            modelBuilder.Entity<QuestionSet>()
                .HasMany(e => e.ExamScheduleds)
                .WithRequired(e => e.QuestionSet)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Student>()
                .Property(e => e.id)
                .HasPrecision(18, 0);

            modelBuilder.Entity<StudentAnswer>()
                .Property(e => e.Id)
                .HasPrecision(18, 0);

            modelBuilder.Entity<StudentAnswer>()
                .Property(e => e.StudentId)
                .HasPrecision(18, 0);

            modelBuilder.Entity<StudentAnswer>()
                .Property(e => e.ExamQuestionId)
                .HasPrecision(18, 0);

            modelBuilder.Entity<StudentAnswer>()
                .Property(e => e.OptionId)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Subject>()
                .HasMany(e => e.QuestionSets)
                .WithRequired(e => e.Subject)
                .HasForeignKey(e => e.SubjectTypeId)
                .WillCascadeOnDelete(false);
        }
    }
}
