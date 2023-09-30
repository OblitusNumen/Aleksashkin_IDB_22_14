using UnityEngine;

public class NewBehaviourScript : MonoBehaviour {

    // Awake is called before the Start
    void Awake() {
        Debug.Log("Awake");
    }
    
    // Start is called before the first frame update
    void Start() {
        Debug.Log("Start");
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Update");
    }
}
