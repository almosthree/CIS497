﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ObserverPattern { 
public interface IEntity
{
        void JumpsUpdate();

        void DeathUpdate();
}
}
