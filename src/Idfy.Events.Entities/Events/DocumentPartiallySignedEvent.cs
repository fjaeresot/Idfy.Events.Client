﻿namespace Idfy.Events.Entities.Events
{
    public class DocumentPartiallySignedEvent : Event<DocumentPartiallySignedPayload>
    {
        public DocumentPartiallySignedEvent(DocumentPartiallySignedPayload payload) : base(EventType.DocumentPartiallySigned, payload)
        {
        }
    }
}