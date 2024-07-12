using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EmployeeData.Models.DBEntities
{
    public class Employee
    {

        // An entity in DBMS is a piece of data that is stored in the database. It can be a person, place, thing or
        // even an event. There are strong & weak entity types. Look these up and research!

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] //Makes it to where we do not have to pass any values to ID field
        public int Id { get; set; }

        [Column(TypeName = "varchar(50)")]
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Email { get; set; }
        public double Salary { get; set; }

    }
}
