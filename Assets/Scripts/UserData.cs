public class UserData
{
    public int id;
    public string question;
    public string[] items;
    public string coin;

    public UserData(int _id, string _userName, string[] _items, string _coin)
    {
        id = _id;
        question = _userName;
        items = _items;
        coin = _coin;
    }
}