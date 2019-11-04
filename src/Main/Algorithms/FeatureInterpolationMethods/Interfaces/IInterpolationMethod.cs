using System.Diagnostics;
using USC.GISResearchLab.Common.Core.Geocoders.FeatureMatching;
using USC.GISResearchLab.Geocoding.Core.Queries.Parameters;

namespace USC.GISResearchLab.Geocoding.Core.Algorithms.FeatureInterpolationMethods.Interfaces
{

    public interface IInterpolationMethod
    {
        TraceSource TraceSource { get; set; }
        string Name { get; set; }
        int Method { get; set; }
        int Quality { get; set; }

        //IFeatureSource FeatureSource { get; set; }
        InterpolationType InterpolationType { get; set; }
        InterpolationSubType InterpolationSubType { get; set; }

        //List<IGeocode> Geocode(ParameterSet parameterSet);

        FeatureInterpolationResult DoFeatureInterpolation(ParameterSet parameterSet, MatchedFeature matchedFeature);
    }
}
