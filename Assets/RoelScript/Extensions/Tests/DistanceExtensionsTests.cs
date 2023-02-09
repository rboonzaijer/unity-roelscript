using NUnit.Framework;
using UnityEngine;

public class DistanceExtensionsTests
{
    #region TestDistance

    [Test]
    public void TestDistanceVector2()
    {
        Vector2 source = Vector2.zero;
        Vector2 target = new Vector2(0, 2);

        Assert.AreEqual(2, source.Distance(target));
    }

    [Test]
    public void TestDistanceVector3vsVector3()
    {
        Vector3 source = Vector3.zero;
        Vector3 target = new Vector3(0, 0, 2);

        Assert.AreEqual(2, source.Distance(target));
    }

    [Test]
    public void TestDistanceVector3vsTransform()
    {
        Vector3 source = Vector3.zero;

        GameObject target = new GameObject();
        target.transform.position = new Vector3(0, 0, 2);

        Assert.AreEqual(2, source.Distance(target.transform));
    }

    [Test]
    public void TestDistanceVector3vsGameObject()
    {
        Vector3 source = Vector3.zero;

        GameObject target = new GameObject();
        target.transform.position = new Vector3(0, 0, 2);

        Assert.AreEqual(2, source.Distance(target));
    }

    [Test]
    public void TestDistanceTransformvsVector3()
    {
        GameObject source = new GameObject();
        Vector3 target = new Vector3(0, 0, 2);

        Assert.AreEqual(2, source.transform.Distance(target));
    }

    [Test]
    public void TestDistanceTransformvsTransform()
    {
        GameObject source = new GameObject();
        GameObject target = new GameObject();
        target.transform.position = new Vector3(0, 0, 2);

        Assert.AreEqual(2, source.transform.Distance(target.transform));
    }

    [Test]
    public void TestDistanceTransformvsGameObject()
    {
        GameObject source = new GameObject();
        GameObject target = new GameObject();
        target.transform.position = new Vector3(0, 0, 2);

        Assert.AreEqual(2, source.transform.Distance(target));
    }

    [Test]
    public void TestDistanceGameObjectvsVector3()
    {
        GameObject source = new GameObject();
        Vector3 target = new Vector3(0, 0, 2);

        Assert.AreEqual(2, source.Distance(target));
    }

    [Test]
    public void TestDistanceGameObjectvsTransform()
    {
        GameObject source = new GameObject();
        GameObject target = new GameObject();
        target.transform.position = new Vector3(0, 0, 2);

        Assert.AreEqual(2, source.Distance(target.transform));
    }

    [Test]
    public void TestDistanceGameObjectvsGameObject()
    {
        GameObject source = new GameObject();
        GameObject target = new GameObject();
        target.transform.position = new Vector3(0, 0, 2);

        Assert.AreEqual(2, source.Distance(target));
    }

    #endregion

    #region TestInRange

    [Test]
    public void TestInRangeVector2()
    {
        Vector2 source = Vector2.zero;
        Vector2 target = new Vector2(0, 2);

        Assert.IsTrue(source.InRange(target, 10));
        Assert.IsTrue(source.InRange(target, 2));
        Assert.IsFalse(source.InRange(target, 1.999999f));
    }

    [Test]
    public void TestInRangeVector3vsVector3()
    {
        Vector3 source = Vector3.zero;
        Vector3 target = new Vector3(0, 0, 2);

        Assert.IsTrue(source.InRange(target, 10));
        Assert.IsTrue(source.InRange(target, 2));
        Assert.IsFalse(source.InRange(target, 1.999999f));
    }

    [Test]
    public void TestInRangeVector3vsVector3Invalid()
    {
        Vector3 source = Vector3.zero;
        Vector3 target = new Vector3(0, 999, 2);

        Assert.IsFalse(source.InRange(target, 10));
        Assert.IsFalse(source.InRange(target, 2));
        Assert.IsFalse(source.InRange(target, 1.999999f));
    }

