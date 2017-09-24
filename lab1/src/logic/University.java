package logic;

/**
 * Created by Дом on 24.09.2017.
 */
public class University {
    private String name;
    private Faculty [] faculties;

    public University(String name, Faculty[] faculties)
    {
        this.name = name;
        this.faculties =faculties;
    }

    public Faculty[] getFaculties(){return faculties;}
    public int getFacultiesNumber(){return faculties.length;}
}
