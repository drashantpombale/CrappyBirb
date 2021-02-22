using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FrameSpawner : MonoBehaviour
{
    public GameObject startFrame;
    public GameObject frame;
    GameObject currentframe;
    Vector2 nextFrame;
    // Start is called before the first frame update
    void Start()
    {
        currentframe = Instantiate(startFrame);
        nextFrame = currentframe.GetComponentsInChildren<Transform>()[1].position;
        for (int i = 0; i < 5; i++) {
            currentframe = Instantiate(frame, new Vector2(nextFrame.x + 12.8f,nextFrame.y), Quaternion.identity); ;
            nextFrame = currentframe.GetComponentsInChildren<Transform>()[1].position;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void NewFrame() {
        currentframe = Instantiate(frame, new Vector2(nextFrame.x + 12.8f, nextFrame.y), Quaternion.identity); ;
        nextFrame = currentframe.GetComponentsInChildren<Transform>()[1].position;
    }


}
