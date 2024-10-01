using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Stratergy_01
{
    internal class Program
    {

        // STRATEGY INTERFACE
        public interface ITextFormatter
        {
            string txtFormat(string text);
        }

        // CONCRETE STRATEGY CLASSES
        public class UpperCaseFormatter : ITextFormatter
        {
            public string txtFormat(string text)
            {
                return $"[UpperCaseFormatter] : {text.ToUpper()}";
            }
        }

        public class LowerCaseFormatter : ITextFormatter
        {
            public string txtFormat(string text)
            {
                return $"[LowerCaseFormatter] : {text.ToLower()}";
            }
        }

        // CONTEXT CLASS
        public class TextEditor
        {
            public ITextFormatter txtFormatter;

            public void SetFormatter(ITextFormatter formatter)
            {
                txtFormatter = formatter;
            }

            public void FormatText(string text)
            {
                if(txtFormatter != null)
                {
                    Console.WriteLine(txtFormatter.txtFormat(text));
                }
                else
                {
                    Console.WriteLine("No formatter set.");
                }
            }
        }

        static void Main(string[] args)
        {
            TextEditor editor = new TextEditor();

            // USING UPPERCASEFORMATTER
            editor.SetFormatter(new UpperCaseFormatter());
            editor.FormatText("Testing text in caps formatter");

            // USING LOWERCASEFORMATTER
            editor.SetFormatter(new LowerCaseFormatter());
            editor.FormatText("Testing text in lower formatter");

            Console.ReadKey();
        }
    }
}
