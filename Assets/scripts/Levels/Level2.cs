using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level2 : MonoBehaviour
{
    [SerializeField] GameObject player;
    [SerializeField] Vector3 startPosition;
    [SerializeField] GameObject mirrorKey;
    [SerializeField] GameObject mother;
    [SerializeField] GameObject door;

    bool playerClickOnMother = false;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("boody");
        player.transform.position = startPosition;

        mother.GetComponent<Mover>().enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        IsPlayerClickOnMother();
        //MotherTrackingThePlayer();
        //IsPlayerClickOnDoor();
    }

    private void IsPlayerClickOnMother()
    {
        Vector3.Distance(mother.transform.position, player.transform.position);
    }
}
