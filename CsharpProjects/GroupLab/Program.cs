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

     //allow adding a student’s name at a specific position in the group
    //if the position is invalid, the system will return an error message
    public void addMember(string stuName, int position)
    {
        if (position < 0 || position >= numMembers)
        {
            Console.WriteLine("Error: Invalid position.");
        }
        else
        {
            for (int count = 0; count < numMembers; count++)
            {
                if (count == position)
                {
                    studentNames[count] = stuName;
                    Console.WriteLine($"Success:{stuName} added to position{count}.");
                }
            }
        }
    }

    //allow retrieving the student’s name when given their position
    //system will return an error message if position is invalid
    public string retrieveMember(int index)
    {
        if (index < 0 || index >= numMembers)
        {
            return "Error: Invalid position.";
        }
        else
        {
            for (int count = 0; count < numMembers; count++)
            {
                if (count == index)
                {
                    return studentNames[count];
                }
            }
        }

    }

    //system will display the group name and name of all students in group
    public void displayGroup()
    {
        Console.WriteLine($"Group: {groupName}");
        for (int count = 0; count < numMembers; count++)
        {
            Console.WriteLine(studentNames[count]);
        }

    }

}
