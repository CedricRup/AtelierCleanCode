// ----------------------------------------------------------------------------79
// SMILE
//
// @(#) $Header:
// /home/cvs/RefonteEspacePro/src/fr/smile/fwk/base/ControllerBase.java,v 1.13
// 2006/10/09 15:31:11 huray Exp $
//
// Langage : C#
//
// Description : Classe de base pour les servlets de type controller.
// R�le principal: fournir les points d'entr�es de validation
// des informations envoy�es par la requ�te.
//
// Auteur : 
// Date creation : Created on 3 septembre 2002, 10:24
//
// Historique :
// 30/08/2005 VDD x7786 - analyse log 2.4 - Afficher la pile d'exception de la
// fonction invoqu�e
// suppression affectation locales des identifiant servlet
// ----------------------------------------------------------------------------79

using System;

namespace Library.Comment
{
    public abstract class ControllerBase  {


        /** paramêtre définissant la méthode du contrôleur à appeler */
        public static readonly String ACTION_PARAMETER = "mth";

        /** Suffixe de toutes les classes Java étendant de la classe ControllerBase */
        public static readonly String CTRL_SUFFIXE = "Ctrl";

        /** Préfixe des classes qui étendent de ControllerBaseAttributes */
        public static readonly String CTRL_ATTRIBUTES_PREFIX = "CtrlAttributes";


    }
}
