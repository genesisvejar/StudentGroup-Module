public class StudentGroup
{
    //private variables:

    private string groupName;
    private int numMembers;

    private string [] studentNames;

    //public methods

    public StudentGroup(string groName, int groSize)

    {
        groupName = groName;

        numMembers = groSize;

        studentNames = new string[groSize];

    }

}
