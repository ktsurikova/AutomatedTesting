package logic;
import java.util.Random;
/**
 * Created by Дом on 24.09.2017.
 */
public class MarksGenerator {
    public int [] generateMarks(){
        Random rand = new Random();
        int marksAmount =rand.nextInt(4);
        int []marks=new int[marksAmount];
        for(int i=0; i<marksAmount;i++) marks[i]=rand.nextInt(10);
        return marks;
    }
}
