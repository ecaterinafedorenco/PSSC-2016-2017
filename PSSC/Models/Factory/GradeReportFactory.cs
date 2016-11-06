namespace Models.Factory
{
    class GradeReportFactory
    {
        public static readonly GradeReportFactory Instance = new GradeReportFactory();

        public GradeReportFactory()
        { }

        public Student.GradeReport createInstance(Student.GradeReport gradeReport)
        {
            return gradeReport;
        }
    }
}