    [Test]
    public void TestInRangeVector3vsTransform()
    {
        Vector3 source = Vector3.zero;

        GameObject target = new GameObject();
        target.transform.position = new Vector3(0, 0, 2);

        Assert.IsTrue(source.InRange(target.transform, 10));
        Assert.IsTrue(source.InRange(target.transform, 2));
        Assert.IsFalse(source.InRange(target.transform, 1.999999f));
    }

    [Test]
    public void TestInRangeVector3vsGameObject()
    {
        Vector3 source = Vector3.zero;

        GameObject target = new GameObject();
        target.transform.position = new Vector3(0, 0, 2);

        Assert.IsTrue(source.InRange(target, 10));
        Assert.IsTrue(source.InRange(target, 2));
        Assert.IsFalse(source.InRange(target, 1.999999f));
    }

    [Test]
    public void TestInRangeTransformvsVector3()
    {
        GameObject source = new GameObject();
        Vector3 target = new Vector3(0, 0, 2);

        Assert.IsTrue(source.transform.InRange(target, 10));
        Assert.IsTrue(source.transform.InRange(target, 2));
        Assert.IsFalse(source.transform.InRange(target, 1.999999f));
    }

    [Test]
    public void TestInRangeTransformvsTransform()
    {
        GameObject source = new GameObject();
        GameObject target = new GameObject();
        target.transform.position = new Vector3(0, 0, 2);

        Assert.IsTrue(source.transform.InRange(target.transform, 10));
        Assert.IsTrue(source.transform.InRange(target.transform, 2));
        Assert.IsFalse(source.transform.InRange(target.transform, 1.999999f));
    }

    [Test]
    public void TestInRangeTransformvsGameObject()
    {
        GameObject source = new GameObject();
        GameObject target = new GameObject();
        target.transform.position = new Vector3(0, 0, 2);

        Assert.IsTrue(source.transform.InRange(target, 10));
        Assert.IsTrue(source.transform.InRange(target, 2));
        Assert.IsFalse(source.transform.InRange(target, 1.999999f));
    }

    [Test]
    public void TestInRangeGameObjectvsVector3()
    {
        GameObject source = new GameObject();
        Vector3 target = new Vector3(0, 0, 2);

        Assert.IsTrue(source.InRange(target, 10));
        Assert.IsTrue(source.InRange(target, 2));
        Assert.IsFalse(source.InRange(target, 1.999999f));
    }

    [Test]
    public void TestInRangeGameObjectvsTransform()
    {
        GameObject source = new GameObject();
        GameObject target = new GameObject();
        target.transform.position = new Vector3(0, 0, 2);

        Assert.IsTrue(source.InRange(target.transform, 10));
        Assert.IsTrue(source.InRange(target.transform, 2));
        Assert.IsFalse(source.InRange(target.transform, 1.999999f));
    }

    [Test]
    public void TestInRangeGameObjectvsGameObject()
    {
        GameObject source = new GameObject();
        GameObject target = new GameObject();
        target.transform.position = new Vector3(0, 0, 2);

        Assert.IsTrue(source.InRange(target, 10));
        Assert.IsTrue(source.InRange(target, 2));
        Assert.IsFalse(source.InRange(target, 1.999999f));
    }

    #endregion

    #region TestFlatDistance

    [Test]
    public void TestFlatDistanceVector3vsVector3()
    {
        var source = Vector3.zero;
        var target = new Vector3(0, 999, 2);

        Assert.AreEqual(2, source.FlatDistance(target));
    }

    [Test]
    public void TestFlatDistanceVector3vsTransform()
    {
        var source = Vector3.zero;
        var target = new GameObject();
        target.transform.position = new Vector3(0, 999, 2);

        Assert.AreEqual(2, source.FlatDistance(target.transform));
    }

    [Test]
    public void TestFlatDistanceVector3vsGameObject()
    {
        var source = Vector3.zero;
        var target = new GameObject();
        target.transform.position = new Vector3(0, 999, 2);

        Assert.AreEqual(2, source.FlatDistance(target));
    }

    [Test]
    public void TestFlatDistanceTransformvsVector3()
    {
        var source = new GameObject();
        var target = new Vector3(0, 999, 2);

        Assert.AreEqual(2, source.transform.FlatDistance(target));
    }

