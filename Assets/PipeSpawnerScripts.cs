using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawnerScripts : MonoBehaviour
{
    public GameObject pipe;
    public float spawnRate = 1.5f;
    private float timer = 0;
    public float heightOffset = 10;
    // Start is called before the first frame update
    void Start()
    {
        spawnPipe();
    }

    // Update is called once per frame
    void Update()
    {   
        Debug.Log(timer.ToString() + " Sec");
        if (timer > spawnRate*1.5){
            spawnPipe();
            timer = 0; 
        }
        timer += Time.deltaTime;

    }

    void spawnPipe(){
        float lowestPoint = transform.position.y - heightOffset;
        float highestPoint = transform.position.y + heightOffset;
        Instantiate(pipe, new Vector3(transform.position.x, Random.Range(lowestPoint, highestPoint), 0), transform.rotation);
    }
}
