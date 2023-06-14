using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Fishing Pole", fileName = "Fishing Pole")]
public class FishingPoleSO : ScriptableObject
{
    [SerializeField] string poleName = "Beginner Pole";

    // time to catch
    public float minTime = 10;
    public float maxTime = 20;

    // success rate of catching fish
    [SerializeField] float fish1 = 0.50f;
    [SerializeField] float fish2 = 0.10f;
    [SerializeField] float fish3 = 1f;
    [SerializeField] float fish4 = 1f;
}
