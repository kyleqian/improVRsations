using UnityEngine;

public class QuadController : MonoBehaviour {

    BreatheScript bs;

    // Use this for initialization
    void Start()
    {
        var bw = GameObject.Find("BreatheWith");
        if (bw && bw.activeSelf)
            bs = bw.GetComponent<BreatheScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if (bs)
        {
            var scale = Mathf.Max(1f, bs.currReading / 50f - 6.0f);
            var currPos = transform.localPosition;
            transform.localPosition = new Vector3(currPos.x, currPos.y, scale);
        }
    }
}
