using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SC.Question.Models
{

    [Table("TestType", Schema = "TestType")]
    public class TestType
    {
        [Key]
        public Guid TypeId { get; set; }
        //public string TypeNo { get; set; }
        [Required,MaxLength(100)]
        public string TypeName { get; set; }
        [Required,Range(1,600)]
        public int TestTimelimit { get; set; }
        [Required,Range(1,600)]
        public int TestSubjectNum { get; set; }
        [Required]
        public int TestPassPoint { get; set; }
        public DateTime CreateTime { get; set; }
        public DateTime? DisableTime { get; set; }
        public bool IsDisable { get; set; }
        public Guid RoleId { get; set; }

        public ICollection<TestSubject> TestSubjects { get; set; }
    }
}
