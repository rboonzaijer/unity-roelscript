using UnityEngine;

public static class DistanceExtensions
{
    #region Distance

    /// <summary>
    /// RoelScript: Calculate the distance between two Vector2's
    /// </summary>
    /// <param name="source"></param>
    /// <param name="target"></param>
    /// <returns></returns>
    public static float Distance(this Vector2 source, Vector2 target)
    {
        return Vector2.Distance(source, target);
    }

    /// <summary>
    /// RoelScript: Calculate the distance to the target
    /// </summary>
    /// <param name="source"></param>
    /// <param name="target"></param>
    /// <returns></returns>
    public static float Distance(this Vector3 source, Vector3 target)
    {
        return Vector3.Distance(source, target);
    }

    /// <summary>
    /// RoelScript: Calculate the distance to the target
    /// </summary>
    /// <param name="source"></param>
    /// <param name="target"></param>
    /// <returns></returns>
    public static float Distance(this Vector3 source, Transform target)
    {
        return source.Distance(target.position);
    }

    /// <summary>
    /// RoelScript: Calculate the distance to the target
    /// </summary>
    /// <param name="source"></param>
    /// <param name="target"></param>
    /// <returns></returns>
    public static float Distance(this Vector3 source, GameObject target)
    {
        return source.Distance(target.transform.position);
    }

    /// <summary>
    /// RoelScript: Calculate the distance to the target
    /// </summary>
    /// <param name="source"></param>
    /// <param name="target"></param>
    /// <returns></returns>
    public static float Distance(this Transform source, Vector3 target)
    {
        return source.position.Distance(target);
    }

    /// <summary>
    /// RoelScript: Calculate the distance to the target
    /// </summary>
    /// <param name="source"></param>
    /// <param name="target"></param>
    /// <returns></returns>
    public static float Distance(this Transform source, Transform target)
    {
        return source.position.Distance(target.position);
    }

    /// <summary>
    /// RoelScript: Calculate the distance to the target
    /// </summary>
    /// <param name="source"></param>
    /// <param name="target"></param>
    /// <returns></returns>
    public static float Distance(this Transform source, GameObject target)
    {
        return source.position.Distance(target.transform.position);
    }

    /// <summary>
    /// RoelScript: Calculate the distance to the target
    /// </summary>
    /// <param name="source"></param>
    /// <param name="target"></param>
    /// <returns></returns>
    public static float Distance(this GameObject source, Vector3 target)
    {
        return source.transform.position.Distance(target);
    }

    /// <summary>
    /// RoelScript: Calculate the distance to the target
    /// </summary>
    /// <param name="source"></param>
    /// <param name="target"></param>
    /// <returns></returns>
    public static float Distance(this GameObject source, Transform target)
    {
        return source.transform.position.Distance(target.position);
    }

    /// <summary>
    /// RoelScript: Calculate the distance to the target
    /// </summary>
    /// <param name="source"></param>
    /// <param name="target"></param>
    /// <returns></returns>
    public static float Distance(this GameObject source, GameObject target)
    {
        return source.transform.position.Distance(target.transform.position);
    }

    #endregion

    #region InRange

    /// <summary>
    /// RoelScript: Is the target in range
    /// </summary>
    /// <param name="source"></param>
    /// <param name="target"></param>
    /// <param name="range"></param>
    /// <returns></returns>
    public static bool InRange(this Vector2 source, Vector2 target, float range)
    {
        return Vector2.Distance(source, target) <= range;
    }

    /// <summary>
    /// RoelScript: Is the target in range
    /// </summary>
    /// <param name="source"></param>
    /// <param name="target"></param>
    /// <param name="range"></param>
    /// <returns></returns>
    public static bool InRange(this Vector3 source, Vector3 target, float range)
    {
        return Vector3.Distance(source, target) <= range;
    }

    /// <summary>
    /// RoelScript: Is the target in range
    /// </summary>
    /// <param name="source"></param>
    /// <param name="target"></param>
    /// <param name="range"></param>
    /// <returns></returns>
    public static bool InRange(this Vector3 source, Transform target, float range)
    {
        return source.InRange(target.position, range);
    }

