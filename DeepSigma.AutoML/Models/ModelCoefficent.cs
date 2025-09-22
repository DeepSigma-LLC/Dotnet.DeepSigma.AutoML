using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeepSigma.AutoML.Models
{
    /// <summary>
    /// Represents a coefficient in a statistical or machine learning model, including its position, value, and associated p-value.
    /// </summary>
    public class ModelCoefficent
    {
        /// <summary>
        /// The index or position of the coefficient in the model, indicating its order or placement among other coefficients.
        /// </summary>
        public int PositionIndex { get; set; }

        /// <summary>
        /// The value of the coefficient in the model, representing the weight or impact of a particular feature or variable on the model's predictions.
        /// </summary>
        public decimal CoefficentValue { get; set; }

        /// <summary>
        /// The p-value associated with the coefficient, indicating the statistical significance of the coefficient in the model.
        /// </summary>
        public decimal PValue { get; set; }
    }
}
