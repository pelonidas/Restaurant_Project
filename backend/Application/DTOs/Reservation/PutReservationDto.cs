namespace Application.DTOs.Reservation;

public class PutReservationDto
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public string Date { get; set; }
    public int ReservationTableId { get; set; }
}   