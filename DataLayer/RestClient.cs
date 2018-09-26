﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{

    public enum httpverb
    {
        GET,
        POST,
        PUT,
        DELETE
    }

    public class RestClient
    {
        public string endPoint { get; set; }
        public httpverb httpMethod { get; set; }

        public RestClient()
        {
            endPoint = "";
            httpMethod = httpverb.GET;
        }

        public string makeRequest()
        {
            string strResponseValue = string.Empty;

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(endPoint);

            HttpClient client = new HttpClient();

            request.Method = httpMethod.ToString();

            using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
            {
                if (response.StatusCode != HttpStatusCode.OK )
                {
                    throw new ApplicationException("Error Code" + response.StatusCode);
                }


                using(Stream responseStream = response.GetResponseStream())
                {
                    if(responseStream != null)
                    {
                        using(StreamReader reader = new StreamReader(responseStream))
                        {
                            strResponseValue = reader.ReadToEnd();
                        }
                    }
                }

            }     
            return strResponseValue;
        }
    }
}