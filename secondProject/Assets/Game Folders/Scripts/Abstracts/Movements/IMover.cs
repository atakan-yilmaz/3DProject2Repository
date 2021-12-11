using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace secondProject.Abstracts.Movements
{
    public interface IMover 
    {
        void FixedTick(float direction);
    }
}

