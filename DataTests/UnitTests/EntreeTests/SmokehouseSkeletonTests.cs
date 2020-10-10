/*
 * Author: Zachery Brunner
 * Modified by: Samuel McGowan
 * Class: SmokehouseSkeletonTests.cs
 * Purpose: Test the SmokehouseSkeleton.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Entrees;

namespace BleakwindBuffet.DataTests.UnitTests.EntreeTests
{
    public class SmokehouseSkeletonTests
    {
        [Fact]
        public void ShouldBeAnIOrderItem()
        {
            SmokehouseSkeleton ss = new SmokehouseSkeleton();
            Assert.IsAssignableFrom<IOrderItem>(ss);
        }

        [Fact]
        public void ShouldBeAnEntree()
        {
            SmokehouseSkeleton ss = new SmokehouseSkeleton();
            Assert.IsAssignableFrom<Entree>(ss);
        }

        [Fact]
        public void ShouldInlcudeSausageByDefault()
        {
            SmokehouseSkeleton ss = new SmokehouseSkeleton();
            Assert.True(ss.SausageLink);
        }

        [Fact]
        public void ShouldInlcudeSausageLinkByDefault()
        {
            SmokehouseSkeleton ss = new SmokehouseSkeleton();
            Assert.True(ss.SausageLink);
        }

        [Fact]
        public void ShouldInlcudeHashbrownsByDefault()
        {
            SmokehouseSkeleton ss = new SmokehouseSkeleton();
            Assert.True(ss.HashBrowns);
        }

        [Fact]
        public void ShouldInlcudePancakeByDefault()
        {
            SmokehouseSkeleton ss = new SmokehouseSkeleton();
            Assert.True(ss.Pancake);
        }

        [Fact]
        public void ShouldBeAbleToSetSausage()
        {
            SmokehouseSkeleton ss = new SmokehouseSkeleton();
            ss.SausageLink = false;
            Assert.False(ss.SausageLink);
            ss.SausageLink = true;
            Assert.True(ss.SausageLink);
        }

        [Fact]
        public void ShouldBeAbleToSetSausageLink()
        {
            SmokehouseSkeleton ss = new SmokehouseSkeleton();
            ss.SausageLink = false;
            Assert.False(ss.SausageLink);
            ss.SausageLink = true;
            Assert.True(ss.SausageLink);
        }

        [Fact]
        public void ShouldBeAbleToSetHashbrowns()
        {
            SmokehouseSkeleton ss = new SmokehouseSkeleton();
            ss.HashBrowns = false;
            Assert.False(ss.HashBrowns);
            ss.HashBrowns = true;
            Assert.True(ss.HashBrowns);
        }

        [Fact]
        public void ShouldBeAbleToSetPancake()
        {
            SmokehouseSkeleton ss = new SmokehouseSkeleton();
            ss.Pancake = false;
            Assert.False(ss.Pancake);
            ss.Pancake = true;
            Assert.True(ss.Pancake);
        }

        [Fact]
        public void ShouldReturnCorrectPrice()
        {
            SmokehouseSkeleton ss = new SmokehouseSkeleton();
            Assert.Equal(5.62, ss.Price);
        }

        [Fact]
        public void ShouldReturnCorrectCalories()
        {
            SmokehouseSkeleton ss = new SmokehouseSkeleton();
            uint x = 602;
            Assert.Equal(x, ss.Calories);
        }

        [Theory]
        [InlineData(true, true, true, true)]
        [InlineData(false, false, false, false)]
        public void ShouldReturnCorrectSpecialInstructions(bool includeSausage, bool includeEgg,
                                                            bool includeHashbrowns, bool includePancake)
        {
            SmokehouseSkeleton ss = new SmokehouseSkeleton();
            ss.SausageLink = includeSausage;
            if (!includeSausage) Assert.Contains("Hold sausage", ss.SpecialInstructions);
            else Assert.Empty(ss.SpecialInstructions);

            ss = new SmokehouseSkeleton();
            ss.Egg = includeEgg;
            if (!includeEgg) Assert.Contains("Hold eggs", ss.SpecialInstructions);
            else Assert.Empty(ss.SpecialInstructions);

            ss = new SmokehouseSkeleton();
            ss.HashBrowns = includeHashbrowns;
            if (!includeHashbrowns) Assert.Contains("Hold hash browns", ss.SpecialInstructions);
            else Assert.Empty(ss.SpecialInstructions);

            ss = new SmokehouseSkeleton();
            ss.Pancake = includePancake;
            if (!includePancake) Assert.Contains("Hold pancakes", ss.SpecialInstructions);
            else Assert.Empty(ss.SpecialInstructions);
        }

        [Fact]
        public void ShouldReturnCorrectToString()
        {
            SmokehouseSkeleton ss = new SmokehouseSkeleton();
            Assert.Equal("Smokehouse Skeleton", ss.ToString());
        }

        [Fact]
        public void ChangingSausageLinkNotifiesSausageLinkProperty()
        {
            SmokehouseSkeleton ss = new SmokehouseSkeleton();

            Assert.PropertyChanged(ss, "SausageLink", () =>
            {
                ss.SausageLink = false;
            });

            Assert.PropertyChanged(ss, "SausageLink", () =>
            {
                ss.SausageLink = true;
            });
        }

        [Fact]
        public void ChangingPancakeNotifiesPancakeProperty()
        {
            SmokehouseSkeleton ss = new SmokehouseSkeleton();

            Assert.PropertyChanged(ss, "Pancake", () =>
            {
                ss.Pancake = false;
            });

            Assert.PropertyChanged(ss, "Pancake", () =>
            {
                ss.Pancake = true;
            });
        }

        [Fact]
        public void ChangingEggNotifiesEggProperty()
        {
            SmokehouseSkeleton ss = new SmokehouseSkeleton();

            Assert.PropertyChanged(ss, "Egg", () =>
            {
                ss.Egg = false;
            });

            Assert.PropertyChanged(ss, "Egg", () =>
            {
                ss.Egg = true;
            });
        }

        [Fact]
        public void ChangingHashBrownsNotifiesHashBrownsProperty()
        {
            SmokehouseSkeleton ss = new SmokehouseSkeleton();

            Assert.PropertyChanged(ss, "HashBrowns", () =>
            {
                ss.HashBrowns = false;
            });

            Assert.PropertyChanged(ss, "HashBrowns", () =>
            {
                ss.HashBrowns = true;
            });
        }

        [Fact]
        public void NamePropertyGetsToString()
        {
            SmokehouseSkeleton ss = new SmokehouseSkeleton();
            Assert.Equal(ss.ToString(), ss.Name);
        }
    }
}