/*
  * <copyright file="" company="AfterJS">
  *     Copyright (c) 2023 All Rights Reserved
  * </copyright>
  * <author>Ricardo Amaro</author>
  * <email>a26004@alunos.ipca.pt</email>
  * <date>Wednesday, November 15, 2023</date>
  * <description></description>
*/

using System;

namespace MedSync_RM
{
    /// <summary>
    /// Purpose: MedSync_RM
    /// Created by: Ricardo Amaro
    /// Created on: Wednesday, November 15, 2023
    /// </summary>
    /// <remarks></remarks>
    /// <example></example>

    public class Diagnostic
    {
        #region Attributes

        private Guid id;
        private string description;
        private DateTime date;
        private string result;
        
        #endregion

        #region Methods

        #region Constructors

        public Diagnostic(string description, DateTime date, string result)
        {
            this.id = System.Guid.NewGuid();
            this.description = description;
            this.date = date;
            this.result = result;
        }

        #endregion

        #region Properties

        public Guid Id
        {
            get => id;
            set => id = value;
        }

        public string Description
        {
            get => description;
            set => description = value;
        }

        public DateTime Date
        {
            get => date;
            set => date = value;
        }

        public string Result
        {
            get => result;
            set => result = value;
        }

        #endregion

        #region Operators

        #endregion

        #region Overrides

        #endregion

        #region Other_Methods

        #endregion

        #endregion
    }
}