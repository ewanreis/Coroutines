using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class playerScript : MonoBehaviour
{
    public Rigidbody2D squareRigid;
    public SpriteRenderer squareRenderer;
    private Vector2 direction = new Vector2(2f, 0f);
    void Start()
    {
        StartCoroutine(LeftRight());
        StartCoroutine(ChangeColor());
    }
    IEnumerator LeftRight()
    {
        for (int i = 0; i < 5; i++)
        {
            squareRigid.AddForce(direction * 2, ForceMode2D.Impulse);
            yield return new WaitForSeconds(0.5f);
            squareRigid.velocity = Vector3.zero;
            direction = -direction;
        }
    }
    IEnumerator ChangeColor()
    {
        for (float j = 0; j < 1; j += 0.1f)
        {
            squareRenderer.color = new Vector4( 1f-j, j, 0f, 1f);
            yield return new WaitForSeconds(0.2f);
        }
    }
}