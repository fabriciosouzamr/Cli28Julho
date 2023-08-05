using Newtonsoft.Json;

namespace WorkerService
{

  public class cResponse
  {
    public string chat_add_id { get; set; }
    public string chat_add_status { get; set; }
    public int code { get; set; }
    public string description { get; set; }
    public string result { get; set; }
  }

  public class modChatGuru
  {
    public string sKey = "UPKZPO18E49W2I2J8NPUVYOF6T0MUYGYV71X1S8S4N3OUV3FYFDU8R4UN16STVZN";
    public string sAccountId = "625ea934822c38492819b7bf";
    public string sPhoneId = "625eaafbbb25ea2c81b31a4e";

    public readonly ILogger<Worker> _logger;

    cResponse oresponse = new cResponse();

    public async Task<bool> EnviarAsync(string sMensagem,
                       string sNome,
                       string sNumero,
                       string sTitulo,
                       string sArquivo,
                       string sUsuario,
                       string sDialogo = "")
    {
      //sNumero = "+55 (73) 91553135";

      if (sNumero.Substring(0, 3) == "+55")
      {
        try
        {
          await message_send(sMensagem, sNome, sNumero, sTitulo, sArquivo, sUsuario, sDialogo);

          if (oresponse == null)
          {
            return false;
          }
          else
          {
            return oresponse.code == 201;
          }
        }
        catch (Exception Ex)
        {
          var erro = Ex.Message;
          return false;
        }
      }
      else
      {
        Escrever(DateTime.Now.ToString() + " - O contato " + sNome + " " + sNumero + " não está no formato certo");
        Escrever("--------------------------------------------------------------------------------");
        return false;
      }
    }

    async Task<bool> message_send(string sMensagem,
                                  string sNome,
                                  string sNumero,
                                  string sTitulo,
                                  string sArquivo,
                                  string sUsuario,
                                  string sDialogo = "")
    {
      bool Ok = false;

      try
      {
        await messag(sMensagem, sNome, sNumero, sTitulo, sArquivo, sUsuario, sDialogo);

        Ok = true;
      }
      catch (Exception Ex)
      {
        var erro = Ex.Message;
      }

      return Ok;
    }

    async Task<bool> messag(string sMensagem, string sNome, string sNumero, string sTitulo, string sArquivo, string sUsuario, string sDialogo = "")
    {
      bool Ok = false;

      try
      {
        string sLink = "";

        oresponse = null;

        if ((sMensagem.Trim() != ""))
        {
          if ((sUsuario.Trim() == "") || (1==1))
          {
            sLink = "https://s15.chatguru.app/api/v1?key=" + sKey +
                                                    "&account_id=" + sAccountId +
                                                    "&phone_id=" + sPhoneId +
                                                    "&action=message_send" +
                                                    "&userid=" + sUsuario +
                                                    "&send_date=" + DateTime.Now.ToString("yyyy-MM-dd HH:MM") +
                                                    "&text=" + sMensagem +
                                                    "&chat_number=" + sNumero;

            if (sDialogo!="")
            {
              sLink = sLink + "&dialog_id=" + sDialogo;
            }

            using (HttpClient httpClient = new HttpClient())
            {
              using (var response = await httpClient.PostAsync(sLink, new StringContent("")))
              {
                string apiResponse = await response.Content.ReadAsStringAsync();

                Escrever(DateTime.Now.ToString() + " - " + sLink);
                Escrever(apiResponse);
                Escrever("--------------------------------------------------------------------------------");

                while (true)
                {
                  try
                  {
                    oresponse = JsonConvert.DeserializeObject<cResponse>(apiResponse);

                    if (oresponse != null)
                    {
                      break;
                    }
                  }
                  catch (Exception Ex)
                  {
                    var erro = Ex.Message;
                  }
                }
              }
            }

            switch (oresponse.code)
            {
              case 400:
                await chat_add(sMensagem, sNome, sNumero, sUsuario);
                break;
            }
          }
          else
          {
            await chat_add(sMensagem, sNome, sNumero, sUsuario, sDialogo);
          }
        }

        if (sArquivo.Trim() != "")
        {
          await file(sNumero, sTitulo, sArquivo);
        }

        Ok = true;
      }
      catch (Exception Ex)
      {
        var erro = Ex.Message;
      }

      return Ok;
    }
    async Task<cResponse> file(string sNumero,
                             string sTitulo,
                             string sArquivo)
    {
      oresponse = null;

      try
      {
        string sLink = "";

        sLink = "https://s15.chatguru.app/api/v1?key=" + sKey +
                                                "&account_id=" + sAccountId +
                                                "&phone_id=" + sPhoneId +
                                                "&action=message_file_send&" +
                                                "&file_url=" + sArquivo +
                                                "&caption=" + sTitulo +
                                                "&chat_number=" + sNumero;

        using (HttpClient httpClient = new HttpClient())
        {
          using (var response = await httpClient.PostAsync(sLink, new StringContent("")))
          {
            string apiResponse = await response.Content.ReadAsStringAsync();
            Escrever(DateTime.Now.ToString() + " - " + sLink);
            Escrever(apiResponse);
            Escrever("--------------------------------------------------------------------------------");

            while (true)
            {
              try
              {
                oresponse = JsonConvert.DeserializeObject<cResponse>(apiResponse);

                if (oresponse != null) break;
              }
              catch (Exception Ex)
              {
                var erro = Ex.Message;
              }
            }
          }
        }
      }
      catch (global::System.Exception)
      {
        //FNC_Mensagem(ex.Message)
      }

      return oresponse;
    }

    async Task<cResponse> chat_add(string sMensagem,
                                   string sNome,
                                   string sNumero, 
                                   string sUsuario, 
                                   string sDialogo = "")
    {
      oresponse = null;

      try
      {
        string sLink = "";

        sLink = "https://s15.chatguru.app/api/v1?key=" + sKey +
                                                "&account_id=" + sAccountId +
                                                "&phone_id=" + sPhoneId +
                                                "&action=chat_add" +
                                                "&userid=" + sUsuario +
                                                "&name=" + sNome +
                                                "&text=" + sMensagem +
                                                "&chat_number=" + sNumero;

        if (sDialogo != "")
        {
          sLink = sLink + "&dialog_id=" + sDialogo;
        }

        if (sUsuario != "") { sLink = sLink + "&user_id=" + sUsuario; }

        using (HttpClient httpClient = new HttpClient())
        {
          using (var response = await httpClient.PostAsync(sLink, new StringContent("")))
          {
            string apiResponse = await response.Content.ReadAsStringAsync();
            Escrever(DateTime.Now.ToString() + " - " + sLink);
            Escrever(apiResponse);
            Escrever("--------------------------------------------------------------------------------");

            while (true)
            {
              try
              {
                oresponse = JsonConvert.DeserializeObject<cResponse>(apiResponse);

                if (oresponse != null) break;
              }
              catch (Exception Ex)
              {
                var erro = Ex.Message;
              }
            }
          }
        }
      }
      catch (Exception Ex)
      {
        var erro = Ex.Message;
        //      FNC_Mensagem(ex.Message)
      }

      return oresponse;
    }

    string Escrever(string sTexto)
    {
      try
      {
        _logger.LogInformation(sTexto);
      }
      catch (Exception)
      {
        //FNC_Mensagem(ex.Message)
      }

      return sTexto;
    }
  }
}
