using UnityEngine;

public class GameResources : MonoBehaviour
{
    public string[] vegetables = { "リンゴ", "ミカン", "ブドウ", "モモ", "スイカ", "バナナ" };
    public string[] livestock = { "牛", "豚", "鶏", "羊", "山羊", "馬" };
    public string[] divingCatches = { "魚(小)", "魚(中)", "魚(大)" };

    public void DisplayResources()
    {
        Debug.Log("作れる野菜: " + string.Join(", ", vegetables));
        Debug.Log("可能な酪農: " + string.Join(", ", livestock));
        Debug.Log("素潜りで捕れる魚: " + string.Join(", ", divingCatches));
    }
}
