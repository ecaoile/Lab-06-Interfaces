using System;
using Xunit;
using Lab_06_Interfaces;
using static Lab_06_Interfaces.Program;
using Lab_06_Interfaces.Classes.Bird;
using Lab_06_Interfaces.Classes.Fish;
using Lab_06_Interfaces.Classes.Mammal;
using Lab_06_Interfaces.Classes.Reptile;

namespace XUnitTestLab06
{
    public class UnitTest1
    {
        [Fact]
        public void CanUseInterface()
        {
            Salmon testSalmon = new Salmon();
            Shark testShark = new Shark();
            Owl testOwl = new Owl();
            Eagle testEagle = new Eagle();

            Assert.Equal("swimming", testSalmon.Swim());
            Assert.Equal("swimming", testShark.Swim());
            Assert.True(testSalmon.CanDetectInfrared);
            Assert.True(testOwl.CanSeeInTheDark);
            Assert.True(testOwl.CanSeeFar);
            Assert.False(testEagle.CanSeeInTheDark);
            Assert.True(testEagle.CanSeeFar);
        }
        [Fact]
        public void CanInherit()
        {
            Salmon testSalmon = new Salmon();
            Shark testShark = new Shark();
            Cat testCat = new Cat();

            Assert.True(testSalmon.HasScales);
            Assert.True(testShark.HasSwimBladder);
            Assert.True(testShark.HasScales);
            Assert.True(testShark.CanBreatheUnderwater);
            Assert.False(testShark.HasBones);
            Assert.True(testCat.IsWarmBlooded);
        }

        [Fact]
        public void CanOverrideMethods()
        {
            Salmon testSalmon = new Salmon();
            Eel testEel = new Eel();
            Shark testShark = new Shark();

            Assert.Equal("yummy", testSalmon.Sushify());
            Assert.Equal("yummy", testEel.Sushify());
            Assert.Equal("yucky", testShark.Sushify());
        }

        [Fact]
        public void CanProveIsAnimal()
        {
            Chameleon testChameleon = new Chameleon();
            Assert.Equal("ZzZzZz...", testChameleon.Sleep());
            Assert.Equal("...", testChameleon.Sound());
            Assert.Equal("nom nom nom", testChameleon.Eat());
            Assert.Equal("Code Fellows Zoo", testChameleon.ZooName);
        }
    }
}
