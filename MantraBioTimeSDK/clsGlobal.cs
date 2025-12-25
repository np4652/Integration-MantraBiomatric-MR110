using MantraBioTimeDLL;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Net;
using System.Text;
using System.Windows.Forms;

namespace MantraBioTimeSDK
{
    public static class clsGlobal
    {
        public static string DevID = "1";
        public static string DevIP = "192.168.1.201";
        public static string DevPort = "4370";
        public static string DevPass = "0";
        public static int DeviceType = 0;
        public static bool IsConnect = false;
        public static string PrintURL = "https://themusclesbargym.co.in/Invoice/{0}";
        public static string ErrorPrint(int aErrorCode)
        {
            switch (aErrorCode)
            {
                case 0:
                    return "SUCCESS";
                case 1:
                    return "ERR_COMPORT_ERROR";
                case 2:
                    return "ERR_WRITE_FAIL";
                case 3:
                    return "ERR_READ_FAIL";
                case 4:
                    return "ERR_INVALID_PARAM";
                case 5:
                    return "ERR_NON_CARRYOUT";
                case 6:
                    return "ERR_LOG_END";
                case 7:
                    return "ERR_MEMORY";
                case 8:
                    return "ERR_MULTIUSER";
                default:
                    return "NO_ERROR";
            }

        }
    }
    public class ClsSetEnrollData
    {
        public int MachineNo { get; set; }
        public int DeviceType { get; set; }
        public string UserId { get; set; }
        public string UserName { get; set; }
        public string pwd { get; set; }
        public string Card { get; set; }
        public int Privilege { get; set; }
        public string IsEnabled { get; set; }
        public int InputNo { get; set; }
        public Byte[] Template { get; set; }
    }

    public class DisableUsers
    {
        public int bioid { get; set; }
        public string name { get; set; }
        public string phoneNumber { get; set; }
    }
    public class APIResponse
    {
        public int statusCode { get; set; }
        public string responseText { get; set; }
    }
    public class APIResponse<T>: APIResponse
    {
        public T result { get; set; }
    }

    public class CollectFeeResponse : APIResponse
    {
        public int userId { get; set; }
        public int ledgerId { get; set; }
    }

    public class subscriptionbyuserResponse
    {
        public int userId { get; set; }
        public string name { get; set; }
    }

    public class GetUserByIdResponse
    {
        public int Id { get; set; }
        public string phoneNumber { get; set; }
        public string userName { get; set; }
        public string name { get; set; }
        public string email { get; set; }
        public string dame { get; set; }
        public string gender { get; set; }
        public string dob { get; set; }
        public string address { get; set; }
        public string adharNo { get; set; }
        public string maritalStatus { get; set; }
        public string occupation { get; set; }
        public string referBy { get; set; }
        public int membershipType { get; set; }
        public string role { get; set; }
        public string refreshToken { get; set; }
        public bool IsCardio { get; set; }
    }
    public class UserDetail
    {
        public int UserId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public string Password { get; set; }
        public string Privilege { get; set; }
        public string CardNumber { get; set; }
        public bool IsUserEnable { get; set; }
        public int fIndex { get; set; }
    }

    public class Helpers
    {
        public string PostJsonDataUsingHWR(string URL, object PostData)
        {
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls;
            string result = "";
            try
            {
                var http = (HttpWebRequest)System.Net.WebRequest.Create(URL);
                http.Timeout = 3 * 60 * 1000;
                var data = Encoding.UTF8.GetBytes(JsonConvert.SerializeObject(PostData, Formatting.Indented));
                http.Method = "POST";
                http.Accept = "application/json";
                http.ContentType = "application/json";
                http.ContentLength = data.Length;
                using (Stream stream = http.GetRequestStream())
                {
                    stream.Write(data, 0, data.Length);
                }
                var response = http.GetResponse();

                using (StreamReader sr = new StreamReader(response.GetResponseStream()))
                {
                    result = sr.ReadToEnd();
                }
            }
            catch (UriFormatException ufx)
            {
                throw new Exception(ufx.Message);
            }
            catch (WebException wx)
            {
                if (wx.Response != null)
                {
                    using (var ErrorResponse = wx.Response)
                    {
                        using (StreamReader sr = new StreamReader(ErrorResponse.GetResponseStream()))
                        {
                            result = sr.ReadToEnd();
                        }
                    }
                }
                else
                {
                    throw new Exception(wx.Message);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return result;
        }

        public void syncData()
        {
            if (clsGlobal.IsConnect)
            {
                var Cursor = Cursors.WaitCursor;
                int _flgVal = 0;
                try
                {
                    DataTable Dt = new DataTable();
                    _flgVal = MantraBioTime.ReadAllLogData(clsGlobal.DeviceType, ref Dt);
                    if (_flgVal == 0)
                    {
                        MantraBioTimeSDK.theForm.EventLogs.Items.Add("Get New AttenLogData Successfully.");
                        MantraBioTimeSDK.theForm.EventLogs.TopIndex = MantraBioTimeSDK.theForm.EventLogs.Items.Count - 1;
                        var serializeLog = JsonConvert.SerializeObject(Dt);
                        //var helper = new Helpers();
                        string apiData = PostJsonDataUsingHWR("https://themusclesbargym.co.in/api/user/syncattendance", new
                        {
                            data = serializeLog
                        });
                    }
                    else
                    {
                        MantraBioTimeSDK.theForm.ErrorLogs.Items.Add(MantraBioTimeException.MsgCode(_flgVal));
                        MantraBioTimeSDK.theForm.ErrorLogs.TopIndex = MantraBioTimeSDK.theForm.ErrorLogs.Items.Count - 1;
                    }
                }
                catch (Exception Ex)
                {
                    MantraBioTimeSDK.theForm.ErrorLogs.Items.Add(Ex.Message);
                    MantraBioTimeSDK.theForm.ErrorLogs.TopIndex = MantraBioTimeSDK.theForm.ErrorLogs.Items.Count - 1;
                }
                finally
                {
                    Cursor = Cursors.Default;
                }
            }
            else
            {
                MantraBioTimeSDK.theForm.ErrorLogs.Items.Add("Please connect device first");
                MantraBioTimeSDK.theForm.ErrorLogs.TopIndex = MantraBioTimeSDK.theForm.ErrorLogs.Items.Count - 1;
            }
        }

        public void DeleteExpiredSubscription()
        {
            if (clsGlobal.IsConnect)
            {
                try
                {
                    string apiData = new WebClient().DownloadString("https://themusclesbargym.co.in/api/user/subscriptionexpired");
                    var data = JsonConvert.DeserializeObject<List<DisableUsers>>(apiData);
                    foreach (var user in data)
                    {
                        MantraBioTime.DeleteEnrollData(clsGlobal.DeviceType, user.bioid.ToString());
                    }
                }
                catch (Exception ex)
                {

                }
            }
            else
            {
                MantraBioTimeSDK.theForm.ErrorLogs.Items.Add("Please connect device first");
                MantraBioTimeSDK.theForm.ErrorLogs.TopIndex = MantraBioTimeSDK.theForm.ErrorLogs.Items.Count - 1;
            }
        }
    }
}
