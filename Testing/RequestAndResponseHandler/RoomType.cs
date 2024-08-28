using GMS.Service.Dtos.Halls;
using GMS.Service.Dtos.Room;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Testing.RequestAndResponseHandler
{
    public class RoomType
    {
        private readonly HttpClient _client;

        public RoomType()
        {
            _client = new HttpClient();
            _client.DefaultRequestHeaders.Accept.Clear();
            _client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }

        public async Task<bool> AddRoomTypeAsync(string fullUrl, RoomTypeDto roomTypeDto)
        {
            var jsonContent = JsonConvert.SerializeObject(roomTypeDto);
            var content = new StringContent(jsonContent, Encoding.UTF8, "application/json");

            try
            {
                HttpResponseMessage response = await _client.PostAsync(fullUrl, content);

                if (response.IsSuccessStatusCode)
                {
                    return true;
                }
                else
                {
                    string responseContent = await response.Content.ReadAsStringAsync();
                    Console.WriteLine($"Error: {response.StatusCode}, {responseContent}");
                    return false;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception: {ex.Message}");
                return false;
            }
        }

        public async Task<RoomTypeDto> GetRoomTypeByIdAsync(string fullUrl)
        {
            try
            {
                HttpResponseMessage response = await _client.GetAsync(fullUrl);

                if (response.IsSuccessStatusCode)
                {
                    var jsonContent = await response.Content.ReadAsStringAsync();
                    var roomTypeDto = JsonConvert.DeserializeObject<RoomTypeDto>(jsonContent);
                    return roomTypeDto;
                }
                else
                {
                    string responseContent = await response.Content.ReadAsStringAsync();
                    Console.WriteLine($"Error: {response.StatusCode}, {responseContent}");
                    return null;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception: {ex.Message}");
                return null;
            }
        }

        public async Task<bool> UpdateRoomTypeAsync(string fullUrl, RoomTypeDto roomTypeDto)
        {
            var jsonContent = JsonConvert.SerializeObject(roomTypeDto);
            var content = new StringContent(jsonContent, Encoding.UTF8, "application/json");

            try
            {
                HttpResponseMessage response = await _client.PutAsync(fullUrl, content);

                if (response.IsSuccessStatusCode)
                {
                    return true;
                }
                else
                {
                    string responseContent = await response.Content.ReadAsStringAsync();
                    Console.WriteLine($"Error: {response.StatusCode}, {responseContent}");
                    return false;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception: {ex.Message}");
                return false;
            }
        }

        public async Task<bool> DeleteRoomTypeByIdAsync(string fullUrl)
        {
            try
            {
                HttpResponseMessage response = await _client.DeleteAsync(fullUrl);

                if (response.IsSuccessStatusCode)
                {
                    return true;
                }
                else
                {
                    string responseContent = await response.Content.ReadAsStringAsync();
                    Console.WriteLine($"Error: {response.StatusCode}, {responseContent}");
                    return false;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception: {ex.Message}");
                return false;
            }
        }
        public async Task<List<RoomTypeDto>> GetAllRoomTypesAsync(string fullUrl)
        {
            try
            {
                HttpResponseMessage response = await _client.GetAsync(fullUrl);

                if (response.IsSuccessStatusCode)
                {
                    string responseContent = await response.Content.ReadAsStringAsync();

                    // Deserialize the response into the wrapper class
                    var roomTypeResponse = JsonConvert.DeserializeObject<RoomTypeResponse>(responseContent);

                    if (roomTypeResponse != null && roomTypeResponse.Success)
                    {
                        return roomTypeResponse.Data;
                    }
                    else
                    {
                        Console.WriteLine("Failed to get room types from the API.");
                        return null;
                    }
                }
                else
                {
                    Console.WriteLine($"Error: {response.StatusCode}");
                    return null;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception: {ex.Message}");
                return null;
            }
        }




    }
}
