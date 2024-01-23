using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheJonesesScriptWidget
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    public class DemoStep
    {
        public string Title { get; set; }
        public string SpeakerNotes { get; set; }
        public string ClipboardContent { get; set; }

        public DemoStep(string title, string speakerNotes, string clipboardContent)
        {
            if (String.IsNullOrEmpty($"{title}")) title = "-- no title --";
            if (String.IsNullOrEmpty($"{speakerNotes}")) speakerNotes = "-- no speaker notes --";
            if (String.IsNullOrEmpty($"{clipboardContent}")) clipboardContent = "-- no clipboard content --";

            Title = $"{title}".Trim();
            SpeakerNotes = $"{speakerNotes}".Trim();
            ClipboardContent = $"{clipboardContent}".Trim();
        }
    }

    public static class DemoScriptParser
    {
        public static List<DemoStep> ParseScriptIntoSteps(string script)
        {
            script = $"{script}\n---";
            var steps = new List<DemoStep>();
            var scriptSections = script.Split(new string[] { "---" }, StringSplitOptions.RemoveEmptyEntries);

            foreach (var section in scriptSections)
            {
                
                var trimmedSection = $"{section.Trim()}";
                var lines = trimmedSection.Split(new string[] { "\r\n", "\n" }, StringSplitOptions.None);
                string title = "", speakerNotes = "", clipboardContent = "";

                title = lines.First();
                speakerNotes = lines.Skip(1).First();
                clipboardContent = String.Join('\n', lines.Skip(2).ToArray());
                steps.Add(new DemoStep(title, speakerNotes, clipboardContent.TrimEnd()));
            }

            return steps;
        }
    }
}
