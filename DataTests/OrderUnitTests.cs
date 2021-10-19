using System;
using Xunit;
using GyroScope.Data.Enums;
using GyroScope.Data.Treats;
using System.ComponentModel;
using GyroScope.Data;
using GyroScope.Data.Entrees;
using System.Collections.Specialized;

namespace GyroScope.DataTests
{
    /// <summary>
    /// Unit tests for the Order class.
    /// </summary>
    public class OrderUnitTests
    {
        /// <summary>
        /// Checks to see if the added item is included in the order.
        /// </summary>
        [Fact]
        public void CheckIfAddedItemsAreIncludedInOrder()
        {
            Order o = new();
            LeoLambGyro gyro = new();
            o.Add(gyro);
            Assert.Contains(gyro,o);
        }

        /// <summary>
        /// Checks to see if the added and removed item is not included in the order.
        /// </summary>
        [Fact]
        public void CheckIfRemovedItemsAreNotIncludedInOrder()
        {
            Order o = new();
            LeoLambGyro gyro = new();
            o.Add(gyro);
            o.Remove(gyro);
            Assert.DoesNotContain(gyro, o);
        }

        /// <summary>
        /// Checks to see that the INotifyPropertyChanged event is correctly changed.
        /// </summary>
        [Fact]
        public void ShouldImplementINotifyPropertyChanged()
        {
            Order o = new();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(o);
        }

        /// <summary>
        /// Checks to see that the INotifyCollectionChanged event is correctly changed.
        /// </summary>
        [Fact]
        public void ShouldImplementINotifyCollectionChanged()
        {
            Order o = new();
            Assert.IsAssignableFrom<INotifyCollectionChanged>(o);
        }
    }
}
