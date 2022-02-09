using UnityEngine;

public class ChessBoard : MonoBehaviour
{
    [SerializeField] private ChessConfig chessConfig;
    [Header("Chess Board")]
    [SerializeField] private Transform startPos;
    [SerializeField] private float cellSize = 1f;

    private void Start()
    {
        var teams = chessConfig.GetTeamsIds();
        
        for (var i = 0; i < teams.Length; i++)
        {
            var ids = chessConfig.GetPiecesIds(teams[i]);
            Debug.Log($"Got ids {i}");
            
            for (var j = 0; j < ids.Length; j++)
            {
                ChessPieceInstance piece = chessConfig.GetPieceInfo(ids[j]);
                Instantiate(piece.PieceType.Prefab, 
                    startPos.position + Vector3.right * cellSize * piece.X + Vector3.forward * cellSize * piece.Y, 
                    Quaternion.identity, transform);
                Debug.Log($"Chess piece team {i}, number {j}");
            }
        }
    }
}
