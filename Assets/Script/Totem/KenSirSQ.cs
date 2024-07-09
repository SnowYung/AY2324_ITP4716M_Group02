using UnityEngine;

public class KenSirSQ : MonoBehaviour
{
    public GameObject TotemPrefab;
    public Bounds spawnArea;
    public LayerMask layerMask;

    private Bounds totemBounds;

    private void Start()
    {
        GameObject totom = Instantiate(TotemPrefab);
        totemBounds = totom.GetComponent<Collider>().bounds;
        Destroy(totom);

        for (int i = 0; i < 5; i++)
            Spawn();
    }

    private GameObject Spawn()
    {
        int tries = 0;
        Vector3 position;
        Quaternion rotation;
        bool hit;
        do
        {
            position = RandomPointInBounds(spawnArea);
            position.y = spawnArea.max.y - totemBounds.size.y;
            rotation = Quaternion.Euler(0f, Random.value * 360f, 0f);

            //var test = GameObject.CreatePrimitive(PrimitiveType.Cube);
            //test.transform.SetPositionAndRotation(position, rotation);
            //test.transform.localScale = totemBounds.extents;
            //Destroy(test.GetComponent<Collider>());

            var colliders = Physics.OverlapBox(position, totemBounds.extents, rotation, layerMask.value, QueryTriggerInteraction.UseGlobal);
            hit = colliders.Length > 0;
            if (hit)
                tries++;
        }
        while (hit && tries < 5);

        if (hit)
        {
            Debug.Log($"Can't spawn totem after {tries} retries");
            return null;
        }

        GameObject totom = Instantiate(TotemPrefab, position, rotation);
        if (Physics.BoxCast(position, totemBounds.extents, Vector3.down, out RaycastHit hitInfo))
        {
            Vector3 newPosition = new Vector3(totom.transform.position.x, hitInfo.point.y, totom.transform.position.z);
            totom.transform.position = newPosition;
        }
        return totom;
    }

    // https://forum.unity.com/threads/pick-random-point-inside-box-collider.541585/
    private static Vector3 RandomPointInBounds(Bounds bounds)
    {
        return new Vector3(
            Random.Range(bounds.min.x, bounds.max.x),
            Random.Range(bounds.min.y, bounds.max.y),
            Random.Range(bounds.min.z, bounds.max.z)
        );
    }
}