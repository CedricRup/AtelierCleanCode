//----------------------------------------------------------------------------79
// SMILE
//
// @(#) $Header: /home/cvs/IncorrectParameterException.cs,v 1.2 2005/11/30 16:09:28 dahug Exp $
//
// Langage     : C#
//
// Description : 
//
// Auteur        : 
// Date creation : 12 nov. 2003
//
// Historique    :
//
//----------------------------------------------------------------------------79


/**
 * @author
 * 
 * Exception lancée lorsqu'un paramètre est manquant ou incorrect
 * 
 */

using System;

namespace Library.coment
{
    public class IncorrectParameterException : Exception
    {

        /**
         * 
         */

        public IncorrectParameterException()
        {
            
        }

        /**
         * @param msg
         */

        public IncorrectParameterException(String msg) : base(msg)
        {
            
        }

    }
}