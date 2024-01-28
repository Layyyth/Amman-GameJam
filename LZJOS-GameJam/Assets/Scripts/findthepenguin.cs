using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class findthepenguin : MonoBehaviour
{
    public GameObject penguin;
    public GameObject startpos;
    // Start is called before the first frame update
    void Start()
    {
        Instantiate(penguin, startpos.transform.position, startpos.transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
