using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Piece Type", menuName = "Chess/Chess Piece Type", order = 0)]
public class ChessPieceType : ScriptableObject
{
    // [Serializable]
    // public class Moving
    // {
    //     public enum MovingType
    //     {
    //         Set,
    //         Dynamic
    //     };
    //
    //     public MovingType movingType;
    //     public int minHorizMove, maxHorizMove, minVertMove, maxVertMove;
    // }

    [SerializeField] private string typeID;
    [SerializeField] private GameObject prefab;

    public string TypeID => typeID;
    public GameObject Prefab => prefab;
}
