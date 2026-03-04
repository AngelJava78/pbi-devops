namespace pbi_devops.Entities;
// Français
public class Person
{
	public long Id { get; set; }
	public string Prenom { get; set; }
	public string NomDeFamille { get; set; }
	public DateTime DateDeNaissance { get; set; }
	public string Email { get; set; }
	public int Age { get; set; }
	public string Pays { get; set; }
	public string Ville { get; set; }
	public string Rue { get; set; }
	public string Numero { get; set; }
}