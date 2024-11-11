/*
   * <copyright file="" company="AfterJS">
   *     Copyright (c) 2023 All Rights Reserved
   * </copyright>
   * <author>Ricardo Amaro</author>
   * <email>a26004@alunos.ipca.pt</email>
   * <date>Tuesday, November 14, 2023</date>
   * <description></description>
*/

using System;


namespace MedSync_RM
{
    
    /// <summary>
    /// Purpose: MedSync_RM
    /// Created by: Ricardo Amaro
    /// Created on: Tuesday, November 14, 2023
    /// </summary>
    /// <remarks></remarks>
    /// <example></example>
    public enum SeverityLevel
    {
        None,
        Mild,
        Moderate,
        Severe,
        Critical
    }
    
    public enum DiseaseState
    {
        Inactive,
        Active,
        Controlled
    }

 
    public class Disease
    {
        #region Attributes

        private Guid id;
        private string name;
        private DiseaseState state;
        private DateTime diagnosisDate;
        private string description;
        private SeverityLevel severityLevel;
       

        #endregion
        
        #region Methods

        #region Constructors
        public Disease(string name, DiseaseState state, DateTime diagnosisDate, string description, SeverityLevel severityLevel)
        {
            this.id = System.Guid.NewGuid();
            this.name = name;
            this.state = state;
            this.diagnosisDate = diagnosisDate;
            this.description = description;
            this.severityLevel = severityLevel;
        }
        #endregion

        #region Properties

        public Guid Id
        {
            get => id;
            set => id = value;
        }

        public string Name
        {
            get => name;
            set => name = value;
        }

        public DiseaseState State
        {
            get => state;
            set => state = value;
        }

        public DateTime DiagnosisDate
        {
            get => diagnosisDate;
            set => diagnosisDate = value;
        }

        public string Description
        {
            get => description;
            set => description = value;
        }

        public SeverityLevel SeverityLevel
        {
            get => severityLevel;
            set => severityLevel = value;
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