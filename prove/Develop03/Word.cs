public class Words {
    private boolean _isHidden;
    private string _text;

    public void GetDisplayString ()
    {
        if (_isHidden == true) 
        {
            int length = _text.Length;
            string underscores = new string('_', length);
            return underscores;
        }
        else 
        {
            return _text;
        }
    }

    public void Hide ()
    {
        _isHidden = true;
    }

}
