using UnityEngine;
using System.Threading;

public class BreatheController : MonoBehaviour {

    public int currReading;
    public bool exhaling;

    [SerializeField] string portName = "COM6";
    [SerializeField] int baudRate = 9600;

    Thread serialThread;
    SerialThreadWorker serialThreadWorker;

    // Initialization
    void Start() {
        serialThreadWorker = new SerialThreadWorker(portName, baudRate);
        serialThread = new Thread(new ThreadStart(serialThreadWorker.Run));
        serialThread.Start();
    }

    // Executed each frame
    void Update() {
        string message = (string)serialThreadWorker.GetReading();
        if (message == null)
            return;

        string[] result = message.Split(',');
        currReading = int.Parse(result[0]);
        exhaling = result[1] == "1";
    }

    private void OnApplicationQuit() {
        serialThreadWorker.Stop();
        serialThread.Join();
    }
}