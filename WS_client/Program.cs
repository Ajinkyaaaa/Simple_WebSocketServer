using System.Net.WebSockets;
using System.Text;
var ws = new ClientWebSocket();
Console.WriteLine("Connecting to server...");
await ws.ConnectAsync(new Uri("ws://localhost:6969/ws"), CancellationToken.None);
Console.WriteLine("Connected to webserver")