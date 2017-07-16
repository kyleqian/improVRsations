using UnityEngine;
using System.IO.Ports;

public class BreatheScript : MonoBehaviour
{
    public int currReading;
    public bool exhaling;

    SerialPort stream = new SerialPort("COM6", 9600);

    // Use this for initialization
    void Start()
    {
        stream.ReadTimeout = 25;
        stream.Open();
    }

    // Update is called once per frame
    void Update()
    {
        string[] reading = stream.ReadLine().Split(',');
        currReading = int.Parse(reading[0]);
        exhaling = reading[1] == "1";
        //print(currReading);

        //if (Time.realtimeSinceStartup > 10)
        //    UnityEditor.EditorApplication.isPlaying = false;
    }

    void OnApplicationQuit()
    {
        stream.Close();
    }
}