using UnityEngine;

public class ToggleSphere : MonoBehaviour
{
    public GameObject sphere;

    public void toggleSphere()
    {
        sphere.SetActive(!sphere.activeSelf);
        Debug.Log("Hello from ToggleSphere.toggleSphere");
    }

    // Awake is called before the Start
    void Awake() {
        // Debug.Log("Awake");
    }
    
    // Start is called before the first frame update
    void Start() {
        Debug.Log("Hello from ToggleSphere.Start");
        sphere = GameObject.Find("Sphere");
        // Debug.Log("Start");
    }

    // Update is called once per frame
    void Update()
    {
        // Debug.Log("Update");
    }
}
