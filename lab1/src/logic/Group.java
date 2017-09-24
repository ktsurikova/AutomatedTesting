package logic;

/**
 * Created by Дом on 24.09.2017.
 */
public class Group {
    private int number;
   private Student [] students;

    public Group(int number, Student[] students)
    {
        this.number = number;
        this.students = students;
    }

    public Student[] getStudents(){return students;}
    public int getStudentsNumber(){return students.length;}
}
