package logic;

/**
 * Created by Дом on 24.09.2017.
 */
public class Student {
    private String firstName;
    private String lastName;
    public SubjectMarks [] subjectMarks;

    public Student(String firstName, String lastName, SubjectMarks[] subjectMarks)
    {
        this.firstName = firstName;
        this.lastName = lastName;
        this.subjectMarks = subjectMarks;
    }
    public SubjectMarks []getSubjectMarks(){return subjectMarks;}
}
