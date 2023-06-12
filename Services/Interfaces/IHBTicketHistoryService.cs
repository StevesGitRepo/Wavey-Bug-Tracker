﻿using HotBug.Models;

namespace HotBug.Services.Interfaces
{
    public interface IHBTicketHistoryService
    {
        Task AddHistoryAsync(Ticket oldTicket, Ticket newTicket, string userId);

        //overload
        Task AddHistoryAsync(int ticketId, string model, string userId);

        Task<List<TicketHistory>> GetProjectTicketsHistoriesAsync(int projectId, int companyId);

        Task<List<TicketHistory>> GetCompanyTicketsHistoriesAsync(int companyId);
    }
}
