using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level2 : MonoBehaviour
{
    [SerializeField] GameObject player;
    [SerializeField] Vector3 startPosition;
    [SerializeField] GameObject mirrorKey;
    [SerializeField] GameObject mother;
    [SerializeField] GameObject door;
    [SerializeField] GameObject text;

    public bool playerClickOnMother = false;


    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("boody");
        player.transform.position = startPosition;

        mother.GetComponent<Mover>().enabled = false;
       
        text.GetComponent<MeshRenderer>().enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        IsPlayerClickOnMother();
        //MotherTrackingThePlayer();
        //IsPlayerClickOnDoor();

        if(GameObject.Find("Door6PanelSlab").GetComponent<Door>().openDoor && playerClickOnMother)
        {
            
            text.GetComponent<MeshRenderer>().enabled = true;
            
            DontDestroyOnLoad(player);
            SceneManager.LoadScene("2");
        }


    }

    private void IsPlayerClickOnMother()
    {
        Vector3.Distance(mother.transform.position, player.transform.position);
        playerClickOnMother = true;
    }
   


}
