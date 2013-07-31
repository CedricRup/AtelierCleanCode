// ----------------------------------------------------------------------------79
//
// @(#) $Header:
// 1.8 2006/05/04 07:53:06 lapag Exp $
//
// Langage : C#
//
// Description :
//
// Date creation : 14 nov. 2003
//
// Historique :
// 06/08/2005 VDD x7786 - analyse log
// 3.4 UPLOAD INTERROMPU PAR UTILISATEUR
// 3.5 ACTION NULL
//
// ----------------------------------------------------------------------------79


/**
 * Description : Attribut de servlet (durée de vie = 1 requête) pour les
 * controleurs
 */

using System;
using System.Collections;
using log4net;

namespace Library.coment
{
    public class ControllerBaseAttributes {

        private static ILog logger = LogManager.GetLogger(typeof(ControllerBaseAttributes));


        /**
	 * paramètre action : ce paramètre définit les méthodes qui seront exécutées
	 * par l'application, et aussi la classe CtrlAttributes qui sera utilisée.
	 */
        protected String action = null;

        /**
	 * Paramètre de redirection, facultatif, géré par le framework
	 */
        public bool enableRedirectParam = false;

        /**
	 * Constructeur de <code>ControllerBaseAttributes</code>
	 */
        public ControllerBaseAttributes() {
            enableRedirectParam = false;
        }

        /**
	 * Renvoie une instance de la classe attributes correspondant au paramêtre
	 * ACTION trouvé dans la requête. Si le formulaire est encodé en multiform,
	 * alors la requête est parsée avec la librairie common-fileupload de
	 * Jakarta.
	 *
	 * @return Si aucun paramêtre ACTION n'est trouvé, la méthode renvoie une
	 * nouvelle instance de la classe <code>ControllerBaseAttributes</code>,
	 * et si une action est trouvée, alors la méthode essaie de renvoyer une
	 * nouvelle instance de la classe CtrlAttributesxxx (ou xxx est le nom de
	 * l'action), située dans le même package que le controleur en cours.
	 */
        public static ControllerBaseAttributes getInstance(HttpServletRequest req, SessionContainer sc,
                                                           Type controllerClass) {
            ControllerBaseAttributes attributes = null;
            bool isMultipartContent = FileUploadBase.IsMultipartContent(req);
            ArrayList l = null;
            String action = null;
            Hashtable h = null;
            if (isMultipartContent) {
                // Retrieve multipart content
                DefaultFileItemFactory dfif = new DefaultFileItemFactory();
                FileUpload upload = new FileUpload(dfif);
                String s = SConfig.GetInstance().getProperty("Config.upload.maxSize");
                long maxUploadSize = long.Parse(s);
                upload.SetSizeMax(maxUploadSize);
                try {
                    l = upload.ParseRequest(req);
                    h = new Hashtable(l.Count);
                   
                    foreach (DefaultFileItem defaultFileItem in l)
                    {
                        h[defaultFileItem.GetFieldName()] =  defaultFileItem;
                        
                    }
                    
                    // récupêre le paramêtre ACTION
                    FileItem fi = ( FileItem) h[ControllerBase.ACTION_PARAMETER];
                    if (fi != null) {
                        action = fi.GetString();
                    }
                }
                catch (FileUploadBase.SizeLimitExceededException slee) {
                    // Le fichier uploadé dépasse la taille maximale
                    sc.setMessageErreurKey("error.parameter.file_size");
                    if (logger.IsDebugEnabled) {
                        logger.Debug("ControllerBaseAttributes", slee);
                    }
                    throw new IncorrectParameterException();
                }
                catch (FileUploadException e) {
                    if (logger.IsErrorEnabled) {
                        logger.Error("Impossible de parser la requête multiform", e);
                    }
                    l = null;
                    // x7786 3.4 UPLOAD INTERROMPU PAR UTILISATEUR
                    // envoi exception pour stopper exécution servlet
                    throw new IncorrectParameterException();
                }
            }
            else {
                action = req.GetParameter(ControllerBase.ACTION_PARAMETER);
            }
            String className = controllerClass.FullName;
            // x7786 3.5 ACTION NULL ou vide
            // envoi exception pour stopper execution servlet
            if (action == null || "".Equals(action)) {
                if (logger.IsWarnEnabled) {
                    logger.Warn("Le parametre action 'mth' n'est pas defini " + "pour le controleur " + className);
                }
                sc.setMessageErreurKey("error.action.null");
                throw new IncorrectParameterException();
            }
            else {
                int i = className.LastIndexOf(".");
                className = className.Substring(0, i + 1) + ControllerBase.CTRL_ATTRIBUTES_PREFIX + action;
                try {
                    Type attributesClass = Type.GetType(className);
                    attributes = (ControllerBaseAttributes) Activator.CreateInstance(attributesClass);
                }
                catch (TypeLoadException cnfe) {
                    if (logger.IsWarnEnabled) {
                        logger.Warn("la classe " + className + " n'a pas été trouvée " + "pour gérer l'action " + action
                                    + " dans le controleur " + controllerClass.FullName);
                    }
                    // x7786 3.X ACTION mal renseignée
                    // envoi exception pour stopper execution servlet
                    sc.setMessageErreurKey("error.action.wrong");
                    throw new IncorrectParameterException();
                }
            }
            if (attributes == null) {
                attributes = new ControllerBaseAttributes();
            }
            if (isMultipartContent) {
                attributes.setFileItems(h);
            }
            attributes.setAction(action);
            return attributes;
                                                           }

        private void setFileItems(Hashtable h) {
        }



        /**
	 * Sets the action.
	 * 
	 * @param action The action to set
	 */
        public void setAction(String action) {
            this.action = action;
        }
    }

    public class FileUploadException : Exception
    {
    }

    public class FileItem
    {
        public string GetString()
        {
            throw new NotImplementedException();
        }
    }

    public class DefaultFileItem    
    {
        public object GetFieldName()
        {
            throw new NotImplementedException();
        }
    }

    public class FileUpload
    {
        public FileUpload(DefaultFileItemFactory dfif)
        {
            throw new NotImplementedException();
        }

        public void SetSizeMax(object longValue)
        {
            throw new NotImplementedException();
        }

        public ArrayList ParseRequest(HttpServletRequest req)
        {
            throw new NotImplementedException();
        }
    }

    public class DefaultFileItemFactory
    {
    }

    public class FileUploadBase
    {
        public static bool IsMultipartContent(HttpServletRequest req)
        {
            throw new NotImplementedException();
        }

        public class SizeLimitExceededException : Exception
        {
        }
    }

    public class HttpServletRequest
    {
        public string GetParameter(string actionParameter)
        {
            throw new NotImplementedException();
        }
    }
}