﻿using System;

namespace Idfy.Events.Entities.Payloads
{
    public class DocumentReadPayload
    {
        public Guid DocumentId { get; set; }
        public Guid SignerId { get; set; }
        public string UserAgent { get; set; }
        public string IpAddress { get; set; }
    }
}