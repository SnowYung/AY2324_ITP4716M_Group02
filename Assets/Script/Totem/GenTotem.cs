using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenTotem : MonoBehaviour
{
    public GameObject totemPosition;

    public GameObject totemObj;

    public GameObject totem;
    
    Vector3 position;

    [SerializeField]
    LayerMask layerMask;

    private void Start()
    {
        Generrate();
    }
    private void Update()
    {

    }
    public void Generrate()
    {
        Vector3 genPos;
        Vector3 origin;
        float radius = 1.5f;

        for (int i = 0; i < 1; i++)
        {
            RaycastHit[] hittotem;
            bool success;
            int counter = 0;
            do
            {
                genPos = new Vector3((float)(Random.Range(-45, 45)), 0, (float)(Random.Range(-45, 45)));
                origin = genPos + Vector3.up * 20;
                hittotem = Physics.SphereCastAll(origin, radius, Vector3.down, 21f, layerMask);

                counter++;
            }
            while (hittotem.Length != 1);

            genPos = hittotem[0].point;
            totem = Instantiate(totemPosition, genPos, new Quaternion(0f, 0f, 0f, 0f), totemObj.transform);
            EnemyAI enemyAI = totem.GetComponent<EnemyAI>();
        }
    }

}