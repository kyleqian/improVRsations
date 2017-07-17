using UnityEngine;

public class SphereController : MonoBehaviour {
    
    BreatheScript bs;
    float scale;

	// Use this for initialization
	void Start () {
        bs = GameObject.Find("BreatheWith").GetComponent<BreatheScript>();
	}
	
	// Update is called once per frame
	void Update () {
        scale = bs.currReading / 100f - 1f;
        transform.localScale = new Vector3(scale, scale, scale);
    }
}
