namespace TennisBookings.Areas.Admin.Models;

public class CancelBookingConfirmationViewModel
{
	public int BookingId { get; set; }

	public string? MemberName { get; set; }

	public string? CourtName { get; set; }

	public DateTime Date { get; set; }

	public string? StartTime { get; set; }

	public string? EndTime { get; set; }
}
