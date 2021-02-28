using NotificationDemo.IService;
using NotificationDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NotificationDemo.Service
{
    public class NotiService : INotiService
    {
        public List<Noti> GetNotification(int nToUserId, bool bIsGetOnlyUnread)
        {
            throw new NotImplementedException();
        }
    }
}
