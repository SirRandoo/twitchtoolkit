using RimWorld;

namespace TwitchToolkit.VotingHelpers.VotingHelpers_Diseases;

public class FluMedium : DiseaseBase
{
	public override bool IsPossible()
	{
		base.IsPossible();
		worker.def = IncidentDef.Named("Disease_Flu");
		parms.points /= 2f;
		return worker.CanFireNow(parms);
	}
}
