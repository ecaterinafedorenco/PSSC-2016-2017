namespace Models.Factory
{
    // Creates a GradeReportFactory instance
    class GradeReportFactory
    {
        public static readonly GradeReportFactory Instance = new GradeReportFactory();

        private GradeReportFactory()
        { }

        // Creates a GreadeReport instance
        public Student.GradeReport CreateInstance(Student.GradeReport gradeReport)
        {
            return gradeReport;
        }
    }
}
