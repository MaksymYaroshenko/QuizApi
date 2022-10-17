using DAL.DbConnection;
using DAL.Interfaces;
using DAL.Models;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repositories.Participants
{
    public class ParticipantRepository : IParticipantRepository
    {

        private readonly QuizDatabaseContext _db;

        public ParticipantRepository(QuizDatabaseContext db)
        {
            _db = db;
        }

        public async Task<Participant> GetOrCreateParticipant(Participant participant)
        {
            var temp = await _db.Participants.FirstOrDefaultAsync(x => x.Name == participant.Name && x.Email == participant.Email);

            if (temp == null)
            {
                _db.Participants.Add(participant);
                await _db.SaveChangesAsync();
            }
            else
                participant = temp;

            return participant;
        }

        public async Task UpdateParticipantResult(int id, ParticipantResult result)
        {
            var participant = await _db.Participants.FindAsync(id);
            if (participant != null)
            {
                participant.Score = result.Score;
                participant.TimeTaken = result.TimeTaken;
                _db.Entry(participant).State = EntityState.Modified;
                try
                {
                    await _db.SaveChangesAsync();
                }
                catch
                {
                    throw;
                }
            }
            else
                throw new ArgumentNullException("id");
        }
    }
}
