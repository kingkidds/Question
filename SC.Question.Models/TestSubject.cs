using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SC.Question.Models
{
    [Table("TestType", Schema = "TestType")]
    public class TestSubject
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int TestSubjectId { get; set; }
        //public string TestSubjectNo { get; set; }
        [Required,MaxLength(500)]
        public string TestSubjectTitle { get; set; }
        [Required,Range(1,100)]
        public int TestSubjectScore { get; set; }
        [Required]
        public TestSubjectType TestSubjectType { get; set; }
        public DateTime CreateTime { get; set; }
        public DateTime? DisableTime { get; set; }
        public bool IsDisable { get; set; }
        [Required,MaxLength(1000)]
        public string ContentDetail { get; set; }
        [Required,MaxLength(10)]
        public string ContentCorrectResult { get; set; }

        public Guid TestTypeId { get; set; }

    }
}