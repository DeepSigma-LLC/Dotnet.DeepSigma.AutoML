using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeepSigma.AutoML.Models
{
    public class DataDimensionMetaData<T> where T : struct
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public Type DataType { get; set; }
        public T MinValue { get; set; }
        public T MaxValue { get; set; }
        public T Mean { get; set; }
        public T Median { get; set; }
        public T StandardDeviation { get; set; }
        public long UniqueValuesCount { get; set; }
        public long TotalValuesCount { get; set; }
        public bool AllowsNull { get; set; }
        public string UnitOfMeasurement { get; set; } = string.Empty;
        public string Format { get; set; } = string.Empty;
    }
}
