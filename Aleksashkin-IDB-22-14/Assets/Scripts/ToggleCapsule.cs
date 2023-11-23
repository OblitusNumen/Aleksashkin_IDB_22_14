using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ToggleCapsule : MonoBehaviour
{
    public GameObject capsule;
    public TMP_Text text;
    public int i = 100;

    public void toggleCapsule()
    {
        capsule.SetActive(!capsule.activeSelf);
        Debug.Log("Hello from ToggleCapsule.toggleCapsule");
        
    }

    // Start is called before the first frame update
    void Start()
    {
        capsule = GameObject.Find("Capsule");
        text = GameObject.Find("Text").GetComponent<TMP_Text>();
        Debug.Log("Hello from ToggleCapsule.Start");
        text.text = i + "";
    }

    private void OnCollisionEnter(Collision other)
    {
        text.text = --i + "";
    }

    void Update()
    {
    }
}
