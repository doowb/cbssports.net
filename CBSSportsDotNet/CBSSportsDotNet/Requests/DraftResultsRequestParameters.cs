using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CBSSportsDotNet.Requests
{
    public class DraftResultsRequestParameters : ICbsRequestParameters
    {
        public string AccessToken { get; set; }
        public ResponseFormatType ResponseFormat { get; set; }

        public bool SuppressPlayerData { get; set; }
        public bool SuppressTeamData { get; set; }
        public bool SuppressRoundData { get; set; }
        public bool MinimumData { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            AddAnd(sb);
            sb.Append(string.Format("{0}={1}", "access_token", AccessToken));
            AddAnd(sb);
            sb.Append(string.Format("{0}={1}", "response_format", ResponseFormat == ResponseFormatType.Xml ? "XML" : "JSON"));


            if (SuppressPlayerData)
            {
                AddAnd(sb);
                sb.Append(string.Format("{0}={1}", "suppress_player_data", 1));
            }

            if (SuppressTeamData)
            {
                AddAnd(sb);
                sb.Append(string.Format("{0}={1}", "suppress_team_data", 1));
            }

            if (SuppressRoundData)
            {
                AddAnd(sb);
                sb.Append(string.Format("{0}={1}", "suppress_round_data", 1));
            }

            if (MinimumData)
            {
                AddAnd(sb);
                sb.Append(string.Format("{0}={1}", "minimum_data", 1));
            }
            return sb.ToString();
        }

        private void AddAnd(StringBuilder sb)
        {
            if (sb.Length > 0)
                sb.Append("&");
        }
    }
}
