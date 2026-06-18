using App.Models;
using App.Repositories;
using App.Services.interfaces;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Services
{
    public class CommentService : ICommentService
    {
        private readonly CommentRepository _commentRepo;
        private readonly ILogger<CommentService> _logger;

        public CommentService(CommentRepository commentRepo, ILogger<CommentService> logger)
        {
            _commentRepo = commentRepo;
            _logger = logger;
        }

        public async Task Add(string text, DateTime date, int ticketID, int userId)
        {
            try
            {
                ServiceHelper.CheckFields(text, _logger, "Коментара");

                Comment comment = new Comment
                {
                    Text = text,
                    CreatedDate = date,
                    TicketID = ticketID,
                    UserID = userId
                };

                await _commentRepo.AddAsync(comment);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message + " " + ex.StackTrace);
                throw new Exception("Възникна грешка с добавянето!");
            }
        }
    }
}
