using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RespawnManager : MonoBehaviour
{

    public GameObject[] obj;
    public Transform respawnTr;

    void Start()
    {
        StartCoroutine(RespawnEnemy());

    }
    IEnumerator RespawnEnemy()
    {
        while (true)
        {
            yield return new WaitForSeconds(0.7f);
            float range = (float)Screen.width / (float)Screen.height * Camera.main.orthographicSize;
            for (int i = 0; i < obj.Length; i++)
                Instantiate(obj[i], respawnTr.position + new Vector3(Random.Range(-range + 0.4f, range - 0.4f), 0, 0), Quaternion.identity);
        }

    }
    void Update()
    {

    }
}
