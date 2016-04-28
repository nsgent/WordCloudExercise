using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Windows.Forms.Fakes;
using Gent_WordCloudExercise.Fakes;
using Gent_WordCloudExercise.Utilities.Fakes;
using Microsoft.QualityTools.Testing.Fakes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Gent_WordCloudExercise.Test
{
    [TestClass]
    public class WordCloudFormTest
    {
        private WordCloudForm _form;

        [TestInitialize]
        public void Initialize()
        {
            _form = new WordCloudForm();
        }

        [TestMethod]
        public void loadButton_Click_GenerateResults()
        {
            using (ShimsContext.Create())
            {
                ShimTextBox.AllInstances.TextGet = textBox => "../../TestExamples/test.txt";
                ShimProperties.FilterStringsGet = () => new[] {"et", "ut"};
                ShimWordCloudForm.AllInstances.OutputFileGet = form => "../../TestExamples/results.txt";

                _form.loadButton_Click(null, null);

                using (var md5 = MD5.Create())
                {
                    using (var expectedStream = File.OpenRead("../../TestExamples/expectedTestResults.txt"))
                    {
                        var expectedHash = md5.ComputeHash(expectedStream);
                        using (var actualStream = File.OpenRead("../../TestExamples/results.txt"))
                        {
                            var actualHash = md5.ComputeHash(actualStream);
                            Assert.IsTrue(expectedHash.SequenceEqual(actualHash));
                        }
                    }
                }
            }
        }
    }
}
