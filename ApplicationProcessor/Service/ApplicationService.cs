namespace ULaw.ApplicationProcessor
{
    public class ApplicationService : IApplicationService
    {

        public readonly IViewBuilderFactory _viewBuilderFactory;

        public ApplicationService(IViewBuilderFactory viewBuilderFactory)
        {
            _viewBuilderFactory = viewBuilderFactory;
        }

        public string Process(Application application)
        {
            return _viewBuilderFactory.GetViewBuilder(application).Build(application);
        }
    }
}
