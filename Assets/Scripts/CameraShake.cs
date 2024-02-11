using System.Collections;
using UnityEngine;

public class CameraShake : MonoBehaviour
{
    [SerializeField] float shakeDuration = 1f;
    [SerializeField] float shakeMagnitude = 0.5f;

    Vector3 initialPosition;
    

    void Start() 
    {
        initialPosition = transform.position;
    }

    public void Play()
    {
        StartCoroutine(Shake());
    }

    IEnumerator Shake()
    {
        // float elapsedTime = 0;
        // while(elapsedTime < shakeDuration)
        // {
        //     transform.position = initialPosition + (Vector3)Random.insideUnitCircle * shakeMagnitude;
        //     elapsedTime += Time.deltaTime;
        //     yield return new WaitForEndOfFrame();
        // }
        //for문이 아닌 while문 이용함 for문으로도 할수있을거 같은데
        //Time.deltaTime이용하기 위해 i++이 아닌 i += Time.deltaTime사용
         for(float i = 0; i < shakeDuration; i += Time.deltaTime)
        {
            transform.position = initialPosition + (Vector3)Random.insideUnitCircle * shakeMagnitude;
            yield return new WaitForEndOfFrame();
        }


        transform.position = initialPosition;

    }

}
