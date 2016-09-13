using UnityEngine;

public class MenuButtonLoadLevel : MonoBehaviour {

	public void loadLevel(string leveltoLoad)
	{
        UnityEngine.SceneManagement.SceneManager.LoadScene(leveltoLoad);
    }
}
