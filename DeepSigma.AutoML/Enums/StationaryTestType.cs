using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeepSigma.AutoML.Enums
{

    public enum StationaryTestType
    {
        Visually,
        GlobalVsLocalTests,
        /// <summary>
        /// For example, the augmented Dickey-Fuller Test
        /// </summary>
        StatisticalTests,
    }
}
