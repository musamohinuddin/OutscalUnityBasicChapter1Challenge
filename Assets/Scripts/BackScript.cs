using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BackScript : MonoBehaviour
{
    public Button button;
	public string BackScene;
	
	// Start is called before the first frame update
    void Start()
    {
        button.onClick.AddListener(OnButtonClick);	
		
    }	
		
	private void OnButtonClick()
	{
		Debug.Log("Button Clicked");
		SceneManager.LoadScene(BackScene);
	}	
    

    // Update is called once per frame
    void Update()
    {
        
    }
}
