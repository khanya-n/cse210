public class Word
{
    private string _text;
    private bool _isHidden;

    public Word(string wordText)
    {
        _text = wordText;
        _isHidden = false;
    }

    public void Hide()
    {
        _isHidden = true;
    }

    public void Show()
    {
        _isHidden = false;
    }

    public bool IsHidden()
    {
        return _isHidden;
    }

    public string GetDisplayText()
    {
        if (!_isHidden)
        {
            return _text;
        }
        else
        {
            string blank = "";

            for (int i = 1; i <= _text.Length; i++)
            {
                blank += "_";
            }
            
            return blank;
        }
    }
}