using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using System.Xml;

namespace UpdaterLibrary
{
    internal class UpdaterXml
    {
        private Version version;
        private Uri uri;
        private string filename;
        private string md5;
        private string description;
        private string launchArgs;
        internal Version _version { get { return this.version; } }
        internal Uri _uri { get { return this.uri; } }
        internal string _filename { get { return this.filename; } }
        internal string _md5 { get { return this.md5; } }
        internal string _description { get { return this.description; } }
        internal string _launchArgs { get { return this.launchArgs; } }
        internal UpdaterXml(Version version, Uri uri, string filename, string md5, string description, string launchArgs)
        {
            version = this.version;
            uri = this.uri;
            filename = this.filename;
            md5 = this.md5;
            description = this.description;
            launchArgs = this.launchArgs;
        }
        internal bool IsNewerThan(Version version)
        {
            return this.version > version;
        }
        internal static bool ExistOnServer(Uri location)
        {
            try
            {
                HttpWebRequest req = (HttpWebRequest)WebRequest.Create(location.AbsoluteUri);
                HttpWebResponse resp = (HttpWebResponse)req.GetResponse();
                resp.Close();
                return resp.StatusCode == HttpStatusCode.OK;
            }
            catch
            {
                { return false; }
            }
        }
        internal static UpdaterXml Parse(Uri location, string appID)
        {
            Version version = null;
            string url = "", filename = "", md5 = "", description = "", launchArgs = "";
            try
            {
                XmlDocument doc = new XmlDocument();
                doc.Load(location.AbsoluteUri);
                XmlNode node = doc.DocumentElement.SelectSingleNode("//update[@appId='" + appID + "']");
                if (node == null)
                {
                    return null;
                }
                version = Version.Parse(node["version"].InnerText);
                url = (node["url"].InnerText);
                filename = (node["fileName"].InnerText);
                md5 = (node["md5"].InnerText);
                description = (node["description"].InnerText);
                launchArgs = (node["launchArgs"].InnerText);
                return new UpdaterXml(version, new Uri(url), filename, md5, description, launchArgs);
            }
            catch
            {
                return null;
            }
        }
    }
}
