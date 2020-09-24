using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShotManager : MonoBehaviour
{
    public Shot topSpin;
    public Shot flat;
}

[System.Serializable]
public class Shot
{
    public float upForce;
    public float hitForce;
}