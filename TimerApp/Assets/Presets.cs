using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Presets : MonoBehaviour {

    //Presets info
    public string presetName { get; set; }
    public float presetDuration { get; set; }
    public int presetTotal { get; set; }

    public List<Task> taskList = new List<Task>(); 

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    public void CreatePreset()
    {

    }

    //presets constructor
    public Presets(string _presetName, float _presetDuration, int _presetTotal)
    {
        presetName = _presetName;
        presetDuration = _presetDuration;
        presetTotal = _presetTotal;
    }
    //copy constructor
    public Presets(Presets copyPresets)
    {
        presetName = copyPresets.presetName;
        presetDuration = copyPresets.presetDuration;
        presetTotal = copyPresets.presetTotal;
    }

}