    [Test]
    public void TestFlatDistanceTransformvsTransform()
    {
        var source = new GameObject();
        var target = new GameObject();
        target.transform.position = new Vector3(0, 999, 2);

        Assert.AreEqual(2, source.transform.FlatDistance(target.transform));
    }

    [Test]
    public void TestFlatDistanceTransformvsGameObject()
    {
        var source = new GameObject();
        var target = new GameObject();
        target.transform.position = new Vector3(0, 999, 2);

        Assert.AreEqual(2, source.transform.FlatDistance(target));
    }

    [Test]
    public void TestFlatDistanceGameObjectvsVector3()
    {
        var source = new GameObject();
        var target = new Vector3(0, 999, 2);

        Assert.AreEqual(2, source.FlatDistance(target));
    }

    [Test]
    public void TestFlatDistanceGameObjectvsTransform()
    {
        var source = new GameObject();
        var target = new GameObject();
        target.transform.position = new Vector3(0, 999, 2);

        Assert.AreEqual(2, source.FlatDistance(target.transform));
    }

    [Test]
    public void TestFlatDistanceGameObjectvsGameObject()
    {
        var source = new GameObject();
        var target = new GameObject();
        target.transform.position = new Vector3(0, 999, 2);

        Assert.AreEqual(2, source.FlatDistance(target));
    }

    #endregion

    #region TestInFlatRange

    [Test]
    public void TestInFlatRangeVector3vsVector3()
    {
        var source = Vector3.zero;
        var target = new Vector3(0, 999, 2);

        Assert.IsTrue(source.InFlatRange(target, 10));
        Assert.IsTrue(source.InFlatRange(target, 2));
        Assert.IsFalse(source.InFlatRange(target, 1.999999f));
    }

    [Test]
    public void TestInFlatRangeVector3vsTransform()
    {
        var source = Vector3.zero;
        var target = new GameObject();
        target.transform.position = new Vector3(0, 999, 2);

        Assert.IsTrue(source.InFlatRange(target.transform, 10));
        Assert.IsTrue(source.InFlatRange(target.transform, 2));
        Assert.IsFalse(source.InFlatRange(target.transform, 1.999999f));
    }

    [Test]
    public void TestInFlatRangeVector3vsGameObject()
    {
        var source = Vector3.zero;
        var target = new GameObject();
        target.transform.position = new Vector3(0, 999, 2);

        Assert.IsTrue(source.InFlatRange(target, 10));
        Assert.IsTrue(source.InFlatRange(target, 2));
        Assert.IsFalse(source.InFlatRange(target, 1.999999f));
    }

    [Test]
    public void TestInFlatRangeTransformvsVector3()
    {
        var source = new GameObject();
        var target = new Vector3(0, 999, 2);

        Assert.IsTrue(source.transform.InFlatRange(target, 10));
        Assert.IsTrue(source.transform.InFlatRange(target, 2));
        Assert.IsFalse(source.transform.InFlatRange(target, 1.999999f));
    }

    [Test]
    public void TestInFlatRangeTransformvsTransform()
    {
        var source = new GameObject();
        var target = new GameObject();
        target.transform.position = new Vector3(0, 999, 2);

        Assert.IsTrue(source.transform.InFlatRange(target.transform, 10));
        Assert.IsTrue(source.transform.InFlatRange(target.transform, 2));
        Assert.IsFalse(source.transform.InFlatRange(target.transform, 1.999999f));
    }

    [Test]
    public void TestInFlatRangeTransformvsGameObject()
    {
        var source = new GameObject();
        var target = new GameObject();
        target.transform.position = new Vector3(0, 999, 2);

        Assert.IsTrue(source.transform.InFlatRange(target, 10));
        Assert.IsTrue(source.transform.InFlatRange(target, 2));
        Assert.IsFalse(source.transform.InFlatRange(target, 1.999999f));
    }

    [Test]
    public void TestInFlatRangeGameObjectvsVector3()
    {
        var source = new GameObject();
        var target = new Vector3(0, 999, 2);

        Assert.IsTrue(source.InFlatRange(target, 10));
        Assert.IsTrue(source.InFlatRange(target, 2));
        Assert.IsFalse(source.InFlatRange(target, 1.999999f));
    }

