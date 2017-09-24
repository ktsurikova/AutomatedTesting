package core;
import logic.*;
public class Main {

    public static void main(String[] args) {
        //Students
       Student s1 = new Student("Mike", "Black",
               new SubjectMarks[] {new SubjectMarks(Subject.Algebra), new SubjectMarks(Subject.AutomatedTesting)}
        );
        Student s2 = new Student("John", "White",
                new SubjectMarks[] {new SubjectMarks(Subject.Geometry), new SubjectMarks(Subject.AutomatedTesting)}
        );
        Student s3 = new Student("Lizzy", "Blue",
                new SubjectMarks[] {new SubjectMarks(Subject.FunctionalAnalysis), new SubjectMarks(Subject.AutomatedTesting)}
        );
        Student s4 = new Student("Katty", "Green",
                new SubjectMarks[] {new SubjectMarks(Subject.Algebra), new SubjectMarks(Subject.AutomatedTesting)}
        );
        Student s5 = new Student("Allon", "Joe",
                new SubjectMarks[] {new SubjectMarks(Subject.Geometry), new SubjectMarks(Subject.AutomatedTesting)}
        );

        //Groups

        Group g1=new Group(1,new Student[]{s1,s2});
        Group g2=new Group(2,new Student[]{s3});
        Group g3=new Group(3,new Student[]{s4,s5});

        //Faculties
        Faculty f1 = new Faculty("MMF", new Group[]{g1,g2});
        Faculty f2 = new Faculty("FAMI", new Group[]{g3});

        //Univeersity
        University u = new University("BSU", new Faculty[]{f1,f2});

        //GPA calculations
        GPACalculator calculator=new GPACalculator();
        System.out.println("GPAs per subject:");
        for(Subject s:Subject.values()){
            System.out.println(s+" GPA:"+calculator.countSubjectGPA(u,s));
        }
        System.out.println("Student 1 GPA:"+calculator.countStudentGPA(s1));
        System.out.println("Group 2 GPA:"+calculator.countGroupGPA(g1));
        System.out.println("Faculty 1 GPA:"+calculator.countFacultyGPA(f1));
        System.out.println("University GPA:"+calculator.countUniversityGPA(u));
        System.out.print("-------------------------------------------------------------------");

    }
}
