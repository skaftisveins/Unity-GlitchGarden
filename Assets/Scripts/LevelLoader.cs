using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; // Use this to fx. load scenes in Unity

public class LevelLoader : MonoBehaviour {

    [SerializeField] int timeToWait = 4;
    int currentSceneIndex;

	// Use this for initialization
	void Start () {
        currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        if(currentSceneIndex == 0)
        {
            StartCoroutine(WaitForTime());
        }
	}
	
    IEnumerator WaitForTime()
    {
        yield return new WaitForSeconds(timeToWait);
        LoadNextScene();

    }

    public void LoadNextScene()
    {
        SceneManager.LoadScene(currentSceneIndex + 1);
    }

	// Update is called once per frame
	void Update () {
		
	}
}
