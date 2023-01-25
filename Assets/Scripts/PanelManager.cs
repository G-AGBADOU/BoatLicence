using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelManager : MonoBehaviour
{
    Vector3 BoatStart;
    Vector3 BoatCurrentPos;
    [SerializeField] private GameObject _instruction;
    // Start is called before the first frame update
    void Start()
    {
        BoatStart = gameObject.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        BoatCurrentPos = gameObject.transform.position;
        float dist = Vector3.Distance(BoatCurrentPos, BoatStart);
        if(dist > 5f)
        {
        _instruction.SetActive(true);
        GetComponent<AudioSource>().Play();

        }
        if (dist > 35f)
        {
            _instruction.SetActive(false);

        }

    }

   
    private void OnTrigerEnter(Collider colission)
    {
        //afficher l'instruction
    }
}
