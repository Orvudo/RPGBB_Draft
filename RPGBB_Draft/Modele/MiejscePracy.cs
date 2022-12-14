namespace RPGBB_Draft.Modele;

public class MiejscePracy : IRola
{
	public Budynek Budynek { get; set; }
	Ludek IRola.Ludek {
		get => throw new NotImplementedException();
		set => throw new NotImplementedException();
	}
}