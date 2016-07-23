using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class GameManager : MonoBehaviour
{

    public float Timer;
    public List<Presets> presetList = new List<Presets>();

    Presets obj = new Presets("kill phillip", 2.0f, 1);

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        UIManager.Instance.MainTimer.text = Timer.ToString();

    }

    public void PresetConstruction()
    {
        presetList.Add(new Presets(obj));
    }


}
