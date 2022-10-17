using DAL.Models;

namespace DAL.Interfaces
{
    public interface IParticipantRepository
    {
        Task UpdateParticipantResult(int id, ParticipantResult result);
        Task<Participant> GetOrCreateParticipant(Participant participant);
    }
}
