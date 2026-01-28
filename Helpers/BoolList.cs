namespace DotNetWorkshop2026.Helpers;

class BoolList
{
    public List<bool> boolArray = [true, false, false];

    public BoolList()
    {
        boolArray.Add(true);
    }

    public BoolList(bool initialBool)
    {
        boolArray.Add(initialBool);
    }

    public void AddBool(bool boolean)
    {
        boolArray.Add(boolean);
    }
}