    /// <summary>
    /// RoelScript: Is the target in range
    /// </summary>
    /// <param name="source"></param>
    /// <param name="target"></param>
    /// <param name="range"></param>
    /// <returns></returns>
    public static bool InRange(this Vector3 source, GameObject target, float range)
    {
        return source.InRange(target.transform.position, range);
    }

    /// <summary>
    /// RoelScript: Is the target in range
    /// </summary>
    /// <param name="source"></param>
    /// <param name="target"></param>
    /// <param name="range"></param>
    /// <returns></returns>
    public static bool InRange(this Transform source, Vector3 target, float range)
    {
        return source.position.InRange(target, range);
    }

    /// <summary>
    /// RoelScript: Is the target in range
    /// </summary>
    /// <param name="source"></param>
    /// <param name="target"></param>
    /// <param name="range"></param>
    /// <returns></returns>
    public static bool InRange(this Transform source, Transform target, float range)
    {
        return source.position.InRange(target.position, range);
    }

    /// <summary>
    /// RoelScript: Is the target in range
    /// </summary>
    /// <param name="source"></param>
    /// <param name="target"></param>
    /// <param name="range"></param>
    /// <returns></returns>
    public static bool InRange(this Transform source, GameObject target, float range)
    {
        return source.position.InRange(target.transform.position, range);
    }

    /// <summary>
    /// RoelScript: Is the target in range
    /// </summary>
    /// <param name="source"></param>
    /// <param name="target"></param>
    /// <param name="range"></param>
    /// <returns></returns>
    public static bool InRange(this GameObject source, Vector3 target, float range)
    {
        return source.transform.position.InRange(target, range);
    }

    /// <summary>
    /// RoelScript: Is the target in range
    /// </summary>
    /// <param name="source"></param>
    /// <param name="target"></param>
    /// <param name="range"></param>
    /// <returns></returns>
    public static bool InRange(this GameObject source, Transform target, float range)
    {
        return source.transform.position.InRange(target.position, range);
    }

    /// <summary>
    /// RoelScript: Is the target in range
    /// </summary>
    /// <param name="source"></param>
    /// <param name="target"></param>
    /// <param name="range"></param>
    /// <returns></returns>
    public static bool InRange(this GameObject source, GameObject target, float range)
    {
        return source.transform.position.InRange(target.transform.position, range);
    }

    #endregion

    #region FlatDistance

    /// <summary>
    /// RoelScript: Calculate the flat distance to the target (ignoring the height y)
    /// </summary>
    /// <param name="source"></param>
    /// <param name="target"></param>
    /// <returns></returns>
    public static float FlatDistance(this Vector3 source, Vector3 target)
    {
        Vector2 sourceFlat = new Vector2(source.x, source.z);
        Vector2 targetFlat = new Vector2(target.x, target.z);

        return Vector2.Distance(sourceFlat, targetFlat);
    }

    /// <summary>
    /// RoelScript: Calculate the flat distance to the target (ignoring the height y)
    /// </summary>
    /// <param name="source"></param>
    /// <param name="target"></param>
    /// <returns></returns>
    public static float FlatDistance(this Vector3 source, Transform target)
    {
        return source.FlatDistance(target.position);
    }

    /// <summary>
    /// RoelScript: Calculate the flat distance to the target (ignoring the height y)
    /// </summary>
    /// <param name="source"></param>
    /// <param name="target"></param>
    /// <returns></returns>
    public static float FlatDistance(this Vector3 source, GameObject target)
    {
        return source.FlatDistance(target.transform.position);
    }

    /// <summary>
    /// RoelScript: Calculate the flat distance to the target (ignoring the height y)
    /// </summary>
    /// <param name="source"></param>
    /// <param name="target"></param>
    /// <returns></returns>
    public static float FlatDistance(this Transform source, Vector3 target)
    {
        return source.position.FlatDistance(target);
    }

    /// <summary>
    /// RoelScript: Calculate the flat distance to the target (ignoring the height y)
    /// </summary>
    /// <param name="source"></param>
    /// <param name="target"></param>
    /// <returns></returns>
    public static float FlatDistance(this Transform source, Transform target)
    {
        return source.position.FlatDistance(target.position);
    }

