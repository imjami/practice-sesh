using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    public bool IsGameOver { get; set; }

    [SerializeField] GameObject pipe;
    [SerializeField] float spawnDelay;

    float _upperSpawnY = 3.1f;
    float _lowerSpawnY = -3.1f;
    float timer;

    // Start is called before the first frame update
    void Start()
    {
        SpawnPipe();
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < spawnDelay)
        {
            timer += Time.deltaTime;
        }
        else
        {
            SpawnPipe();
        }
    }

    void SpawnPipe()
    {
        Instantiate(pipe, new Vector2(transform.position.x, Random.Range(_lowerSpawnY, _upperSpawnY)), pipe.transform.rotation);
        timer = 0;
    }
}
