using DeepSigma.AutoML.Models;

namespace DeepSigma.AutoML.Utilities;


public class ModelComplexitySelection
{
    /// <summary>
    /// Calculates the Akaike Information Criterion (AIC) for a given model. 
    /// AIC is a measure used to compare the relative quality of statistical models for a given dataset, balancing model fit and complexity.
    /// We will favor models with lower AIC values, indicating a better trade-off between goodness of fit and model simplicity.
    /// </summary>
    /// <param name="likelihood"></param>
    /// <param name="numParameters"></param>
    /// <returns></returns>
    public static double AkaikeInformationCriterion(double likelihood, int numParameters)
    {
        double logLikelihood = Math.Log(likelihood);
        return 2 * numParameters - 2 * logLikelihood;
    }

    /// <summary>
    /// Selects statistically significant model coefficients based on a specified significance level.
    /// </summary>
    /// <param name="modelCoefficents"></param>
    /// <param name="significanceLevel"></param>
    /// <returns></returns>
    public static List<ModelCoefficent> SelectStatisticallySignificantModelCoefficents(List<ModelCoefficent> modelCoefficents, decimal significanceLevel = (decimal)0.05, bool adjust_significance_level_for_multiselction = false, int? max_number_of_coeffients = null)
    {
        // Filter the model coefficients based on the significance level
        var significantCoefficients = modelCoefficents
            .Where(coef => coef.PValue < significanceLevel)
            .ToList();

        if(max_number_of_coeffients is not null)
        {
           return significantCoefficients.OrderByDescending(coef => coef.PValue).Take((int)max_number_of_coeffients).ToList();
        }
        return significantCoefficients;
    }
}
