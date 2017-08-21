using Abp.Web.Mvc.Views;

namespace JahomProject.Web.Views
{
    public abstract class JahomProjectWebViewPageBase : JahomProjectWebViewPageBase<dynamic>
    {

    }

    public abstract class JahomProjectWebViewPageBase<TModel> : AbpWebViewPage<TModel>
    {
        protected JahomProjectWebViewPageBase()
        {
            LocalizationSourceName = JahomProjectConsts.LocalizationSourceName;
        }
    }
}