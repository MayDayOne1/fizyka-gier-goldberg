using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosion : MonoBehaviour
{

    [SerializeField] private ParticleSystemForceField forceField;
    // Start is called before the first frame update
    void Start()
    {
        forceField = GetComponent<ParticleSystemForceField>();
        forceField.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            StartCoroutine(WaitForExplosion());
        }
    }

    IEnumerator WaitForExplosion()
    {
        Debug.Log("Boom!");
        forceField.enabled = true;
        yield return new WaitForSeconds(1);
        forceField.enabled = false;
    }
}
