
using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace BankApp
{
    public class StateController
    {
        private string path = Path.Join(AppDomain.CurrentDomain.BaseDirectory, "Data");
        private string filename = null;
        private JsonSerializerOptions options;

        public StateController(string filename = "data.json")
        {
  
            this.filename = Path.Join(this.path, filename);
            this.options = new JsonSerializerOptions { Converters = { new CustomerConverter() } };
        }

        /// <summary>
        /// Objects to json.
        /// </summary>
        /// <param name="o">The o.</param>
        /// <returns></returns>
        //internal string ObjectToJson(List<Customer> o)
        //{
        //    string json = JsonConvert.SerializeObject(o, Formatting.Indented);
        //    return json;
        //}
        /// <summary>
        /// Jsons to object.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="json">The json.</param>
        /// <returns></returns>
        //internal T JsonToObject<T>(String json)
        //{
        //    T Obj = JsonConvert.DeserializeObject<T>(json);
        //    return Obj;
        //}


        /// <summary>
        /// Loads the state.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public List<Customer> LoadState()
        {

            if (!File.Exists(this.filename))
            {
                return new List<Customer>();
            }


            string json = File.ReadAllText(filename);
            List<Customer> result = new List<Customer>();
            List<CustomerAdapter> customers =  JsonSerializer.Deserialize<List<CustomerAdapter>>(json,options);
            customers.ForEach(customer => result.Add(customer.GetAccount()));
            return result;
        }

        /// <summary>
        /// Saves the state.
        /// </summary>
        /// <param name="customers">The customers.</param>
        public void SaveState(List<Customer> customers)
        {

            if (!Directory.Exists(this.path))
            {
                Directory.CreateDirectory(this.path);
            }
            File.WriteAllText(filename, JsonSerializer.Serialize(customers, options));
        }
    }
}
