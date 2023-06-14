using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;


[CreateAssetMenu(menuName = "Rod Holder", fileName = "Rod Holder")]
public class RodHolderSO : ScriptableObject
{
    [SerializeField] int rodDirection;
    public bool isOccupied = false;

    // % likelihood of fish appearing
    [SerializeField] float fish1 = 0.60f;
    [SerializeField] float fish2 = 0.25f;
    [SerializeField] float fish3 = 0.1f;
    [SerializeField] float fish4 = 0.05f;

    public int GetDirection()
    {
        return rodDirection;
    }

    public bool GetOccupiedStatus()
    {
        return isOccupied;
    }
    public float GetFish1Probability()
    {
        return fish1;
    }
    public float GetFish2Probability()
    {
        return fish2;
    }
    public float GetFish3Probability()
    {
        return fish3;
    }
    
    public float GetFish4Probability()
    {
        return fish4;
    }
    public void Reset()
    {
        isOccupied = false;
        // reset other fields as necessary...
    }
}
