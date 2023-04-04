let {TicketsAirWay} = require("./module");

let tickets = new TicketsAirWay();

console.log(tickets.Reservation("NasrCity", "October", 104, 150, "30/3/2023"))
console.log(tickets.Reservation("October", "NasrCity", 200, 150, "30/3/2023"))
console.log(tickets.Reservation("Smart village", "NasrCity", 6, 110, "30/3/2023"))

console.log("////////////////////////////////");

tickets.DisplayAll();

console.log("////////////////////////////////");
tickets.DisplayTicket(1);
console.log("////////////////////////////////");

let newTicket = {
    ticketId: 1,
    From: "Masr el gedida",
    To: "smart village",
    FlightNumber: 423,
    SeatNumber: 18,
    TravellingDate: "1/4/2023"
}


tickets.UpdateTicket(1, newTicket);


console.log("////////////////////////////////");
tickets.DisplayTicket(1);
console.log("////////////////////////////////");
