using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class newObs : MonoBehaviour
{
    public float maxTime = 1;
    public float Timer = 4;
    public GameObject Obstacles;
    public float height;

    // Start is called before the first frame update
    void Start()
    {
        GameObject newObs = Instantiate(Obstacles);
        newObs.transform.position = transform.position + new Vector3(0, Random.Range(-height, height), -0.556804f);
    }

    // Update is called once per frame
    void Update()
    {
        if (Timer > maxTime) {
            GameObject newObs = Instantiate(Obstacles);
            newObs.transform.position = transform.position + new Vector3(0, Random.Range(-height, height), -0.556804f);
            Destroy(newObs, 15);
            Timer = 0;
        }
        Timer += Time.deltaTime;
    }
}
