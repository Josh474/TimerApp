using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class UIManager : MonoBehaviour {


    public static UIManager Instance;

    public Text TaskName;
    public Text MainTimer;

    public Text SetName;

    void Awake ()
    {
        Instance = this;
    }
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
