﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examples.Notification
{
    public class EmailNotification : INotification
    {
        public string Send(string message)
        {
            return message;
        }
    }
}