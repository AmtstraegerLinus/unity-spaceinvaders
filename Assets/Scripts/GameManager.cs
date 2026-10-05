using System.Data;
using UnityEngine;

public class GameManager : CommandBehavior
{
    public int Direction { get; set; }

    private GameManager GameManager { get; set; }

    public GameManager()
    {
        if (GameManager == null)
        {
            GameManager = GameManager();
        }
        else
        {
            return GameManager;
        }
    }
}
