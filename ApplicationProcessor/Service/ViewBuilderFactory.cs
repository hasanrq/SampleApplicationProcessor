using ULaw.ApplicationProcessor.Enums;

namespace ULaw.ApplicationProcessor
{
    public class ViewBuilderFactory : IViewBuilderFactory
    {
        public IViewBuilder GetViewBuilder(Application application)
        {
            switch (application.DegreeGrade)
            {
                case DegreeGradeEnum.twoTwo:
                    return new DegreeTwoTwoViewBuilder();
                case DegreeGradeEnum.third:
                    return new DegreeThirdViewBuilder();

                default:
                    if (application.DegreeSubject == DegreeSubjectEnum.law || application.DegreeSubject == DegreeSubjectEnum.lawAndBusiness)
                    {
                        return new DegreeSubjectLawViewBuilder();
                    }
                    else
                    {
                        return new DegreeDefaultViewBuilder();
                    }
            }
        }
    }
}
