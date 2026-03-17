using UnityEngine;

public class PipeBehaviour : MonoBehaviour
{
  [SerializeField] private float moveSpeed = 1f;
  [SerializeField] private float initialPos = 0.48f;
  [SerializeField] private float endPos = -1.27f;

  private void Update()
  {
    transform.Translate(Vector2.left * moveSpeed * Time.deltaTime);
    

  }

}
