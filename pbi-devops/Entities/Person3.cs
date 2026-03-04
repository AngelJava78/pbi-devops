namespace pbi_devops.Entities;
// English
public class Person3
{
	public long Id { get; set; }
	public string Name { get; set; }
	public string Lastname { get; set; }
	public DateTime BirthDate { get; set; }
	// No changes expected for Gender property
	public string Gender { get; set; }
	public string Email { get; set; }
	public int Age { get; set; }
	public string Country { get; set; }
	public string City { get; set; }
	public string Street { get; set; }
	public string Number { get; set; }
	// No changes expected for Phone property
	public string Phone { get; set; }
	// No changes expected for PostalCode property
	public string PostalCode { get; set; }
}