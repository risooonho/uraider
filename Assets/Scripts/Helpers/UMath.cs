﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class UMath
{
    public static float GetHorizontalMag(Vector3 vector)
    {
        return Mathf.Sqrt(Mathf.Pow(vector.x, 2) + Mathf.Pow(vector.z, 2));
    }

    public static Vector3 VelocityToReachPoint(Vector3 start, Vector3 end, float gravity, float time)
    {
        Vector3 relative = end - start;
        Vector3 dir = relative.normalized;
        float xzResultant = Mathf.Sqrt(Mathf.Pow(relative.z, 2) + Mathf.Pow(relative.x, 2));
        float xz = xzResultant / time;  // u = s/t
        float y = (relative.y - (0.5f * (-gravity) * Mathf.Pow(time, 2))) / time;  // u = (s - 0.5at^2) / t
        return new Vector3(xz * dir.x, y, xz * dir.z);
    }
}