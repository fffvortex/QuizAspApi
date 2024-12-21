using System.ComponentModel.DataAnnotations;

namespace QuizAPI.Models
{
    public class Participant
    {
        [Key]
        public int ParticipantId { get; set; }

        [MaxLength(50)]
        public string Email { get; set; } = string.Empty;

        [MaxLength(50)]
        public string Name { get; set; }=string.Empty;

        public int Score { get; set; }

        public int TimeTaken { get; set; }

    }
}
