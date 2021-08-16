using System;

namespace CodeLab.Scoreboard.Domain.Entities
{
    public sealed class Score : Entity
    {
        public Employee Penitent { get; private set; }
        public DateTime Date { get; private set; }
        public string Description { get; private set; }
        public bool IsPaid { get; private set; }

        public Score(Employee penitent, DateTime date, string description)
        {
            Validate(penitent, date, description);
            Penitent = penitent;
            Date = date;
            Description = description;
            IsPaid = false;
        }

        private void Validate(Employee penitent, DateTime date, string description)
        {
            if (!IsValidPenitent(penitent))
                throw new Exception("O penitente está invalido");

            if (!IsValidDate(date))
                throw new Exception("A data estar no intervalo de hoje a 1 semana atrás.");

            if (!IsValidDescription(description))
                throw new Exception("A descrição não pode ser nula ou vazia, precisa ter 10 a 250 characteres");
        }

        private bool IsValidPenitent(Employee penitent) => penitent != null;
        private bool IsValidDate(DateTime date)
        {
            return date.Date <= DateTime.Now.Date
                && date.Date >= DateTime.Now.Date.AddDays(-7);
        }

        private bool IsValidDescription(string description)
        {
            return !string.IsNullOrWhiteSpace(description)
                && description.Length >= 10
                && description.Length <= 255;
        }

    }
}
