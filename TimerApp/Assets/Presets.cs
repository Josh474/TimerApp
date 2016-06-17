using UnityEngine;
using System.Collections;

public class Presets : MonoBehaviour {

    //task info
    public string taskName { get; set; }
    public float taskDuration { get; set; }
    public int taskFrequency { get; set; }
    public int taskOrder { get; set; }

    //Presets info
    public string presetName { get; set; }
    public float presetDuration { get; set; }
    public int presetTotal { get; set; }

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    //presets constructor
    public Presets(string _taskName, float _taskDuration, int _taskFrequency, int taskOrder)
    {

    }

    //copy constructor
    public Presets(Presets copyPresets)
    {

    }
}
