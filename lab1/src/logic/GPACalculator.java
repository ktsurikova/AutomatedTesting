package logic;

/**
 * Created by Дом on 24.09.2017.
 */
public class GPACalculator {
    public static double countSubjectGPA(University university, Subject subject) {
        double counter = 0;
        int marksNumber = 0;
        for (Faculty f:university.getFaculties()) {
            for (Group g:f.getGroups()) {
                for (Student s:g.getStudents()) {
                    for (SubjectMarks sm:s.getSubjectMarks()) {
                         if(sm.getSubject()==subject){
                             for (int m:sm.getMarks()) {
                                   counter+=m;
                                   marksNumber++;
                             }
                         }
                    }
                }
            }
        }
        return marksNumber == 0 ? 0 : counter / marksNumber;
    }

    public static double countStudentGPA(Student student) {
        double counter = 0;
        int marksNumber = 0;
                    for (SubjectMarks sm:student.getSubjectMarks()) {
                            for (int m:sm.getMarks()) {
                                counter+=m;
                                marksNumber++;
                            }
                    }
        return marksNumber == 0 ? 0 : counter / marksNumber;
    }

    public static double countGroupGPA(Group group) {
        double counter = 0;
        for (Student s:group.getStudents()) {
            counter+=countStudentGPA(s);
        }
        return group.getStudentsNumber() == 0 ? 0 : counter /group.getStudentsNumber();
    }

    public static double countFacultyGPA(Faculty faculty) {
        double counter = 0;
        for (Group g:faculty.getGroups()) {
            counter+=countGroupGPA(g);
        }
        return faculty.getGroupsNumber() == 0 ? 0 : counter /faculty.getGroupsNumber();
    }

    public static double countUniversityGPA(University university) {
        double counter = 0;
        for (Faculty f:university.getFaculties()) {
            counter+=countFacultyGPA(f);
        }
        return university.getFacultiesNumber()== 0 ? 0 : counter /university.getFacultiesNumber();
    }



}
