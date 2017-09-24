package logic;

/**
 * Created by Дом on 24.09.2017.
 */
public class Faculty {
    private String name;
    private Group [] groups;

    public Faculty(String name, Group[] groups)
    {
        this.name = name;
        this.groups = groups;
    }

    public Group[] getGroups(){return groups;}
    public int getGroupsNumber(){return groups.length;}
}
