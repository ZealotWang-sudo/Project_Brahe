using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportPlayer : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject[] teleportLocation;

    private int currentIndex = 1;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Tab))
        {

            toggleRoomTeleport();
        }

    }

    public void toggleRoomTeleport()
    {

        if (currentIndex < teleportLocation.Length)
        {
            teleportTolocation(currentIndex);
            currentIndex++;
        }
        else
        {
            currentIndex = 0;
        }

    }
    public void teleportToLocation(GameObject location) {
        transform.position = location.transform.position;
    }

    

    private void teleportTolocation(int locationIndex)
    {


        transform.position = teleportLocation[locationIndex].transform.position;
       
    }
}
