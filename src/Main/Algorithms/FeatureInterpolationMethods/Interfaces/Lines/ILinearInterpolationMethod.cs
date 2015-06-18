using USC.GISResearchLab.Common.Geographics.Units;

namespace USC.GISResearchLab.Geocoding.Core.Algorithms.FeatureInterpolationMethods.Interfaces
{

    public interface ILinearInterpolationMethod : IInterpolationMethod
    {
        #region Properties
        
        LinearUnitTypes DropbackUnits { get; set; }
        double DropbackValue { get; set; }
        
        #endregion

        //new Geocode Geocode(ParameterSet parameterSet);
    }
}
