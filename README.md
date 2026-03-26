# Dotnet.DeepSigma.AutoML

A C#/.NET library that provides **domain models, enums, and lightweight utilities for building custom AutoML workflows**.

Rather than shipping a full training pipeline, this package currently focuses on the **foundational types** you would use to describe datasets, model metadata, learning approaches, prediction characteristics, and model-selection concepts inside a larger AutoML system.

## Why this project exists

`Dotnet.DeepSigma.AutoML` is useful when you want a shared .NET package for:

- describing datasets and their metadata
- representing ML models and their capabilities
- standardizing enums across data science, ML, statistics, time series, NLP, deployment, and reasoning domains
- applying simple model-complexity heuristics such as AIC and coefficient significance filtering

This makes it a good fit for teams building an internal AutoML platform, model registry, experiment framework, or domain-specific ML orchestration layer in C#.

## What is included

### Core models

The package includes strongly typed models such as:

- `DataSet<TIndex, TValue>` for pairing index metadata with value metadata
- `DataSetMetaData<T>` for describing a field/series, including min/max/mean/median, nullability, units, and formatting
- `Model` for general model attributes such as memory behavior, stationarity requirements, learning type, and multitask support
- `MachineLearningModel : Model` for ML-specific modeling with a `LearningApproach`
- `ModelCoefficent` for coefficient value and p-value tracking
- `Prediction` for predicted value, Brier score, confidence, and risk posture

### Utilities

The package currently includes `ModelComplexitySelection`, with helpers for:

- calculating **Akaike Information Criterion (AIC)**
- selecting statistically significant coefficients using a configurable significance threshold
- optionally limiting the number of selected coefficients

### Enum coverage

One of the biggest strengths of this repository is the breadth of enum coverage for building higher-level AutoML workflows.

The repo organizes enums into multiple domains, including:

- **Data**: awareness, relation types, sample/series/window types, missing-data handling, stationarity, synthetic data generation, and related concepts
- **MachineLearning**: learning approaches, clustering, dimensionality reduction, ensembles, optimizers, feature extraction, and evaluation criteria
- **Modeling**: hyperparameter selection, learning-rate styles, model complexity, memory, fit outcomes, objectives, overfitting prevention, sequence classification, and weight status
- **Statistical**: evidence, hypothesis testing outcomes, distributions, sampling, and dataset categorization
- **TimeSeries**: visualization, temporal similarity, decomposition sources, and time-series issue types

At the top level, the package also includes broader cross-cutting enums such as:

- `AIIntelligenceCapacity`
- `GenerativeModel`
- `ThinkingSystemClassification`
- `ReasoningType`
- `SimulationType`
- `StationaryTestType`

## Installation

> The repository is configured as a packable SDK-style .NET project targeting **.NET 10.0**.

If you are consuming the project directly from source:

```bash
git clone https://github.com/DeepSigma-LLC/Dotnet.DeepSigma.AutoML.git
cd Dotnet.DeepSigma.AutoML/DeepSigma.AutoML
dotnet build
```

If you plan to publish or consume it as a NuGet package, the `.csproj` is already configured with package metadata and `GeneratePackageOnBuild=true`.

## Quick start

