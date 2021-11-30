using UnityEngine;
public abstract class Puzzle : MonoBehaviour {
  public static Puzzle active;
  public static int current;
  public int index;
  public bool solved;
  public AudioSource audSuccess;
  protected virtual void Start() {
    Util.SetVisible(gameObject, false);
    current = 0;
    solved = false;
  }
  public abstract void OnFailed();
  public virtual void OnSolved() {
    Util.SetVisible(gameObject, false);
    current++;
    solved = true;
    audSuccess.Play();
  }
}
