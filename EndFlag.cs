using UnityEngine;
using UnityEngine.SceneManagement;

public class EndFlag : MonoBehaviour
{
    public string nextSceneName;
    public bool lastlevel;

    private void OnTriggerEnter(Collider other) 
    {
         if(other.CompareTag("Player"))
        {
            if(lastlevel == true)
            {
                Debug.Log("You Win");
            }
            else
            {
                SceneManager.LoadScene(nextSceneName);
            }
        }
    }
}
