using System;

namespace TamrinInterface
{
    public interface IAlert
    {
        Guid AddAlert(DateTime time);

        DateTime GetAlert(Guid id);
    }
}
