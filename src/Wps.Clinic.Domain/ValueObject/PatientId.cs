﻿namespace Wps.Clinic.Domain.ValueObject
{
    public record PatientId
    {
        public Guid Value { get; set; }
        public PatientId(Guid value)
        {
            Validate(value);
            Value = value;
        }

        private void Validate(Guid value)
        {
            if (value == Guid.Empty)
            {
                throw new ArgumentNullException("ID value is empty");
            }


        }
        public static implicit operator PatientId(Guid value) { return new PatientId(value); }
        public static implicit operator Guid(PatientId value) { return (value.Value); }

    }
}