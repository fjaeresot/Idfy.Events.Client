﻿using System;
using System.Collections.Generic;

namespace Idfy.Events.Entities.Sign
{
    public class DocumentSignedEvent : BaseDocumentEvent
    {
        public DateTime SignedTimeStamp { get; set; }

        public List<Signer> Signees { get; set; }
    }
}
