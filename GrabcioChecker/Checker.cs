using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace GrabcioChecker
{
    class Checker
    {
        private static readonly string GrabcioUrl="http://home.agh.edu.pl/~pgrab/grabowski_files/tylkoseks/";
        private static Regex checker = new Regex(@".*16-Jan-2017.*");
        public static bool Check(Label label)
        {
            label.Text = "Last check: " + DateTime.Now.ToString("HH:mm:ss");
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(GrabcioUrl);
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            StreamReader reader = new StreamReader(response.GetResponseStream());
            return !checker.IsMatch(reader.ReadToEnd());
            
        }
    }
}
