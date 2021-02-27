using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileController : MonoBehaviour
{
    public TextController tempTextController;
    public float projectileLifeTime = 10f; // 10 seconds

    private bool isProjectile = false;
    private AudioSource splatAudio;

    void Start()
    {
        splatAudio = GetComponent<AudioSource>();
    }

    public void ToggleShotState()
    {
        // destroys itself if it has been present for too long without collision after it has been shot
        Destroy(gameObject, projectileLifeTime);
        isProjectile = true;
    }

    // todo: bug: need to detect collision only after it has been shot. 
    // right now its detecting its spawned location (the plane) and immediately deleting itself
    void OnCollisionEnter(Collision col)
    {
        if (isProjectile)
        {
            // play projectile destruction sound
            AudioSource.PlayClipAtPoint(splatAudio.clip, transform.position);

            if (col.gameObject.CompareTag("Target"))
            {
                // increment score
                tempTextController.setText("+1");
            }

            // destroy itself
            Destroy(gameObject);
        }
    }
}
