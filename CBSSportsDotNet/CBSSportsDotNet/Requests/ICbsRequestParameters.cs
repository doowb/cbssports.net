using System;
using System.Collections.Generic;
using System.Linq;

namespace CBSSportsDotNet.Requests
{
    public interface ICbsRequestParameters
    {
        string AccessToken { get; set; }
        ResponseFormatType ResponseFormat { get; set; }

        string ToString();
    }
}
