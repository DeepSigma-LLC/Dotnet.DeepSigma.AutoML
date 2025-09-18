using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeepSigma.AutoML.Enums
{
    /// <summary>
    /// Specifies the result type of a model fit evaluation, indicating whether the model is overfitting or underfitting the data.
    /// </summary>
    public enum ModelFitResultType
    {
        /// <summary>
        /// Overfit indicates that the model has learned the training data too well, capturing noise and fluctuations that do not generalize to new, unseen data. This results in high accuracy on the training set but poor performance on validation or test datasets.
        /// </summary>
        Overfit,
        /// <summary>
        /// Underfit indicates that the model has not captured the underlying patterns in the training data adequately, resulting in poor performance on both training and validation datasets.
        /// </summary>
        Underfit
    }
}
