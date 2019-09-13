using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Defender : MonoBehaviour {

	// we need to call starDisplay
    public void AddStarsEvent(int amount) // the amount of stars we pass in this method
    {
        FindObjectOfType<StarDisplay>().AddStars(amount); // pass the amount straight through here
        
    }
}
