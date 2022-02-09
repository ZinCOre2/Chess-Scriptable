using UnityEngine;

[CreateAssetMenu(fileName = "Chess Piece Instance", menuName = "Chess/Piece Instance", order = 0)]
public class ChessPieceInstance : ScriptableObject
{
    [SerializeField] private string id;
    [SerializeField] private ChessPieceType chessPieceType;
    [Range(0, 7)] [SerializeField] private int x;
    [Range(0, 7)] [SerializeField] private int y;

    public string ID => id;
    public ChessPieceType PieceType => chessPieceType;
    public int X => x;
    public int Y => y;
}
