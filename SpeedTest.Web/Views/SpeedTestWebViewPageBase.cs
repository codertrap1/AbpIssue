using Abp.Web.Mvc.Views;

namespace SpeedTest.Web.Views
{
    public abstract class SpeedTestWebViewPageBase : SpeedTestWebViewPageBase<dynamic>
    {

    }

    public abstract class SpeedTestWebViewPageBase<TModel> : AbpWebViewPage<TModel>
    {
        protected SpeedTestWebViewPageBase()
        {
            LocalizationSourceName = SpeedTestConsts.LocalizationSourceName;
        }
    }
}