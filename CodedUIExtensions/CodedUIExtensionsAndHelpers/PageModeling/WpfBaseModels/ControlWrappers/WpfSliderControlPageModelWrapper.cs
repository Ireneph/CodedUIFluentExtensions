using Microsoft.VisualStudio.TestTools.UITesting.WpfControls;

namespace CodedUIExtensionsAndHelpers.PageModeling
{
    public class WpfSliderControlPageModelWrapper<TNextModel> : HasNextModelUIControlPageModelWrapperBase<WpfSlider, TNextModel>, IValueablePageModel<double, TNextModel>
        where TNextModel : IPageModel
    {
        public WpfSliderControlPageModelWrapper(WpfSlider control, TNextModel nextModel) : base(control, nextModel)
        {
        }

        public double Value
        {
            get { return this.Me.Position; }
        }

        public TNextModel SetValue(double toValue)
        {
            this.Me.Position = toValue;
            return this.NextModel;
        }
    }
}