class TicketsAirWay{
    tickets = [] ;
    id = 0 ;
    
    DisplayAll() {
        for (let ticket of this.tickets) {
            console.log(ticket);
        }
    }

    DisplayTicket(searchId){
        for (let ticket of this.tickets){
            if(ticket.ticketId===searchId){
                console.log(ticket);
                break;
            }
        }
    }

    Reservation(From,To,FlightNumber,SeatNumber,TravellingDate){
        let ticketId = ++(this.id);
        let newTicket = {ticketId , From , To , FlightNumber , SeatNumber , TravellingDate }
        this.tickets.push(newTicket);

        return "Your Ticket Id is: "+ this.id;
    }

    UpdateTicket(Id , newTicket){
        for(let i=0 ; i< this.tickets.length; i++){
            if(this.tickets[i].ticketId === Id){
                this.tickets[i] = newTicket;
                console.log("Your Ticket with Id " + Id + " Updated Successfully!");
                return;
            }
        }
    }
}


module.exports = {
    TicketsAirWay
}