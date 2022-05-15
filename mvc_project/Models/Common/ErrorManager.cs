using System;
using System.Collections.Generic;
using System.IO;
using Microsoft.AspNetCore.Hosting;

namespace mvc_project.Models.Common
{
    public class ErrorManager
    {
        public static JsonReturn GetErrorList(
            string userMessage, 
            string logMessage, 
            Exception exception,
            IWebHostEnvironment environment)
        {
            List<string> errorList = new List<string>();
            List<string> userMessageList = new List<string>();

            userMessageList.Add(userMessage);
            errorList.Add(logMessage);

            addSystemTrace(
                exception, 
                errorList, 
                userMessageList);

            addIISTrace(
                exception, 
                errorList);

            addOperationData(errorList);
            
            sendLogByEMail(
                environment, 
                errorList, 
                userMessageList);

            return JsonReturn.ErrorWithListMessage("Error", userMessageList);
        }

        private static void sendLogByEMail(
            IWebHostEnvironment environment, 
            List<string> errorList, 
            List<string> userMessageList)
        {
            string pathConfigErrorManager =
                Path.Combine(environment.ContentRootPath, "ErrorManager.config");

            XMLReader xmlReader = new XMLReader(pathConfigErrorManager);

            if (xmlReader.ReadNode("enviar_mail").Trim().ToUpper().Equals("SI"))
            {
                string sOrigin = xmlReader.ReadNode("origen");
                string sDestination = xmlReader.ReadNode("destino");
                string[] destinations = sDestination.Split(';');
                string sHost = xmlReader.ReadNode("host");
                string sPort = xmlReader.ReadNode("puerto");
                string sUserName = xmlReader.ReadNode("nombre_usuario");
                string sPassword = xmlReader.ReadNode("password");
                string sSubject = xmlReader.ReadNode("asunto");
                bool useSsl = xmlReader.ReadNode("ssl").Trim().ToUpper().Equals("SI");
                int port = 25;
                int.TryParse(sPort, out port);

                userMessageList.Add("");
                
                if (MailManager.SendEmail(
                    destinations,
                    sDestination,
                    sSubject,
                    string.Join("\n", errorList.ToArray()),
                    string.Join("<br />", errorList.ToArray()),
                    sHost,
                    port,
                    sUserName,
                    sPassword,
                    useSsl,
                    null))
                {
                    userMessageList.Add("Se envió un mail notificando del error");
                }
                else
                {
                    userMessageList.Add("No se pudo enviar el mail notificando del error.");
                    userMessageList.Add("Por favor, comuniquese con el administrador de sistema.");
                }
            }
        }

        private static void addOperationData(List<string> errorList)
        {
            errorList.Add("");
            errorList.Add("");
            errorList.Add("*******************************************");
            errorList.Add("DATOS DE LA OPERACIÓN");
            errorList.Add("*******************************************");
            errorList.Add("Fecha y hora de la operación: " + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"));
            errorList.Add("*******************************************");
            errorList.Add("FIN DATOS DE LA OPERACIÓN");
            errorList.Add("*******************************************");
        }

        private static void addIISTrace(
            Exception exception,
            List<string> errorList)
        {
            errorList.Add("");
            errorList.Add("");
            errorList.Add("*******************************************");
            errorList.Add("TRAZA GENERADA POR IIS");
            errorList.Add("*******************************************");

            Exception exc2 = exception;
            int number = 1;
            while (exc2 != null)
            {
                if (number > 1)
                {
                    errorList.Add("");
                    errorList.Add("");
                }

                errorList.Add("Error número: " + number.ToString("00"));
                errorList.Add("Source: " + exc2.Source);
                errorList.Add("TargetSite: " + exc2.TargetSite);
                errorList.Add("StackTrace: " + exc2.StackTrace);

                exc2 = exc2.InnerException;
                number++;
            }

            errorList.Add("*******************************************");
            errorList.Add("FIN TRAZA GENERADA POR IIS");
            errorList.Add("*******************************************");
        }

        private static void addSystemTrace(
            Exception exception, 
            List<string> errorList, 
            List<string> userMessageList)
        {
            errorList.Add("");
            errorList.Add("");
            errorList.Add("*******************************************");
            errorList.Add("TRAZA GENERADA POR EL SISTEMA");
            errorList.Add("*******************************************");

            long number = 1;
            Exception exc1 = exception;
            while (exc1 != null)
            {
                if (number > 1)
                {
                    errorList.Add("");
                    errorList.Add("");
                }
                else
                {
                    userMessageList.Add("");
                    userMessageList.Add("Mensaje: " + exc1.Message);
                }

                errorList.Add("Error número " + number.ToString("00") + ": " + exc1.Message);

                exc1 = exc1.InnerException;
                number++;
            }

            errorList.Add("*******************************************");
            errorList.Add("FIN TRAZA GENERADA POR EL SISTEMA");
            errorList.Add("*******************************************");
        }
    }
}