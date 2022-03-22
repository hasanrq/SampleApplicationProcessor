namespace ULaw.ApplicationProcessor
{
    public interface IViewBuilderFactory
    {
        IViewBuilder GetViewBuilder(Application application);
    }
}