using UnityEngine;
using System.Collections;
public class Util {
  public static IEnumerator IEMove(Transform cell, Vector2 target, float time) {
    Vector2 start = cell.localPosition;
    float elapsed = 0;
    while (elapsed < time) {
      cell.localPosition = Vector2.Lerp(start, target, elapsed / time);
      elapsed += Time.deltaTime;
      yield return null;
    }
    cell.localPosition = target;
  }
  public static int[] Unsorted(int n) {
    int[] arr = new int[n];
    for (int i = 0; i < arr.Length; i++) {
      arr[i] = i;
    }
    // fisher-yates shuffle
    for (int i = arr.Length - 1; i > 0; i--) {
      int j = Random.Range(0, i);
      int temp = arr[i];
      arr[i] = arr[j];
      arr[j] = temp;
    }
    return arr;
  }
  public static void SetVisible(GameObject gameObject, bool visible) {
    gameObject.SetActive(visible);
  }
}