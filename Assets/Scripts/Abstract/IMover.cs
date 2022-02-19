using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IMover 
{
    void Move(float directionX, float directionY, float moveSpeed, float rotationSpeed);
}
