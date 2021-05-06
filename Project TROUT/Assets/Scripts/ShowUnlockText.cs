using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowUnlockText : MonoBehaviour
{
    private GameObject unlockText;

    public GameObject[] doors;

    // Start is called before the first frame update
    void Start()
    {
        unlockText = GameObject.FindGameObjectWithTag("UnlockText");
        unlockText.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
        doors = GameObject.FindGameObjectsWithTag("Door");
        for (int i = 0; i < doors.Length; i++)
        {
            if (doors[i].GetComponent<UnlockDoor>().playerNearDoor)
            {
                unlockText.SetActive(true);
            }
            else
            {
                unlockText.SetActive(false);
            }
        }

    }
}
