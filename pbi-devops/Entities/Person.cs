namespace pbi_devops.Entities;
// Español
public class Person
{
	public long Id { get; set; }
	public string Nombre { get; set; }
	public string Apellidos { get; set; }
	public DateTime FechaNacimiento { get; set; }
	public string Correo { get; set; }
	public int Edad { get; set; }
	public string Pais { get; set; }
	public string Ciudad { get; set; }
	public string Calle { get; set; }
	public string Numero { get; set; }
	// No changes expected for Phone property
	public string Phone { get; set; }
	// No changes expected for PostalCode property
	public string PostalCode { get; set; }
}