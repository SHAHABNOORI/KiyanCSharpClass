using System;

namespace TamrinInterface
{
    public class AlertService
    {
        public AlertService(IAlert alertDao)
        {
            _storage = alertDao;
        }

        private readonly IAlert _storage;

        public Guid RaiseAlert()
        {
            return _storage.AddAlert(DateTime.Now);
        }

        public DateTime GetAlertTime(Guid id)
        {
            return _storage.GetAlert(id);
        }
    }
}
