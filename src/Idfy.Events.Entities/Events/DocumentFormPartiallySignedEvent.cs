﻿using System;
using Idfy.Events.Entities.Payloads;

namespace Idfy.Events.Entities.Events
{
    public class DocumentFormPartiallySignedEvent : Event<DocumentFormPartiallySignedPayload>
    {
        public DocumentFormPartiallySignedEvent(DocumentFormPartiallySignedPayload payload, Guid accountId) 
            : base(EventType.DocumentFormPartiallySigned, payload, accountId)
        {
        }
    }
}