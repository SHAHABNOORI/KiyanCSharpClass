using System;
using System.Collections.Generic;

namespace TamrinInterface
{
    public class Alert : IAlert
    {
        private readonly Dictionary<Guid, DateTime> _alerts = new Dictionary<Guid, DateTime>();

        public Guid AddAlert(DateTime time)
        {
            var id = Guid.NewGuid();
            _alerts.Add(id, time);
            return id;
        }

        public DateTime GetAlert(Guid id)
        {
            return _alerts[id];
        }
    }
}
