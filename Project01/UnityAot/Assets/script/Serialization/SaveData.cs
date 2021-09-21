using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveData : MonoBehaviour

{
    private static SaveData _current;
    public static SaveData current;

    public PlayerProfile profile;
    public int toyCars;
    public int toyDolls;
}

