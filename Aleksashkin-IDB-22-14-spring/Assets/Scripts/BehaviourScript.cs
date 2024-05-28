using TMPro;
using UnityEngine;
using Debug = UnityEngine.Debug;
using Valve.Newtonsoft.Json;

public class BehaviourScript : MonoBehaviour
{
    public TextMeshProUGUI text;
    public GameObject movable;
    public GameObject rotatable;
    float maxPos = 1.164f;
    float minPos = 1.057f;
    bool up = false;
    bool moving = false;
    float speed = .05f;
    float rotationSpd = 100f;
    private Text loadedText;
    private Vector3 pos;

    void Start()
    {
        LoadJson();
        pos = rotatable.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
//            Debug.LogError("" + movable.transform.position.y);
        if (moving) {
            if (movable.transform.position.y < minPos) up = true;
            if (movable.transform.position.y > maxPos) up = false;
            movable.transform.Translate(0, 0, speed * Time.deltaTime * (up ? 1 : -1));
            rotatable.transform.Rotate(-rotationSpd * Time.deltaTime * (up ? 1 : -1), 0, 0);
        }

        text.text = loadedText.ToString();
    }
    
    public class Text
    {
        public string text;
        public int number;

         public override string ToString()
         {
             return "Loaded text: " + text + ", number = " + number;
         }
    }
    

    public void LoadJson()
    {
        TextAsset jsonFile = Resources.Load<TextAsset>("text");

        if (jsonFile != null)
        {
            string jsonText = jsonFile.text;
            loadedText = JsonConvert.DeserializeObject<Text>(jsonText);
        }
        else
        {
            Debug.LogError("JSON file is absent!");
            loadedText = new Text();
        }
    }

    public void startInteract()
    {
        moving = true;
    }

    public void finishInteract()
    {
        moving = false;
    }

    public void interactUpdate()
    {
        rotatable.transform.position = pos;
    }
}
