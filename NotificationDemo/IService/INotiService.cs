using NotificationDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NotificationDemo.IService
{
    public interface INotiService
    {
        List<Noti> GetNotification(int nToUserId, bool bIsGetOnlyUnread);
    }
}