```csharp
using DeepSigma.AutoML.Models;
using DeepSigma.AutoML.Enums.Data;
using DeepSigma.AutoML.Enums.Modeling;
using DeepSigma.AutoML.Enums.MachineLearning;
using DeepSigma.AutoML.Utilities;

var dataSet = new DataSet<int, decimal>
{
    Index = new DataSetMetaData<int>
    {
        Name = "TimeStep",
        Description = "Sequential index",
        DataType = typeof(int),
        MinValue = 0,
        MaxValue = 100,
        Mean = 50,
        Median = 50,
        StandardDeviation = 29,
        UniqueValuesCount = 101,
        TotalValuesCount = 101,
        AllowsNull = false,
        UnitOfMeasurement = "step",
        Format = "D"
    },
    Value = new DataSetMetaData<decimal>
    {
        Name = "Demand",
        Description = "Observed demand",
        DataType = typeof(decimal),
        MinValue = 10m,
        MaxValue = 250m,
        Mean = 96m,
        Median = 91m,
        StandardDeviation = 22m,
        UniqueValuesCount = 88,
        TotalValuesCount = 101,
        AllowsNull = false,
        UnitOfMeasurement = "units",
        Format = "0.00"
    }
};

var model = new MachineLearningModel
{
    Name = "Demand Forecasting Baseline",
    Description = "A simple forecasting model definition",
    MemoryLengthType = ModelMemoryLengthType.MediumTermMemory,
    RequiredStationarityType = SeriesStatisticalPropertyType.Stationary,
    ModelLearningType = ModelLearningType.Supervised,
    ModelMemoryType = ModelMemoryType.StateDependent,
    MultitaskLearning = false,
    LearningType = LearningApproach.BatchLearning
};

var coefficients = new List<ModelCoefficent>
{
    new() { PositionIndex = 0, CoefficentValue = 0.82m, PValue = 0.01m },
    new() { PositionIndex = 1, CoefficentValue = 0.15m, PValue = 0.08m },
    new() { PositionIndex = 2, CoefficentValue = 0.34m, PValue = 0.03m }
};

var significant = ModelComplexitySelection
    .SelectStatisticallySignificantModelCoefficents(coefficients, significanceLevel: 0.05m);

double aic = ModelComplexitySelection.AkaikeInformationCriterion(
    likelihood: 0.91,
    numParameters: significant.Count
);
```

## Repository structure

```text
Dotnet.DeepSigma.AutoML/
├── README.md
└── DeepSigma.AutoML/
    ├── Assets/
    ├── Enums/
    │   ├── Data/
    │   ├── DeepLearning/
    │   ├── Deployment/
    │   ├── Evaluation/
    │   ├── LLM/
    │   ├── MachineLearning/
    │   ├── Mathematics/
    │   ├── Modeling/
    │   ├── NLP/
    │   ├── Prediction/
    │   ├── StateSpace/
    │   ├── Statistical/
    │   └── TimeSeries/
    ├── Models/
    ├── Utilities/
    ├── DeepSigma.AutoML.csproj
    └── DeepSigma.AutoML.sln
```

## Current project shape

Based on the current repository contents, this project is best described as a **foundational library** rather than a complete end-to-end AutoML engine. The codebase currently emphasizes:

- classification vocabularies and configuration enums
- reusable model and dataset abstractions
- a small set of statistical selection helpers

That is a solid base for future additions such as training pipelines, preprocessing engines, experiment tracking, model evaluation workflows, or AutoML search strategies.

## Documentation notes

A few naming details in the current API are worth preserving for compatibility when you document or extend the project:

- `ModelCoefficent` is spelled exactly that way in the source
- `SelectStatisticallySignificantModelCoefficents(...)` uses the same spelling
- some enum filenames also appear to preserve project-specific naming conventions

If you later introduce breaking cleanup changes, consider documenting them clearly in release notes.

## Testing

I did not find a separate test project or test directory in the repository structure shown on GitHub. If tests are planned, a future addition such as `DeepSigma.AutoML.Tests` would make the package easier to validate and adopt.

## Suggested next improvements

Here are the highest-impact improvements for the repository over time:

1. Add runnable examples that show how the abstractions compose in a real AutoML workflow.
2. Add unit tests for `ModelComplexitySelection` and the model types.
3. Publish NuGet usage instructions once package distribution is available.
4. Add XML-doc-based API documentation or DocFX-generated reference docs.
5. Clarify which enums and models are stable public API versus still evolving.

## License

No license file is visible in the current repository snapshot. If you intend others to use or contribute to the package, adding a license file would remove ambiguity.

## Contributing

Contributions are easiest when the repository documents:

- supported .NET SDK version
- branching and PR expectations
- testing requirements
- release/versioning process

A `CONTRIBUTING.md` file would be a helpful next step.

---

Built from the current public repository structure and source files in `DeepSigma-LLC/Dotnet.DeepSigma.AutoML`.
