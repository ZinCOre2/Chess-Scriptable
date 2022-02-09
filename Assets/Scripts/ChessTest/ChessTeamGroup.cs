using System.Linq;
using UnityEngine;

[CreateAssetMenu(fileName = "Chess Team Group", menuName = "Chess/Chess Team Group", order = 0)]
public class ChessTeamGroup : ScriptableObject
{
    [SerializeField] private string id;
    [SerializeField] private ChessPieceInstance[] pieces;

    public string ID => id;

    public string[] GetIds()
    {
        return pieces.Select(p => p.ID).ToArray();
    }

    public ChessPieceInstance GetPieceInfo(string pieceId)
    {
        return pieces.FirstOrDefault(p => p.ID == pieceId);
    }
}
