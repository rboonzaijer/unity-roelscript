using NUnit.Framework;
using UnityEngine;

public class GridExtensionsTests
{
    #region TestSnapToGrid

    [Test]
    public void TestTransformSnapToGrid()
    {
        var source = new GameObject();
        source.transform.position = new Vector3(.8f, 2.2f, 7.8f);
        source.transform.SnapToGrid(2);

        Assert.AreEqual(0, source.transform.position.x);
        Assert.AreEqual(2.2f, source.transform.position.y);
        Assert.AreEqual(8, source.transform.position.z);
    }

    [Test]
    public void TestTransformSnapToGridWithHeight()
    {
        var source = new GameObject();
        source.transform.position = new Vector3(.8f, 2.2f, 7.8f);
        source.transform.SnapToGrid(2, true);

        Assert.AreEqual(0, source.transform.position.x);
        Assert.AreEqual(2, source.transform.position.y);
        Assert.AreEqual(8, source.transform.position.z);
    }

    [Test]
    public void TestGameObjectSnapToGrid()
    {
        var source = new GameObject();
        source.transform.position = new Vector3(.8f, 2.2f, 7.8f);
        source.SnapToGrid(1);

        Assert.AreEqual(1, source.transform.position.x);
        Assert.AreEqual(2.2f, source.transform.position.y);
        Assert.AreEqual(8, source.transform.position.z);
    }

    [Test]
    public void TestGameObjectSnapToGridWithHeight()
    {
        var source = new GameObject();
        source.transform.position = new Vector3(.8f, 2.2f, 7.8f);
        source.SnapToGrid(1, true);

        Assert.AreEqual(1, source.transform.position.x);
        Assert.AreEqual(2, source.transform.position.y);
        Assert.AreEqual(8, source.transform.position.z);
    }

    #endregion

    #region TestSnapToGridCalc

    [Test]
    public void TestSnapToGridCalcFloat()
    {
        Assert.AreEqual(0, -1f.SnapToGridCalc(3));
        Assert.AreEqual(0, 0f.SnapToGridCalc(3));
        Assert.AreEqual(0, 1f.SnapToGridCalc(3));

        Assert.AreEqual(3, 2f.SnapToGridCalc(3));
        Assert.AreEqual(3, 3f.SnapToGridCalc(3));
        Assert.AreEqual(3, 3.5f.SnapToGridCalc(3));
        Assert.AreEqual(3, 4f.SnapToGridCalc(3));

        Assert.AreEqual(6, 5f.SnapToGridCalc(3));
        Assert.AreEqual(6, 6f.SnapToGridCalc(3));
        Assert.AreEqual(6, 7f.SnapToGridCalc(3));
    }

    [Test]
    public void TestSnapToGridCalcVector3()
    {
        var source = new Vector3(.8f, 2.2f, 7.8f);
        Vector3 value = source.SnapToGridCalc(2);

        Assert.AreEqual(0, value.x);
        Assert.AreEqual(2.2f, value.y);
        Assert.AreEqual(8, value.z);
    }
    
    [Test]
    public void TestSnapToGridCalcVector3WithHeight()
    {
        var source = new Vector3(.8f, 2.2f, 7.8f);
        Vector3 value = source.SnapToGridCalc(2, true);

        Assert.AreEqual(0, value.x);
        Assert.AreEqual(2, value.y);
        Assert.AreEqual(8, value.z);
    }

    [Test]
    public void TestSnapToGridCalcTransform()
    {
        var source = new GameObject();
        source.transform.position = new Vector3(.8f, 2.2f, 7.8f);
        Vector3 value = source.transform.SnapToGridCalc(2);

        Assert.AreEqual(0, value.x);
        Assert.AreEqual(2.2f, value.y);
        Assert.AreEqual(8, value.z);
    }

    [Test]
    public void TestSnapToGridCalcTransformWithHeight()
    {
        var source = new GameObject();
        source.transform.position = new Vector3(.8f, 2.2f, 7.8f);
        Vector3 value = source.transform.SnapToGridCalc(2, true);

        Assert.AreEqual(0, value.x);
        Assert.AreEqual(2, value.y);
        Assert.AreEqual(8, value.z);
    }

    [Test]
    public void TestSnapToGridCalcGameObject()
    {
        var source = new GameObject();
        source.transform.position = new Vector3(.8f, 2.2f, 7.8f);
        Vector3 value = source.SnapToGridCalc(1);

        Assert.AreEqual(1, value.x);
        Assert.AreEqual(2.2f, value.y);
        Assert.AreEqual(8, value.z);
    }

    [Test]
    public void TestSnapToGridCalcGameObjectWithHeight()
    {
        var source = new GameObject();
        source.transform.position = new Vector3(.8f, 2.2f, 7.8f);
        Vector3 value = source.SnapToGridCalc(1, true);

        Assert.AreEqual(1, value.x);
        Assert.AreEqual(2, value.y);
        Assert.AreEqual(8, value.z);
    }

    #endregion
}
