using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeepSigma.AutoML.Enums
{
    /// <summary>
    /// Specifies the specific stationarity requirements for a time series.
    /// </summary>
    public enum StationarityRequirementType
    {
        /// <summary>
        /// ConstantMean indicates that the time series should have a constant mean over time, meaning that the average value of the series does not change significantly as time progresses.
        /// </summary>
        ConstantMean,
        /// <summary>
        /// ConstantVariance indicates that the time series should have a constant variance over time, meaning that the variability or spread of the data points around the mean remains relatively stable as time progresses.
        /// </summary>
        ConstantVariance,
        /// <summary>
        /// SeasonalityNotPresent indicates that the time series should not exhibit any seasonal patterns or cycles, meaning that there are no regular fluctuations or recurring patterns in the data that occur at specific intervals (e.g., daily, monthly, yearly).
        /// </summary>
        SeasonalityNotPresent
    }
}
