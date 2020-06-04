using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spwanManager : MonoBehaviour
{
    [SerializeField]
    GameObject enemyPrefab;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpwanRoutine());
    }

    // Update is called once per frame
    void Update()
    {

    }
 
    IEnumerator SpwanRoutine()
    {
        while (true)
        {
            Vector3 postospwan = new Vector3(Random.Range(-8f, 8f), 7, 0);
            GameObject new_enemy = Instantiate(enemyPrefab, postospwan, Quaternion.identity);
            yield return new WaitForSeconds(3);
        }
    }
}
