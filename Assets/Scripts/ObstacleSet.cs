using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSet : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject[] obstacles;
    public FrameSpawner spawn;
    void Start()
    {
        spawn = GameObject.FindObjectOfType<FrameSpawner>();
        for (int i = 0; i < obstacles.Length; i++) {
            obstacles[i].transform.position = new Vector2(obstacles[i].transform.position.x, Random.Range(-2, 2.1f));
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        spawn.NewFrame();
        Destroy(gameObject);
    }
}
