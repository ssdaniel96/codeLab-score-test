using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeLab.Scoreboard.Domain.Entities
{
    public class Confraternization
    {

        public IReadOnlyCollection<Score> Scores => _scores;
        private List<Score> _scores;

        public Confraternization(List<Score> scores)
        {
            if (!IsValid(scores))
                throw new Exception("O valor para a criação de uma confraternização são 10 scores válidos (não-nulos)");

            _scores = scores;
        }

        private bool IsValid(List<Score> scores) 
            => scores.Count == 10 
            && !scores.Any(s => s == null);
    }
}
