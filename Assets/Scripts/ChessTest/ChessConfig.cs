using System.Linq;
using UnityEngine;


[CreateAssetMenu(fileName = "Chess Config", menuName = "Chess/Chess Config", order = 0)]
public class ChessConfig : ScriptableObject
{
    [SerializeField] private ChessTeamGroup[] teams;

    public string[] GetTeamsIds()
    {
        return teams.Select(s => s.ID).ToArray();
    }

    public string[] GetPiecesIds(string teamId)
    {
        var team = teams.FirstOrDefault(s => s.ID == teamId);
        return team == null ? null : team.GetIds();
    }

    public ChessPieceInstance GetPieceInfo(string id)
    {
        foreach (var team in teams)
        {
            var piece = team.GetPieceInfo(id);
            if (piece != null)
            {
                return piece;
            }
        }

        return null;
    }
}
