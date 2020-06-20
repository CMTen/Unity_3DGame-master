using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    [Header("玩家資料")]
    public PlayerData dataPlayer;

    public GameObject sword;
    public GameObject swordOn;
    public GameObject swordUI;
    public GameObject armor;
    public GameObject armorOn;
    public GameObject armorUI;

    public void BuyHp_100()
    {
        dataPlayer.maxHp += 100;
        dataPlayer.hp = dataPlayer.maxHp;
    }

    public void BuyAtk_50()
    {
        dataPlayer.attack += 50;
    }

    public void LoadLevel()
    {
        dataPlayer.hp = dataPlayer.maxHp;
        SceneManager.LoadScene("關卡1");
    }

    public void showSword()
    {
        sword.SetActive(true);
    }

    public void closeSword()
    {
        sword.SetActive(false);
    }

    public void wearSword()
    {
        swordOn.SetActive(true);
        swordUI.SetActive(true);
    }

    public void takeoffSword()
    {
        swordOn.SetActive(false);
        swordUI.SetActive(false);
    }

    public void showArmor()
    {
        armor.SetActive(true);
    }

    public void closeArmor()
    {
        armor.SetActive(false);
    }

    public void wearArmor()
    {
        armorOn.SetActive(true);
        armorUI.SetActive(true);
    }

    public void takeofArmor()
    {
        armorOn.SetActive(false);
        armorUI.SetActive(false);
    }
}
