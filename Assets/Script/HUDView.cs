using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class HUDView : MonoBehaviour
{
    public Health health;
    public SurvivalCollectibles collectibles;
    public SurvivalTimer timer;
    public Text hearts;
    public TMP_Text score;
    public TMP_Text timeLabel;
    void Update()
    {
        int hp=Mathf.Max(health.hp,0);
        hearts.text=new string('♥',Mathf.Min(hp,5))+(hp>5?" +"+(hp-5):"");
        score.text="COINS  "+collectibles.Score.ToString("00");
        timeLabel.text=timer.HasWon?"GATE OPEN":"SURVIVE  "+Mathf.FloorToInt(timer.Elapsed).ToString("00")+" / 60";
    }
}
