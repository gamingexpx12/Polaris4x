using UnityEngine;
using UnityEditor;
using NUnit.Framework;
using RenameSpace;
[TestFixture]
public class RenameTest {
    
    [Test]
    public void EditorTest()
    {
        //Arrange
        var gameObject = new GameObject("test");
        var renameComp = gameObject.AddComponent<RenameComp>();
        //Act
        //Try to rename the GameObject
        var newGameObjectName = "DoReMi";
        renameComp.Rename(newGameObjectName);
        //Assert
        //The object has a new name
        Assert.AreEqual(newGameObjectName, gameObject.name);
    }


}
