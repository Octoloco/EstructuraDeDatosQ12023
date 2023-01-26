using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAlineVargas : MonoBehaviour
{
    public string Name;
    public int Life;
    public int Experience;
    public int Level;
    public int Speed;
    // Start is called before the first frame update
    void Start()
    {
        Name = "Alinestaa";
        Life = 45;
        Experience = 0;
        Level = 1;
        Speed = 50;
    }
    public string ShowName()
    {
        string showName = Name;
        return showName;
    }
    public int ConsumeMushroom()
    {
        int consumeMushroom = Life + 30;
        return consumeMushroom;
    }
    public int EnemyDefeat()
    {
        int enemyDefeat = Experience + 30;
        return enemyDefeat;
    }
    public int LevelUp()
    {
        int levelUp = Level + 1;
        return levelUp;
    }
    public int RunningAbility()
    {
        int runningAbility = Speed + 30;
        return runningAbility;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
