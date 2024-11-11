/*
*	<copyright file="MedSync RM.cs" company="IPCA">
*	Copyright (c) 2023 All Rights Reserved
*	</copyright>
* 	<author>João Ferreira</author>
*   <date>15/11/2023</date>
*	<description></description>
*/

using System;

namespace MedSync_RM
{
    /// <summary>
    /// Purpose: Exam
    /// Created by: João Ferreira
    /// Created on: 15/11/2023
    /// </summary>
    /// <remarks></remarks>
    /// <example></example>
    public class Exam
    {
        #region Attributes
        private Guid id;
        private Guid appointmentId;
        private DateTime date;
        private string description;
        

        #endregion

        #region Methods

        #region Constructors

        public Exam(Guid id, Guid appointmentId, DateTime date, string description, string result)
        {
            this.id = System.Guid.NewGuid();
            this.appointmentId = appointmentId;
            this.date = date;
            this.description = description;
      
        }

        #endregion

        #region Properties

        public Guid Id
        {
            get => id;
            set => id = value;
        }
        
        public DateTime Date
        {
            get => date;
            set => date = value;
        }

        public string Description
        {
            get => description;
            set => description = value;
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