using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shakecam : MonoBehaviour
{
    public IEnumerator Shake(float duration, float magnitude)
    {
        Vector3 originalpos = transform.localPosition;
        
        float elapsed = 0.0f;

        while (elapsed < duration)
        {   
            float x = Random.Range(0f,0.5f) * magnitude;
            float y = Random.Range(5f,5.5f) * magnitude;

            transform.localPosition = new Vector3(x, y, originalpos.z);

            elapsed += Time.deltaTime;

            yield return null;

        }
        transform.localPosition = originalpos;
    }
}
