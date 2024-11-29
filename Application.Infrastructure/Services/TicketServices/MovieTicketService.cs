﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.Core.Interfaces;

namespace Application.Infrastructure.Services.TicketServices
{
    public class MovieTicketService : ITicketService
    {
        public void CreateNewTicket()
        {
            Console.WriteLine("Creating Movie Ticket....");
        }
    }
}