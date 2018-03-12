using System;
using System.Text;
using Crestron.SimplSharp;                          				// For Basic SIMPL# Classes
using Crestron.SimplSharp.Net;
using Crestron.SimplSharp.Net.Http;

namespace AVTS_Panasonic_Camera
{
    public class PanasonicCam
    {
        public string ip;
        
        /// <summary>
        /// SIMPL+ can only execute the default constructor. If you have variables that require initialization, please
        /// use an Initialize method
        /// </summary>
        ///
        HttpClientResponse response;
        HttpClient client = new HttpClient();
        HttpClientRequest request = new HttpClientRequest();

        public void powerOn()
        {
            try
            {
                String url = "http://" + ip + "/cgi-bin/aw_ptz?cmd=%23O1&res=1";
                request.Url.Parse(url);
                response = client.Dispatch(request);
                //ErrorLog.Warn("REPSONSE FROM WEB REQUEST:{0}", response.Code.ToString());
                client.Dispose();
            }
            catch (Exception e)
            {
                ErrorLog.Error("Error In Camera Control: {0}", e.Message);
            }
            
        }
        public void powerOff()
        {
            try
            {
                String url = "http://" + ip + "/cgi-bin/aw_ptz?cmd=%23O0&res=1";
                request.Url.Parse(url);
                response = client.Dispatch(request);
                //ErrorLog.Warn("REPSONSE FROM WEB REQUEST:{0}", response.Code.ToString());
                client.Dispose();
            }
            catch (Exception e)
            {
                ErrorLog.Error("Error In Camera Control: {0}", e.Message);
            }
        }
        public void panLeft()
        {
            try
            {
                String url = "http://" + ip + "/cgi-bin/aw_ptz?cmd=%23PTS2150&res=1";
                request.Url.Parse(url);
                response = client.Dispatch(request);
                //ErrorLog.Warn("REPSONSE FROM WEB REQUEST:{0}", response.Code.ToString());
                client.Dispose();
            }
            catch (Exception e)
            {
                ErrorLog.Error("Error In Camera Control: {0}", e.Message);
            }
        }
        public void panRight()
        {
            try
            {
                String url = "http://" + ip + "/cgi-bin/aw_ptz?cmd=%23PTS7950&res=1";
                request.Url.Parse(url);
                response = client.Dispatch(request);
                //ErrorLog.Warn("REPSONSE FROM WEB REQUEST:{0}", response.Code.ToString());
                client.Dispose();
            }
            catch (Exception e)
            {
                ErrorLog.Error("Error In Camera Control: {0}", e.Message);
            }
        }
        public void tiltUp()
        {
            try
            {
                String url = "http://" + ip + "/cgi-bin/aw_ptz?cmd=%23PTS5079&res=1";
                request.Url.Parse(url);
                response = client.Dispatch(request);
                //ErrorLog.Warn("REPSONSE FROM WEB REQUEST:{0}", response.Code.ToString());
                client.Dispose();
            }
            catch (Exception e)
            {
                ErrorLog.Error("Error In Camera Control: {0}", e.Message);
            }
        }
        public void tiltDown()
        {
            try
            {
                String url = "http://" + ip + "/cgi-bin/aw_ptz?cmd=%23PTS5021&res=1";
                request.Url.Parse(url);
                response = client.Dispatch(request);
                //ErrorLog.Warn("REPSONSE FROM WEB REQUEST:{0}", response.Code.ToString());
                client.Dispose();
            }
            catch (Exception e)
            {
                ErrorLog.Error("Error In Camera Control: {0}", e.Message);
            }
        }
        public void panTiltStop()
        {
            try
            {
                String url = "http://" + ip + "/cgi-bin/aw_ptz?cmd=%23PTS5050&res=1";
                request.Url.Parse(url);
                response = client.Dispatch(request);
                //ErrorLog.Warn("REPSONSE FROM WEB REQUEST:{0}", response.Code.ToString());
                client.Dispose();
            }
            catch (Exception e)
            {
                ErrorLog.Error("Error In Camera Control: {0}", e.Message);
            }
        }
        public void zoomIn()
        {
            try
            {
                String url = "http://" + ip + "/cgi-bin/aw_ptz?cmd=%23Z99&res=1";
                request.Url.Parse(url);
                response = client.Dispatch(request);
                //ErrorLog.Warn("REPSONSE FROM WEB REQUEST:{0}", response.Code.ToString());
                client.Dispose();
            }
            catch (Exception e)
            {
                ErrorLog.Error("Error In Camera Control: {0}", e.Message);
            }
        }
        public void zoomOut()
        {
            try
            {
                String url = "http://" + ip + "/cgi-bin/aw_ptz?cmd=%23Z01&res=1";
                request.Url.Parse(url);
                response = client.Dispatch(request);
                //ErrorLog.Warn("REPSONSE FROM WEB REQUEST:{0}", response.Code.ToString());
                client.Dispose();
            }
            catch (Exception e)
            {
                ErrorLog.Error("Error In Camera Control: {0}", e.Message);
            }
        }
        public void zoomStop()
        {
            try
            {
                String url = "http://" + ip + "/cgi-bin/aw_ptz?cmd=%23Z50&res=1";
                request.Url.Parse(url);
                response = client.Dispatch(request);
                //ErrorLog.Warn("REPSONSE FROM WEB REQUEST:{0}", response.Code.ToString());
                client.Dispose();
            }
            catch (Exception e)
            {
                ErrorLog.Error("Error In Camera Control: {0}", e.Message);
            }
        }
        public void callPreset1()
        {
            try
            {
                  String url = "http://" + ip + "/cgi-bin/aw_ptz?cmd=%23R00&res=1";
                  request.Url.Parse(url);
                  response = client.Dispatch(request);
                  //ErrorLog.Warn("REPSONSE FROM WEB REQUEST:{0}", response.Code.ToString());
                  client.Dispose();
                
            }
            catch (Exception e)
            {
                ErrorLog.Error("Error In Camera Control: {0}", e.Message);
            }
        }
        public void callPreset2()
        {
            try
            {
                String url = "http://" + ip + "/cgi-bin/aw_ptz?cmd=%23R01&res=1";
                request.Url.Parse(url);
                response = client.Dispatch(request);
                //ErrorLog.Warn("REPSONSE FROM WEB REQUEST:{0}", response.Code.ToString());
                client.Dispose();

            }
            catch (Exception e)
            {
                ErrorLog.Error("Error In Camera Control: {0}", e.Message);
            }
        }
        public void callPreset3()
        {
            try
            {
                String url = "http://" + ip + "/cgi-bin/aw_ptz?cmd=%23R02&res=1";
                request.Url.Parse(url);
                response = client.Dispatch(request);
                //ErrorLog.Warn("REPSONSE FROM WEB REQUEST:{0}", response.Code.ToString());
                client.Dispose();

            }
            catch (Exception e)
            {
                ErrorLog.Error("Error In Camera Control: {0}", e.Message);
            }
        }
        public void callPreset4()
        {
            try
            {
                String url = "http://" + ip + "/cgi-bin/aw_ptz?cmd=%23R03&res=1";
                request.Url.Parse(url);
                response = client.Dispatch(request);
                //ErrorLog.Warn("REPSONSE FROM WEB REQUEST:{0}", response.Code.ToString());
                client.Dispose();

            }
            catch (Exception e)
            {
                ErrorLog.Error("Error In Camera Control: {0}", e.Message);
            }
        }
        public void callPreset5()
        {
            try
            {
                String url = "http://" + ip + "/cgi-bin/aw_ptz?cmd=%23R04&res=1";
                request.Url.Parse(url);
                response = client.Dispatch(request);
                //ErrorLog.Warn("REPSONSE FROM WEB REQUEST:{0}", response.Code.ToString());
                client.Dispose();

            }
            catch (Exception e)
            {
                ErrorLog.Error("Error In Camera Control: {0}", e.Message);
            }
        }
        public void storePreset1()
        {
            try
            {
                String url = "http://" + ip + "/cgi-bin/aw_ptz?cmd=%23M00&res=1";
                request.Url.Parse(url);
                response = client.Dispatch(request);
                //ErrorLog.Warn("REPSONSE FROM WEB REQUEST:{0}", response.Code.ToString());
                client.Dispose();

            }
            catch (Exception e)
            {
                ErrorLog.Error("Error In Camera Control: {0}", e.Message);
            }
        }
        public void storePreset2()
        {
            try
            {
                String url = "http://" + ip + "/cgi-bin/aw_ptz?cmd=%23M01&res=1";
                request.Url.Parse(url);
                response = client.Dispatch(request);
                //ErrorLog.Warn("REPSONSE FROM WEB REQUEST:{0}", response.Code.ToString());
                client.Dispose();

            }
            catch (Exception e)
            {
                ErrorLog.Error("Error In Camera Control: {0}", e.Message);
            }
        }
        public void storePreset3()
        {
            try
            {
                String url = "http://" + ip + "/cgi-bin/aw_ptz?cmd=%23M02&res=1";
                request.Url.Parse(url);
                response = client.Dispatch(request);
                //ErrorLog.Warn("REPSONSE FROM WEB REQUEST:{0}", response.Code.ToString());
                client.Dispose();

            }
            catch (Exception e)
            {
                ErrorLog.Error("Error In Camera Control: {0}", e.Message);
            }
        }
        public void storePreset4()
        {
            try
            {
                String url = "http://" + ip + "/cgi-bin/aw_ptz?cmd=%23M03&res=1";
                request.Url.Parse(url);
                response = client.Dispatch(request);
                //ErrorLog.Warn("REPSONSE FROM WEB REQUEST:{0}", response.Code.ToString());
                client.Dispose();

            }
            catch (Exception e)
            {
                ErrorLog.Error("Error In Camera Control: {0}", e.Message);
            }
        }
        public void storePreset5()
        {
            try
            {
                String url = "http://" + ip + "/cgi-bin/aw_ptz?cmd=%23M04&res=1";
                request.Url.Parse(url);
                response = client.Dispatch(request);
                //ErrorLog.Warn("REPSONSE FROM WEB REQUEST:{0}", response.Code.ToString());
                client.Dispose();

            }
            catch (Exception e)
            {
                ErrorLog.Error("Error In Camera Control: {0}", e.Message);
            }
        }
       


        public PanasonicCam()
        {
        }
    }
}
