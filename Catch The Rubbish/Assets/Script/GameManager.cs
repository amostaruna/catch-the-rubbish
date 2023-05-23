using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject Rubbish_Prefab;
    public int targetScore = 10;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRubbish", 2, 2);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnRubbish()
    {
        float tempPos = Random.Range(-6f, 6f);
        Instantiate(Rubbish_Prefab, new Vector3(tempPos, 5.5f, 0), Quaternion.identity);
    }

    public void StopSpawning()
    {
        CancelInvoke();
    }
}
