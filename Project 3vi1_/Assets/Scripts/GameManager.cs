using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public static class GameManager 
{
    public static int player_health = 100;

    public static int boss_health = 50;//
    public static int boss_shape;

    
    public static int boss_attack_type = 2;//
    public static int boss_attack_range;
    public static int boss_attack_delay = 3;//
    public static int boss_attack_speed = 5;//
    public static int boss_attack_damage = 5;//
    public static int boss_attack_directions = 2;//


    public static int boss_move_speed = 30;//
    public static int boss_move_pattern;//


    public static int boss_tracking;
    public static int boss_tracking_speed;//
    public static int boss_tracking_strength;//


    public static int spawns_on;
    public static int spawns_health;

    public static float volume = .5f;
    public static float effectsvolume = .5f;



    public static int spawns_move_speed;
    public static int spawns_attack_damage;
    public static int spawns_attack_speed;
    public static int spawns_attack_range;

    public static bool boss_hit;

}
