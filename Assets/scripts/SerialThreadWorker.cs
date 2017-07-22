using System.IO.Ports;
using UnityEngine;

public class SerialThreadWorker {

    string portName;
    int baudRate;
    bool keepRunning;
    object message;
    SerialPort stream;

    public SerialThreadWorker(string portName, int baudRate) {
        this.portName = portName;
        this.baudRate = baudRate;
    }

    public void Run() {
        stream = new SerialPort(portName, baudRate);
        stream.Open();
        keepRunning = true;
        while (keepRunning) {
            message = stream.ReadLine();
        }
        stream.Close();
    }

    public object GetReading() {
        return message;
    }

    public void Stop() {
        keepRunning = false;
    }
}
