

namespace DeepSigma.AutoML.Enums.Evaluation;

/// <summary>
/// RegressionMetric specifies the various metrics used to evaluate the performance of regression models, which are a type of machine learning model that predicts continuous numerical values based on input features.
/// </summary>
public enum RegressionMetric
{
    /// <summary>
    /// Mean Absolute Error (MAE) is a commonly used metric for evaluating the performance of regression models, which measures the average of the absolute differences between predicted and actual values.
    /// This provides a measure of the model's accuracy in terms of how closely the predicted values match the actual values, with lower MAE indicating better model performance and higher MAE indicating poorer performance, and is less sensitive to large errors compared to Mean Squared Error (MSE), making it a more robust metric for evaluating regression models in the presence of outliers or extreme values.
    /// </summary>
    MeanAbsoluteError,
    /// <summary>
    /// Mean Squared Error (MSE) is a commonly used metric for evaluating the performance of regression models, which measures the average of the squared differences between predicted and actual values.
    /// This provides a measure of the model's accuracy in terms of how closely the predicted values match the actual values, with lower MSE indicating better model performance and higher MSE indicating poorer performance, and is particularly sensitive to large errors due to the squaring of the differences, making it useful for identifying models that may have significant outliers or poor predictions.
    /// </summary>
    MeanSquaredError,
    /// <summary>
    /// Root Mean Squared Error (RMSE) is a commonly used metric for evaluating the performance of regression models, which measures the average magnitude of the errors between predicted and actual values by taking the square root of the average of the squared differences.
    /// This provides a more interpretable measure of the model's performance in terms of the original units of the target variable, and is particularly sensitive to large errors, making it useful for identifying models that may have significant outliers or poor predictions.
    /// </summary>
    RootMeanSquaredError,
    /// <summary>
    /// R-Squared, also known as the coefficient of determination, is a statistical measure that represents the proportion of the variance in the dependent variable that is explained by the independent variables in a regression model.
    /// This provides an indication of how well the model fits the data, with values ranging from 0 to 1, where a value of 1 indicates a perfect fit and a value of 0 indicates that the model does not explain any of the variance in the dependent variable.
    /// </summary>
    RSquared,
    /// <summary>
    /// Adjusted R-Squared is a modified version of R-Squared that takes into account the number of predictors in the model.
    /// This provides a more accurate measure of the goodness of fit for regression models with multiple predictors by penalizing the addition of irrelevant predictors and rewarding the inclusion of relevant predictors, making it a more reliable metric for evaluating the performance of regression models with varying numbers of predictors.
    /// </summary>
    AdjustedRSquared
}
