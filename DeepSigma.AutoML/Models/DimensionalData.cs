using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeepSigma.AutoML.Models
{
    public class DimensionalData<TIndex, TValue> where TIndex : struct where TValue : struct
    {
        public DataDimensionMetaData<TIndex> Index { get; set; } = new();
        public DataDimensionMetaData<TValue> Value { get; set; } = new();
    }
}
