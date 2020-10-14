using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightController : MonoBehaviour
{
    public GameObject player;
    private Light theLight;
    private float positionZ;
    private Color underwater;
    // Start is called before the first frame update
    void Start()
    {
        theLight = GetComponent<Light>();
        underwater = new Color(0.2548f, 0.4697f, 0.6509f, 1.0f);
    }

    // Update is called once per frame
    void LateUpdate()
    {
        positionZ = player.transform.position.z;
        if (positionZ >= 56)
        {
            theLight.color = underwater;
            //Debug.Log(underwater.ToString());
        }
        
    }
}
