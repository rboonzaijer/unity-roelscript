using UnityEngine;

public static class GridExtensions
{
    #region SnapToGrid

    /// <summary>
    /// RoelScript: Snap to a given grid size (apply directly to the position of the Transform)
    /// </summary>
    /// <param name="source"></param>
    /// <param name="gridSize"></param>
    /// <param name="includeHeight"></param>
    public static void SnapToGrid(this Transform source, float gridSize = .5f, bool alsoSnapToHeight = false)
    {
        source.position = source.SnapToGridCalc(gridSize, alsoSnapToHeight);
    }

    /// <summary>
    /// RoelScript: Snap to a given grid size (apply directly to the position of the GameObject's transform)
    /// </summary>
    /// <param name="source"></param>
    /// <param name="gridSize"></param>
    /// <param name="includeHeight"></param>
    public static void SnapToGrid(this GameObject source, float gridSize = .5f, bool alsoSnapToHeight = false)
    {
        source.transform.position = source.SnapToGridCalc(gridSize, alsoSnapToHeight);
    }

    #endregion

    #region SnapToGridCalc

    /// <summary>
    /// RoelScript: Calculate a float for snapping to a grid
    /// </summary>
    /// <param name="value"></param>
    /// <param name="gridSize"></param>
    /// <returns></returns>
    public static float SnapToGridCalc(this float value, float gridSize = .5f)
    {
        return Mathf.RoundToInt(value / gridSize) * gridSize;
    }

    /// <summary>
    /// RoelScript: Calculate a Vector3 position for snapping to a grid
    /// </summary>
    /// <param name="position"></param>
    /// <param name="gridSize"></param>
    /// <param name="includeHeight"></param>
    /// <returns></returns>
    public static Vector3 SnapToGridCalc(this Vector3 position, float gridSize = .5f, bool includeHeight = false)
    {
        if (includeHeight == true)
        {
            return new Vector3
            {
                x = SnapToGridCalc(position.x, gridSize),
                y = SnapToGridCalc(position.y, gridSize),
                z = SnapToGridCalc(position.z, gridSize)
            };
        }
        return new Vector3
        {
            x = SnapToGridCalc(position.x, gridSize),
            y = position.y,
            z = SnapToGridCalc(position.z, gridSize)
        };
    }

    /// <summary>
    /// RoelScript: Calculate a Vector3 position for snapping to a grid
    /// </summary>
    /// <param name="position"></param>
    /// <param name="gridSize"></param>
    /// <param name="includeHeight"></param>
    /// <returns></returns>
    public static Vector3 SnapToGridCalc(this Transform source, float gridSize = .5f, bool includeHeight = false)
    {
        return source.position.SnapToGridCalc(gridSize, includeHeight);
    }

    /// <summary>
    /// RoelScript: Calculate a Vector3 position for snapping to a grid
    /// </summary>
    /// <param name="position"></param>
    /// <param name="gridSize"></param>
    /// <param name="includeHeight"></param>
    /// <returns></returns>
    public static Vector3 SnapToGridCalc(this GameObject source, float gridSize = .5f, bool includeHeight = false)
    {
        return source.transform.position.SnapToGridCalc(gridSize, includeHeight);
    }

    #endregion
}
