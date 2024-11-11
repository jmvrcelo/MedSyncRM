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
using System.Collections.Generic;

using MedSync_RM_Person;
using MedSync_RM_Address;

namespace MedSync_RM
{
    /// <summary>
    /// Purpose: MedSync_RM
    /// Created by: Ricardo Amaro
    /// Created on: Tuesday, November 14, 2023
    /// </summary>
    /// <remarks></remarks>
    /// <example></example>

    public class Patient : Person
    {
        #region Attributes
        
        private List<Disease> diseases;
        private int healthNumber;
        
        #endregion


        #region Methods

        #region Constructors

        public Patient(int healthNumber, string fullName, DateTime dob, string nif, Address address, Sex sex) : base(fullName, dob, nif, address, sex)
        {
            this.diseases = new List<Disease>();
            this.healthNumber = healthNumber;
        }

        public Patient(List<Disease> diseases, int healthNumber, string fullName, DateTime dob, string nif, Address address, Sex sex) : base(fullName, dob, nif, address, sex)
        {
            this.diseases = diseases;
            this.healthNumber = healthNumber;
        }
             
        #endregion

        #region Properties
        
   
        public List<Disease> Diseases
        {
            get => diseases; 
            set => diseases = value ?? new List<Disease>(); 
        }

        public int HealthNumber
        {
            get => healthNumber; 
            set => healthNumber = value; 
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