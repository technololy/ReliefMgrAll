using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SterlingMobile.Services
{
    public class DataService
    {
        APIService apiService;
        public DataService()
        {
            apiService = new APIService();
        }


       

        public  async Task<T2> PostData<T1,T2>(T1 model,string endPoint)
        {            
            var response = await apiService.Post<T2>(model, endPoint);
            return response;
        }

        public  async Task<T> GetData<T>( string endPoint)
        {
            var response = await apiService.Get<T>( endPoint);
            return response;
        }
    }
}
