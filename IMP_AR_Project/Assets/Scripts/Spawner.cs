using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public bool spawnEnable;

    public GameObject Mosquito;

    //?????? ??? ???? ???? ?��????

    // Start is called before the first frame update
    void Start()
    {
        //If Game is Play mode, It will work.
        if (GameManager.instance.gamestatus == 1)
            spawnMosquito();
    }

    // Update is called once per frame
    void Update()
    {
        GameObject mosq = GameObject.FindGameObjectWithTag("Mosquito");

        if (GameManager.instance.gamestatus == 1)
        {
            if (mosq == null)
            {
                Debug.Log("1");
                spawnEnable = true;
            }
            else
                spawnEnable = false;

            if (spawnEnable)
            {
                spawnMosquito();
            }
        }
    }

    void spawnMosquito()
    {
        float randomX = Random.Range(-5f, 5f);
        float randomZ = Random.Range(-5f, 5f);

        GameObject mosq = (GameObject)Instantiate(Mosquito, new Vector3(randomX, 0f, randomZ), Quaternion.identity);
    }
}
