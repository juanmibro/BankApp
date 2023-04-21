
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace BankApp
{
    public class CustomerConverter : JsonConverter<CustomerAdapter>
    {

        public override bool CanConvert(Type objectType)
        {
            return objectType == typeof(CustomerAdapter);
        }

        public override CustomerAdapter Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            if(reader.TokenType != JsonTokenType.StartObject)
        {
                throw new JsonException();
            }

            var customer = new CustomerAdapter();

            while (reader.Read())
            {
                if (reader.TokenType == JsonTokenType.EndObject)
                {
                    return customer;
                }

                if (reader.TokenType != JsonTokenType.PropertyName)
                {
                    throw new JsonException();
                }

                string propertyName = reader.GetString();
                reader.Read();

                switch (propertyName)
                {
                    case "Id":
                        customer.Id = reader.GetInt32();
                        break;
                    case "Name":
                        customer.Name = reader.GetString();
                        break;
                    case "Contact_details":
                        customer.Contact_details = reader.GetString();
                        break;
                    case "Fee":
                        customer.Fee = reader.GetDouble();
                        break;
                    case "CustomerType":
                        customer.CustomerType = reader.GetString();
                        break;
                    case "Accounts":
                        if (reader.TokenType == JsonTokenType.StartArray)
                        {
                            var tmp_list = new List<AccountAdapter>();
                            tmp_list = JsonSerializer.Deserialize<List<AccountAdapter>>(ref reader, options);

                            customer.Accounts = new List<Account>();
                            foreach(AccountAdapter a in tmp_list)
                            {
                                customer.Accounts.Add(a.getAccount());
                            }
                        }
                        break;
                    default:
                        reader.Skip();
                        break;
                }
            }

            throw new JsonException();
        }

        public override void Write(Utf8JsonWriter writer, CustomerAdapter customer, JsonSerializerOptions options)
        {
            writer.WriteStartObject();
            writer.WriteNumber("Id", customer.Id);
            writer.WriteString("Name", customer.Name);
            writer.WriteString("CustomerType", customer.CustomerType);
            writer.WriteString("Contact_details", customer.Contact_details);
            writer.WriteNumber("Fee", customer.Fee);
            writer.WritePropertyName("Accounts");
            JsonSerializer.Serialize(writer, customer.Accounts, options);
            writer.WriteEndObject();
        }
    }
    }

