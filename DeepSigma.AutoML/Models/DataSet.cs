
namespace DeepSigma.AutoML.Models;

public class DataSet<TIndex, TValue> where TIndex : struct where TValue : struct
{
    public DataSetMetaData<TIndex> Index { get; set; } = new();
    public DataSetMetaData<TValue> Value { get; set; } = new();
}