    /// <summary>
    /// RoelScript: Calculate the flat distance to the target (ignoring the height y)
    /// </summary>
    /// <param name="source"></param>
    /// <param name="target"></param>
    /// <returns></returns>
    public static float FlatDistance(this Transform source, GameObject target)
    {
        return source.position.FlatDistance(target.transform.position);
    }

    /// <summary>
    /// RoelScript: Calculate the flat distance to the target (ignoring the height y)
    /// </summary>
    /// <param name="source"></param>
    /// <param name="target"></param>
    /// <returns></returns>
    public static float FlatDistance(this GameObject source, Vector3 target)
    {
        return source.transform.position.FlatDistance(target);
    }

    /// <summary>
    /// RoelScript: Calculate the flat distance to the target (ignoring the height y)
    /// </summary>
    /// <param name="source"></param>
    /// <param name="target"></param>
    /// <returns></returns>
    public static float FlatDistance(this GameObject source, Transform target)
    {
        return source.transform.position.FlatDistance(target.position);
    }

    /// <summary>
    /// RoelScript: Calculate the flat distance to the target (ignoring the height y)
    /// </summary>
    /// <param name="source"></param>
    /// <param name="target"></param>
    /// <returns></returns>
    public static float FlatDistance(this GameObject source, GameObject target)
    {
        return source.transform.position.FlatDistance(target.transform.position);
    }

    #endregion

    #region InFlatRange

    /// <summary>
    /// RoelScript: Is the target in flat range (ignoring the height y)
    /// </summary>
    /// <param name="source"></param>
    /// <param name="target"></param>
    /// <param name="range"></param>
    /// <returns></returns>
    public static bool InFlatRange(this Vector3 source, Vector3 target, float range)
    {
        return source.FlatDistance(target) <= range;
    }

    /// <summary>
    /// RoelScript: Is the target in flat range (ignoring the height y)
    /// </summary>
    /// <param name="source"></param>
    /// <param name="target"></param>
    /// <param name="range"></param>
    /// <returns></returns>
    public static bool InFlatRange(this Vector3 source, Transform target, float range)
    {
        return source.InFlatRange(target.position, range);
    }

    /// <summary>
    /// RoelScript: Is the target in flat range (ignoring the height y)
    /// </summary>
    /// <param name="source"></param>
    /// <param name="target"></param>
    /// <param name="range"></param>
    /// <returns></returns>
    public static bool InFlatRange(this Vector3 source, GameObject target, float range)
    {
        return source.InFlatRange(target.transform.position, range);
    }

    /// <summary>
    /// RoelScript: Is the target in flat range (ignoring the height y)
    /// </summary>
    /// <param name="source"></param>
    /// <param name="target"></param>
    /// <param name="range"></param>
    /// <returns></returns>
    public static bool InFlatRange(this Transform source, Vector3 target, float range)
    {
        return source.position.InFlatRange(target, range);
    }

    /// <summary>
    /// RoelScript: Is the target in flat range (ignoring the height y)
    /// </summary>
    /// <param name="source"></param>
    /// <param name="target"></param>
    /// <param name="range"></param>
    /// <returns></returns>
    public static bool InFlatRange(this Transform source, Transform target, float range)
    {
        return source.position.InFlatRange(target.position, range);
    }

    /// <summary>
    /// RoelScript: Is the target in flat range (ignoring the height y)
    /// </summary>
    /// <param name="source"></param>
    /// <param name="target"></param>
    /// <param name="range"></param>
    /// <returns></returns>
    public static bool InFlatRange(this Transform source, GameObject target, float range)
    {
        return source.position.InFlatRange(target.transform.position, range);
    }

    /// <summary>
    /// RoelScript: Is the target in flat range (ignoring the height y)
    /// </summary>
    /// <param name="source"></param>
    /// <param name="target"></param>
    /// <param name="range"></param>
    /// <returns></returns>
    public static bool InFlatRange(this GameObject source, Vector3 target, float range)
    {
        return source.transform.position.InFlatRange(target, range);
    }

    /// <summary>
    /// RoelScript: Is the target in flat range (ignoring the height y)
    /// </summary>
    /// <param name="source"></param>
    /// <param name="target"></param>
    /// <param name="range"></param>
    /// <returns></returns>
    public static bool InFlatRange(this GameObject source, Transform target, float range)
    {
        return source.transform.position.InFlatRange(target.position, range);
    }

