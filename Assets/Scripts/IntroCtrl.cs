using UnityEngine;
using UnityEngine.SceneManagement;

public class IntroCtrl : MonoBehaviour {
  protected void Start() {
    Invoke("ChangeScene", 20f);
  }
  protected void ChangeScene() {
    SceneManager.LoadScene("Game1");
  }
}
