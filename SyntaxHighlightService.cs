using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using DevExpress.XtraRichEdit.API.Native;
using DevExpress.XtraRichEdit.Services;

namespace UniversalReferenceDataEditor
{
    public class SyntaxHighlightService :ISyntaxHighlightService
    {
        #region #parsetokens

        private readonly Document _document;
        private readonly SyntaxHighlightProperties _defaultSettings = new SyntaxHighlightProperties() { ForeColor = Color.Black };
        private readonly SyntaxHighlightProperties _keywordSettings = new SyntaxHighlightProperties() { ForeColor = Color.DodgerBlue };
        private readonly SyntaxHighlightProperties _stringSettings = new SyntaxHighlightProperties() { ForeColor = Color.Red };
        private readonly SyntaxHighlightProperties _lesserKeywordSettings = new SyntaxHighlightProperties() { ForeColor = Color.DarkBlue };
        private readonly SyntaxHighlightProperties _comments = new SyntaxHighlightProperties() {ForeColor = Color.Chartreuse};

        private readonly string[] _keywords =
        {
            "INSERT", "SELECT", "CREATE", "TABLE", "USE", "IDENTITY" 
        };

        private readonly string[] _lesserKeywords =
        {
            "ON", "OFF", "NOT", "NULL", "WITH", "SET", "FROM", "WHERE", "JOIN"
        };

        public SyntaxHighlightService(Document document)
        {
            _document = document;
        }

        private List<SyntaxHighlightToken> ParseTokens()
        {

            var tokens = new List<SyntaxHighlightToken>();
            var expr = new System.Text.RegularExpressions.Regex(@"(/\*([^*]|[\r\n]|(\*+([^*/]|[\r\n])))*\*+/)|(--.*)");
            var ranges = _document.FindAll(expr);
            foreach (var t in ranges)
            {
                if (!IsRangeInTokens(t, tokens))
                    tokens.Add(new SyntaxHighlightToken(t.Start.ToInt(), t.Length, _comments));
            }

            // search for quotation marks
            ranges = _document.FindAll("'", SearchOptions.None);
            for (var i = 0; i < ranges.Length / 2; i++)
            {
                tokens.Add(new SyntaxHighlightToken(ranges[i * 2].Start.ToInt(),
                    ranges[i * 2 + 1].Start.ToInt() - ranges[i * 2].Start.ToInt() + 1, _stringSettings));
            }
            // search for keywords
            foreach (var t in _keywords)
            {
                ranges = _document.FindAll(t, SearchOptions.WholeWord);

                foreach (var t1 in ranges)
                {
                    if (!IsRangeInTokens(t1, tokens))
                        tokens.Add(new SyntaxHighlightToken(t1.Start.ToInt(), t1.Length, _keywordSettings));
                }
            }
            //search for lesser keywords
            foreach (var t in _lesserKeywords)
            {
                ranges = _document.FindAll(t, SearchOptions.WholeWord);

                foreach (var t1 in ranges)
                {
                    if (!IsRangeInTokens(t1, tokens))
                        tokens.Add(new SyntaxHighlightToken(t1.Start.ToInt(), t1.Length, _lesserKeywordSettings));
                }
            }
           
            // order tokens by their start position
            tokens.Sort(new SyntaxHighlightTokenComparer());
            // fill in gaps in document coverage
            AddPlainTextTokens(tokens);
            return tokens;
        }

        #endregion
        private void AddPlainTextTokens(IList<SyntaxHighlightToken> tokens)
        {
            var count = tokens.Count;
            if (count == 0)
            {
                tokens.Add(new SyntaxHighlightToken(0, _document.Range.End.ToInt(), _defaultSettings));
                return;
            }
            tokens.Insert(0, new SyntaxHighlightToken(0, tokens[0].Start, _defaultSettings));
            for (var i = 1; i < count; i++)
            {
                tokens.Insert(i * 2, new SyntaxHighlightToken(tokens[i * 2 - 1].End,
                    tokens[i * 2].Start - tokens[i * 2 - 1].End, _defaultSettings));
            }
            tokens.Add(new SyntaxHighlightToken(tokens[count * 2 - 1].End,
                _document.Range.End.ToInt() - tokens[count * 2 - 1].End, _defaultSettings));
        }

        private static bool IsRangeInTokens(DocumentRange range, IEnumerable<SyntaxHighlightToken> tokens)
        {
            return tokens.Any(t => IsIntersect(range, t));
        }

        private static bool IsIntersect(DocumentRange range, SyntaxHighlightToken token)
        {
            var start = range.Start.ToInt();
            if (start >= token.Start && start < token.End)
                return true;
            var end = range.End.ToInt() - 1;
            if (end >= token.Start && end < token.End)
                return true;
            return false;
        }

        #region #ISyntaxHighlightServiceMembers
        public void ForceExecute()
        {
            Execute();
        }
        public void Execute()
        {
            _document.ApplySyntaxHighlight(ParseTokens());
        }
        #endregion #ISyntaxHighlightServiceMembers
    }
}
    #region #SyntaxHighlightTokenComparer
    public class SyntaxHighlightTokenComparer : IComparer<SyntaxHighlightToken>
    {
        public int Compare(SyntaxHighlightToken x, SyntaxHighlightToken y)
        {
            if (x == null) return -1;
            if (y != null)
            {
                return x.Start - y.Start;
            }
            return -1;
        }
    }
    #endregion #SyntaxHighlightTokenComparer

