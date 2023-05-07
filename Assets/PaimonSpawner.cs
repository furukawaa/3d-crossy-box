using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaimonSpawner : MonoBehaviour
{
    [SerializeField] Paimon paimon;
    [SerializeField] Chicken chicken;
    [SerializeField] float initialTimer = 3;

    float timer;

    // Start is called before the first frame update
    void Start()
    {
        timer = initialTimer;
        paimon.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(timer <= 0 && paimon.gameObject.activeInHierarchy == false)
        {
            paimon.gameObject.SetActive(true);
            paimon.transform.position = chicken.transform.position + new Vector3(0, 0, 13);
            chicken.SetMoveable(false);
        }

        timer -= Time.deltaTime;
    }

    public void ResetTimer()
    {
        timer = initialTimer;
    }
}
