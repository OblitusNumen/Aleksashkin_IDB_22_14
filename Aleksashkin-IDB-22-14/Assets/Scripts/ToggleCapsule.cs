using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleCapsule : MonoBehaviour
{
    public GameObject capsule;

    public void toggleCapsule()
    {
        capsule.SetActive(!capsule.activeSelf);
        Debug.Log("Hello from ToggleCapsule.toggleCapsule");

    }

    // Start is called before the first frame update
    void Start()
    {
        capsule = GameObject.Find("Capsule");
        Debug.Log("Hello from ToggleCapsule.Start");
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
