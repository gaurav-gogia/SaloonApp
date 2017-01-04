﻿using Sassy_Saloons.Models;
using Sassy_Saloons.Pages;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Net.Http;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;

namespace Sassy_Saloons.Managers
{
    class CommentCall
    {
        private static string URI;
        static FormUrlEncodedContent parameters;

        private static async Task<CommentsResponse> GetWrapperAsync(CommentInfo com)
        {
            var http = new HttpClient();

            switch(com.Upins)
            {
                case 0:
                    parameters = new FormUrlEncodedContent(new[] { new KeyValuePair<string, string>("sname", com.Salonname) });
                    URI = Constants.GETCOM;
                    break;
                case 1:
                    parameters = new FormUrlEncodedContent(new[] { new KeyValuePair<string, string>("sname", com.Salonname),
                                                                   new KeyValuePair<string, string>("user", com.Username),
                                                                   new KeyValuePair<string, string>("comment", com.Comment),
                                                                   new KeyValuePair<string, string>("star", com.Star) });
                    URI = Constants.INCOM;
                    break;
                case 2:
                    parameters = new FormUrlEncodedContent(new[] { new KeyValuePair<string, string>("sname", com.Salonname),
                                                                   new KeyValuePair<string, string>("user", com.Username),
                                                                   new KeyValuePair<string, string>("comment", com.Comment),
                                                                   new KeyValuePair<string, string>("star", com.Star) });
                    URI = Constants.UPCOM;
                    break;
            }

            var response = await http.PostAsync(URI, parameters);
            var result = await response.Content.ReadAsStringAsync();
            var serializer = new DataContractJsonSerializer(typeof(CommentsResponse));
            var ms = new MemoryStream(Encoding.UTF8.GetBytes(result));

            var datax = (CommentsResponse)serializer.ReadObject(ms);

            return datax;
        }   
        
        internal static async Task GetCommentsAsync(CommentInfo com, ObservableCollection<Response> allcom)
        {
            var datawrapper = await GetWrapperAsync(com);
            var getdata = datawrapper.response;            

            foreach (var d in getdata)
                allcom.Add(d);
        }
    }
}