    [Test]
    public void TestInFlatRangeGameObjectvsTransform()
    {
        var source = new GameObject();
        var target = new GameObject();
        target.transform.position = new Vector3(0, 999, 2);

        Assert.IsTrue(source.InFlatRange(target.transform, 10));
        Assert.IsTrue(source.InFlatRange(target.transform, 2));
        Assert.IsFalse(source.InFlatRange(target.transform, 1.999999f));
    }

    [Test]
    public void TestInFlatRangeGameObjectvsGameObject()
    {
        var source = new GameObject();
        var target = new GameObject();
        target.transform.position = new Vector3(0, 999, 2);

        Assert.IsTrue(source.InFlatRange(target, 10));
        Assert.IsTrue(source.InFlatRange(target, 2));
        Assert.IsFalse(source.InFlatRange(target, 1.999999f));
    }

    #endregion

    #region TestClosest

    [Test]
    public void TestClosestVector3()
    {
        var source = Vector3.zero;
        var targets = new Vector3[] {
            new Vector3(5, 2, 2),
            new Vector3(2, 2, 2), // == closest
            new Vector3(2, 2, 5),
        };

        Assert.AreEqual(2, source.Closest(targets).x);
        Assert.AreEqual(2, source.Closest(targets).y);
        Assert.AreEqual(2, source.Closest(targets).z);
    }

    [Test]
    public void TestClosestTransform()
    {
        var source = new GameObject();

        var target1 = new GameObject();
        var target2 = new GameObject();
        var target3 = new GameObject();

        target1.transform.position = new Vector3(5, 2, 2);
        target2.transform.position = new Vector3(2, 2, 2); // == closest
        target3.transform.position = new Vector3(2, 2, 5);

        var targets = new Transform[] { target1.transform, target2.transform, target3.transform };

        var closest = source.transform.position.Closest(targets);

        Assert.AreEqual(target2.transform, closest);
        Assert.IsInstanceOf<Transform>(closest);
    }

    [Test]
    public void TestClosestGameObject()
    {
        var source = new GameObject();

        var target1 = new GameObject();
        var target2 = new GameObject();
        var target3 = new GameObject();

        target1.transform.position = new Vector3(5, 2, 2);
        target2.transform.position = new Vector3(2, 2, 2); // == closest
        target3.transform.position = new Vector3(2, 2, 5);

        var targets = new GameObject[] { target1, target2, target3 };

        var closest = source.transform.position.Closest(targets);

        Assert.AreEqual(target2, closest);
        Assert.IsInstanceOf<GameObject>(closest);
    }

    [Test]
    public void TestClosestComponent()
    {
        var source = (new GameObject()).AddComponent<Camera>();

        var target1 = (new GameObject()).AddComponent<Camera>();
        var target2 = (new GameObject()).AddComponent<Camera>();
        var target3 = (new GameObject()).AddComponent<Camera>();

        target1.transform.position = new Vector3(5, 2, 2);
        target2.transform.position = new Vector3(2, 2, 2); // == closest
        target3.transform.position = new Vector3(2, 2, 5);

        var targets = new Camera[] { target1, target2, target3 };

        var closest = source.transform.position.Closest(targets);

        Assert.AreEqual(target2, closest);
        Assert.IsInstanceOf<Component>(closest);
        Assert.IsInstanceOf<Camera>(closest);
    }

    [Test]
    public void TestClosestTransformInvertedRange()
    {
        var source = new GameObject();

        var target1 = new GameObject();
        var target2 = new GameObject();
        var target3 = new GameObject();
        var target4 = new GameObject();

        target1.transform.position = new Vector3(7, 2, 2);
        target2.transform.position = new Vector3(2, 2, 2); // == ignored (out of inverted range)
        target3.transform.position = new Vector3(2, 2, 5); // closest
        target4.transform.position = new Vector3(2, 2, 7);

        var targets = new Transform[] { target1.transform, target2.transform, target3.transform, target4.transform };

        var closest = source.transform.position.Closest(targets, range: 3f, invertRange: true);

        Assert.AreEqual(target3.transform, closest);
    }

    #endregion
}
