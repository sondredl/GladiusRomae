using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Interactable : MonoBehaviour
{
    public float radius = 3f;
    public Transform interactionTransform;

    bool isFocus = false;
    Transform player;

    bool hasInteracted = false;

    public virtual void Interact()
    {
        // This method is meant to be overwritten
        Debug.Log("Interacting with " + transform.name);
    }


    // Update is called once per frame
    void Update()
    {
        if (isFocus)
        {
        Debug.Log("interactable update() if  " + transform.name);
            float distance = Vector3.Distance(player.position, interactionTransform.position);
            if(!hasInteracted && distance <= radius)
            {
                hasInteracted = true;
                Interact();
            }
        }
    }

    public void OnFocused(Transform playerTransform)
    {
        Debug.Log("interactable.onFocus");
        isFocus = true;
        hasInteracted = false;
        player = playerTransform;
    }

    public void OnDeFocused()
    {
        isFocus = false;
        hasInteracted=false;
        player = null;

    }

    void OnDrawGizmosSelected()
    {
            Debug.Log("interactable.onDrawGizmosSelected()");
        if (interactionTransform == null) {
            Debug.Log("interactable.onDrawGizmosSelected() if ");
            interactionTransform = transform;
        }

        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(interactionTransform.position, radius);

    }
}
