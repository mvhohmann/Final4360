using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Communication.Email;
using Azure.Communication.Email.Models;
namespace Final4360
{
    internal class Email
    {
        public static async void send(string inputEmail)
        {
            // this serviceConnectionString is stored in the code diectly in this example for demo purpose
            // it should be stored in the server when working for a business application.
            // ref: https://learn.microsoft.com/en-us/azure/communication-services/quickstarts/create-communication-resource?tabs=windows&pivots=platform-azp#store-your-connection-string
            string serviceConnectionString =  "endpoint=https://mvhohmann1communicationservice.communication.azure.com/;accesskey=cPUv28f8mGbbHXPRs0Sb1jioljbNSyMWdsfJPsQNVsdAZ64IcFmrp0fDgT+0gVHZZlV2DGZzXv6TuLZCKBTKRA==";
            EmailClient emailClient = new EmailClient(serviceConnectionString);
            var subject = "Amarillo Apartment Package Notification";
            var emailContent = new EmailContent(subject);
            // use Multiline String @ to design html content
            emailContent.Html= @"
                        <html>
                            <body>
                                <p>Hello,<br><br>We have received a package in the office for you. Due to limited storing space you will have 5 days to pick up your package. Or it will be sent back with the post office.<br><br>Thank you!</p>
                            </body>
                        </html>";


            // mailfrom domain of your email service on Azure
            var sender = "DoNotReply@2bf3113e-9a80-4ecc-a053-c7979e3bf4de.azurecomm.net";
            var emailRecipients = new EmailRecipients(new List<EmailAddress> {
                new EmailAddress(inputEmail) { DisplayName = "Testing" },
            });

            var emailMessage = new EmailMessage(sender, emailContent, emailRecipients);

            try
            {
                SendEmailResult sendEmailResult = emailClient.Send(emailMessage);

                string messageId = sendEmailResult.MessageId;
                if (!string.IsNullOrEmpty(messageId))
                {
                    Console.WriteLine($"Email sent, MessageId = {messageId}");
                }
                else
                {
                    Console.WriteLine($"Failed to send email.");
                    return;
                }

                // wait max 2 minutes to check the send status for mail.
                var cancellationToken = new CancellationTokenSource(TimeSpan.FromMinutes(2));
                do
                {
                    SendStatusResult sendStatus = emailClient.GetSendStatus(messageId);
                    Console.WriteLine($"Send mail status for MessageId : <{messageId}>, Status: [{sendStatus.Status}]");

                    if (sendStatus.Status != SendStatus.Queued)
                    {
                        break;
                    }
                    await Task.Delay(TimeSpan.FromSeconds(10));
                
                } while (!cancellationToken.IsCancellationRequested);

                if (cancellationToken.IsCancellationRequested)
                {
                    Console.WriteLine($"Looks like we timed out for email");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in sending email, {ex}");
            }
        }
    }
}