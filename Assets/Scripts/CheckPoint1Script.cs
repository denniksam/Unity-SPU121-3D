using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CheckPoint1Script : MonoBehaviour
{
    [SerializeField]
    private Image image;

    private AudioSource collectSound;
    private AudioSource destroySound;

    private float time = 10f;
    private float leftTime;

    private void Start()
    {
        leftTime = time;
        GameState.isCheckPoint1 = false;
        AudioSource[] sources = this.GetComponents<AudioSource>();
        collectSound = sources[0];
        destroySound = sources[1];
    }

    void LateUpdate()
    {
        leftTime -= Time.deltaTime;
        image.fillAmount = leftTime / time;
        if(leftTime < 0)
        {
            destroySound.Play();
            // GameObject.Destroy(gameObject);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        // спрацювання чекпоїнту - включаємо "бонус"
        collectSound.Play();
        GameState.isCheckPoint1 = true;
        // GameObject.Destroy(gameObject);
    }
}
/* Реалізувати відкладене руйнування об'єкту на час програвання звуку
 */
