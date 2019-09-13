using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using Newtonsoft.Json;

namespace Practica4.Api_Service
{
    public class ApiService
    { 
            HttpClient client;
            string grant_type = "Materia";

            public ApiService()
            {
                client = new HttpClient();
                client.MaxResponseContentBufferSize = 256000;
                client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("https://api-newbee.herokuapp.com/materia"));
            }

        }
    }
