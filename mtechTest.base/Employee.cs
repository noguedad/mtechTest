using System;
using System.Collections;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;

namespace mtechTest
{
    public enum EmployeeStatus
    {
        NotSet,
        Active,
        Inactive,
    }

    public class Employee
    {
         
        [Key]
        [DisplayName("ID")]
        public int Id { get; set; }
        
        [DisplayName("Name")]
        [StringLength(50)]
        public string Name { get; set; }
        
        [DisplayName("Last Name")]
        [StringLength(50)]
        public string LastName { get; set; }
        
        [DisplayName("RFC")]
        [RegularExpression(@"[a-zA-Z]{4}[0-9]{6}[a-zA-Z0-9]{3}", 
            ErrorMessage ="RFC is not in the correct format!!")]
        [StringLength(13, MinimumLength =13, ErrorMessage ="RFC is not the correct length!!")]
        [Required]
        public string RFC { get; set; }
        
        [DisplayName("Date of Birth")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString ="{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime BornDate { get; set; }
        
        [DisplayName("Status")]
        public EmployeeStatus Status { get; set; }
    }

    public class EmployeeContext : DbContext 
    { 
        public DbSet<Employee> Employees { get; set; }
    }
}
