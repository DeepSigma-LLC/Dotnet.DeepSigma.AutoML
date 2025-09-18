using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeepSigma.AutoML.Enums
{
    /// <summary>
    /// Specifies the bias-variance tradeoff status in a machine learning model.
    /// </summary>
    public enum ModelBiasVarianceTradeoffStatusType
    {
        /// <summary>
        /// Bias refers to the error introduced by approximating a real-world problem, which may be complex, by a simplified model. High bias can cause an algorithm to miss the relevant relations between features and target outputs (underfitting).
        /// </summary>
        Bias,
        /// <summary>
        /// Variance refers to the error introduced by the model's sensitivity to small fluctuations in the training set. High variance can cause an algorithm to model the random noise in the training data, rather than the intended outputs (overfitting).
        /// </summary>
        Variance
    }
}
