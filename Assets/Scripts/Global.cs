using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Global
{
    static public bool isBlack;
    static public GameObject player;
    static public GameObject white;
    static public GameObject black;
    static public GameObject BG;
    static public Transform blackBound;
    static public Transform whiteBound;

    static public class level1
    {
        public static GameObject jumpbuild;
        public static GameObject jumpbuild2;
        public static Vector3 targetPos;
        public static Vector3 targetPos2;
    }

    static public class level2
    {
        public static GameObject cube;
        public static GameObject cubeW;
        public static GameObject cubeB;
    }
}
