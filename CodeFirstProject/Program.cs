using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
    public class Course 
    {
        public int Id { get; set; }
        public  string Name { get; set; }
        public string description { get; set; }
        
       
        public DateTime time { get; set; }
        
    }
    
    public class Tag
    {
        public int Id { get; set; }
        public string Name { get; set; }
       
    }
    public enum CourseLevel
    {
        Beginner=1,
        Intermediate=2,
        Advanced=3,
    }
    public class AplicationDbContext : DbContext
    {
        public DbSet<Course> Courses { get; set; }
        
        
       
        public AplicationDbContext():base("DefaultConnectionString")
        {
            
        }
    }
}
