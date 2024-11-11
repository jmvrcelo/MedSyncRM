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
using System.Collections.Generic;

using MedSync_RM_Person;
using MedSync_RM_Address;


namespace MedSync_RM
{
    /// <summary>
    /// Purpose: MedSync_RM
    /// Created by: Ricardo Amaro
    /// Created on: Wednesday, November 15, 2023
    /// </summary>
    /// <remarks></remarks>
    /// <example></example>
    
        
    public class MedicalProfessional: Person
    {
        #region Attributes

        private Guid id;
        private List<Specialty> specialties;

        #endregion

        #region Methods

        #region Constructors
        
        public MedicalProfessional(string fullName, DateTime dob, string nif, Address address, Sex gender, List<Specialty> specialties)
            : base( fullName, dob, nif, address, gender)
        {
            this.specialties = specialties;
        }
        #endregion

        #region Properties

        public Guid Id
        {
            get => id; 
            set => id = value; 
        }

        public List<Specialty> Specialties
        {
            get => specialties; 
            set => specialties = value; 
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