using System;
using Xunit;
using Lab05_Zoo_OOP.Classes;
using Lab05_Zoo_OOP.Interface;

namespace Zoo_test
{
    public class UnitTest1
    {   
        [Fact]
        public void IsReindeerADeer()
        {
            Reindeer reindeer = new Reindeer();
            Assert.True(reindeer.HasHorns);
        }

        [Fact]
        public void CanReindeerFly()
        {
            Reindeer reindeer = new Reindeer();
            Assert.False(reindeer.DoIHasWing);
        }

        [Fact]
        public void HowDoReindeerFly()
        {
            Reindeer reindeer = new Reindeer();
            Assert.Equal("Magical Powers", reindeer.HowIFly());
        }

        [Fact]
        public void DoesRabbitSleepInAM()
        {
            Rabbit rabbit = new Rabbit();
            Assert.Equal("AM", rabbit.SleepAt());
        }

        [Fact]
        public void DoesZebraGallop()
        {
            Zebra zebra = new Zebra();
            Assert.True(zebra.MoreMagesticThanRunning);
        }

        [Fact]
        public void DoesZebraHavetail()
        {
            Zebra zebra = new Zebra();
            Assert.True(zebra.HasTail);
        }

        [Fact]
        public void AreFruitBatsAndDraculaBats()
        {
            FruitBat fbat = new FruitBat();
            Dracula count = new Dracula();
            Assert.Equal(fbat.SleepAt(), count.SleepAt());

        }

        [Fact]
        public void AreDraculaDifferentFromFruitBats()
        {
            FruitBat fbat = new FruitBat();
            Dracula count = new Dracula();
            Assert.NotEqual(fbat.EatsWhat(), count.EatsWhat());
        }

        [Fact]
        public void AreTigerJungleAnimals()
        {
            Tiger tiger = new Tiger();
            Assert.True(tiger.LovesTrees);
        }

        [Fact]
        public void AreWhiteTigerAndZebraMonochrome()
        {
            WhiteTiger wtiger = new WhiteTiger();
            Zebra zebra = new Zebra();
            Assert.Equal(zebra.BlackOrWhite(), wtiger.BlackOrWhite());
        }
    }
}
