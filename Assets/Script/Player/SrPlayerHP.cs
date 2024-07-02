using UnityEngine;
using UnityEngine.UI;

public class SrPlayerHP : MonoBehaviour
{
    public Image PlayerHP;
    public Transform Transform;
    public static float damage;
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

    public void TakeDamage()
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
}
