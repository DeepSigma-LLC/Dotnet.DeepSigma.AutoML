using DeepSigma.AutoML.Enums;
using DeepSigma.AutoML.Enums.Modeling;


namespace DeepSigma.AutoML.Models;

public class Model
{
    public required string Name { get; set; }
    public string Description { get; set; } = string.Empty;
    public ModelMemoryLengthType MemoryLengthType { get; set; }
    public SeriesStatisticalPropertyType RequiredStationarityType { get; set; }
    public ModelLearningType ModelLearningType { get; set; }
    public ModelMemoryType ModelMemoryType { get; set; }
    public 
    public bool MultitaskLearning { get; set; }
}