    /// <summary>
    /// RoelScript: Is the target in flat range (ignoring the height y)
    /// </summary>
    /// <param name="source"></param>
    /// <param name="target"></param>
    /// <param name="range"></param>
    /// <returns></returns>
    public static bool InFlatRange(this GameObject source, GameObject target, float range)
    {
        return source.transform.position.InFlatRange(target.transform.position, range);
    }

    #endregion

    #region Closest

    /// <summary>
    /// RoelScript: Find the closest object from a list of objects within a given range
    /// </summary>
    /// <param name="sourcePosition"></param>
    /// <param name="objects"></param>
    /// <param name="range"></param>
    /// <param name="invertRange"></param>
    /// <returns></returns>
    public static Vector3 Closest(this Vector3 sourcePosition, Vector3[] objects, float range = Mathf.Infinity, bool invertRange = false)
    {
        Vector3 closest = Vector3.zero;
        float closestDistance = Mathf.Infinity;
        float distance = Mathf.Infinity;

        for (int i = 0; i < objects.Length; i++)
        {
            distance = Vector3.Distance(sourcePosition, objects[i]);

            if (range == Mathf.Infinity || (invertRange == false && distance <= range) || (invertRange == true && distance > range))
            {
                if (distance < closestDistance)
                {
                    closestDistance = distance;
                    closest = objects[i];
                }
            }
        }
        return closest;
    }

    /// <summary>
    /// RoelScript: Find the closest object from a list of objects within a given range
    /// </summary>
    /// <param name="sourcePosition"></param>
    /// <param name="objects"></param>
    /// <param name="range"></param>
    /// <param name="invertRange"></param>
    /// <returns></returns>
    public static Transform Closest(this Vector3 sourcePosition, Transform[] objects, float range = Mathf.Infinity, bool invertRange = false)
    {
        Transform closest = null;
        float closestDistance = Mathf.Infinity;
        float distance = Mathf.Infinity;

        for (int i = 0; i < objects.Length; i++)
        {
            distance = Vector3.Distance(sourcePosition, objects[i].position);

            if (range == Mathf.Infinity || (invertRange == false && distance <= range) || (invertRange == true && distance > range))
            {
                if (distance < closestDistance)
                {
                    closestDistance = distance;
                    closest = objects[i];
                }
            }
        }
        return closest;
    }

    /// <summary>
    /// RoelScript: Find the closest object from a list of objects within a given range
    /// </summary>
    /// <param name="sourcePosition"></param>
    /// <param name="objects"></param>
    /// <param name="range"></param>
    /// <param name="invertRange"></param>
    /// <returns></returns>
    public static GameObject Closest(this Vector3 sourcePosition, GameObject[] objects, float range = Mathf.Infinity, bool invertRange = false)
    {
        GameObject closest = null;
        float closestDistance = Mathf.Infinity;
        float distance = Mathf.Infinity;

        for (int i = 0; i < objects.Length; i++)
        {
            distance = Vector3.Distance(sourcePosition, objects[i].transform.position);

            if (range == Mathf.Infinity || (invertRange == false && distance <= range) || (invertRange == true && distance > range))
            {
                if (distance < closestDistance)
                {
                    closestDistance = distance;
                    closest = objects[i];
                }
            }
        }
        return closest;
    }

    /// <summary>
    /// RoelScript: Find the closest object from a list of objects within a given range
    /// </summary>
    /// <param name="sourcePosition"></param>
    /// <param name="objects"></param>
    /// <param name="range"></param>
    /// <param name="invertRange"></param>
    /// <returns></returns>
    public static Component Closest(this Vector3 sourcePosition, Component[] objects, float range = Mathf.Infinity, bool invertRange = false)
    {
        Component closest = null;
        float closestDistance = Mathf.Infinity;
        float distance = Mathf.Infinity;

        for (int i = 0; i < objects.Length; i++)
        {
            distance = Vector3.Distance(sourcePosition, objects[i].transform.position);

            if (range == Mathf.Infinity || (invertRange == false && distance <= range) || (invertRange == true && distance > range))
            {
                if (distance < closestDistance)
                {
                    closestDistance = distance;
                    closest = objects[i];
                }
            }
        }
        return closest;
    }

    #endregion
}
