using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameValues : MonoBehaviour
{
    public static int Difficulty { get; set; }
    public static int Score { get; set; }
    public static int Lives { get; set; }
    public static int damageCoolDown { get; set; }
    public static int totalCoins { get; set; }
    public static bool isLoss { get; set; }
    public static float secondsCount { get; set; }
    public static float minuteCount { get; set; }
}
