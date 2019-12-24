using System;
using GasStationMs.App.DistributionLaws;

namespace GasStationMs.App.Models
{
    public class TrafficFlow
    {
        public static readonly int MinTimeBetweenCarsInSeconds = 2;
        public static readonly int MaxTimeBetweenCarsInSeconds = 10;

        private IDistributionLaw _distributionLaw;
        private int _timeBetweenCarsInSeconds;

        public TrafficFlow(IDistributionLaw distributionLaw)
        {
            _distributionLaw = distributionLaw;
        }

        public int TimeBetweenCarsInSeconds
        {
            get
            {
                return _timeBetweenCarsInSeconds;
            }

            set
            {
                if (value < MinTimeBetweenCarsInSeconds)
                {
                    throw new ArgumentOutOfRangeException();
                }

                if (value > MaxTimeBetweenCarsInSeconds)
                {
                    throw new ArgumentOutOfRangeException();
                }

                _timeBetweenCarsInSeconds = value;
            }
        }
    }
}
