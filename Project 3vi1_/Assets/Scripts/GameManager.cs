using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public static class GameManager 
{
    public static int player_health = 100;

    public static int boss_health = 100;//
    public static int boss_shape;

    
    public static int boss_attack_type = 1;//
    public static int boss_attack_range;
    public static int boss_attack_delay = 2;//
    public static int boss_attack_speed = 10;//
    public static int boss_attack_damage = 20;//
    public static int boss_attack_directions;//


    public static int boss_move_speed = 40;//
    public static int boss_move_pattern;//


    public static int boss_tracking;
    public static int boss_tracking_speed;//
    public static int boss_tracking_strength;//


    public static int spawns_on;
    public static int spawns_health;


    public static int spawns_move_speed;
    public static int spawns_attack_damage;
    public static int spawns_attack_speed;
    public static int spawns_attack_range;

    public static bool boss_hit;

}
