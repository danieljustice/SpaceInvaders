using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Data", menuName = "ScriptAbles/ShotChance", order = 2)]
public class ChanceToShoot : ScriptableObject {
    [Range(0, 1)]
    public float shotPercent = .5f;
}
