using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Presets : MonoBehaviour {

    //Presets info
    public string presetName { get; set; }
    public float presetDuration { get; set; }
    public int presetTotal { get; set; }

    List<Task> taskList = new List<Task>(); 

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
