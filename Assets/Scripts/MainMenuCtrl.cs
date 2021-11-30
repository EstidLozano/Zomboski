using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenuCtrl : MonoBehaviour {
  public Button btnPlay;
  public Button btnQuit;
  protected void Start() {
    btnPlay.onClick.AddListener((() => {
      SceneManager.LoadScene("Intro");
    }));
    btnQuit.onClick.AddListener((() => {
      Application.Quit();
    }));
  }
}
