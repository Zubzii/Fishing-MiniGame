using System.Collections;
using System.Collections.Generic;
using System.Xml.Schema;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class FishingPoleScript : MonoBehaviour
{
    public FishingPoleSO fishingPoleSO;

    

    // timer
    float elapsedTime = 0;
    int totalFishCaught= 0;
   

    void Start()
    {
        
    }

    void Update()
    {
        elapsedTime += Time.deltaTime;
        float timeToCatch = Random.Range(fishingPoleSO.minTime, fishingPoleSO.maxTime);



        if (elapsedTime > timeToCatch)
        {
            totalFishCaught++;
            int typeOfFish = Random.Range(0, 4);
            elapsedTime = 0;
        }

        
    }
}
