using UnityEngine;
using UnityEngine.UI;

public class SrPlayerHP : MonoBehaviour
{
    public Image PlayerHP;
    public Transform Transform;
    int x, y, z;

    //public void OnTriggerEnter(Collider other)
    //{
    //    if (other.gameObject.name == "M1Weapon")
    //    {
    //        PlayerHP.fillAmount -= 0.05f;
    //        //Debug.Log("HP reduced");
    //    }
    //}

    //public static void Reset()
    //{
    //    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    //    GameObject.Find("Enermys").GetComponent<updataNum>().ResetMark();
    //}

    public void TakeDamage(float damage)
    {
        PlayerHP.fillAmount -= damage;
    }

    public float GetHP()
    {
        return PlayerHP.fillAmount;
    }

    public void ResetHP()
    {
        PlayerHP.fillAmount = 1;
    }

    public void TransformA( )
    {
        //float x = gameObject.GetComponent<NewBehaviourScript>().transform.position.x;
        //float y = gameObject.GetComponent<NewBehaviourScript>().transform.position.y;
        //float z = gameObject.GetComponent<NewBehaviourScript>().transform.position.z;
        //y = gameObject.GetComponent<NewBehaviourScript>().EndTP.y;
        //Transform = GetComponent<Transform>();


    }
}
