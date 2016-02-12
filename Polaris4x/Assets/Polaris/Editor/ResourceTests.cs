//using UnityEngine;
using Resources;
using NUnit.Framework;

public class ResourceTests {

    [Test]
    public void MaterialTest()
    {
        //Arrange

        //Act
        var newGameObjectName = "Material";
        
        //Assert
        //The object has a new name
        Assert.AreEqual(newGameObjectName, MyMaterial.Name);
    }
    
    [Test]
    public void UraniumTest()
    {
        //Arrange

        //Act
        var newGameObjectName = "Uranium";

        //Assert
        Assert.AreEqual(newGameObjectName, Uranium.Name);
    }
}
