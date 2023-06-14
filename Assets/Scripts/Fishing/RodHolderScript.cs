using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RodHolderScript : MonoBehaviour
{
    public GameObject fishingPole;
    bool activate = false;
    bool nearRodHolder = false;
    [SerializeField] RodHolderSO rodHolderSO;
    GameObject newFishingPole;

    //fish timer
    [SerializeField] FishingPoleSO fishingPoleSO;
    float elapsedTime = 0;
    [SerializeField] GameObject fish1;
    [SerializeField] GameObject fish2;
    GameObject newFish1;
    Rigidbody2D newFish1RB;

    //force


    float gravityDelay = 0.5f;
    float landingDelay = 1.2f;

    private void Start()
    {
        rodHolderSO.Reset();
    }

    void Update()
    {



        float timeToCatch = Random.Range(fishingPoleSO.minTime, fishingPoleSO.maxTime);
        Vector2 force = new Vector2(1 * -rodHolderSO.GetDirection(), 0.6f);
        Vector2 gravityForce = new Vector2(0, -0.4f);
        Vector2 landingForce = new Vector2(0.2f * -rodHolderSO.GetDirection(), 0f);

        if (rodHolderSO.isOccupied)
        {
            elapsedTime += Time.deltaTime;

            if (elapsedTime > timeToCatch)
            {
                int typeOfFish = Random.Range(0, 4);
                newFish1 = Instantiate(fish1, transform.GetChild(0).position, Quaternion.identity);

                Vector3 fishDirection = newFish1.transform.localScale;
                fishDirection.x *= -rodHolderSO.GetDirection();
                newFish1.transform.localScale = fishDirection;

                newFish1RB = newFish1.GetComponent<Rigidbody2D>();
                newFish1RB.AddForce(force, ForceMode2D.Impulse);
                elapsedTime = 0;
            }

            if (newFish1RB !=null && elapsedTime > gravityDelay)
            {
                newFish1RB.AddForce(gravityForce, ForceMode2D.Force);
            }


            if (newFish1RB != null && elapsedTime > landingDelay)
            {
                newFish1RB.velocity = new Vector2 (0,0);
                //newFish1RB.AddForce(landingForce, ForceMode2D.Impulse);

            }

        }


        if (Input.GetButtonDown("Fishing") && nearRodHolder && !rodHolderSO.isOccupied) // if the player is colliding with a rod holder, and pressing activate button, and the holder is unoccupied then...
        {


            newFishingPole = Instantiate(fishingPole, transform.position, Quaternion.identity); // generates a fishing pole at the location of the nearest holder
            rodHolderSO.isOccupied = true;

            // switches the sprite to face the water
            Vector3 fishingPoleDirection = newFishingPole.transform.localScale;
            fishingPoleDirection.x *= rodHolderSO.GetDirection();
            newFishingPole.transform.localScale = fishingPoleDirection;

            // adjusts pole position
            Vector3 polePosition = newFishingPole.transform.position;
            polePosition.y += 0.15f;
            polePosition.x += -.4f * -rodHolderSO.GetDirection();
            newFishingPole.transform.position = polePosition;
        }

        if (Input.GetButtonDown("Remove") && nearRodHolder && rodHolderSO.isOccupied) // if the player is colliding with a rod holder, and pressing activate button, and the holder is unoccupied then...
        {
            Destroy(newFishingPole);
            rodHolderSO.isOccupied = false;
        }


    }


    // says that player is near a rod holder
    void OnTriggerEnter2D(Collider2D other)
    {


        if (other.tag == "Player")
        {
            nearRodHolder = true;
        }

    }

    // flags that player is no longer near a rod holder
    void OnTriggerExit2D(Collider2D other)
    {

        if (other.tag == "Player")
        {
            nearRodHolder = false;
        }
    }


}
