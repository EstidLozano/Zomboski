using UnityEngine;
public class Puzzle : MonoBehaviour {
  public static int current;
  public int index;
  public bool solved;
  protected virtual void Start() {
    Util.SetVisible(gameObject, false);
    current = 0;
    solved = false;
  }
  public virtual void Open() {
    Util.SetVisible(gameObject, true);
    AudManage.Get(AudManage.puzzleOpen).Play();
  }
  public virtual void Close() {
    Util.SetVisible(gameObject, false);
  }
  public virtual void OnFailed() {
    Close();
  }
  public virtual void OnSolved() {
    Close();
    current++;
    solved = true;
    AudManage.Get(AudManage.success).Play();
  }
}
