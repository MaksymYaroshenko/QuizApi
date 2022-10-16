using DAL.Models;
using Microsoft.EntityFrameworkCore;

namespace DAL.DbConnection
{
    public class QuizDatabaseContext:DbContext
    {
        public QuizDatabaseContext(DbContextOptions<QuizDatabaseContext> options):base(options) 
        { }

        public DbSet<Question> Questions { get; set; }
        public DbSet<Participant> Participants { get; set; }
        public DbSet<EmailStatistic> EmailStatistics { get; set; }
    }
}
