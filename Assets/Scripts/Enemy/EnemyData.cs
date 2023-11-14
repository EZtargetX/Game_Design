using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Data", menuName = "ScriptableObjects/Enemy", order = 1)]
public class EnemyData : ScriptableObject // This will allow us to hold data we can change
{
    public int hp;
    public int damage;
    public float speed;

    // This data code is a template for now. Later on, it can be added to our different enemy types, though the HP int will most likely not be used
    
}
