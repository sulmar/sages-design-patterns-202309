using FacadePattern.Models;
using FacadePattern.Repositories;
using FacadePattern.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern
{
    public struct TicketParameters
    {
        public string From { get; set; }
        public string To { get; set; }
        public DateTime When { get; set; }
        public byte NumberOfPlaces { get; set; }
        public bool HasDog { get; set; }

        public TicketParameters(string from, string to, DateTime when, byte numberOfPlaces = 1, bool hasDog = false) 
        {
            From = from;
            To = to;
            When = when;
            NumberOfPlaces = numberOfPlaces;
            HasDog = hasDog;
        }
    }

    public interface ITicketService
    {
        Ticket Buy(TicketParameters parameters);
        void Cancel(Ticket ticket);
    }

    public class TicketService : ITicketService
    {
        private IRailwayConnectionRepository railwayConnectionRepository;
        private TicketCalculator ticketCalculator;
        private ReservationService reservationService;
        private PaymentService paymentService;
        private EmailService emailService;

        public TicketService(IRailwayConnectionRepository railwayConnectionRepository, TicketCalculator ticketCalculator, ReservationService reservationService, PaymentService paymentService, EmailService emailService)
        {
            this.railwayConnectionRepository = railwayConnectionRepository;
            this.ticketCalculator = ticketCalculator;
            this.reservationService = reservationService;
            this.paymentService = paymentService;
            this.emailService = emailService;
        }

        public Ticket Buy(TicketParameters parameters)
        {
            RailwayConnection railwayConnection = railwayConnectionRepository.Find(parameters.From, parameters.To, parameters.When);
            decimal price = ticketCalculator.Calculate(railwayConnection, parameters.NumberOfPlaces);
            Reservation reservation = reservationService.MakeReservation(railwayConnection, parameters.NumberOfPlaces);
            Ticket ticket = new Ticket { RailwayConnection = reservation.RailwayConnection, NumberOfPlaces = reservation.NumberOfPlaces, Price = price };
            Payment payment = paymentService.CreateActivePayment(ticket);

            if (payment.IsPaid)
            {
                emailService.Send(ticket);
            }

            return ticket;
        }

        public void Cancel(Ticket ticket)
        {
            throw new NotImplementedException();
        }
    }
}
