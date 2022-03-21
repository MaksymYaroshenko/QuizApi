using Microsoft.EntityFrameworkCore;

namespace QuizApi.Models
{
    public class QuizDatabaseContext:DbContext
    {
        public QuizDatabaseContext(DbContextOptions<QuizDatabaseContext> options):base(options) 
        { }

        public DbSet<Question> Questions { get; set; }
        public DbSet<Participant> Participants { get; set; }
    }
}
