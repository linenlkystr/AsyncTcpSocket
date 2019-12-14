# AsyncTcpSocket
this is a Class Library about tcp socket ,it is based on dot netcore 3.1, the classLib was created by Dennis Gao,I developed server-side and client-side desktop applications that can be uses for testing.

-  Messages are sent in bytes, increasing the message length in the protocol header to prevent interception of messages of wrong length 

  ```c#
  /// <summary>
  /// 待发送字符串加长度头后转字节数组
  /// </summary>
  /// <param name="sendMsg">待转换字符串</param>
  /// <returns></returns>
  public static byte[] ConvertToByteData(string sendMsg)
  {
      byte[] data = Encoding.UTF8.GetBytes(sendMsg);
      byte[] sendData = new byte[sizeof(int)+ data.Length];
      byte[] dataLen = BitConverter.GetBytes(data.Length);
      sendData = dataLen.Concat(data).ToArray();
      return sendData;
  }
  
  /// <summary>
  /// 收到的字节数组还原成消息字符串
  /// </summary>
  /// <param name="receiveData">待转换消息字节数组</param>
  /// <returns></returns>
  public static string ConvertToStrData(byte[] receiveData)
  {
      string receiveStr = string.Empty;
      byte[] dataLen = receiveData.Take(sizeof(int)).ToArray();
      int msgLen = BitConverter.ToInt32(dataLen);
      byte[] receiveMsg = receiveData.Skip(sizeof(int)).Take(msgLen).ToArray();
      receiveStr = Encoding.UTF8.GetString(receiveMsg);
      return receiveStr;
  }
  
  ```

- If you want to use the Winform designer,You must be using **Visual Studio 16.5 Preview 1** or a later version.You need to enable the designer in Visual Studio. 

  **Go to Tools > Options > Environment > Preview Features** and select the **Use the preview Windows Forms designer for .NET Core apps** option.