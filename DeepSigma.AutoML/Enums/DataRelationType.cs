using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeepSigma.AutoML.Enums
{
    public enum DataRelationType
    {
        /// <summary>
        /// None indicates that there is no specific relationship or association between the variables being considered.
        /// </summary>
        None,
        /// <summary>
        /// Correlation refers to a statistical relationship between two or more variables, indicating how they tend to move together.
        /// </summary>
        Correlation,
        /// <summary>
        /// Cointegration refers to a statistical property of a collection of time series variables that indicates a long-term equilibrium relationship among them, even if the individual series themselves are non-stationary.
        /// </summary>
        Cointegration,
        /// <summary>
        /// Causation indicates a relationship where one event (the cause) directly influences another event (the effect), leading to a change in the effect as a result of the cause.
        /// </summary>
        Causation
    }
}
