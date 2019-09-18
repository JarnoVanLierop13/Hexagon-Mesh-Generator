using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class CallGenerator : MonoBehaviour
{
    public Button startGeneration;
    public GridGenerator other;

    void Start()
    {
        Button btn = startGeneration.GetComponent<Button>();
        btn.onClick.AddListener(startFunctions);
    }

    public void startFunctions()
    {
        other.AddGap();
        other.CalcStartPos();
        other.CreateGrid();
    }

}