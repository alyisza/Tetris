﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IScore
{ 
    int Score { get; }

    void Reset();
    void AddToScore(int value);
}
