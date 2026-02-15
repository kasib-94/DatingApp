namespace DatingApp.Api.Entities
{
	public class AppUser
	{
		public int Id {get;set;}
		public required string DisplayName {get;set;}
		public required string Email {get;set;}
	}
}