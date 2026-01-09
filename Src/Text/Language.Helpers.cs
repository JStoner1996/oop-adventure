using System.Text;

namespace OOPAdventure;

public partial class Language
{
    private readonly StringBuilder _stringBuilder = new();

    public virtual string JoinedWordList(string[] words, string conjuction)
    {
        _stringBuilder.Clear();

        for (var i = 0; i < words.Length; i++)
        {
            if (i > 0)
            {
                _stringBuilder.Append(words.Length > 2 ? Comma + Space : Space);
            }

            if (i == words.Length - 1 && words.Length > 1)
            {
                _stringBuilder.Append(conjuction + Space);
            }

            _stringBuilder.Append(words[i]);
        }

        return _stringBuilder.ToString();
    }
}