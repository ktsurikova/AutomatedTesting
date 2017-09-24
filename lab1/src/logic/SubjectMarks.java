package logic;
import java.util.*;
/**
 * Created by Дом on 24.09.2017.
 */
public class SubjectMarks {
    private Subject subject;
    private int[] marks;

    public SubjectMarks(Subject subject){
        this.subject=subject;
        MarksGenerator generator=new MarksGenerator();
        this.marks=generator.generateMarks();
    }

    public Subject getSubject(){return subject;}
    public int[] getMarks(){return marks;}

}
