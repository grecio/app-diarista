﻿using System;

 namespace Diarista.Infra.Validations.Validations
{
    public partial class Contract
    {
        public Contract AreEquals(Guid val, Guid comparer, string property, string message)
        {
            if (val.ToString() != comparer.ToString())
                AddNotification(property, message);

            return this;
        }

        public Contract AreNotEquals(Guid val, Guid comparer, string property, string message)
        {
            if (val.ToString() == comparer.ToString())
                AddNotification(property, message);

            return this;
        }

        public Contract IsEmpty(Guid val, string property, string message)
        {
            if (val != Guid.Empty)
                AddNotification(property, message);

            return this;
        }

        public Contract IsNotEmpty(Guid val, string property, string message)
        {
            if (val == Guid.Empty)
                AddNotification(property, message);

            return this;
        }
    }
}