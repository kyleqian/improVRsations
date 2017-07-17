using UnityEngine;

public class QuadController : MonoBehaviour {

    BreatheScript bs;

    // Use this for initialization
    void Start()
    {
        bs = GameObject.Find("BreatheWith").GetComponent<BreatheScript>();
    }

    // Update is called once per frame
    void Update()
    {
        var scale = bs.currReading / 50f - 3.0f; ;
        var currPos = transform.localPosition;
        transform.localPosition = new Vector3(currPos.x, currPos.y, scale);
    }
}
