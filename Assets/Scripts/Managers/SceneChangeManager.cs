using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChangeManager : MonoBehaviour
{
   public void ChnageScene(string sceneName)
   {
       SceneManager.LoadScene(sceneName);
   }

    public void Quit()
    {
        Application.Quit();
    }
}
