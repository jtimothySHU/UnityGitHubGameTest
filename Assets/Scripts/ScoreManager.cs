﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour

{

    
    public static int score = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void Awake()
    {
        DontDestroyOnLoad(this);
    }

    // Update is called once per frame
    void Update()
    {
      
    }
}
