using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class WorldCreatorCalculator
{
    
    public static int[] CreateRadiusArray (int worldSize, int unitType)
    {
        float worldRadius;
        //Convert unitType == 0 as circumference and unitType == 2 as diameter
        switch (unitType)
        {
            case 0:
                worldRadius = worldSize / (2 * Mathf.PI);
                break;
            case 2:
                worldRadius = (float)worldSize / 2;
                break;
            default:
                worldRadius = worldSize;
                break;
        }

        int truncWorldRadius = (int)Mathf.Floor(worldRadius);

        int[] circumferences = new int[truncWorldRadius + 1]; //radius plus an extra for the "0" (circumference)

        circumferences[0] = (unitType == 0) ? worldSize : Mathf.RoundToInt(2 * Mathf.PI * worldRadius);
        for (int i = 1; i <= truncWorldRadius; i++)
        {
            float radiusI;
            radiusI = Mathf.Sqrt(Mathf.Pow(worldRadius, 2) - Mathf.Pow(i, 2));
            circumferences[i] = Mathf.RoundToInt(2 * Mathf.PI * radiusI);
        }

        return circumferences;
    }
}
